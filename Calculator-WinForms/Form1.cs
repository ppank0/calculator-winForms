using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        LinkedList<double>numbersList = new LinkedList<double>();
        LinkedList<char>operationsList = new LinkedList<char>();

        private void button_zero_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text += (sender as Button).Text;
            }
            catch (NullReferenceException)
            {
               // MessageBox.Show("Пожалуйста, выберите кнопку с цифрой.");
            }
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            double number;
            if(double.TryParse(textBox1.Text, out number))
            {
                numbersList.AddLast(number);
                operationsList.AddLast((sender as Button).Text[0]);
                textBox1.Text += (sender as Button).Text;
                textBox1.Clear();
            }
        }

        private void equal_Click(object sender, EventArgs e)
        {
            double number;
            double firstnumber, secondnumber, result =0;
            char operation;
            if (double.TryParse(textBox1.Text, out number))
            {
                numbersList.AddLast(number);
                textBox1.Clear();
            }

            while(numbersList.Count > 1)
            {
                if(numbersList.Count >=2 && operationsList.Count>=1) 
                {
                    firstnumber = numbersList.First.Value;
                    numbersList.RemoveFirst();
                    secondnumber = numbersList.First.Value;
                    numbersList.RemoveFirst();
                    operation = operationsList.First.Value;
                    operationsList.RemoveFirst();

                    switch (operation)
                    {
                        case '+':
                            result = firstnumber+ secondnumber;
                            break;
                        case '-':
                            result = firstnumber-secondnumber;
                            break;
                        case 'x':
                            result = firstnumber * secondnumber;
                            break;
                        case '/':
                            result = firstnumber / secondnumber;
                            break;
                    }
                    numbersList.AddFirst(result);
                }
            }

            textBox1.Text += result.ToString();
            numbersList.Clear();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button_bracket_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }

        private void button_percent_Click(object sender, EventArgs e)
        {
            double number;
            if (double.TryParse(textBox1.Text, out number))
            {
                number = number / 100;
                textBox1.Clear();
                textBox1.Text += number.ToString();
            }
        }

        private void change_symbols_Click(object sender, EventArgs e)
        {
            double number;
            if (double.TryParse(textBox1.Text, out number))
            {
                number = number * (-1);
                textBox1.Clear();
                textBox1.Text += number.ToString();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true; // Запрещаем ввод символа
            }
        }

        private void DarkTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (DarkTheme.Checked)
            {
                this.ForeColor = Color.White;
                panel1.BackColor = Color.DarkSlateGray;
                this.BackColor = Color.DarkSlateGray;
                equal.BackColor = Color.Teal;

                textBox1.BackColor = Color.Gray;
                textBox1.ForeColor = Color.White;

                button_division.BackColor = Color.CadetBlue;
                button_multiplication.BackColor = Color.CadetBlue;
                button_subtraction.BackColor = Color.CadetBlue;
                button_plus.BackColor = Color.CadetBlue;

                button_clear.BackColor = Color.DarkGray;
                button_bracket.BackColor = Color.DarkGray;
                button_percent.BackColor = Color.DarkGray;
            }
            else
            {
                this.ForeColor = Color.Black;
                this.BackColor = Color.WhiteSmoke;
                panel1.BackColor = Color.RosyBrown;
                equal.BackColor = Color.RosyBrown;

                textBox1.BackColor = Color.White;
                textBox1.ForeColor = Color.DimGray;

                button_division.BackColor = Color.DarkGray;
                button_multiplication.BackColor = Color.DarkGray;
                button_subtraction.BackColor = Color.DarkGray;
                button_plus.BackColor = Color.DarkGray;

                button_clear.BackColor = Color.LightGray;
                button_bracket.BackColor = Color.LightGray;
                button_percent.BackColor = Color.LightGray;
            }
        }
    }
}
