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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 objForm1 = new Form1();
            objForm1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 objForm3 = new Form3();
            objForm3.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 objForm4 = new Form4();
            objForm4.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 objForm5 = new Form5();
            objForm5.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form6 objForm6 = new Form6();
            objForm6.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form7 objForm7 = new Form7();
            objForm7.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form8 objForm8 = new Form8();
            objForm8.ShowDialog();
        }
    }
}
