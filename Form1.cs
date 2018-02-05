using System;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox_lastarg_or_answer.Text = "";
            textBox_first_arg.Text = "";
          
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
        
        //ВВОД РАЗДЕЛИТЕЛЯ
        private void button_razdelit_Click(object sender, EventArgs e)
        {
            textBox_lastarg_or_answer.Text += ",";
            //надо проверить - 1)есть ли уже запятая
            //2)записана хоть одна цифра 
        }

        //...
        //ОПЕРАЦИИ С 2 АРГУМЕНТАМИ
        private void button_plus_Click(object sender, EventArgs e)
        {
            firstMetod("plus");         
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            firstMetod("difference");      
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            firstMetod("divizion"); 
        }
        
        private void button_stepen_y_Click(object sender, EventArgs e)
        {
            firstMetod("exponentiation");
        }

        private void button_umnoj_Click(object sender, EventArgs e)
        {
            firstMetod("multiply");         
        }

        //..
        //ОПЕРАЦИИ С ОДНИМ АРГУМЕНТОМ
        private void button_sin_Click(object sender, EventArgs e)
        {
           if(textBox_lastarg_or_answer.Text!="")
            {
                MethodCallOneOperand("sin", textBox_lastarg_or_answer);
            }

        }

        private void button_cos_Click(object sender, EventArgs e)
        {
            if (textBox_lastarg_or_answer.Text != "")
            {
                MethodCallOneOperand("cos", textBox_lastarg_or_answer);
            }
        }

        private void button_tg_Click(object sender, EventArgs e)
        {
            if (textBox_lastarg_or_answer.Text != "")
            {
                MethodCallOneOperand("tan", textBox_lastarg_or_answer);
            }
        }

        private void button_ctg_Click(object sender, EventArgs e)
        {
            if (textBox_lastarg_or_answer.Text != "")
            {
                MethodCallOneOperand("ctan", textBox_lastarg_or_answer);
            }
        }

        private void button_nat_logarifm_Click(object sender, EventArgs e)
        {
            if (textBox_lastarg_or_answer.Text != "")
            {
                MethodCallOneOperand("ln", textBox_lastarg_or_answer);
            }
        }

        private void button_obratnoe_chislo_Click(object sender, EventArgs e)
        {
            if (textBox_lastarg_or_answer.Text != "")
            {
                MethodCallOneOperand("invers", textBox_lastarg_or_answer);
            }
        }

        private void button_factorial_Click(object sender, EventArgs e)
        {
            if (textBox_lastarg_or_answer.Text != "")
            {
                MethodCallOneOperand("factorial", textBox_lastarg_or_answer);
            }
        }

        private void button_step_dva_Click(object sender, EventArgs e)
        {
            if (textBox_lastarg_or_answer.Text != "")
            {
                MethodCallOneOperand("squar", textBox_lastarg_or_answer);
            }
        }

        private void button_sqrt_Click(object sender, EventArgs e)
        {
            if (textBox_lastarg_or_answer.Text != "")
            {
                MethodCallOneOperand("sqr", textBox_lastarg_or_answer);
            }
        }
        //..


        //РАБОТА С ЗАПИСЯМИ
        //очистка всех 2 записей-КНОПКА С
        private void button_clearall_Click(object sender, EventArgs e)
        {
            textBox_lastarg_or_answer.Text = "";
            textBox_first_arg.Text = "";

        }
        //удаление последнего символа с textBox_lastarg_or_answer  - КНОПКА СТРЕЛКА
        private void button_dellone_Click(object sender, EventArgs e)
        {
            if(textBox_lastarg_or_answer.Text!="")
            {
                string s = textBox_lastarg_or_answer.Text;
                textBox_lastarg_or_answer.Text = s.Substring(0, s.Length - 1);                  
            }           
        }

        //ВЫВОД РЕЗУЛЬТАТА
        private void button_show_rez_Click(object sender, EventArgs e)
        {
            MethodCallTwoOperand(calculator.Operation,textBox_first_arg);
            if (textBox_first_arg.Text != "")
                textBox_lastarg_or_answer.Clear();
            calculator.Operation = null;          
        }
    }
}
