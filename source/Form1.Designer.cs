namespace BooksManageSystem
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_M = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_BUYBOOK = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_RETURNBOOK = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_SELLBOOK = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_LINGQU = new System.Windows.Forms.ToolStripMenuItem();
            this.记录查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_BookLOG = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_All_bookLOG = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_BigList = new System.Windows.Forms.ToolStripMenuItem();
            this.书籍清单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ModifyBook = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_newBook = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_exportBookList = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ExcelOutBookList = new System.Windows.Forms.ToolStripMenuItem();
            this.销售统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_TotalSell = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_TotalOut = new System.Windows.Forms.ToolStripMenuItem();
            this.初始化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_init = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_About = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ShowAll = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_in_Buy = new System.Windows.Forms.Button();
            this.btn_in_Return = new System.Windows.Forms.Button();
            this.btn_out_Sell = new System.Windows.Forms.Button();
            this.btn_out_Give = new System.Windows.Forms.Button();
            this.pl_BtnPlanel = new System.Windows.Forms.Panel();
            this.btn_out_Sell_List = new System.Windows.Forms.Button();
            this.btn_out_Give_booklist = new System.Windows.Forms.Button();
            this.btn_BuyListQuery = new System.Windows.Forms.Button();
            this.btn_OPLOGALL = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.pl_BtnPlanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_M,
            this.记录查询ToolStripMenuItem,
            this.书籍清单ToolStripMenuItem,
            this.销售统计ToolStripMenuItem,
            this.初始化ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(784, 25);
            this.menuStrip1.TabIndex = 0;
            // 
            // menu_M
            // 
            this.menu_M.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_BUYBOOK,
            this.menu_RETURNBOOK,
            this.toolStripSeparator1,
            this.menu_SELLBOOK,
            this.menu_LINGQU});
            this.menu_M.Name = "menu_M";
            this.menu_M.Size = new System.Drawing.Size(84, 21);
            this.menu_M.Text = "数量变更(&C)";
            // 
            // menu_BUYBOOK
            // 
            this.menu_BUYBOOK.Name = "menu_BUYBOOK";
            this.menu_BUYBOOK.Size = new System.Drawing.Size(140, 22);
            this.menu_BUYBOOK.Text = "批量购书(&P)";
            this.menu_BUYBOOK.Click += new System.EventHandler(this.menu_BUYBOOK_Click);
            // 
            // menu_RETURNBOOK
            // 
            this.menu_RETURNBOOK.Name = "menu_RETURNBOOK";
            this.menu_RETURNBOOK.Size = new System.Drawing.Size(140, 22);
            this.menu_RETURNBOOK.Text = "归还书籍(&R)";
            this.menu_RETURNBOOK.Click += new System.EventHandler(this.menu_RETURNBOOK_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(137, 6);
            // 
            // menu_SELLBOOK
            // 
            this.menu_SELLBOOK.Name = "menu_SELLBOOK";
            this.menu_SELLBOOK.Size = new System.Drawing.Size(140, 22);
            this.menu_SELLBOOK.Text = "销售书籍(&S)";
            this.menu_SELLBOOK.Click += new System.EventHandler(this.menu_SELLBOOK_Click);
            // 
            // menu_LINGQU
            // 
            this.menu_LINGQU.Name = "menu_LINGQU";
            this.menu_LINGQU.Size = new System.Drawing.Size(140, 22);
            this.menu_LINGQU.Text = "领取书籍(&E)";
            this.menu_LINGQU.Click += new System.EventHandler(this.menu_LINGQU_Click);
            // 
            // 记录查询ToolStripMenuItem
            // 
            this.记录查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_BookLOG,
            this.menu_All_bookLOG,
            this.menu_BigList});
            this.记录查询ToolStripMenuItem.Name = "记录查询ToolStripMenuItem";
            this.记录查询ToolStripMenuItem.Size = new System.Drawing.Size(86, 21);
            this.记录查询ToolStripMenuItem.Text = "记录查询(&Q)";
            // 
            // menu_BookLOG
            // 
            this.menu_BookLOG.Name = "menu_BookLOG";
            this.menu_BookLOG.Size = new System.Drawing.Size(229, 22);
            this.menu_BookLOG.Text = "选中的书籍数量变更记录";
            this.menu_BookLOG.Click += new System.EventHandler(this.menu_BookLOG_Click);
            // 
            // menu_All_bookLOG
            // 
            this.menu_All_bookLOG.Name = "menu_All_bookLOG";
            this.menu_All_bookLOG.Size = new System.Drawing.Size(229, 22);
            this.menu_All_bookLOG.Text = "最近100次书籍数量变更记录";
            this.menu_All_bookLOG.Click += new System.EventHandler(this.menu_All_bookLOG_Click);
            // 
            // menu_BigList
            // 
            this.menu_BigList.Name = "menu_BigList";
            this.menu_BigList.Size = new System.Drawing.Size(229, 22);
            this.menu_BigList.Text = "购书单查询";
            this.menu_BigList.Click += new System.EventHandler(this.menu_BigList_Click);
            // 
            // 书籍清单ToolStripMenuItem
            // 
            this.书籍清单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_ModifyBook,
            this.menu_newBook,
            this.toolStripSeparator2,
            this.menu_exportBookList,
            this.menu_ExcelOutBookList});
            this.书籍清单ToolStripMenuItem.Name = "书籍清单ToolStripMenuItem";
            this.书籍清单ToolStripMenuItem.Size = new System.Drawing.Size(88, 21);
            this.书籍清单ToolStripMenuItem.Text = "书籍管理(&M)";
            // 
            // menu_ModifyBook
            // 
            this.menu_ModifyBook.Name = "menu_ModifyBook";
            this.menu_ModifyBook.Size = new System.Drawing.Size(228, 22);
            this.menu_ModifyBook.Text = "修改书籍(录入错误时候修改)";
            this.menu_ModifyBook.Click += new System.EventHandler(this.menu_ModifyBook_Click);
            // 
            // menu_newBook
            // 
            this.menu_newBook.Name = "menu_newBook";
            this.menu_newBook.Size = new System.Drawing.Size(228, 22);
            this.menu_newBook.Text = "添加新书(从没有用过的教材)";
            this.menu_newBook.Click += new System.EventHandler(this.menu_newBook_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(225, 6);
            // 
            // menu_exportBookList
            // 
            this.menu_exportBookList.Name = "menu_exportBookList";
            this.menu_exportBookList.Size = new System.Drawing.Size(228, 22);
            this.menu_exportBookList.Text = "导出txt库存列表";
            this.menu_exportBookList.Click += new System.EventHandler(this.menu_exportBookList_Click);
            // 
            // menu_ExcelOutBookList
            // 
            this.menu_ExcelOutBookList.Name = "menu_ExcelOutBookList";
            this.menu_ExcelOutBookList.Size = new System.Drawing.Size(228, 22);
            this.menu_ExcelOutBookList.Text = "导出Excel库存列表";
            this.menu_ExcelOutBookList.Click += new System.EventHandler(this.menu_ExcelOutBookList_Click);
            // 
            // 销售统计ToolStripMenuItem
            // 
            this.销售统计ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_TotalSell,
            this.menu_TotalOut});
            this.销售统计ToolStripMenuItem.Name = "销售统计ToolStripMenuItem";
            this.销售统计ToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.销售统计ToolStripMenuItem.Text = "统计(&T)";
            // 
            // menu_TotalSell
            // 
            this.menu_TotalSell.Name = "menu_TotalSell";
            this.menu_TotalSell.Size = new System.Drawing.Size(177, 22);
            this.menu_TotalSell.Text = "导出Excel销售数据";
            this.menu_TotalSell.Click += new System.EventHandler(this.menu_TotalSell_Click);
            // 
            // menu_TotalOut
            // 
            this.menu_TotalOut.Name = "menu_TotalOut";
            this.menu_TotalOut.Size = new System.Drawing.Size(177, 22);
            this.menu_TotalOut.Text = "导出Excel领取数据";
            this.menu_TotalOut.Click += new System.EventHandler(this.menu_TotalOut_Click);
            // 
            // 初始化ToolStripMenuItem
            // 
            this.初始化ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_init,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.menu_About});
            this.初始化ToolStripMenuItem.Name = "初始化ToolStripMenuItem";
            this.初始化ToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.初始化ToolStripMenuItem.Text = "系统(&S)";
            // 
            // menu_init
            // 
            this.menu_init.Name = "menu_init";
            this.menu_init.Size = new System.Drawing.Size(182, 22);
            this.menu_init.Text = "初始数据维护";
            this.menu_init.Click += new System.EventHandler(this.menu_init_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.toolStripMenuItem1.Text = "数据库升级1.0到1.1";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(182, 22);
            this.toolStripMenuItem2.Text = "数据库升级1.1到1.3";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // menu_About
            // 
            this.menu_About.Name = "menu_About";
            this.menu_About.Size = new System.Drawing.Size(182, 22);
            this.menu_About.Text = "关于";
            this.menu_About.Click += new System.EventHandler(this.menu_About_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(116, 55);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(656, 494);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 46;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "书名";
            this.columnHeader2.Width = 328;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "定价";
            this.columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "订购价";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "数量";
            this.columnHeader5.Width = 62;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "学生用书";
            this.columnHeader6.Width = 80;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(555, 28);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(100, 21);
            this.txt_Search.TabIndex = 4;
            this.txt_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Search_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(520, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "查找";
            // 
            // btn_ShowAll
            // 
            this.btn_ShowAll.Location = new System.Drawing.Point(696, 26);
            this.btn_ShowAll.Name = "btn_ShowAll";
            this.btn_ShowAll.Size = new System.Drawing.Size(79, 23);
            this.btn_ShowAll.TabIndex = 6;
            this.btn_ShowAll.Text = "刷新/全部";
            this.btn_ShowAll.UseVisualStyleBackColor = true;
            this.btn_ShowAll.Click += new System.EventHandler(this.btn_ShowAll_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(660, 26);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(37, 23);
            this.btn_Search.TabIndex = 7;
            this.btn_Search.Text = "Go";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "红色为数量少的学生用书";
            // 
            // btn_in_Buy
            // 
            this.btn_in_Buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(129)))), ((int)(((byte)(93)))));
            this.btn_in_Buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_in_Buy.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_in_Buy.Location = new System.Drawing.Point(3, 3);
            this.btn_in_Buy.Name = "btn_in_Buy";
            this.btn_in_Buy.Size = new System.Drawing.Size(91, 32);
            this.btn_in_Buy.TabIndex = 10;
            this.btn_in_Buy.Text = "批量购入";
            this.btn_in_Buy.UseVisualStyleBackColor = false;
            this.btn_in_Buy.Click += new System.EventHandler(this.btn_in_Buy_Click);
            // 
            // btn_in_Return
            // 
            this.btn_in_Return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(164)))), ((int)(((byte)(59)))));
            this.btn_in_Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_in_Return.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_in_Return.Location = new System.Drawing.Point(3, 41);
            this.btn_in_Return.Name = "btn_in_Return";
            this.btn_in_Return.Size = new System.Drawing.Size(91, 32);
            this.btn_in_Return.TabIndex = 11;
            this.btn_in_Return.Text = "归还";
            this.btn_in_Return.UseVisualStyleBackColor = false;
            this.btn_in_Return.Click += new System.EventHandler(this.btn_in_Return_Click);
            // 
            // btn_out_Sell
            // 
            this.btn_out_Sell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_out_Sell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_out_Sell.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_out_Sell.Location = new System.Drawing.Point(4, 97);
            this.btn_out_Sell.Name = "btn_out_Sell";
            this.btn_out_Sell.Size = new System.Drawing.Size(91, 32);
            this.btn_out_Sell.TabIndex = 12;
            this.btn_out_Sell.Text = "销售￥";
            this.btn_out_Sell.UseVisualStyleBackColor = false;
            this.btn_out_Sell.Click += new System.EventHandler(this.btn_out_Sell_Click);
            // 
            // btn_out_Give
            // 
            this.btn_out_Give.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(204)))), ((int)(((byte)(90)))));
            this.btn_out_Give.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_out_Give.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_out_Give.Location = new System.Drawing.Point(4, 167);
            this.btn_out_Give.Name = "btn_out_Give";
            this.btn_out_Give.Size = new System.Drawing.Size(91, 32);
            this.btn_out_Give.TabIndex = 13;
            this.btn_out_Give.Text = "领取";
            this.btn_out_Give.UseVisualStyleBackColor = false;
            this.btn_out_Give.Click += new System.EventHandler(this.btn_out_Give_Click);
            // 
            // pl_BtnPlanel
            // 
            this.pl_BtnPlanel.Controls.Add(this.btn_out_Sell_List);
            this.pl_BtnPlanel.Controls.Add(this.btn_out_Give_booklist);
            this.pl_BtnPlanel.Controls.Add(this.btn_BuyListQuery);
            this.pl_BtnPlanel.Controls.Add(this.btn_OPLOGALL);
            this.pl_BtnPlanel.Controls.Add(this.btn_in_Buy);
            this.pl_BtnPlanel.Controls.Add(this.btn_out_Give);
            this.pl_BtnPlanel.Controls.Add(this.btn_in_Return);
            this.pl_BtnPlanel.Controls.Add(this.btn_out_Sell);
            this.pl_BtnPlanel.Location = new System.Drawing.Point(12, 55);
            this.pl_BtnPlanel.Name = "pl_BtnPlanel";
            this.pl_BtnPlanel.Size = new System.Drawing.Size(98, 327);
            this.pl_BtnPlanel.TabIndex = 14;
            // 
            // btn_out_Sell_List
            // 
            this.btn_out_Sell_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_out_Sell_List.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_out_Sell_List.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_out_Sell_List.Location = new System.Drawing.Point(4, 132);
            this.btn_out_Sell_List.Name = "btn_out_Sell_List";
            this.btn_out_Sell_List.Size = new System.Drawing.Size(91, 32);
            this.btn_out_Sell_List.TabIndex = 17;
            this.btn_out_Sell_List.Text = "批量销售";
            this.btn_out_Sell_List.UseVisualStyleBackColor = false;
            this.btn_out_Sell_List.Click += new System.EventHandler(this.btn_out_Sell_List_Click);
            // 
            // btn_out_Give_booklist
            // 
            this.btn_out_Give_booklist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(204)))), ((int)(((byte)(90)))));
            this.btn_out_Give_booklist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_out_Give_booklist.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_out_Give_booklist.Location = new System.Drawing.Point(4, 202);
            this.btn_out_Give_booklist.Name = "btn_out_Give_booklist";
            this.btn_out_Give_booklist.Size = new System.Drawing.Size(91, 32);
            this.btn_out_Give_booklist.TabIndex = 16;
            this.btn_out_Give_booklist.Text = "批量领取";
            this.btn_out_Give_booklist.UseVisualStyleBackColor = false;
            this.btn_out_Give_booklist.Click += new System.EventHandler(this.btn_out_Give_booklist_Click);
            // 
            // btn_BuyListQuery
            // 
            this.btn_BuyListQuery.BackColor = System.Drawing.Color.Violet;
            this.btn_BuyListQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BuyListQuery.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_BuyListQuery.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_BuyListQuery.Location = new System.Drawing.Point(4, 292);
            this.btn_BuyListQuery.Name = "btn_BuyListQuery";
            this.btn_BuyListQuery.Size = new System.Drawing.Size(91, 32);
            this.btn_BuyListQuery.TabIndex = 15;
            this.btn_BuyListQuery.Text = "购书记录";
            this.btn_BuyListQuery.UseVisualStyleBackColor = false;
            this.btn_BuyListQuery.Click += new System.EventHandler(this.btn_BuyListQuery_Click);
            // 
            // btn_OPLOGALL
            // 
            this.btn_OPLOGALL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(134)))));
            this.btn_OPLOGALL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OPLOGALL.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OPLOGALL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_OPLOGALL.Location = new System.Drawing.Point(3, 254);
            this.btn_OPLOGALL.Name = "btn_OPLOGALL";
            this.btn_OPLOGALL.Size = new System.Drawing.Size(91, 32);
            this.btn_OPLOGALL.TabIndex = 14;
            this.btn_OPLOGALL.Text = "全部记录";
            this.btn_OPLOGALL.UseVisualStyleBackColor = false;
            this.btn_OPLOGALL.Click += new System.EventHandler(this.btn_OPLOGALL_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pl_BtnPlanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_ShowAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1920, 1078);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grace的图书管理";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pl_BtnPlanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_M;
        private System.Windows.Forms.ToolStripMenuItem menu_BUYBOOK;
        private System.Windows.Forms.ToolStripMenuItem menu_LINGQU;
        private System.Windows.Forms.ToolStripMenuItem menu_SELLBOOK;
        private System.Windows.Forms.ToolStripMenuItem menu_RETURNBOOK;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 书籍清单ToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ToolStripMenuItem menu_newBook;
        private System.Windows.Forms.ToolStripMenuItem 记录查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_BookLOG;
        private System.Windows.Forms.ToolStripMenuItem menu_All_bookLOG;
        private System.Windows.Forms.ToolStripMenuItem menu_exportBookList;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ShowAll;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ToolStripMenuItem 销售统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_TotalSell;
        private System.Windows.Forms.ToolStripMenuItem menu_ExcelOutBookList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 初始化ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_init;
        private System.Windows.Forms.ToolStripMenuItem menu_ModifyBook;
        private System.Windows.Forms.ToolStripMenuItem menu_About;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_in_Buy;
        private System.Windows.Forms.Button btn_in_Return;
        private System.Windows.Forms.Button btn_out_Sell;
        private System.Windows.Forms.Button btn_out_Give;
        private System.Windows.Forms.Panel pl_BtnPlanel;
        private System.Windows.Forms.Button btn_OPLOGALL;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menu_BigList;
        private System.Windows.Forms.Button btn_BuyListQuery;
        private System.Windows.Forms.Button btn_out_Give_booklist;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button btn_out_Sell_List;
        private System.Windows.Forms.ToolStripMenuItem menu_TotalOut;
        private System.Windows.Forms.Button button1;
    }
}

