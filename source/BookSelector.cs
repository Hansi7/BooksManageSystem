using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BooksManageSystem
{
    public partial class BookSelector : UserControl
    {
        List<Book> list;
        public BookSelector()
        {
            InitializeComponent();
            this.BackColorChanged += BookSelector_BackColorChanged;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.comboBox1.MouseWheel += comboBox1_MouseWheel;
        }
        int indexTemp;
        bool mousewheel;
        void comboBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta != 0 && !this.comboBox1.DroppedDown)
            {
                indexTemp = this.comboBox1.SelectedIndex;
                this.mousewheel = true;
            }
        }

        void BookSelector_BackColorChanged(object sender, EventArgs e)
        {
            //this.btn_dispose.BackColor = this.BackColor;
            //this.numericUpDown1.BackColor = this.BackColor;
        }

        public void SetData(List<Book> bookList)
        {
            this.list = bookList;
            this.comboBox1.Items.AddRange(list.ToArray());
            this.comboBox1.DisplayMember = "BookName";
            this.comboBox1.ValueMember = "BookID";
       }
        public int BookCount 
        {
            get
            {
                return (int)this.numericUpDown1.Value;
            }
        }
        public Book Book
        {
            get
            {
                return this.comboBox1.SelectedItem as Book;
            }
            set
            {
                this.comboBox1.SelectedItem = value;
            }
        }

        private void btn_dispose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mousewheel)
            {
                this.comboBox1.SelectedIndex = indexTemp;
            }
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.mousewheel = false;
        }

        private void comboBox1_MouseDown(object sender, MouseEventArgs e)
        {
            this.mousewheel = false;
        }

    }
}
