using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BooksManageSystem
{
    public partial class FrmEditOP : Form
    {
        public FrmEditOP(OPLOG log)
        {
            InitializeComponent();
            this.oplog = log;
        }
        OPLOG oplog;

        private void FrmEditOP_Load(object sender, EventArgs e)
        {
        //            public int BookID { get; set; }
        //public string BookName { get; set; }
        //public EnumOP op { get; set; }
        //public DateTime OPdatetime { get; set; }
        //public int OPCount { get; set; }
        //public int AfterOPCount { get; set; }
        //public string oper { get; set; }

            this.dtp_datetime.Value = oplog.OPdatetime;
            this.txt_bookname.Text = oplog.BookName;
            this.txt_op.Text = oplog.op.ToString();
            this.txt_opCount.Text = oplog.OPCount.ToString();
            this.txt_oper.Text = oplog.oper;
        }

        public string Operator { get; set; }
        public DateTime DateOP { get; set; }
        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.Operator = txt_oper.Text;
            this.DateOP = this.dtp_datetime.Value;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

    }
}
