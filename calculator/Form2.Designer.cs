namespace calculator
{
    partial class Form2
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
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 146);
            button1.Name = "button1";
            button1.Size = new Size(89, 49);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(500, 94);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(151, 146);
            button2.Name = "button2";
            button2.Size = new Size(89, 49);
            button2.TabIndex = 0;
            button2.Text = "button1";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(293, 146);
            button3.Name = "button3";
            button3.Size = new Size(89, 49);
            button3.TabIndex = 0;
            button3.Text = "button1";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(423, 146);
            button4.Name = "button4";
            button4.Size = new Size(89, 49);
            button4.TabIndex = 0;
            button4.Text = "button1";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(12, 222);
            button5.Name = "button5";
            button5.Size = new Size(89, 49);
            button5.TabIndex = 0;
            button5.Text = "button1";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(151, 222);
            button6.Name = "button6";
            button6.Size = new Size(89, 49);
            button6.TabIndex = 0;
            button6.Text = "button1";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(293, 222);
            button7.Name = "button7";
            button7.Size = new Size(89, 49);
            button7.TabIndex = 0;
            button7.Text = "button1";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button3_Click;
            // 
            // button8
            // 
            button8.Location = new Point(423, 222);
            button8.Name = "button8";
            button8.Size = new Size(89, 49);
            button8.TabIndex = 0;
            button8.Text = "button1";
            button8.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 499);
            Controls.Add(textBox1);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}