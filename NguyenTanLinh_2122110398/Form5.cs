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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public bool checkInfo()
        {
            if (txt_id.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_id.Focus();
                return false;
            }
            if (txt_name.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_name.Focus();
                return false;
            }
            if (txt_age.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số tuổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_age.Focus();
                return false;
            }
            if (!rbtn_male.Checked && !rbtn_female.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private bool is_number(string str)
        {
            foreach (char c in str)
            {
                if (char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
        //private bool gender_checked()
        //{
        //    if(rbtn_male.Checked)
        //    {
        //        return true;
        //    }
        //    if (rbtn_female.Checked)
        //    {
        //        return false;
        //    }
        //}

        private void btn_add_Click(object sender, EventArgs e)
        {
            string gen = "";
            if (checkInfo())
            {
                if (is_number(txt_age.Text))
                {
                    MessageBox.Show("Vui lòng nhập số tuổi là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_age.Clear();
                    txt_age.Focus();
                    return;
                }
                double age = Convert.ToDouble(txt_age.Text);
                if (age<=0)
                {
                    MessageBox.Show("Vui lòng nhập số tuổi cho đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_age.Clear();
                    txt_age.Focus();
                    return;
                }

                if (rbtn_male.Checked)
                {
                    gen = rbtn_male.Text;
                }
                if (rbtn_female.Checked)
                {
                    gen = rbtn_female.Text;
                }
                dtgv_employee.Rows.Add(txt_id.Text, txt_name.Text, txt_age.Text, gen);
            }
        }
    }
}
