using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenTanLinh_2122110398
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender = "";

            if (textBox1.Text == "" || comboBox1.Text == "" || (!radioButton1.Checked && !radioButton2.Checked))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            if (radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }

            if (radioButton2.Checked)
            {
                gender = radioButton2.Text;
            }

            string oldData = richTextBox1.Text;
            string newData = "Họ tên: " + textBox1.Text + "\n" +
                             "Ngày sinh: " + dateTimePicker1.Text + "\n" +
                             "Giới tính: " + gender + "\n" +
                             "Khoa: " + comboBox1.Text + "\n";
            richTextBox1.Text = oldData + newData;
            textBox1.Clear();
            dateTimePicker1.Value = DateTime.Now;
            comboBox1.SelectedIndex = -1;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

    }
}
