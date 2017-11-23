using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;                    //String storing user input
        string operand1 = string.Empty;                 //String storing first operand
        string operand2 = string.Empty;                 //String storing second operand
        char operation;                                 //char for operation
        double result = 0.00;                           //calculated result

        public Form1()
        {
            InitializeComponent();
        }

        private void one_Click(object sender, EventArgs e)
        {
            this.outputScreen.Text = "";
            input += "1";
            this.outputScreen.Text += input;
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.outputScreen.Text = "";
            input += "2";
            this.outputScreen.Text += input;
        }

        private void three_Click(object sender, EventArgs e)
        {
            this.outputScreen.Text = "";
            input += "3";
            this.outputScreen.Text += input;
        }

        private void four_Click(object sender, EventArgs e)
        {
            this.outputScreen.Text = "";
            input += "4";
            this.outputScreen.Text += input;
        }

        private void five_Click(object sender, EventArgs e)
        {
            this.outputScreen.Text = "";
            input += "5";
            this.outputScreen.Text += input;
        }

        private void six_Click(object sender, EventArgs e)
        {
            this.outputScreen.Text = "";
            input += "6";
            this.outputScreen.Text += input;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            this.outputScreen.Text = "";
            input += "7";
            this.outputScreen.Text += input;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.outputScreen.Text = "";
            input += "8";
            this.outputScreen.Text += input;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.outputScreen.Text = "";
            input += "9";
            this.outputScreen.Text += input;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            this.outputScreen.Text = "";
            input += "0";
            this.outputScreen.Text += input;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            this.outputScreen.Text = "";
            input += ".";
            this.outputScreen.Text += input;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.outputScreen.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand1 = string.Empty;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void percentage_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '%';
            input = string.Empty;
        }

        private void euro_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://finance.google.com/finance/converter");
        }

        private void equals_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            this.outputScreen.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;

            if (operation == '*')
            {
                result = num1 * num2;
                outputScreen.Text = result.ToString();
            }

            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    outputScreen.Text = result.ToString();
                }
            }

            else if (operation == '+')
            {
                result = num1 + num2;
                outputScreen.Text = result.ToString();
            }

            else if (operation == '-')
            {
                result = num1 - num2;
                outputScreen.Text = result.ToString();
            }

            else if (operation == '%')
            {
                result = num1 / num2 * 100;
                outputScreen.Text = result.ToString();
            }

            else
            {
                outputScreen.Text = "DIV/Zero!";
            }
        }

        private void outputScreen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
