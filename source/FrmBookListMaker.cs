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
    public partial class FrmBookListMaker : Form
    {
        public FrmBookListMaker(List<Book> booklist,string frmTitle,string buttonOK)
        {
            InitializeComponent();
            this.Text = frmTitle;
            this.btn_OK.Text = buttonOK;
            this._listSelector = new List<BookSelector>(20);
            this._booklist = booklist;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            initData();
        }
        List<BookSelector> _listSelector;
        List<Book> _booklist;
        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddOne(null);
        }


        private Color odd = Color.FromArgb(217, 192, 255);
        private Color even = Color.FromArgb(151, 165, 249);
        void AddOne(Book book)
        {
            var s = new BookSelector();
            s.SetData(_booklist);
            _listSelector.Add(s);
            if (_listSelector.Count % 2 == 1)
            {
                s.BackColor = odd;
            }
            else
            {
                s.BackColor = even;
            }

            s.Disposed += s_Disposed;

            if (book !=null )
            {
                s.Book = book;
            }

            drawOne(s);
        }
        void s_Disposed(object sender, EventArgs e)
        {
            _listSelector.Remove(sender as BookSelector);
            redrawThis();
        }

        private void redrawThis()
        {
            this.panel1.Controls.Clear();
            for (int i = 0; i < _listSelector.Count; i++)
            {
                this.panel1.Controls.Add(_listSelector[i]);
                if ((i+1) % 2 == 1)
                {
                    _listSelector[i].BackColor = odd;
                }
                else
                {
                    _listSelector[i].BackColor = even;
                }
                _listSelector[i].Location = new Point(0, i * _listSelector[i].Size.Height);
            }
        }

        private void drawOne(BookSelector selec)
        {
            this.panel1.Controls.Add(selec);
            selec.Location = new Point(0, (_listSelector.Count-1) * selec.Size.Height);
            this.panel1.Update();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (_listSelector.Count==0)
                {
                    MessageBox.Show("列表为空！ ","空列表", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textBox1.Text == "")
                {
                    MessageBox.Show("请填写备注信息,以便日后查询","注意", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                this.BookListToOperate = new Dictionary<Book, int>();
                foreach (var item in _listSelector)
                {
                    if (item.Book != null)
                    {
                        BookListToOperate.Add(item.Book, item.BookCount);
                    }
                }
                this.NoteTag = textBox1.Text;
                this.OperTime = this.dtp_Op_time.Value;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("清单的书名称不能重复,请通过数量修改清单", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch(Exception erra)
            {
                MessageBox.Show(erra.Message);
                return;
            }

        }
        public Dictionary<Book,int> BookListToOperate { get; set; }
        public string NoteTag { get; set; }
        public DateTime OperTime { get; set; }

        #region Test2
        void initData()
        {
            this.checkedListBox1.Items.AddRange(_booklist.ToArray());
            this.checkedListBox1.DisplayMember = "BookName";
        }

        #endregion

        private void btn_AddChecked_Click(object sender, EventArgs e)
        {
            this.btn_AddChecked.Text = "请等待...";
            this.btn_AddChecked.Enabled = false;
            this.checkedListBox1.Visible = false;
            
            Action action = new Action(delegate()
            {
                foreach (var item in checkedListBox1.CheckedItems)
                {
                    AddOne(item as Book);
                }
            });
            var res = this.Invoke(action);
            //MessageBox.Show("请调整购买数量,完成后点击购买","提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.btn_AddChecked.Visible = false;
            this.btn_OK.Enabled = true;
        }
        void AddFinishCallback(IAsyncResult res)
        {
            //var action = res.AsyncState as Action;
            this.Invoke(new Action(delegate() { this.btn_AddChecked.Visible = false; }));
        }

        private void FrmBookListMaker_SizeChanged(object sender, EventArgs e)
        {
            this.panel1.Size = new Size(this.Size.Width -this.panel1.Location.X - 25, this.Size.Height - this.panel1.Location.Y - 50 - this.panel3.Height);
            this.checkedListBox1.Size = new Size(this.panel1.Width - 25, this.panel1.Height - 5);
        }

        private void btn_saveList_Click(object sender, EventArgs e)
        {
            try
            {
                if (_listSelector.Count == 0)
                {
                    MessageBox.Show("列表为空 ", "空列表", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textBox1.Text == "")
                {
                    MessageBox.Show("请填写备注信息,备注信息是列表的名字", "注意", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                this.BookListToOperate = new Dictionary<Book, int>();
                foreach (var item in _listSelector)
                {
                    if (item.Book != null)
                    {
                        BookListToOperate.Add(item.Book, item.BookCount);
                    }
                }
                new DBcon().SaveBookList(this.BookListToOperate.Keys.ToList<Book>(), textBox1.Text);
                MessageBox.Show("保存成功");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            } 
        }

        private void btn_LoadList_Click(object sender, EventArgs e)
        {
            var fblv =new FrmBookListViewer();
            if (fblv.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.btn_AddChecked.Text = "请等待...";
                this.btn_AddChecked.Enabled = false;
                this.checkedListBox1.Visible = false;

                Action action = new Action(delegate()
                {
                    foreach (var item in fblv.BookList)
                    {
                        var q = from Book a in _booklist
                                where a.BookID == item.BookID
                                select a;
                        AddOne(q.First());
                    }
                });
                var res = this.Invoke(action);
                //MessageBox.Show("请调整购买数量,完成后点击购买","提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.btn_AddChecked.Visible = false;
                this.btn_OK.Enabled = true;




            }
        }
    }
}
