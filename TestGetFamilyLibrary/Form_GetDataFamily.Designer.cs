namespace TestGetFamilyLibrary
{
    partial class Form_GetDataFamily
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
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_showPara = new System.Windows.Forms.Button();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.btn_Path = new System.Windows.Forms.Button();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(703, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get Info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(62, 81);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(866, 293);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Group";
            this.columnHeader3.Width = 150;
            // 
            // btn_showPara
            // 
            this.btn_showPara.Location = new System.Drawing.Point(524, 419);
            this.btn_showPara.Name = "btn_showPara";
            this.btn_showPara.Size = new System.Drawing.Size(140, 23);
            this.btn_showPara.TabIndex = 0;
            this.btn_showPara.Text = "Show Parameters";
            this.btn_showPara.UseVisualStyleBackColor = true;
            this.btn_showPara.Click += new System.EventHandler(this.btn_getInfo_Click);
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(93, 31);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(835, 20);
            this.tb_path.TabIndex = 2;
            // 
            // btn_Path
            // 
            this.btn_Path.Location = new System.Drawing.Point(12, 31);
            this.btn_Path.Name = "btn_Path";
            this.btn_Path.Size = new System.Drawing.Size(75, 23);
            this.btn_Path.TabIndex = 0;
            this.btn_Path.Text = "path";
            this.btn_Path.UseVisualStyleBackColor = true;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Type";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 150;
            // 
            // Form_GetDataFamily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 467);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_Path);
            this.Controls.Add(this.btn_showPara);
            this.Controls.Add(this.button1);
            this.Name = "Form_GetDataFamily";
            this.Text = "Form_GetDataFamily";
            this.Load += new System.EventHandler(this.Form_GetDataFamily_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_showPara;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Button btn_Path;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}