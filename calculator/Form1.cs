using System;
using System.IO;
using System.Numerics;

namespace calculator
{
    public partial class Form1 : Form
    {

        //输入值
        double Number = 0;

        //计算结果
        double AndNumber = 0;

        //总显示值
        double ResultNum = 0;

        //按键编号
        int InputNumber = 0;

        //记录按键值
        double TestNum = 0;

        //小数点位置  指数值 Math.Pow(10, -1) = 0.1 以此类推
        int PointNumber = 0;

        //第一次是否进行按下小数点按键
        bool IsFirst = false;

        //第一次是否进行按下数字键
        //bool IsFirstD = false;

        //窗口是否拓展变大
        bool IsBig = false;

        string strnum = "";

        string str = "";
        //定义加减乘除等符号 
        enum Operator { None, Plus, Minus, Multiplication, Divison };
        Operator Mode = Operator.None;

        public Form1()
        {
            InitializeComponent();
        }

        //按键数字显示方法
        public void AddNum(int num)
        {
            if (IsFirst == false)
            {
                Number = Number * 10 + num;
                DisPlay.Text = Convert.ToString(Number);
                strnum = Convert.ToString(Number);
                PointNumber++;
            }
            else
            {

                Number = Number + num * Math.Pow(10, (-PointNumber));
                DisPlay.Text = Convert.ToString(Number);
                strnum = Convert.ToString(Number);
                PointNumber++;
            }

        }

        //重置显示栏的Number值
        public void Reset()
        {
            TestNum = Number;
        }

        public void MathematicalOperations(string str)
        {
            switch (Mode)
            {
                case Operator.Plus:

                    ResultNum = AndNumber + Number;
                    AndNumber += Number;
                    Reset();
                    DisPlay1.Text = ResultNum + str;
                    Clear.PerformClick();
                    DisPlay.Text = Convert.ToString(TestNum);
                    break;
                case Operator.Minus:


                    AndNumber = Number;
                    Reset();
                    DisPlay1.Text = Number + str;
                    Clear.PerformClick();
                    DisPlay.Text = Convert.ToString(TestNum);
                    break;
                case Operator.Multiplication:

                    //if (Number == 0)
                    //{
                    //    break;
                    //}

                    // ResultNum =  Number;
                    AndNumber = Number;
                    Reset();
                    DisPlay1.Text = Number + str;
                    Clear.PerformClick();
                    DisPlay.Text = Convert.ToString(TestNum);
                    break;
                case Operator.Divison:

                    AndNumber = Number;
                    Reset();
                    DisPlay1.Text = Number + str;
                    Clear.PerformClick();
                    DisPlay.Text = Convert.ToString(TestNum);
                    break;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            Mode = Operator.None;
            Clear.PerformClick();
            DisPlay1.Text = "";
            ResultNum = 0;
            AndNumber = 0;
            TestNum = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Number = 0;
            strnum = "";
            InputNumber = 0;
            AddNum(InputNumber);
            IsFirst = false;
            PointNumber = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisPlay.Text = Convert.ToString(Number);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            InputNumber = 1;
            AddNum(InputNumber);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //切换成为加号模式
            Mode = Operator.Plus;
            str = "+";
            MathematicalOperations(str);


        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            //切换成为减号模式
            Mode = Operator.Minus;
            str = "-";
            MathematicalOperations(str);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // 创建并显示 Form2
            //Form2 form2 = new Form2();
            // form2.Show();
            if (IsBig == false)
            {
                this.Size = new Size(1005, 594);
                IsBig = true;
            }
            else
            {
                this.Size = new Size(486, 594);
                IsBig = false;
            }

        }

        private void Num2_Click(object sender, EventArgs e)
        {
            InputNumber = 2;
            AddNum(InputNumber);
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            InputNumber = 3;
            AddNum(InputNumber);
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            InputNumber = 4;
            AddNum(InputNumber);
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            InputNumber = 5;
            AddNum(InputNumber);
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            InputNumber = 6;
            AddNum(InputNumber);
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            InputNumber = 7;
            AddNum(InputNumber);
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            InputNumber = 8;
            AddNum(InputNumber);
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            InputNumber = 9;
            AddNum(InputNumber);
        }

        private void Num0_Click(object sender, EventArgs e)
        {
            InputNumber = 0;
            AddNum(InputNumber);
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            if (IsFirst == false)
            {
                strnum = strnum + ".";
                IsFirst = true;
                DisPlay.Text = Convert.ToString(strnum);

            }
            //if (!string.IsNullOrEmpty(strnum) && Number != 0)
            //{
            //    strnum = strnum.Substring(0, strnum.Length - 1);
            //    DisPlay.Text = Convert.ToString(strnum);
            //    if (string.IsNullOrEmpty(strnum))
            //    {
            //        Number = 0;
            //        Clear.PerformClick();
            //    }
            //    else
            //    {
            //        Number = Convert.ToDouble(strnum);
            //    }

            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DisPlay_Click(object sender, EventArgs e)
        {
            AddNum(InputNumber);
        }

        private void DisPlay1_Click(object sender, EventArgs e)
        {

        }

        private void Divison_Click(object sender, EventArgs e)
        {
            //切换成为除号模式
            Mode = Operator.Divison;
            str = "/";
            MathematicalOperations(str);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(strnum) && Number != 0)
            {
                strnum = strnum.Substring(0, strnum.Length - 1);
                DisPlay.Text = Convert.ToString(strnum);
                if (string.IsNullOrEmpty(strnum))
                {
                    Number = 0;
                    Clear.PerformClick();
                }
                else
                {
                    Number = Convert.ToDouble(strnum);
                }

            }

        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            //切换成为乘号模式
            Mode = Operator.Multiplication;
            str = "*";
            MathematicalOperations(str);
        }

        private void Amount_Click(object sender, EventArgs e)
        {
            switch (Mode)
            {
                case Operator.Plus:
                    ResultNum = AndNumber + Number;
                    DisPlay1.Text = Convert.ToString(ResultNum);
                    break;
                case Operator.Minus:
                    ResultNum = AndNumber - Number;
                    DisPlay1.Text = Convert.ToString(ResultNum);
                    break;
                case Operator.Multiplication:

                    ResultNum = AndNumber * Number;
                    DisPlay1.Text = Convert.ToString(ResultNum);
                    break;
                case Operator.Divison:
                    ResultNum = AndNumber / Number;
                    DisPlay1.Text = Convert.ToString(ResultNum);
                    break;
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            ResultNum = Math.Abs(ResultNum);
            DisPlay1.Text = Convert.ToString(ResultNum);

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            textBox1.Text = "返回一个数的绝对值";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ResultNum = Math.Cos(ResultNum);
            DisPlay1.Text = Convert.ToString(ResultNum);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            textBox1.Text = "返回一个数的平方根";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            textBox1.Text = "计算指定底数的对数,计算自然对数（以e为底数的对数）";
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            textBox1.Text = "计算给定角度的正弦值（以弧度表示）";
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            textBox1.Text = "计算给定角度的余弦值（以弧度表示）";
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            textBox1.Text = "计算给定角度的正切值（以弧度表示）";
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            ResultNum = Math.Sqrt(Number);
            DisPlay1.Text = Convert.ToString(ResultNum);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResultNum = Math.Log(Number);
            DisPlay1.Text = Convert.ToString(ResultNum);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ResultNum = Math.Sin(Number);
            DisPlay1.Text = Convert.ToString(ResultNum);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ResultNum = Math.Tan(Number);
            DisPlay1.Text = Convert.ToString(ResultNum);
        }
    }
}