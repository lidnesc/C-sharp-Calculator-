using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool znak = true;
        public static double sum(double a, double b)
        { return a + b; }
        public static double vychit(double a, double b)
        { return a - b; }
        public static double umnozh(double a, double b)
        { return a * b; }
        public static double delen(double a, double b)
        { return a / b; }



        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(sum(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(vychit(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(umnozh(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(delen(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            if (b == 0)
                textBox3.Text = "ОШИБКА:Деление на ноль";
            else
                textBox3.Text = (a / b).ToString();
        }
       // private void CorrectNumber()
        
            //if (textBox3.Text.IndexOf("∞") != -1)
              //  textBox3.Text = textBox3.Text.Substring(0, textBox3.Text.Length - 1);
            
            //MessageBox.Show("на ноль делить нельзя!");
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //только одна запятая
            var c = Convert.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (c == e.KeyChar)
            {
                if (textBox1.Text.Contains(c))
                {
                    e.Handled = true;
                }
            }
            //запрет на ввод запятой, если первым не идет число
            if (textBox1.Text.Length == 0)
                if (e.KeyChar == ',') e.Handled = true;
            //запреь на ввод второго нуля, если после первого не стоит запятая
            if (textBox1.Text.Length == 1)
                if (e.KeyChar == '0') e.Handled = true;
            if (textBox1.Text.Length >=1)
                if (e.KeyChar == '-') e.Handled = true;

            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44 && number !=45)
            {
                e.Handled = true;
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            var c = Convert.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (c == e.KeyChar)
            {
                if (textBox2.Text.Contains(c))
                {
                    e.Handled = true;
                }
            }
            
            if (textBox2.Text.Length == 0)
                if (e.KeyChar == ',') e.Handled = true;
            if (textBox2.Text.Length == 1)
                if (e.KeyChar == '0') e.Handled = true;
            if (textBox2.Text.Length >= 1)
                if (e.KeyChar == '-') e.Handled = true;
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44 && number != 45)
            {
                e.Handled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
  
            }
            else if (znak == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
               
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            textBox3.ReadOnly = true;

        }
    }
}
