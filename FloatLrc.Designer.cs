namespace FloatLrc
{
    partial class FloatLrc
    {
        /// <summary>
        /// Required designer variable.
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.LrcText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LrcText
            // 
            this.LrcText.Font = new System.Drawing.Font("等线", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LrcText.ForeColor = System.Drawing.Color.DarkOrange;
            this.LrcText.Location = new System.Drawing.Point(11, 7);
            this.LrcText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LrcText.Name = "LrcText";
            this.LrcText.Size = new System.Drawing.Size(1012, 53);
            this.LrcText.TabIndex = 0;
            this.LrcText.Text = "LRCTEXT";
            this.LrcText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FloatLrc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 73);
            this.Controls.Add(this.LrcText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FloatLrc";
            this.ShowInTaskbar = false;
            this.Text = "FloatLrc";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FloatLrc_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label LrcText;
    }
}
