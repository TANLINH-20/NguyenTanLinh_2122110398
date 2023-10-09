using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenTanLinh_2122110398
{
    public partial class Form7 : Form
    {
        private string currentInput = "";
        private double result;
        private char operation;
        public Form7()
        {
            InitializeComponent();
        }
        private void buttonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string btnText = btn.Text;
            if (btnText == "+" || btnText == "-" || btnText == "*" || btnText == "/")
            {
                lbResult.Text = currentInput + " " + btnText;
                operation = char.Parse(btnText);
                PerformOperation();
                txtInput.Clear();
                currentInput = "";
            }
            else
            {
                txtInput.Text += btn.Text;
                currentInput = txtInput.Text;
            }
        }
        private void PerformOperation()
        {
            if (currentInput != "")
            {
                string[] parst = lbResult.Text.Split(' ');
                result = Convert.ToDouble(parst[0]);
                Double lastNumber = double.Parse(currentInput);
                switch (operation)
                {
                    case '+':
                        result += lastNumber;
                        break;
                    case '-':
                        result -= lastNumber;
                        break;
                    case '*':
                        result *= lastNumber;
                        break;
                    case '/':
                        if (lastNumber != 0)
                        {
                            result /= lastNumber;
                        }
                        else
                        {
                            lbResult.Text = "Error";
                            return;
                        }
                        break;
                }
                currentInput = "";
            }
        }
        private void equal_btn(object sender, EventArgs e)
        {
            PerformOperation();
            lbResult.Text = result.ToString();
            txtInput.Clear();
            result = 0;
        }

        private void ac_btn(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            result = 0;
            txtInput.Clear();
            lbResult.Text = "";
            btn.Enabled = true;
        }

        private void del_btn(object sender, EventArgs e)
        {
            var length1 = txtInput.Text.Length - 1;
            if (length1 > -1)
                txtInput.Text = txtInput.Text.Substring(0, length1);
        }

        private void btn_lunisolar(object sender, EventArgs e)
        {
            if (txtInput.Text != "")
            {
                Double number = Convert.ToDouble(txtInput.Text);
                number *= -1;
                txtInput.Text = number.ToString();
                currentInput = txtInput.Text;
            }
        }

        private void btn_CE(object sender, EventArgs e)
        {
            txtInput.Clear();
        }
    }
}

