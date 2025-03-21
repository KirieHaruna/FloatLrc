using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;


namespace FloatLrc
{
    public partial class WebViewMain : Form
    {
        public FloatLrc floatLrc = new FloatLrc();
        public WebViewMain()
        {
            string ApplicationData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            InitializeComponent();
            InitializeTrayIcon(); // 初始化托盘图标
            this.AutoScaleMode = AutoScaleMode.Dpi;
            try
            {
                this.webView.Source = (System.Uri)SerializeUtil.Decode(SerializeUtil.FileToByte($"{ApplicationData}\\FloatLrc\\Uri.bin"));
                this.floatLrc.Width = (int)SerializeUtil.Decode(SerializeUtil.FileToByte($"{ApplicationData}\\FloatLrc\\Width.bin"));
                this.floatLrc.Height = (int)SerializeUtil.Decode(SerializeUtil.FileToByte($"{ApplicationData}\\FloatLrc\\Height.bin"));
                this.floatLrc.LrcText.Width = this.floatLrc.Width;
                this.floatLrc.LrcText.Height = this.floatLrc.Height;
                this.floatLrc.MaximumSize = new System.Drawing.Size(width: this.floatLrc.Width, height: this.floatLrc.Height);
                this.floatLrc.LrcText.Font = (System.Drawing.Font)SerializeUtil.Decode(SerializeUtil.FileToByte($"{ApplicationData}\\FloatLrc\\Font.bin"));
                this.floatLrc.LrcText.ForeColor = (System.Drawing.Color)SerializeUtil.Decode(SerializeUtil.FileToByte($"{ApplicationData}\\FloatLrc\\ForeColor.bin"));
            }
            catch
            {
                Directory.CreateDirectory($"{ApplicationData}\\FloatLrc");
            }
            this.Resize += new System.EventHandler(this.Form_Resize);
            webView.NavigationStarting += ChangeTextofaddressBar;
        }
        private NotifyIcon notifyIcon;
        private ContextMenuStrip trayMenu;

        private void InitializeTrayIcon()
        {
            // 创建托盘图标
            notifyIcon = new NotifyIcon
            {
                Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath), 
                Text = "FloatLrc",
                Visible = false
            };

            // 创建右键菜单
            trayMenu = new ContextMenuStrip();
            trayMenu.Items.Add("退出", null, OnExitClick);

            notifyIcon.ContextMenuStrip = trayMenu;
            notifyIcon.DoubleClick += NotifyIcon_DoubleClick;
        }

        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false; // 隐藏托盘图标

            // 可选：将窗口带回前台
            this.Activate();
        }

        private void OnExitClick(object sender, EventArgs e)
        {
            notifyIcon.Dispose(); // 清理托盘图标
            Application.Exit();  // 完全退出程序
        }

        private void MinimizeToTray()
        {
            this.Hide();             // 隐藏主窗口
            notifyIcon.Visible = true; // 显示托盘图标

            // 可选：显示气泡提示
            notifyIcon.ShowBalloonTip(2000, "FloatLrc", "程序已最小化到托盘", ToolTipIcon.Info);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // 点击关闭按钮时最小化到托盘
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true; // 取消默认关闭行为
                MinimizeToTray();
            }
            else
            {
                base.OnFormClosing(e);
            }
        }
        private void Form_Resize(object sender, EventArgs e)
        {
            webView.Size = this.ClientSize - new System.Drawing.Size(webView.Location);
            goButton.Left = this.ClientSize.Width - goButton.Width - LrcButton.Width - 6 - settings.Width - 12 - 6 - 6;
            LrcButton.Left = this.ClientSize.Width - LrcButton.Width - settings.Width - 12 - 6 - 6;
            settings.Left = this.ClientSize.Width - settings.Width - 12 - 6;
            addressBar.Width = goButton.Left - addressBar.Left - 6;
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.Navigate(addressBar.Text);
            }
        }

        void ChangeTextofaddressBar(object sender, CoreWebView2NavigationStartingEventArgs args)
        {
            addressBar.Text = args.Uri;
        }

        private void LrcButton_Click(object sender, EventArgs e)
        {
            if (floatLrc.Visible)
            {
                floatLrc.Hide();
            }
            else
            {
                this.floatLrc.LrcText.Width = this.floatLrc.Width;
                this.floatLrc.LrcText.Height = this.floatLrc.Height;
                floatLrc.Show();
                timer.Start();
            }
        }
        private async void timer_Tick(object sender, EventArgs e)
        {
            String lrc = await webView.CoreWebView2.ExecuteScriptAsync("document.getElementById('lyric').innerText;");
            floatLrc.LrcText.Text = lrc.Replace("\"", "");
        }

        private void settings_Click(object sender, EventArgs e)
        {
            Settings setting = new Settings(this, floatLrc);
            setting.ShowDialog();
        }
    }
}
