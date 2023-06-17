namespace FloatLrc
{
    partial class Settings
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
            label1 = new Label();
            label2 = new Label();
            Y = new NumericUpDown();
            label3 = new Label();
            X = new NumericUpDown();
            colorGrid1 = new Cyotek.Windows.Forms.ColorGrid();
            label4 = new Label();
            label5 = new Label();
            FontSizeInput = new NumericUpDown();
            save = new Button();
            label6 = new Label();
            textBox1 = new TextBox();
            label7 = new Label();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)Y).BeginInit();
            ((System.ComponentModel.ISupportInitialize)X).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FontSizeInput).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 74);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 17);
            label1.TabIndex = 0;
            label1.Text = "字幕透明窗体大小:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 115);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(23, 17);
            label2.TabIndex = 1;
            label2.Text = "高:";
            // 
            // Y
            // 
            Y.Location = new Point(69, 110);
            Y.Margin = new Padding(4);
            Y.Maximum = new decimal(new int[] { 2048, 0, 0, 0 });
            Y.Name = "Y";
            Y.Size = new Size(76, 23);
            Y.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(200, 115);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(23, 17);
            label3.TabIndex = 3;
            label3.Text = "宽:";
            // 
            // X
            // 
            X.Location = new Point(233, 112);
            X.Margin = new Padding(4);
            X.Maximum = new decimal(new int[] { 4096, 0, 0, 0 });
            X.Name = "X";
            X.Size = new Size(76, 23);
            X.TabIndex = 4;
            // 
            // colorGrid1
            // 
            colorGrid1.Location = new Point(38, 169);
            colorGrid1.Margin = new Padding(4);
            colorGrid1.Name = "colorGrid1";
            colorGrid1.Padding = new Padding(6, 7, 6, 7);
            colorGrid1.Size = new Size(249, 169);
            colorGrid1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 144);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(35, 17);
            label4.TabIndex = 6;
            label4.Text = "颜色:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 435);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(59, 17);
            label5.TabIndex = 7;
            label5.Text = "字体大小:";
            // 
            // FontSizeInput
            // 
            FontSizeInput.Location = new Point(92, 429);
            FontSizeInput.Margin = new Padding(4);
            FontSizeInput.Name = "FontSizeInput";
            FontSizeInput.Size = new Size(71, 23);
            FontSizeInput.TabIndex = 8;
            // 
            // save
            // 
            save.Location = new Point(139, 476);
            save.Margin = new Padding(4);
            save.Name = "save";
            save.Size = new Size(88, 33);
            save.TabIndex = 9;
            save.Text = "保存";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 13);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(80, 17);
            label6.TabIndex = 10;
            label6.Text = "Kikoeru网址:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(38, 35);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(314, 23);
            textBox1.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 372);
            label7.Name = "label7";
            label7.Size = new Size(107, 17);
            label7.TabIndex = 12;
            label7.Text = "字幕窗体是否透明:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(130, 375);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 13;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 533);
            Controls.Add(checkBox1);
            Controls.Add(label7);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(save);
            Controls.Add(FontSizeInput);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(colorGrid1);
            Controls.Add(X);
            Controls.Add(label3);
            Controls.Add(Y);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4);
            MaximumSize = new Size(378, 572);
            MinimumSize = new Size(378, 572);
            Name = "Settings";
            ShowIcon = false;
            Text = "设置";
            ((System.ComponentModel.ISupportInitialize)Y).EndInit();
            ((System.ComponentModel.ISupportInitialize)X).EndInit();
            ((System.ComponentModel.ISupportInitialize)FontSizeInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown Y;
        private Label label3;
        private NumericUpDown X;
        private Cyotek.Windows.Forms.ColorGrid colorGrid1;
        private Label label4;
        private Label label5;
        private NumericUpDown FontSizeInput;
        private Button save;
        private Label label6;
        private TextBox textBox1;
        private Label label7;
        private CheckBox checkBox1;
    }
}