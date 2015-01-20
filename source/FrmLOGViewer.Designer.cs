namespace BooksManageSystem
{
    partial class FrmLOGViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLOGViewer));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_outExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.分类显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_del = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cMenu_Edit_oplog = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenu_Del_oplog = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(969, 580);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 33;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "书名";
            this.columnHeader2.Width = 341;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "操作";
            this.columnHeader3.Width = 45;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "变更数量";
            this.columnHeader4.Width = 86;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "变更后数量";
            this.columnHeader5.Width = 96;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "变更时间";
            this.columnHeader6.Width = 183;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "备注";
            this.columnHeader7.Width = 151;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_outExcel,
            this.分类显示ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(969, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_outExcel
            // 
            this.menu_outExcel.Name = "menu_outExcel";
            this.menu_outExcel.Size = new System.Drawing.Size(44, 21);
            this.menu_outExcel.Text = "导出";
            this.menu_outExcel.Click += new System.EventHandler(this.menu_outExcel_Click);
            // 
            // 分类显示ToolStripMenuItem
            // 
            this.分类显示ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_edit,
            this.menu_del});
            this.分类显示ToolStripMenuItem.Name = "分类显示ToolStripMenuItem";
            this.分类显示ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.分类显示ToolStripMenuItem.Text = "编辑";
            // 
            // menu_edit
            // 
            this.menu_edit.Name = "menu_edit";
            this.menu_edit.Size = new System.Drawing.Size(152, 22);
            this.menu_edit.Text = "修改记录";
            this.menu_edit.Click += new System.EventHandler(this.menu_edit_Click);
            // 
            // menu_del
            // 
            this.menu_del.Name = "menu_del";
            this.menu_del.Size = new System.Drawing.Size(152, 22);
            this.menu_del.Text = "删除记录";
            this.menu_del.Click += new System.EventHandler(this.menu_del_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMenu_Edit_oplog,
            this.cMenu_Del_oplog});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 48);
            // 
            // cMenu_Edit_oplog
            // 
            this.cMenu_Edit_oplog.Name = "cMenu_Edit_oplog";
            this.cMenu_Edit_oplog.Size = new System.Drawing.Size(124, 22);
            this.cMenu_Edit_oplog.Text = "修改记录";
            this.cMenu_Edit_oplog.Click += new System.EventHandler(this.cMenu_Edit_oplog_Click);
            // 
            // cMenu_Del_oplog
            // 
            this.cMenu_Del_oplog.Name = "cMenu_Del_oplog";
            this.cMenu_Del_oplog.Size = new System.Drawing.Size(124, 22);
            this.cMenu_Del_oplog.Text = "删除记录";
            this.cMenu_Del_oplog.Click += new System.EventHandler(this.cMenu_Del_oplog_Click);
            // 
            // FrmLOGViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 605);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FrmLOGViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "变更记录查询";
            this.Load += new System.EventHandler(this.FrmLOGViewer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_outExcel;
        private System.Windows.Forms.ToolStripMenuItem 分类显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_edit;
        private System.Windows.Forms.ToolStripMenuItem menu_del;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cMenu_Edit_oplog;
        private System.Windows.Forms.ToolStripMenuItem cMenu_Del_oplog;
    }
}