using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NguyenTanLinh_2122110398
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox3.Text == "" || textBox2.Text == "" || (radioButton1.Checked == false && radioButton2.Checked == false))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                foreach (ListViewItem i in listView1.Items)
                {
                    if (textBox1.Text == i.SubItems[0].Text)
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại.");
                        textBox1.Clear();
                        textBox1.Focus();
                        return;
                    }
                }
                ListViewItem item = new ListViewItem(textBox1.Text);
                item.SubItems.Add(textBox2.Text);
                if (!str_is_digit(textBox3.Text))
                {
                    MessageBox.Show("Vui lòng nhập số.");
                    textBox3.Clear();
                    textBox3.Focus();
                    return;
                }
                item.SubItems.Add(textBox3.Text);
                if (radioButton1.Checked)
                {
                    item.SubItems.Add("Nam");
                }
                if (radioButton2.Checked)
                {
                    item.SubItems.Add("Nữ");
                }
                listView1.Items.Add(item);

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                radioButton1.Checked = false; 
                radioButton2.Checked = false;
                textBox1.Focus();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
                textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
                textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
                if(listView1.SelectedItems[0].SubItems[3].Text == "Nam")
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                for(int i = listView1.SelectedItems.Count - 1; i >= 0 ;i--)
                {
                    listView1.Items.Remove(listView1.SelectedItems[i]);
                }
            }
            else
            {
                MessageBox.Show("Chọn tối thiểu 1 row");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].SubItems[0].Text = textBox1.Text;
            listView1.SelectedItems[0].SubItems[1].Text = textBox2.Text;
            listView1.SelectedItems[0].SubItems[2].Text = textBox3.Text;
            if (radioButton1.Checked)
            {
                listView1.SelectedItems[0].SubItems[3].Text = "Nam";
            }
            if (radioButton2.Checked)
            {
                listView1.SelectedItems[0].SubItems[3].Text = "Nữ";
            }
        }

        private Boolean str_is_digit(String str)
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns[0].Width = (int)(listView1.Width * 0.25);
            listView1.Columns[1].Width = (int)(listView1.Width * 0.25);
            listView1.Columns[2].Width = (int)(listView1.Width * 0.25);
            listView1.Columns[3].Width = (int)(listView1.Width * 0.25);
        }
    }
}
