namespace KalkulatorSederhana
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtdisplay = new TextBox();
            bt1 = new Button();
            bt2 = new Button();
            bt3 = new Button();
            bt6 = new Button();
            bt9 = new Button();
            bt5 = new Button();
            bt8 = new Button();
            bt4 = new Button();
            bt7 = new Button();
            btclear = new Button();
            bt0 = new Button();
            bthasil = new Button();
            btbagi = new Button();
            btkurang = new Button();
            bttambah = new Button();
            txtdisplay2 = new TextBox();
            btkoma = new Button();
            btkali = new Button();
            SuspendLayout();
            // 
            // txtdisplay
            // 
            txtdisplay.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtdisplay.Location = new Point(62, 22);
            txtdisplay.Multiline = true;
            txtdisplay.Name = "txtdisplay";
            txtdisplay.Size = new Size(467, 59);
            txtdisplay.TabIndex = 0;
            txtdisplay.Text = "0";
            txtdisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // bt1
            // 
            bt1.Location = new Point(24, 100);
            bt1.Name = "bt1";
            bt1.Size = new Size(94, 70);
            bt1.TabIndex = 1;
            bt1.Text = "1";
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += bt1_Click;
            // 
            // bt2
            // 
            bt2.Location = new Point(124, 100);
            bt2.Name = "bt2";
            bt2.Size = new Size(94, 70);
            bt2.TabIndex = 2;
            bt2.Text = "2";
            bt2.UseVisualStyleBackColor = true;
            bt2.Click += bt2_Click;
            // 
            // bt3
            // 
            bt3.Location = new Point(224, 100);
            bt3.Name = "bt3";
            bt3.Size = new Size(94, 70);
            bt3.TabIndex = 3;
            bt3.Text = "3";
            bt3.UseVisualStyleBackColor = true;
            bt3.Click += bt3_Click;
            // 
            // bt6
            // 
            bt6.Location = new Point(224, 176);
            bt6.Name = "bt6";
            bt6.Size = new Size(94, 70);
            bt6.TabIndex = 4;
            bt6.Text = "6";
            bt6.UseVisualStyleBackColor = true;
            bt6.Click += bt6_Click;
            // 
            // bt9
            // 
            bt9.Location = new Point(224, 252);
            bt9.Name = "bt9";
            bt9.Size = new Size(94, 70);
            bt9.TabIndex = 5;
            bt9.Text = "9";
            bt9.UseVisualStyleBackColor = true;
            bt9.Click += bt9_Click;
            // 
            // bt5
            // 
            bt5.Location = new Point(124, 176);
            bt5.Name = "bt5";
            bt5.Size = new Size(94, 70);
            bt5.TabIndex = 6;
            bt5.Text = "5";
            bt5.UseVisualStyleBackColor = true;
            bt5.Click += bt5_Click;
            // 
            // bt8
            // 
            bt8.Location = new Point(124, 252);
            bt8.Name = "bt8";
            bt8.Size = new Size(94, 70);
            bt8.TabIndex = 7;
            bt8.Text = "8";
            bt8.UseVisualStyleBackColor = true;
            bt8.Click += bt8_Click;
            // 
            // bt4
            // 
            bt4.Location = new Point(24, 176);
            bt4.Name = "bt4";
            bt4.Size = new Size(94, 70);
            bt4.TabIndex = 8;
            bt4.Text = "4";
            bt4.UseVisualStyleBackColor = true;
            bt4.Click += bt4_Click;
            // 
            // bt7
            // 
            bt7.Location = new Point(24, 252);
            bt7.Name = "bt7";
            bt7.Size = new Size(94, 70);
            bt7.TabIndex = 9;
            bt7.Text = "7";
            bt7.UseVisualStyleBackColor = true;
            bt7.Click += bt7_Click;
            // 
            // btclear
            // 
            btclear.Location = new Point(324, 100);
            btclear.Name = "btclear";
            btclear.Size = new Size(229, 70);
            btclear.TabIndex = 10;
            btclear.Text = "C";
            btclear.UseVisualStyleBackColor = true;
            btclear.Click += btclear_Click;
            // 
            // bt0
            // 
            bt0.Location = new Point(324, 176);
            bt0.Name = "bt0";
            bt0.Size = new Size(229, 70);
            bt0.TabIndex = 11;
            bt0.Text = "0";
            bt0.UseVisualStyleBackColor = true;
            bt0.Click += bt0_Click;
            // 
            // bthasil
            // 
            bthasil.Location = new Point(424, 252);
            bthasil.Name = "bthasil";
            bthasil.Size = new Size(129, 146);
            bthasil.TabIndex = 12;
            bthasil.Text = "=";
            bthasil.UseVisualStyleBackColor = true;
            bthasil.Click += bthasil_Click;
            // 
            // btbagi
            // 
            btbagi.Location = new Point(224, 328);
            btbagi.Name = "btbagi";
            btbagi.Size = new Size(94, 70);
            btbagi.TabIndex = 13;
            btbagi.Text = "/";
            btbagi.UseVisualStyleBackColor = true;
            btbagi.Click += btbagi_Click;
            // 
            // btkurang
            // 
            btkurang.Location = new Point(124, 328);
            btkurang.Name = "btkurang";
            btkurang.Size = new Size(94, 70);
            btkurang.TabIndex = 14;
            btkurang.Text = "-";
            btkurang.UseVisualStyleBackColor = true;
            btkurang.Click += btkurang_Click;
            // 
            // bttambah
            // 
            bttambah.Location = new Point(24, 328);
            bttambah.Name = "bttambah";
            bttambah.Size = new Size(94, 70);
            bttambah.TabIndex = 15;
            bttambah.Text = "+";
            bttambah.UseVisualStyleBackColor = true;
            bttambah.Click += bttambah_Click;
            // 
            // txtdisplay2
            // 
            txtdisplay2.BorderStyle = BorderStyle.None;
            txtdisplay2.Location = new Point(82, 43);
            txtdisplay2.Name = "txtdisplay2";
            txtdisplay2.Size = new Size(77, 20);
            txtdisplay2.TabIndex = 16;
            // 
            // btkoma
            // 
            btkoma.Location = new Point(324, 252);
            btkoma.Name = "btkoma";
            btkoma.Size = new Size(94, 70);
            btkoma.TabIndex = 17;
            btkoma.Text = ",";
            btkoma.UseVisualStyleBackColor = true;
            btkoma.Click += btkoma_Click;
            // 
            // btkali
            // 
            btkali.Location = new Point(324, 328);
            btkali.Name = "btkali";
            btkali.Size = new Size(94, 70);
            btkali.TabIndex = 18;
            btkali.Text = "x";
            btkali.UseVisualStyleBackColor = true;
            btkali.Click += btkali_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(589, 430);
            Controls.Add(btkali);
            Controls.Add(btkoma);
            Controls.Add(txtdisplay2);
            Controls.Add(bttambah);
            Controls.Add(btkurang);
            Controls.Add(btbagi);
            Controls.Add(bthasil);
            Controls.Add(bt0);
            Controls.Add(btclear);
            Controls.Add(bt7);
            Controls.Add(bt4);
            Controls.Add(bt8);
            Controls.Add(bt5);
            Controls.Add(bt9);
            Controls.Add(bt6);
            Controls.Add(bt3);
            Controls.Add(bt2);
            Controls.Add(bt1);
            Controls.Add(txtdisplay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtdisplay;
        private Button bt1;
        private Button bt2;
        private Button bt3;
        private Button bt6;
        private Button bt9;
        private Button bt5;
        private Button bt8;
        private Button bt4;
        private Button bt7;
        private Button btclear;
        private Button bt0;
        private Button bthasil;
        private Button btbagi;
        private Button btkurang;
        private Button bttambah;
        private TextBox txtdisplay2;
        private Button btkoma;
        private Button btkali;
    }
}
