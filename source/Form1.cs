using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
//using NPOI.SS.UserModel;
using System.IO;

namespace BooksManageSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DBcon con = new DBcon();
       
        List<Book> booklist;
        private void Form1_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void reload()
        {
            try
            {
                booklist = new DBcon().GetBookList();
                fillListView(booklist);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + "请确保数据库文件和程序在同一个目录。");
            }
        }

        private void fillListView(List<Book> list) 
        {
            listView1.Items.Clear();
            listView1.BeginUpdate();
            foreach (var item in list)
            {
                ListViewItem i = new ListViewItem(item.BookID.ToString());
                i.SubItems.Add(item.BookName);
                i.SubItems.Add(item.Price.ToString());
                i.SubItems.Add(item.OrderPrice.ToString());
                i.SubItems.Add(item.Count.ToString());
                i.SubItems.Add(item.IsStuBook?"YES":"NO");
                i.Tag = item;
                if (item.IsStuBook&& item.Count<10)
                {
                    i.ForeColor = Color.Firebrick;
                }
                listView1.Items.Add(i);
            }
            listView1.EndUpdate();
        }

        private void menu_BUYBOOK_Click(object sender, EventArgs e)
        {
            BUY_BookList();
        }



        private void menu_RETURNBOOK_Click(object sender, EventArgs e)
        {
            RETURN_BOOK();
        }

     

        private void menu_SELLBOOK_Click(object sender, EventArgs e)
        {
            SELL_BOOK();
        }

       

        private void menu_LINGQU_Click(object sender, EventArgs e)
        {

            LINGQU_BOOK();
        }

   

        private void menu_BookLOG_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 1)
            {
                MessageBox.Show("只能选择一种书！");
                return;
            }
            if (listView1.SelectedItems.Count == 1)
            {
                var list =con.GetOPLogByID((listView1.SelectedItems[0].Tag as Book).BookID);
                new FrmLOGViewer(list).ShowDialog();
            }
        }

        private void menu_All_bookLOG_Click(object sender, EventArgs e)
        {
            new FrmLOGViewer(con.GetOPLogALL()).ShowDialog();
        }

        private void menu_exportBookList_Click(object sender, EventArgs e)
        {
            var list = con.GetBookList();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("编号\t书名\t定价\t购入价\t库存+\t学生用书");
            foreach (Book item in list)
            {
                sb.AppendLine(item.BookID + "\t" + item.BookName + "\t" + item.Price + "\t" + item.OrderPrice + "\t" + item.Count + "\t" + (item.IsStuBook?"YES":"NO"));
            }
            try
            {
                var fDia = new SaveFileDialog();
                fDia.Filter = "txt files (*.txt)|*.txt";
                if (fDia.ShowDialog()== DialogResult.OK)
	            {
                    System.IO.File.WriteAllText(fDia.FileName, sb.ToString(), Encoding.Default);
                    MessageBox.Show("如需要Excel在Excel中操作，请全选并复制粘贴到Excel中。");
                    System.Diagnostics.Process.Start(fDia.FileName);
	            } 
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        void output()
        {
            //NPOI.HSSF.UserModel.HSSFWorkbook wb = new NPOI.HSSF.UserModel.HSSFWorkbook();
            //ISheet oSheet = wb.CreateSheet("leibieo");
            //var row  = oSheet.CreateRow(1);
            //row.CreateCell(1).SetCellValue("编号");
            //row.CreateCell(2).SetCellValue("书名");
            //row.CreateCell(3).SetCellValue("定价");
            //row.CreateCell(4).SetCellValue("购入价");
            //row.CreateCell(5).SetCellValue("库存");
            //row.CreateCell(6).SetCellValue("学生用书");

            //var list = con.GetBookList();
            //int n = 2;
            //foreach (Book item in list)
            //{
            //    row = oSheet.CreateRow(n++);
            //    row.CreateCell(1).SetCellValue(item.BookID);
            //    row.CreateCell(2).SetCellValue(item.BookName);
            //    row.CreateCell(3).SetCellValue(item.Price);
            //    row.CreateCell(4).SetCellValue(item.OrderPrice);
            //    row.CreateCell(5).SetCellValue(item.Count);
            //    row.CreateCell(6).SetCellValue(item.IsStuBook);
            //}
            //FileStream fs = new FileStream(@"abc.xlsx", FileMode.Create);
            //wb.Write(fs);
            //fs.Close();
        }

        void outputExcelBookList()
        {
            string fn;
            var fDia = new SaveFileDialog();
            fDia.Filter = "Excel files (*.xlsx)|*.xlsx";
            if (fDia.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fn = fDia.FileName;
            }
            else
            {
                return;
            }
            var file = new FileInfo(fn);
            if (File.Exists(file.FullName))
            {
                file.Delete();
            }
            OfficeOpenXml.ExcelPackage ep = new OfficeOpenXml.ExcelPackage(file) ;

            var sheet = ep.Workbook.Worksheets.Add("库存列表");
            var list = con.GetBookList();
            int r =1;
            int c=1;


            sheet.Cells[r, c].Value = "编号";
            sheet.Cells[r, ++c].Value = "书名";
            sheet.Cells[r, ++c].Value = "定价";
            sheet.Cells[r, ++c].Value = "购入价";
            sheet.Cells[r, ++c].Value = "库存";
            sheet.Cells[r, ++c].Value = "学生用书";

            foreach (Book item in list)
            {
                c = 1;
                sheet.Cells[++r, c++].Value = item.BookID;
                sheet.Cells[r, c++].Value = item.BookName;
                sheet.Cells[r, c++].Value = item.Price;
                sheet.Cells[r, c++].Value = item.OrderPrice;
                sheet.Cells[r, c++].Value = item.Count;
                sheet.Cells[r, c++].Value = item.IsStuBook; 
            }

            sheet.Cells["1:1"].Style.Font.Bold = true;
            sheet.Cells["A:F"].AutoFitColumns();
            //Console.WriteLine(sheet.Cells["1:1"].End.Row.ToString());
            ep.Save();
            ep.Dispose();
        }

        void outputExcelSellList(DateTime start,DateTime end)
        {//编号, 书名 , 定价, 数量, 备注信息 , 小计

            var fDia = new SaveFileDialog();
            fDia.Filter = "Excel files (*.xlsx)|*.xlsx";
            if (fDia.ShowDialog()== System.Windows.Forms.DialogResult.OK)
	        {
                if (File.Exists(fDia.FileName))
                {
                    File.Delete(fDia.FileName);
                }
	        }
            else
            {
                return;
            }

            var dt =con.GetSellList(start,end);
            using (OfficeOpenXml.ExcelPackage ep = new OfficeOpenXml.ExcelPackage())
            {
                var sheet = ep.Workbook.Worksheets.Add("Table1");
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    sheet.Cells[1, i + 1].Value = dt.Columns[i].ColumnName;
                }

                int row = 1;
                foreach (DataRow r in dt.Rows)
                {
                    row++;
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        sheet.Cells[row, i + 1].Value = r[i];
                    }
                }
                sheet.Cells["A:G"].AutoFitColumns();
                sheet.Cells["A1:G1"].Style.Font.Bold = true;
                sheet.Cells["E:E"].Style.Numberformat.Format = "yyyy-mm-dd";
                ep.SaveAs(new FileInfo(fDia.FileName));
            }

        }

        private void menu_newBook_Click(object sender, EventArgs e)
        {
            var ok= new FrmAddNewBook(null).ShowDialog();
            if (ok== System.Windows.Forms.DialogResult.OK)
            {
                reload();

            }
        }

        private void txt_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                var list =con.GetBookListByName(txt_Search.Text.Trim());
                fillListView(list);
                e.Handled = true;
            }
        }



        private void menu_ExcelOutBookList_Click(object sender, EventArgs e)
        {
            outputExcelBookList();
        }

        private void menu_TotalSell_Click(object sender, EventArgs e)
        {
            FrmOutputSellList olist = new FrmOutputSellList();
            if (olist.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                outputExcelSellList(olist.Start, olist.End);
            }
        }

        private void menu_init_Click(object sender, EventArgs e)
        {
            new FrmClearDB().ShowDialog();
        }

        private void menu_ModifyBook_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                var ok = new FrmAddNewBook(listView1.SelectedItems[0].Tag as Book).ShowDialog();
                if (ok== System.Windows.Forms.DialogResult.OK)
                {
                    reload();
                }
            }
            else
            {
                MessageBox.Show("需要选择一项进行修改!");
            }
        }

        private void menu_About_Click(object sender, EventArgs e)
        {
            new FrmAbout().ShowDialog();
            //MessageBox.Show("H为Grace定制的图书管理！\r\n\r\n                2014年4月12日", "Grace的图书管理", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            //pl_ListView.Size = new Size(pl_ListView.Size.Width, this.Size.Height - he);
            listView1.Size = new Size(this.Size.Width - listView1.Location.X - 25 , this.Size.Height - listView1.Location.Y - 45);
        }

        private void menu_BigList_Click(object sender, EventArgs e)
        {
            try
            {
                new FrmBigListViewer().ShowDialog();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        #region 书籍变更逻辑

        void BUY_BOOK()
        {
            if (listView1.SelectedItems.Count != 1)
            {
                MessageBox.Show("请先选择需要操作的书籍!（能且只能选择一种书籍）");
                return;
            }
            if (listView1.SelectedItems.Count == 1)
            {
                var frm = new frmChange(listView1.SelectedItems[0].Tag as Book, EnumOP.购);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        int after = con.PurchaseBook(frm.BookID, frm.BookChangeCount, frm.NoteTag, frm.OPDateTime,0);
                        listView1.SelectedItems[0].SubItems[4].Text = after.ToString();
                        MessageBox.Show("变更成功!","成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("变更失败:" + err.Message);
                    }
                }
            }
        }

        void RETURN_BOOK()
        {
            if (listView1.SelectedItems.Count != 1)
            {
                MessageBox.Show("请先选择需要操作的书籍!（能且只能选择一种书籍）");
                return;
            }
            if (listView1.SelectedItems.Count == 1)
            {
                var frm = new frmChange(listView1.SelectedItems[0].Tag as Book, EnumOP.还);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        int after = con.ReturnBookByID(frm.BookID, frm.BookChangeCount, frm.NoteTag, frm.OPDateTime);
                        listView1.SelectedItems[0].SubItems[4].Text = after.ToString();
                        MessageBox.Show("变更成功!","成功!",  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("变更失败:" + err.Message);
                    }
                }
            }
        }

        void SELL_BOOK()
        {
            if (listView1.SelectedItems.Count != 1)
            {
                MessageBox.Show("请先选择需要操作的书籍!（能且只能选择一种书籍）");
                return;
            }
            if (listView1.SelectedItems.Count == 1)
            {
                var frm = new frmChange(listView1.SelectedItems[0].Tag as Book, EnumOP.售);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        int after = con.SellBookByID(frm.BookID, frm.BookChangeCount, frm.NoteTag, frm.OPDateTime);
                        listView1.SelectedItems[0].SubItems[4].Text = after.ToString();
                        MessageBox.Show("变更成功!", "成功!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("变更失败:" + err.Message);
                    }
                }
            }
        }

        void LINGQU_BOOK()
        {
            if (listView1.SelectedItems.Count != 1)
            {
                MessageBox.Show("请先选择需要操作的书籍!（能且只能选择一种书籍）");
                return;
            }
            if (listView1.SelectedItems.Count == 1)
            {
                var frm = new frmChange(listView1.SelectedItems[0].Tag as Book, EnumOP.领);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        int after = con.Lingqu(frm.BookID, frm.BookChangeCount, frm.NoteTag, frm.OPDateTime);
                        listView1.SelectedItems[0].SubItems[4].Text = after.ToString();
                        MessageBox.Show("变更成功!","成功!",  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("变更失败:" + err.Message);
                    }
                }
            }
        }

        void BUY_BookList()
        {
            try
            {
                if (booklist==null)
                {
                    booklist = con.GetBookList();
                }

                var maker = new FrmBookListMaker(booklist,"购买-列表编辑器","确认购买");
                if (maker.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //maker.BookListToBuy.Values.Count;
                    int i = 0;
                    foreach (var item in maker.BookListToOperate.Values)
                    {
                        i = i + item;
                    }
                    int bid = con.Blist(i, maker.OperTime);
                    foreach (KeyValuePair<Book, int> item in maker.BookListToOperate)
                    {
                        con.PurchaseBook(item.Key.BookID, item.Value, maker.NoteTag, maker.OperTime, bid);
                    }
                    reload();
                    MessageBox.Show("购买成功!","成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception err)
            {
                MessageBox.Show("操作失败,错误消息:" + err.Message);
            }
        }

        void Lingqu_Booklist()
        {
            try
            {
                if (booklist == null)
                {
                    booklist = con.GetBookList();
                }

                var maker = new FrmBookListMaker(booklist, "领取-列表编辑器", "确认领取");
                if (maker.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    int i = 0;
                    foreach (var item in maker.BookListToOperate.Values)
                    {
                        i = i + item;
                    }
                    foreach (KeyValuePair<Book, int> item in maker.BookListToOperate)
                    {
                        con.Lingqu(item.Key.BookID, item.Value, maker.NoteTag, maker.OperTime);
                    }
                    reload();
                    MessageBox.Show("领取成功!", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("操作失败,错误消息:" + err.Message);
            }

        }

        void out_sell_BookList()
        {
            try
            {
                if (booklist == null)
                {
                    booklist = con.GetBookList();
                }

                var maker = new FrmBookListMaker(booklist, "销售-列表编辑器", "确认售书");
                if (maker.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    int i = 0;
                    foreach (var item in maker.BookListToOperate.Values)
                    {
                        i = i + item;
                    }
                    foreach (KeyValuePair<Book, int> item in maker.BookListToOperate)
                    {
                        con.SellBookByID(item.Key.BookID, item.Value, maker.NoteTag, maker.OperTime);
                    }
                    reload();
                    MessageBox.Show("售书成功!", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("操作失败,错误消息:" + err.Message);
            }
        }
        #endregion
        #region ButtonCalls

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            var list = con.GetBookListByName(txt_Search.Text.Trim());
            fillListView(list);
        }

        private void btn_in_Return_Click(object sender, EventArgs e)
        {
            RETURN_BOOK();
        }

        private void btn_out_Sell_Click(object sender, EventArgs e)
        {
            SELL_BOOK();
        }

        private void btn_out_Give_Click(object sender, EventArgs e)
        {
            LINGQU_BOOK();
        }

        private void btn_OPLOGALL_Click(object sender, EventArgs e)
        {
            new FrmLOGViewer(con.GetOPLogALL()).ShowDialog();
        }

        private void btn_in_Buy_Click(object sender, EventArgs e)
        {
            BUY_BookList();
        }

        private void btn_BuyListQuery_Click(object sender, EventArgs e)
        {
            try
            {
                new FrmBigListViewer().ShowDialog();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btn_out_Sell_List_Click(object sender, EventArgs e)
        {
            out_sell_BookList();
        }



        private void btn_out_Give_booklist_Click(object sender, EventArgs e)
        {
            Lingqu_Booklist();
        }

        #endregion

        #region 升级

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                DBHelper.ExecuteNonQuery(@"Alter TABLE OPERATE ADD COLUMN BID INT");
                DBHelper.ExecuteNonQuery(@"CREATE TABLE BLIST(BID INT NOT NULL IDENTITY(1,1),BCOUNT INT NOT NULL,BDATE DATETIME NOT NULL)");

                MessageBox.Show("升级成功！");
            }
            catch (Exception)
            {
                MessageBox.Show("升级失败,可能已经升级过了。");
            }

        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                //DBHelper.ExecuteNonQuery(@"Alter TABLE OPERATE ADD COLUMN BID INT");
                DBHelper.ExecuteNonQuery(@"CREATE TABLE BOOKLIST(LID INT NOT NULL IDENTITY(1,1),BOOKSID TEXT NOT NULL,TAG TEXT NOT NULL)");
                MessageBox.Show("升级成功！");
            }
            catch (Exception)
            {
                MessageBox.Show("升级失败,可能已经升级过了。");
            }
        } 
        #endregion



    }
}
