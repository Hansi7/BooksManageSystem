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
    public partial class FrmBigListViewer : Form
    {
        public FrmBigListViewer()
        {
            InitializeComponent();
        }
        DBcon con = new DBcon();

        private void FrmBigListViewer_Load(object sender, EventArgs e)
        {
            this.listBox1.Items.AddRange(con.GetAllBuyList().ToArray());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 1)
            {
                int bid = (listBox1.SelectedItem as BuyList).BID;
                var l = con.GetOPLogByBID(bid);
                new FrmLOGViewer(l).ShowDialog();
            }
        }

        private void FrmBigListViewer_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 1)
            {
                int bid = (listBox1.SelectedItem as BuyList).BID;
                var l = con.GetOPLogByBID(bid);
                new FrmLOGViewer(l).ShowDialog();
            }
        }
    }
}
