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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tru_Click(object sender, EventArgs e)
        {
            if (!isNumber(txtx.Text))
            {
                MessageBox.Show("Vui lòng nhập số!");
                txtx.Clear();
                txtx.Focus();
                return;
            }
            if (!isNumber(txty.Text))
            {
                MessageBox.Show("Vui lòng nhập số!");
                txty.Clear();
                txty.Focus();
                return;
            }
            Double num1 = Convert.ToDouble(txtx.Text);
            Double num2 = Convert.ToDouble(txty.Text);
            double kq = num1 - num2;
            txtkq.Text = kq.ToString();
        }

        private bool isNumber(string s)
        {
            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void nhan_Click(object sender, EventArgs e)
        {
            if (!isNumber(txtx.Text))
            {
                MessageBox.Show("Vui lòng nhập số!");
                txtx.Clear();
                txtx.Focus();
                return;
            }
            if (!isNumber(txty.Text))
            {
                MessageBox.Show("Vui lòng nhập số!");
                txty.Clear();
                txty.Focus();
                return;
            }
            Double num1 = Convert.ToDouble(txtx.Text);
            Double num2 = Convert.ToDouble(txty.Text);
            double kq = num1 * num2;
            txtkq.Text = kq.ToString();
        }

        private void cong_Click(object sender, EventArgs e)
        {
            if (!isNumber(txtx.Text))
            {
                MessageBox.Show("Vui lòng nhập số!");
                txtx.Clear();
                txtx.Focus();
                return;
            }
            if (!isNumber(txty.Text))
            {
                MessageBox.Show("Vui lòng nhập số!");
                txty.Clear();
                txty.Focus();
                return;
            }
            Double num1 = Convert.ToDouble(txtx.Text);
            Double num2 = Convert.ToDouble(txty.Text);
            double kq = num1 = num2;
            txtkq.Text = kq.ToString();
        }

        private void chia_Click(object sender, EventArgs e)
        {
            if (!isNumber(txtx.Text))
            {
                MessageBox.Show("Vui lòng nhập số!");
                txtx.Clear();
                txtx.Focus();
                return;
            }
            if (!isNumber(txty.Text))
            {
                MessageBox.Show("Vui lòng nhập số!");
                txty.Clear();
                txty.Focus();
                return;
            }
            Double num1 = Convert.ToDouble(txtx.Text);
            Double num2 = Convert.ToDouble(txty.Text);
            double kq = num1 / num2;
            txtkq.Text = kq.ToString();
        }
    }
}
