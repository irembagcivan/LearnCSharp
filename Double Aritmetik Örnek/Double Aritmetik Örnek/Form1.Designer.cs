﻿namespace Double_Aritmetik_Örnek
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            labelsonuc = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.Location = new Point(111, 231);
            button1.Name = "button1";
            button1.Size = new Size(141, 53);
            button1.TabIndex = 0;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(36, 57);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 1;
            label1.Text = "1. Sayı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(36, 111);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 2;
            label2.Text = "2. Sayı:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.Location = new Point(100, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11F);
            textBox2.Location = new Point(100, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 27);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(39, 165);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 5;
            label3.Text = "Sonuç:";
            // 
            // labelsonuc
            // 
            labelsonuc.AutoSize = true;
            labelsonuc.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelsonuc.Location = new Point(100, 165);
            labelsonuc.Name = "labelsonuc";
            labelsonuc.Size = new Size(18, 20);
            labelsonuc.TabIndex = 6;
            labelsonuc.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(354, 313);
            Controls.Add(labelsonuc);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label labelsonuc;
    }
}
