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
    public partial class FrmOutputSellList : Form
    {
        public FrmOutputSellList()
        {
            InitializeComponent();
        }

        private void FrmOutputSellList_Load(object sender, EventArgs e)
        {
            dtp_Start.Value = DateTime.Parse(DateTime.Now.AddMonths(-2).ToString("yyyy-MM-01 00:00:00"));
            dtp_End.Value = DateTime.Parse(DateTime.Now.AddMonths(1).ToString("yyyy-MM-01 00:00:00")).AddSeconds(-1);
        }

        public DateTime Start;
        public DateTime End;
        private void btn_output_Click(object sender, EventArgs e)
        {
            this.Start = dtp_Start.Value;
            this.End = dtp_End.Value;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
