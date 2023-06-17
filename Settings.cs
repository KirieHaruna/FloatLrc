using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloatLrc
{
    public partial class Settings : Form
    {
        WebViewMain webViewMain;
        FloatLrc floatLrc;
        public Settings(WebViewMain webViewMain, FloatLrc floatLrc)
        {
            this.webViewMain = webViewMain;
            this.floatLrc = floatLrc;
            InitializeComponent();
            //this.textBox1.Text = webViewMain.webView.Source.ToString();
            this.X.Value = floatLrc.Width;
            this.Y.Value = floatLrc.Height;
            this.colorGrid1.Color = floatLrc.LrcText.ForeColor;
            this.FontSizeInput.Value = (int)floatLrc.LrcText.Font.Size;
        }

        private void save_Click(object sender, EventArgs e)
        {
            string ApplicationData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            floatLrc.Width = (int)this.X.Value;
            floatLrc.MaximumSize = new System.Drawing.Size(width: (int)this.X.Value, height: (int)this.Y.Value);
            floatLrc.Height = (int)this.Y.Value;
            floatLrc.LrcText.Width = (int)this.X.Value;
            floatLrc.LrcText.Height = (int)this.Y.Value;

            floatLrc.LrcText.Font = new Font("等线", (float)this.FontSizeInput.Value, FontStyle.Bold);
            floatLrc.LrcText.ForeColor = this.colorGrid1.Color;
            if (!this.checkBox1.Checked)
            {
                floatLrc.BackColor = Color.White;
            }
            else
            {
                floatLrc.BackColor = Color.Black;
            }
            this.Close();
            if (!SerializeUtil.ByteToFile(SerializeUtil.Encode(floatLrc.Width), $"{ApplicationData}\\FloatLrc\\Width.bin"))
            {
                Directory.CreateDirectory($"{ApplicationData}\\FloatLrc");
                SerializeUtil.ByteToFile(SerializeUtil.Encode(floatLrc.Width), $"{ApplicationData}\\FloatLrc\\Width.bin");
            }
            if (!this.textBox1.Text.Equals(""))
            {
                webViewMain.webView.Source = new System.Uri(this.textBox1.Text);
                SerializeUtil.ByteToFile(SerializeUtil.Encode(webViewMain.webView.Source), $"{ApplicationData}\\FloatLrc\\Uri.bin");
            }
            SerializeUtil.ByteToFile(SerializeUtil.Encode(floatLrc.Height), $"{ApplicationData}\\FloatLrc\\Height.bin");
            SerializeUtil.ByteToFile(SerializeUtil.Encode(floatLrc.LrcText.Font), $"{ApplicationData}\\FloatLrc\\Font.bin");
            SerializeUtil.ByteToFile(SerializeUtil.Encode(floatLrc.LrcText.ForeColor), $"{ApplicationData}\\FloatLrc\\ForeColor.bin");
        }
    }
}
