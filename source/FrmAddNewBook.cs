using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BooksManageSystem
{
    public partial class FrmAddNewBook : Form
    {
        Book _book;
        int bkID;
        public FrmAddNewBook(Book bk)
        {
            InitializeComponent();
            this._book = bk;
        }

        private void FrmAddNewBook_Load(object sender, EventArgs e)
        {
            if (this._book != null)
            {
                this.txt_Bookname.Text = _book.BookName;
                this.txt_Count.Text = _book.Count.ToString();
                this.txt_Price.Text = _book.Price.ToString();
                this.txt_orderPrice.Text = _book.OrderPrice.ToString();
                this.cb_IsStuBook.Checked = _book.IsStuBook;
                this.bkID = _book.BookID;
                this.Text = "修改书籍";
            }
            else
            {
                this.txt_Count.Text = "0";
                this.txt_Count.Enabled = false;
            }

        }
        private Book book;
        private bool checkVaild()
        {
            double pr, ordpr;
            int c;

            if (!double.TryParse(txt_Price.Text, out pr))
            {
                return false;
            }
            if (!double.TryParse(txt_orderPrice.Text, out ordpr))
            {
                return false;
            }
            if (!int.TryParse(txt_Count.Text, out c))
            {
                return false;
            }
            Book bk = new Book(999, txt_Bookname.Text.Trim(), pr, ordpr, c, cb_IsStuBook.Checked);
            this.book = bk;
            return true;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (_book == null)
                {
                    add();
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    modify();
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void add()
        {
            if (checkVaild())
            {
                this.btn_OK.Enabled = false;
                this.btn_OK.Text = "请稍后...";
                this.btn_OK.Update();
                new DBcon().AddNewBook(book.BookName, book.Price, book.OrderPrice, book.Count, book.IsStuBook);
                this.btn_OK.Enabled = true;
                this.btn_OK.Text = "确认";
                MessageBox.Show("添加成功！");
            }
            else
            {
                MessageBox.Show("输入的数据不正确!");
            }
        }

        private void modify()
        {
            if (checkVaild())
            {
                this.btn_OK.Enabled = false;
                this.btn_OK.Text = "请稍后...";
                this.btn_OK.Update();
                new DBcon().ModifyBook(bkID, book.BookName, book.Price, book.OrderPrice, book.Count, book.IsStuBook);
                this.btn_OK.Enabled = true;
                this.btn_OK.Text = "确认";
                MessageBox.Show("修改成功！");
            }
            else
            {
                MessageBox.Show("输入的数据不正确!");
            }
        }
    }
}
