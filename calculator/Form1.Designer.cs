﻿namespace calculator
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
            Clear = new Button();
            Num1 = new Button();
            Num2 = new Button();
            Num3 = new Button();
            Num4 = new Button();
            Num5 = new Button();
            Num6 = new Button();
            Num7 = new Button();
            Num8 = new Button();
            Num9 = new Button();
            Num0 = new Button();
            Dot = new Button();
            Delete = new Button();
            Amount = new Button();
            Plus = new Button();
            Minus = new Button();
            Multiplication = new Button();
            Divison = new Button();
            checkBox1 = new CheckBox();
            DisPlay1 = new Label();
            DisPlay = new Label();
            CE = new Button();
            SuspendLayout();
            // 
            // Clear
            // 
            Clear.Location = new Point(144, 122);
            Clear.Name = "Clear";
            Clear.Size = new Size(97, 56);
            Clear.TabIndex = 1;
            Clear.Text = "C";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += button1_Click;
            // 
            // Num1
            // 
            Num1.Location = new Point(27, 212);
            Num1.Name = "Num1";
            Num1.Size = new Size(96, 39);
            Num1.TabIndex = 4;
            Num1.Text = "1";
            Num1.UseVisualStyleBackColor = true;
            Num1.Click += button2_Click_1;
            // 
            // Num2
            // 
            Num2.Location = new Point(145, 212);
            Num2.Name = "Num2";
            Num2.Size = new Size(96, 39);
            Num2.TabIndex = 5;
            Num2.Text = "2";
            Num2.UseVisualStyleBackColor = true;
            Num2.Click += Num2_Click;
            // 
            // Num3
            // 
            Num3.Location = new Point(258, 212);
            Num3.Name = "Num3";
            Num3.Size = new Size(96, 39);
            Num3.TabIndex = 6;
            Num3.Text = "3";
            Num3.UseVisualStyleBackColor = true;
            Num3.Click += Num3_Click;
            // 
            // Num4
            // 
            Num4.Location = new Point(26, 283);
            Num4.Name = "Num4";
            Num4.Size = new Size(96, 39);
            Num4.TabIndex = 4;
            Num4.Text = "4";
            Num4.UseVisualStyleBackColor = true;
            Num4.Click += Num4_Click;
            // 
            // Num5
            // 
            Num5.Location = new Point(144, 283);
            Num5.Name = "Num5";
            Num5.Size = new Size(96, 39);
            Num5.TabIndex = 5;
            Num5.Text = "5";
            Num5.UseVisualStyleBackColor = true;
            Num5.Click += Num5_Click;
            // 
            // Num6
            // 
            Num6.Location = new Point(257, 283);
            Num6.Name = "Num6";
            Num6.Size = new Size(96, 39);
            Num6.TabIndex = 6;
            Num6.Text = "6";
            Num6.UseVisualStyleBackColor = true;
            Num6.Click += Num6_Click;
            // 
            // Num7
            // 
            Num7.Location = new Point(26, 347);
            Num7.Name = "Num7";
            Num7.Size = new Size(96, 39);
            Num7.TabIndex = 4;
            Num7.Text = "7";
            Num7.UseVisualStyleBackColor = true;
            Num7.Click += Num7_Click;
            // 
            // Num8
            // 
            Num8.Location = new Point(144, 347);
            Num8.Name = "Num8";
            Num8.Size = new Size(96, 39);
            Num8.TabIndex = 5;
            Num8.Text = "8";
            Num8.UseVisualStyleBackColor = true;
            Num8.Click += Num8_Click;
            // 
            // Num9
            // 
            Num9.Location = new Point(257, 347);
            Num9.Name = "Num9";
            Num9.Size = new Size(96, 39);
            Num9.TabIndex = 6;
            Num9.Text = "9";
            Num9.UseVisualStyleBackColor = true;
            Num9.Click += Num9_Click;
            // 
            // Num0
            // 
            Num0.Location = new Point(27, 412);
            Num0.Name = "Num0";
            Num0.Size = new Size(96, 39);
            Num0.TabIndex = 7;
            Num0.Text = "0";
            Num0.UseVisualStyleBackColor = true;
            Num0.Click += Num0_Click;
            // 
            // Dot
            // 
            Dot.Location = new Point(144, 412);
            Dot.Name = "Dot";
            Dot.Size = new Size(96, 39);
            Dot.TabIndex = 7;
            Dot.Text = ".";
            Dot.UseVisualStyleBackColor = true;
            Dot.Click += Dot_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(257, 122);
            Delete.Name = "Delete";
            Delete.Size = new Size(95, 56);
            Delete.TabIndex = 3;
            Delete.Text = "Die";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Amount
            // 
            Amount.Location = new Point(257, 412);
            Amount.Name = "Amount";
            Amount.Size = new Size(96, 39);
            Amount.TabIndex = 7;
            Amount.Text = "=";
            Amount.UseVisualStyleBackColor = true;
            Amount.Click += Amount_Click;
            // 
            // Plus
            // 
            Plus.Location = new Point(366, 122);
            Plus.Name = "Plus";
            Plus.Size = new Size(96, 56);
            Plus.TabIndex = 8;
            Plus.Text = "+";
            Plus.UseVisualStyleBackColor = true;
            Plus.Click += button1_Click_1;
            // 
            // Minus
            // 
            Minus.Location = new Point(366, 212);
            Minus.Name = "Minus";
            Minus.Size = new Size(96, 56);
            Minus.TabIndex = 8;
            Minus.Text = "-";
            Minus.UseVisualStyleBackColor = true;
            Minus.Click += Subtract_Click;
            // 
            // Multiplication
            // 
            Multiplication.Location = new Point(366, 308);
            Multiplication.Name = "Multiplication";
            Multiplication.Size = new Size(96, 56);
            Multiplication.TabIndex = 8;
            Multiplication.Text = "*";
            Multiplication.UseVisualStyleBackColor = true;
            Multiplication.Click += Multiplication_Click;
            // 
            // Divison
            // 
            Divison.Location = new Point(366, 395);
            Divison.Name = "Divison";
            Divison.Size = new Size(96, 56);
            Divison.TabIndex = 8;
            Divison.Text = "/";
            Divison.UseVisualStyleBackColor = true;
            Divison.Click += Divison_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(366, 484);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(75, 21);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "更多功能";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // DisPlay1
            // 
            DisPlay1.BackColor = SystemColors.AppWorkspace;
            DisPlay1.Location = new Point(26, 20);
            DisPlay1.Name = "DisPlay1";
            DisPlay1.Size = new Size(435, 35);
            DisPlay1.TabIndex = 11;
            DisPlay1.TextAlign = ContentAlignment.BottomRight;
            DisPlay1.Click += DisPlay1_Click;
            // 
            // DisPlay
            // 
            DisPlay.BackColor = SystemColors.AppWorkspace;
            DisPlay.Location = new Point(26, 55);
            DisPlay.Name = "DisPlay";
            DisPlay.Size = new Size(435, 35);
            DisPlay.TabIndex = 12;
            DisPlay.Text = "0";
            DisPlay.TextAlign = ContentAlignment.BottomRight;
            DisPlay.Click += DisPlay_Click;
            // 
            // CE
            // 
            CE.Location = new Point(26, 122);
            CE.Name = "CE";
            CE.Size = new Size(95, 56);
            CE.TabIndex = 0;
            CE.Text = "CE";
            CE.UseVisualStyleBackColor = true;
            CE.Click += button0_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 555);
            Controls.Add(DisPlay);
            Controls.Add(DisPlay1);
            Controls.Add(checkBox1);
            Controls.Add(Divison);
            Controls.Add(Multiplication);
            Controls.Add(Minus);
            Controls.Add(Plus);
            Controls.Add(Amount);
            Controls.Add(Dot);
            Controls.Add(Num0);
            Controls.Add(Num9);
            Controls.Add(Num6);
            Controls.Add(Num3);
            Controls.Add(Num8);
            Controls.Add(Num5);
            Controls.Add(Num2);
            Controls.Add(Num7);
            Controls.Add(Num4);
            Controls.Add(Num1);
            Controls.Add(Delete);
            Controls.Add(CE);
            Controls.Add(Clear);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Clear;
        private Button Num1;
        private Button Num2;
        private Button Num3;
        private Button Num4;
        private Button Num5;
        private Button Num6;
        private Button Num7;
        private Button Num8;
        private Button Num9;
        private Button Num0;
        private Button Dot;
        private Button Delete;
        private Button Amount;
        private Button Plus;
        private Button Minus;
        private Button Multiplication;
        private Button Divison;
        private CheckBox checkBox1;
        private Label DisPlay1;
        private Label DisPlay;
        private Button CE;
    }
}