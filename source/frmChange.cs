using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BooksManageSystem
{
    public partial class frmChange : Form
    {
        Book book;
        EnumOP op;
        public frmChange(Book b,EnumOP op)
        {
            InitializeComponent();
            this.book = b;
            this.op = op;

            switch (op)
            {
                case EnumOP.售:
                    this.Text = "售书";
                    break;
                case EnumOP.领:
                    this.Text = "领用书籍";
                    break;
                case EnumOP.购:
                    this.Text = "购入书籍";
                    break;
                case EnumOP.还:
                    this.Text = "归还书籍";
                    break;
                default:
                    break;
            }



        }

        private void frmChange_Load(object sender, EventArgs e)
        {
            this.txt_Bookname.Text = book.BookName;
            
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
                this.BookChangeCount = (int)numberUD.Value;
                this.BookID = this.book.BookID;
                this.NoteTag = txt_NoteTag.Text;
                this.OPDateTime = this.dtp_Op_time.Value;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        public DateTime OPDateTime { get; set; }
        public int BookChangeCount { get; set; }
        public string NoteTag { get; set; }
        public int BookID { get; set; }

        private void txt_NoteTag_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                //same as btn_OK
                this.BookChangeCount = (int)numberUD.Value;
                this.BookID = this.book.BookID;
                this.NoteTag = txt_NoteTag.Text;
                this.OPDateTime = this.dtp_Op_time.Value;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void txt_Bookname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
