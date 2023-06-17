namespace FloatLrc
{
    partial class WebViewMain
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebViewMain));
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            addressBar = new TextBox();
            goButton = new Button();
            LrcButton = new Button();
            timer = new System.Windows.Forms.Timer(components);
            settings = new Button();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            SuspendLayout();
            // 
            // webView
            // 
            webView.AllowExternalDrop = true;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.White;
            webView.Location = new Point(0, 50);
            webView.Margin = new Padding(4);
            webView.Name = "webView";
            webView.Size = new Size(1875, 1330);
            webView.Source = new Uri("https://asmr.one/", UriKind.Absolute);
            webView.TabIndex = 0;
            webView.ZoomFactor = 1D;
            // 
            // addressBar
            // 
            addressBar.Location = new Point(0, 10);
            addressBar.Margin = new Padding(4);
            addressBar.Name = "addressBar";
            addressBar.Size = new Size(1637, 23);
            addressBar.TabIndex = 1;
            // 
            // goButton
            // 
            goButton.Location = new Point(1645, 9);
            goButton.Margin = new Padding(4);
            goButton.Name = "goButton";
            goButton.Size = new Size(62, 25);
            goButton.TabIndex = 2;
            goButton.Text = "访问";
            goButton.UseVisualStyleBackColor = true;
            goButton.Click += goButton_Click;
            // 
            // LrcButton
            // 
            LrcButton.Location = new Point(1714, 9);
            LrcButton.Margin = new Padding(4);
            LrcButton.Name = "LrcButton";
            LrcButton.Size = new Size(88, 25);
            LrcButton.TabIndex = 3;
            LrcButton.Text = "开/关字幕";
            LrcButton.UseVisualStyleBackColor = true;
            LrcButton.Click += LrcButton_Click;
            // 
            // timer
            // 
            timer.Interval = 50;
            timer.Tick += timer_Tick;
            // 
            // settings
            // 
            settings.Location = new Point(1808, 9);
            settings.Margin = new Padding(4);
            settings.Name = "settings";
            settings.Size = new Size(47, 25);
            settings.TabIndex = 4;
            settings.Text = "设置";
            settings.UseVisualStyleBackColor = true;
            settings.Click += settings_Click;
            // 
            // WebViewMain
            // 
            AcceptButton = goButton;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1876, 1383);
            Controls.Add(settings);
            Controls.Add(LrcButton);
            Controls.Add(goButton);
            Controls.Add(addressBar);
            Controls.Add(webView);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "WebViewMain";
            Text = "FloatLrc  by.Kirie";
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox addressBar;
        private Button goButton;
        private Button LrcButton;
        private System.Windows.Forms.Timer timer;
        private Button settings;
        public Microsoft.Web.WebView2.WinForms.WebView2 webView;
    }
}

