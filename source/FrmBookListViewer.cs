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
    public partial class FrmBookListViewer : Form
    {
        public FrmBookListViewer()
        {
            InitializeComponent();
        }
        DBcon con = new DBcon();

        private void FrmBookListViewer_Load(object sender, EventArgs e)
        {
            var dic =  con.BookListALL();
            foreach (KeyValuePair<int,string> item in dic)
            {
                ListViewItem li = new ListViewItem(item.Value);
                li.Tag = item.Key;
                this.listView1.Items.Add(li);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count>0)
            {
                int bklid = (int)this.listView1.SelectedItems[0].Tag;
                var list = con.GetBookListFromBookListID(bklid);
                this.BookList = list;
                this.listBox1.Items.Clear();

                this.listBox1.Items.AddRange(tos(list).ToArray());
            }
        }

        private List<string> tos(List<Book> list)
        {
            List<string> s = new List<string>();
            foreach (var item in list)
            {
                s.Add(item.BookName);
            }
            return s;
        }

        public List<Book> BookList { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count > 0)
            {
                int bklid = (int)this.listView1.SelectedItems[0].Tag;
                var c = con.RemoveBookListByBookListID(bklid);
                if (c>0)
                {
                    this.listView1.SelectedItems[0].Remove();
                    MessageBox.Show("成功删除一个书单！");
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
        }
    }
}
