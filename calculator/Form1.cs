using System;
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

        //第一次是否进行按下数字键
        bool IsFirst = false;

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
            Number = Number * 10 + num;
            DisPlay.Text = Convert.ToString(Number);
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

                    ResultNum = AndNumber - Number;
                    AndNumber = AndNumber - Number;
                    Reset();
                    DisPlay1.Text = ResultNum + str;
                    Clear.PerformClick();
                    DisPlay.Text = Convert.ToString(TestNum);
                    break;
                case Operator.Multiplication:

                    //if (Number == 0)
                    //{
                    //    break;
                    //}

                   // ResultNum =  Number;
                    AndNumber =   Number;
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

                    // ResultNum = AndNumber / Number;
                    //AndNumber = AndNumber / Number;
                    //Reset();
                    //DisPlay1.Text = ResultNum + str;
                    //Clear.PerformClick();
                    //DisPlay.Text = Convert.ToString(TestNum);
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
            IsFirst = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Number = 0;
            InputNumber = 0;
            AddNum(InputNumber);
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
    }
}