using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BooksManageSystem
{
    public partial class FrmClearDB : Form
    {
        public FrmClearDB()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text=="888888")
            {
                button1.Enabled = true;
                btn_Brower.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                btn_Brower.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (new DBcon().ClearDataBase())
            {
                MessageBox.Show("数据库已经清空");
            }
            else
            {
                MessageBox.Show("清空数据库失败！");
            }
        }

        private void btn_bookListTemplate_Click(object sender, EventArgs e)
        {
            using (OfficeOpenXml.ExcelPackage ep = new OfficeOpenXml.ExcelPackage())
            {
                var sheet = ep.Workbook.Worksheets.Add("Books");
                sheet.Cells[1, 1].Value = "书名";
                sheet.Cells[1, 2].Value = "定价";
                sheet.Cells[1, 3].Value = "购入价";
                sheet.Cells[1, 4].Value = "数量";
                sheet.Cells[1, 5].Value = "学生用书";

                sheet.Cells[2, 1].Value = "示例数据书";
                sheet.Cells[2, 2].Value = 22.5;
                sheet.Cells[2, 3].Value = 18.3;
                sheet.Cells[2, 4].Value = 20;
                sheet.Cells[2, 5].Value = true;

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel File(*.xlsx)|*.xlsx";
                if (sfd.ShowDialog()== System.Windows.Forms.DialogResult.OK)
                {
                    ep.SaveAs(new FileInfo(sfd.FileName));    
                }
                
            }
        }

        private void btn_Brower_Click(object sender, EventArgs e)
        {
            DBcon con = new DBcon();
            var ofd = new OpenFileDialog();
            ofd.Filter = "Excel File(*.xlsx)|*.xlsx";
            if (ofd.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                btn_Brower.Text = "请等待...";
                using (OfficeOpenXml.ExcelPackage ep = new OfficeOpenXml.ExcelPackage(new FileInfo(ofd.FileName)))
                {
                    //int c = ep.Workbook.Worksheets.Count;
                    //if (c<1)
                    //{
                    //    return;
                    //}
                    var sheet= ep.Workbook.Worksheets[1];
                    int rowEnd = sheet.Dimension.End.Row;

                    for (int i = 2; i <= rowEnd; i++)
                    {
                        string bkname= sheet.GetValue(i, 1).ToString();
                        double price = Convert.ToDouble(sheet.GetValue(i, 2));
                        double ordPrice = Convert.ToDouble(sheet.GetValue(i, 3));
                        int count = Convert.ToInt32(sheet.GetValue(i, 4));
                        bool isStu = Convert.ToBoolean(sheet.GetValue(i, 5));
                        con.AddNewBook(bkname, price, ordPrice, count, isStu);
                    }
                }
                btn_Brower.Text = "导入完成";
            }
        }

    }
}
