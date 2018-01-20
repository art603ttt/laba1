using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        

        //ВВОД ЦИФР
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
        //...
        //ВВОД РАЗДЕЛИТЕЛЯ
        private void button_razdelit_Click(object sender, EventArgs e)
        {
            textBox_lastarg_or_answer.Text += ".";
            //надо проверить - 1)есть ли уже запятая
            //2)записана хоть одна цифра
            //точка может не работать(вместо нее - запятая)
        }

        //...
        //ОПЕРАЦИИ С 2 АРГУМЕНТАМИ
        private void button_plus_Click(object sender, EventArgs e)
        {
            //при нажатии на операцию с 2 аргументами нужно перенести запись c поля textBox_lastarg_or_answer в textBox_first_arg ?? - нужно чтобы ввести 2-е число
            textBox_first_arg.Text = textBox_lastarg_or_answer.Text;
            textBox_lastarg_or_answer.Text = "";
        }

        private void button_minus_Click(object sender, EventArgs e)
        {

        }

        private void button_div_Click(object sender, EventArgs e)
        {

        }
        
        private void button_stepen_y_Click(object sender, EventArgs e)
        {

        }

        private void button_umnoj_Click(object sender, EventArgs e)
        {

        }

        //..
        //ОПЕРАЦИИ С ОДНИМ АРГУМЕНТОМ
        private void button_sin_Click(object sender, EventArgs e)
        {
           

        }

        private void button_cos_Click(object sender, EventArgs e)
        {

        }

        private void button_tg_Click(object sender, EventArgs e)
        {

        }

        private void button_ctg_Click(object sender, EventArgs e)
        {

        }

        private void button_nat_logarifm_Click(object sender, EventArgs e)
        {

        }

        private void button_obratnoe_chislo_Click(object sender, EventArgs e)
        {

        }

        private void button_factorial_Click(object sender, EventArgs e)
        {

        }

        private void button_step_dva_Click(object sender, EventArgs e)
        {

        }

        private void button_sqrt_Click(object sender, EventArgs e)
        {

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
            
        }

        //ВЫВОД РЕЗУЛЬТАТА
        private void button_show_rez_Click(object sender, EventArgs e)
        {

        }
    }
}
