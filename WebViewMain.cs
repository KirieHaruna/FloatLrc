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
