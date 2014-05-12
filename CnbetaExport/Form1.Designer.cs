namespace _2013092401文章导出为txt
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
            this.txtPfrom = new System.Windows.Forms.TextBox();
            this.txtPto = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.pgbar = new System.Windows.Forms.ProgressBar();
            this.lbpgbar = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_encn = new System.Windows.Forms.RadioButton();
            this.rbtn_cnbeta = new System.Windows.Forms.RadioButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.rtxt = new System.Windows.Forms.RichTextBox();
            this.gpThread = new System.Windows.Forms.GroupBox();
            this.rbtn_8 = new System.Windows.Forms.RadioButton();
            this.rbtn_4 = new System.Windows.Forms.RadioButton();
            this.rbtn_2 = new System.Windows.Forms.RadioButton();
            this.rbtn_1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCostLeave = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gpThread.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPfrom
            // 
            this.txtPfrom.Location = new System.Drawing.Point(43, 114);
            this.txtPfrom.Name = "txtPfrom";
            this.txtPfrom.Size = new System.Drawing.Size(54, 21);
            this.txtPfrom.TabIndex = 1;
            // 
            // txtPto
            // 
            this.txtPto.Location = new System.Drawing.Point(121, 114);
            this.txtPto.Name = "txtPto";
            this.txtPto.Size = new System.Drawing.Size(54, 21);
            this.txtPto.TabIndex = 2;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(209, 114);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // pgbar
            // 
            this.pgbar.Location = new System.Drawing.Point(11, 293);
            this.pgbar.Name = "pgbar";
            this.pgbar.Size = new System.Drawing.Size(215, 17);
            this.pgbar.TabIndex = 3;
            // 
            // lbpgbar
            // 
            this.lbpgbar.AutoSize = true;
            this.lbpgbar.Location = new System.Drawing.Point(231, 293);
            this.lbpgbar.Name = "lbpgbar";
            this.lbpgbar.Size = new System.Drawing.Size(53, 12);
            this.lbpgbar.TabIndex = 4;
            this.lbpgbar.Text = "progress";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_encn);
            this.groupBox1.Controls.Add(this.rbtn_cnbeta);
            this.groupBox1.Location = new System.Drawing.Point(11, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 32);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Web";
            // 
            // rbtn_encn
            // 
            this.rbtn_encn.AutoSize = true;
            this.rbtn_encn.Location = new System.Drawing.Point(69, 13);
            this.rbtn_encn.Name = "rbtn_encn";
            this.rbtn_encn.Size = new System.Drawing.Size(47, 16);
            this.rbtn_encn.TabIndex = 1;
            this.rbtn_encn.TabStop = true;
            this.rbtn_encn.Text = "Encn";
            this.rbtn_encn.UseVisualStyleBackColor = true;
            // 
            // rbtn_cnbeta
            // 
            this.rbtn_cnbeta.AutoSize = true;
            this.rbtn_cnbeta.Location = new System.Drawing.Point(9, 13);
            this.rbtn_cnbeta.Name = "rbtn_cnbeta";
            this.rbtn_cnbeta.Size = new System.Drawing.Size(59, 16);
            this.rbtn_cnbeta.TabIndex = 0;
            this.rbtn_cnbeta.TabStop = true;
            this.rbtn_cnbeta.Text = "cnBeta";
            this.rbtn_cnbeta.UseVisualStyleBackColor = true;
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Location = new System.Drawing.Point(10, 11);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(236, 21);
            this.txtFolderPath.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOpenFolder);
            this.groupBox2.Controls.Add(this.txtFolderPath);
            this.groupBox2.Location = new System.Drawing.Point(11, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 34);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Folder";
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(241, 9);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(32, 23);
            this.btnOpenFolder.TabIndex = 1;
            this.btnOpenFolder.Text = "...";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // rtxt
            // 
            this.rtxt.Location = new System.Drawing.Point(11, 143);
            this.rtxt.Name = "rtxt";
            this.rtxt.Size = new System.Drawing.Size(273, 144);
            this.rtxt.TabIndex = 0;
            this.rtxt.Text = "";
            // 
            // gpThread
            // 
            this.gpThread.Controls.Add(this.rbtn_8);
            this.gpThread.Controls.Add(this.rbtn_4);
            this.gpThread.Controls.Add(this.rbtn_2);
            this.gpThread.Controls.Add(this.rbtn_1);
            this.gpThread.Location = new System.Drawing.Point(11, 76);
            this.gpThread.Name = "gpThread";
            this.gpThread.Size = new System.Drawing.Size(272, 32);
            this.gpThread.TabIndex = 8;
            this.gpThread.TabStop = false;
            this.gpThread.Text = "Thread";
            // 
            // rbtn_8
            // 
            this.rbtn_8.AutoSize = true;
            this.rbtn_8.Location = new System.Drawing.Point(112, 13);
            this.rbtn_8.Name = "rbtn_8";
            this.rbtn_8.Size = new System.Drawing.Size(29, 16);
            this.rbtn_8.TabIndex = 0;
            this.rbtn_8.TabStop = true;
            this.rbtn_8.Text = "8";
            this.rbtn_8.UseVisualStyleBackColor = true;
            // 
            // rbtn_4
            // 
            this.rbtn_4.AutoSize = true;
            this.rbtn_4.Location = new System.Drawing.Point(75, 13);
            this.rbtn_4.Name = "rbtn_4";
            this.rbtn_4.Size = new System.Drawing.Size(29, 16);
            this.rbtn_4.TabIndex = 0;
            this.rbtn_4.TabStop = true;
            this.rbtn_4.Text = "4";
            this.rbtn_4.UseVisualStyleBackColor = true;
            // 
            // rbtn_2
            // 
            this.rbtn_2.AutoSize = true;
            this.rbtn_2.Location = new System.Drawing.Point(41, 13);
            this.rbtn_2.Name = "rbtn_2";
            this.rbtn_2.Size = new System.Drawing.Size(29, 16);
            this.rbtn_2.TabIndex = 0;
            this.rbtn_2.TabStop = true;
            this.rbtn_2.Text = "2";
            this.rbtn_2.UseVisualStyleBackColor = true;
            // 
            // rbtn_1
            // 
            this.rbtn_1.AutoSize = true;
            this.rbtn_1.Location = new System.Drawing.Point(6, 13);
            this.rbtn_1.Name = "rbtn_1";
            this.rbtn_1.Size = new System.Drawing.Size(29, 16);
            this.rbtn_1.TabIndex = 0;
            this.rbtn_1.TabStop = true;
            this.rbtn_1.Text = "1";
            this.rbtn_1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "-";
            // 
            // lbCostLeave
            // 
            this.lbCostLeave.AutoSize = true;
            this.lbCostLeave.Location = new System.Drawing.Point(11, 330);
            this.lbCostLeave.Name = "lbCostLeave";
            this.lbCostLeave.Size = new System.Drawing.Size(41, 12);
            this.lbCostLeave.TabIndex = 11;
            this.lbCostLeave.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 354);
            this.Controls.Add(this.lbCostLeave);
            this.Controls.Add(this.pgbar);
            this.Controls.Add(this.lbpgbar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpThread);
            this.Controls.Add(this.rtxt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtPto);
            this.Controls.Add(this.txtPfrom);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CnbetaExport";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gpThread.ResumeLayout(false);
            this.gpThread.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPfrom;
        private System.Windows.Forms.TextBox txtPto;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ProgressBar pgbar;
        private System.Windows.Forms.Label lbpgbar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_encn;
        private System.Windows.Forms.RadioButton rbtn_cnbeta;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.RichTextBox rtxt;
        private System.Windows.Forms.GroupBox gpThread;
        private System.Windows.Forms.RadioButton rbtn_1;
        private System.Windows.Forms.RadioButton rbtn_8;
        private System.Windows.Forms.RadioButton rbtn_4;
        private System.Windows.Forms.RadioButton rbtn_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCostLeave;
    }
}

