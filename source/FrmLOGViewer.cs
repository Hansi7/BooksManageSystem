using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BooksManageSystem
{
    public partial class FrmLOGViewer : Form
    {
        List<OPLOG> list;
        DBcon con;
        public FrmLOGViewer( List<OPLOG> l)
        {
            InitializeComponent();
            this.list = l;
            con = new DBcon();
        }

        private void FrmLOGViewer_Load(object sender, EventArgs e)
        {
            foreach (var item in list)
            {
                ListViewItem ii = new ListViewItem(item.BookID.ToString());
                ii.SubItems.Add(item.BookName);
                ii.SubItems.Add(item.op.ToString());
                ii.SubItems.Add(item.OPCount.ToString());
                ii.SubItems.Add(item.AfterOPCount.ToString());
                ii.SubItems.Add(item.OPdatetime.ToString());
                ii.SubItems.Add(item.oper);
                ii.Tag = item;
                listView1.Items.Add(ii);
            }
        }

        private void menu_outExcel_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Excel File(*.xlsx)|*.xlsx";
            if (sfd.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                if (File.Exists(sfd.FileName))
                {
                    File.Delete(sfd.FileName);
                }
                using (OfficeOpenXml.ExcelPackage ep = new OfficeOpenXml.ExcelPackage(new FileInfo(sfd.FileName)))
                {
                    var sheet = ep.Workbook.Worksheets.Add("变更记录");
                    sheet.Cells[1, 1].Value = "书名";
                    sheet.Cells[1, 2].Value = "变更操作";
                    sheet.Cells[1, 3].Value = "变更数量";
                    sheet.Cells[1, 4].Value = "变更后数量";
                    sheet.Cells[1, 5].Value = "变更时间";
                    sheet.Cells[1, 6].Value = "备注";
                    int r = 1;
                    foreach (var item in this.list)
                    {
                        sheet.Cells[++r, 1].Value = item.BookName;
                        sheet.Cells[r, 2].Value = item.op.ToString();
                        sheet.Cells[r, 3].Value = item.OPCount;
                        sheet.Cells[r, 4].Value = item.AfterOPCount;
                        sheet.Cells[r, 5].Value = item.OPdatetime;
                        sheet.Cells[r, 6].Value = item.oper;
                    }
                    sheet.Cells["A:G"].AutoFitColumns();
                    sheet.Cells["A1:G1"].Style.Font.Bold = true;
                    sheet.Cells["E:E"].Style.Numberformat.Format = "yyyy-mm-dd";
                    ep.Save();
                    MessageBox.Show("已保存！","成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void menu_edit_Click(object sender, EventArgs e)
        {
            Edit_OP_LOG();
        }

        private void Edit_OP_LOG()
        {
            if (listView1.SelectedItems.Count == 1)
            {
                OPLOG log = listView1.SelectedItems[0].Tag as OPLOG;
                var eop = new FrmEditOP(log);
                if (eop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (con.ModifyOPLog(log.OPID, eop.DateOP, eop.Operator) > 0)
                    {
                        listView1.SelectedItems[0].SubItems[5].Text = eop.DateOP.ToString("yyyy-MM-dd HH:mm:ss");
                        listView1.SelectedItems[0].SubItems[6].Text = eop.Operator;
                    }
                    else
                    {
                        MessageBox.Show("修改失败！");
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择一项进行修改");
            }
        }

        private void menu_del_Click(object sender, EventArgs e)
        {
            Del_OP_LOG();
        }

        private void Del_OP_LOG()
        {
            if (listView1.SelectedItems.Count == 1)
            {
                OPLOG log = listView1.SelectedItems[0].Tag as OPLOG;
                string op = string.Empty;
                if (log.op == EnumOP.购 || log.op == EnumOP.还)
                {
                    op = "减少";
                }
                else if (log.op == EnumOP.领 || log.op == EnumOP.售)
                {
                    op = "增加";
                }
                string message = "删除本记录会使《" + log.BookName + "》的数量" + op + log.OPCount.ToString() + "。本操作不可撤销。确认删除？";

                var res = MessageBox.Show(message, "确认删除本条记录？", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (res == System.Windows.Forms.DialogResult.Yes)
                {
                    if (con.UndoOPByOPID(log.OPID) > 0)
                    {
                        listView1.Items.Remove(listView1.SelectedItems[0]);
                        listView1.Update();
                        //MessageBox.Show("删除成功");
                    }
                }
                else if (res == System.Windows.Forms.DialogResult.No)
                {

                }
                else if (res == System.Windows.Forms.DialogResult.Cancel)
                {

                }

            }
            else
            {
                MessageBox.Show("请选择一项进行修改");
            }
        }

        private void cMenu_Del_oplog_Click(object sender, EventArgs e)
        {
            Del_OP_LOG();
        }

        private void cMenu_Edit_oplog_Click(object sender, EventArgs e)
        {
            Edit_OP_LOG();
        }




    }
}
