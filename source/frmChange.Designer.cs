namespace BooksManageSystem
{
    partial class frmChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChange));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Bookname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NoteTag = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.dtp_Op_time = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.numberUD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numberUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "书名:";
            // 
            // txt_Bookname
            // 
            this.txt_Bookname.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Bookname.Location = new System.Drawing.Point(53, 49);
            this.txt_Bookname.Name = "txt_Bookname";
            this.txt_Bookname.Size = new System.Drawing.Size(407, 23);
            this.txt_Bookname.TabIndex = 4;
            this.txt_Bookname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Bookname_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "数量:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "备注:";
            // 
            // txt_NoteTag
            // 
            this.txt_NoteTag.BackColor = System.Drawing.SystemColors.Info;
            this.txt_NoteTag.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_NoteTag.Location = new System.Drawing.Point(53, 109);
            this.txt_NoteTag.Name = "txt_NoteTag";
            this.txt_NoteTag.Size = new System.Drawing.Size(308, 23);
            this.txt_NoteTag.TabIndex = 0;
            this.txt_NoteTag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NoteTag_KeyPress);
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(108)))), ((int)(((byte)(123)))));
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OK.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_OK.Location = new System.Drawing.Point(384, 107);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(93, 27);
            this.btn_OK.TabIndex = 3;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // dtp_Op_time
            // 
            this.dtp_Op_time.CustomFormat = "yyyy年MM月dd日 HH:mm:ss";
            this.dtp_Op_time.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtp_Op_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Op_time.Location = new System.Drawing.Point(53, 18);
            this.dtp_Op_time.Name = "dtp_Op_time";
            this.dtp_Op_time.Size = new System.Drawing.Size(223, 23);
            this.dtp_Op_time.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(12, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "时间:";
            // 
            // numberUD
            // 
            this.numberUD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberUD.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numberUD.Location = new System.Drawing.Point(53, 78);
            this.numberUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberUD.Name = "numberUD";
            this.numberUD.Size = new System.Drawing.Size(93, 23);
            this.numberUD.TabIndex = 1;
            this.numberUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 164);
            this.Controls.Add(this.numberUD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_Op_time);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_NoteTag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Bookname);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmChange";
            this.Load += new System.EventHandler(this.frmChange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Bookname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NoteTag;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.DateTimePicker dtp_Op_time;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numberUD;
    }
}