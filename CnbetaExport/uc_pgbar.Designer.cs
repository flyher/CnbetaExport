namespace _2013092401文章导出为txt
{
    partial class uc_pgbar
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pgbar = new System.Windows.Forms.ProgressBar();
            this.lbbar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pgbar
            // 
            this.pgbar.Location = new System.Drawing.Point(4, 2);
            this.pgbar.Name = "pgbar";
            this.pgbar.Size = new System.Drawing.Size(241, 23);
            this.pgbar.TabIndex = 0;
            // 
            // lbbar
            // 
            this.lbbar.AutoSize = true;
            this.lbbar.Location = new System.Drawing.Point(251, 10);
            this.lbbar.Name = "lbbar";
            this.lbbar.Size = new System.Drawing.Size(41, 12);
            this.lbbar.TabIndex = 1;
            this.lbbar.Text = "label1";
            // 
            // uc_pgbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbbar);
            this.Controls.Add(this.pgbar);
            this.Name = "uc_pgbar";
            this.Size = new System.Drawing.Size(307, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbar;
        private System.Windows.Forms.Label lbbar;
    }
}
