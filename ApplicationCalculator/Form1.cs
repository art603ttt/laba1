using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 Calculator calculator = new Calculator();
        
        public void firstMetod(string operation)
        {
            calculator.Operation = operation;
            if (textBox_lastarg_or_answer.Text != "")
            {
                if (textBox_first_arg.Text == "")
                    textBox_first_arg.Text = textBox_lastarg_or_answer.Text;
                else
                    MethodCallTwoOperand(calculator.Operation,textBox_first_arg);

                calculator.Operation = operation;
                textBox_lastarg_or_answer.Clear();
            }
        }

        void MethodCallTwoOperand(string operation,TextBox res)
        {
            switch (operation)
            {
                case "plus":
                    res.Text = calculator.Plus(Convert.ToDouble(textBox_first_arg.Text),
                        Convert.ToDouble(textBox_lastarg_or_answer.Text)).ToString();break;
                case "difference":
                    res.Text = calculator.Difference(Convert.ToDouble(textBox_first_arg.Text),
                        Convert.ToDouble(textBox_lastarg_or_answer.Text)).ToString(); break;
                case "multiply":
                    res.Text = calculator.Multiply(Convert.ToDouble(textBox_first_arg.Text),
                        Convert.ToDouble(textBox_lastarg_or_answer.Text)).ToString(); break;
                case "divizion":
                    res.Text = calculator.Divizion(Convert.ToDouble(textBox_first_arg.Text),
                        Convert.ToDouble(textBox_lastarg_or_answer.Text)).ToString(); break;
                case "exponentiation":res.Text = calculator.Exponentiation(Convert.ToDouble(textBox_first_arg.Text),
                        Convert.ToDouble(textBox_lastarg_or_answer.Text)).ToString(); break;
                default:
                    break;
            }
        }

        void MethodCallOneOperand(string operation, TextBox res)
        {
            switch (operation)
            {
                case "sin":
                    res.Text = calculator.Sinus(Convert.ToDouble(textBox_lastarg_or_answer.Text)).ToString();
                    break;
                case "cos":
                    res.Text = calculator.Cosinus(Convert.ToDouble(textBox_lastarg_or_answer.Text)).ToString();
                    break;
                case "tan":
                    res.Text = calculator.Tangens(Convert.ToDouble(textBox_lastarg_or_answer.Text)).ToString();
                    break;
                case "ctan":
                    res.Text = calculator.Cotangens(Convert.ToDouble(textBox_lastarg_or_answer.Text)).ToString();
                    break;
                case "ln":
                    res.Text = calculator.NaturalLogarithm(Convert.ToDouble(textBox_lastarg_or_answer.Text)).ToString();
                    break;
                case "invers":
                    res.Text = calculator.InverseNumber(Convert.ToDouble(textBox_lastarg_or_answer.Text)).ToString();
                    break;
                case "sqr":
                    res.Text = calculator.Sqrt(Convert.ToDouble(textBox_lastarg_or_answer.Text)).ToString();
                    break;
                case "squar":
                    res.Text = calculator.Squaring(Convert.ToDouble(textBox_lastarg_or_answer.Text)).ToString();
                    break;
                case "factorial":
                    res.Text = calculator.Factorial(Convert.ToDouble(textBox_lastarg_or_answer.Text)).ToString();
                    break;
                default:
                    break;
            }
        }


        #region ВВОД ЦИФР
        private void button_num1_Click(object sender, EventArgs e)
        {
            textBox_lastarg_or_answer.Text += "1";
        }

        private void button_num2_Click(object sender, EventArgs e)
        {
            textBox_lastarg_or_answer.Text += "2";
        }

        private void button_num3_Click(object sender, EventArgs e)
        {
            textBox_lastarg_or_answer.Text += "3";
        }

        private void button_num4_Click(object sender, EventArgs e)
        {
            textBox_lastarg_or_answer.Text += "4";
        }

        private void button_num5_Click(object sender, EventArgs e)
        {
            textBox_lastarg_or_answer.Text += "5";
        }

        private void button_num6_Click(object sender, EventArgs e)
        {
            textBox_lastarg_or_answer.Text += "6";
        }

        private void button_num7_Click(object sender, EventArgs e)
        {
            textBox_lastarg_or_answer.Text += "7";
        }

        private void button_num8_Click(object sender, EventArgs e)
        {
            textBox_lastarg_or_answer.Text += "8";
        }

        private void button_num9_Click(object sender, EventArgs e)
        {
            textBox_lastarg_or_answer.Text += "9";
        }

        private void button_num0_Click(object sender, EventArgs e)
        {
            textBox_lastarg_or_answer.Text += "0";
        }
        #endregion
    }
}
