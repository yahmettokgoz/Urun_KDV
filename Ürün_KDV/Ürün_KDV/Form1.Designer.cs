﻿namespace Ürün_KDV
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
            label1 = new Label();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            button1 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(104, 62);
            label1.Name = "label1";
            label1.Size = new Size(69, 31);
            label1.TabIndex = 0;
            label1.Text = "Ürün:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(193, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 27);
            textBox1.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(81, 270);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(424, 104);
            listBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(203, 159);
            button1.Name = "button1";
            button1.Size = new Size(169, 28);
            button1.TabIndex = 3;
            button1.Text = "KDV'Li fiyat hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(104, 107);
            label2.Name = "label2";
            label2.Size = new Size(67, 31);
            label2.TabIndex = 4;
            label2.Text = "Fiyat:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(193, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(179, 27);
            textBox2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 482);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private ListBox listBox1;
        private Button button1;
        private Label label2;
        private TextBox textBox2;
    }
}