﻿using System;
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Quan_ly_nhan_vien_Load(object sender, EventArgs e)
        {
            //dtGV_quan_ly.Columns[0].Width = dtGV_quan_ly.Width * 30 / 100;
            //dtGV_quan_ly.Columns[1].Width = dtGV_quan_ly.Width * 40 / 100;
            //dtGV_quan_ly.Columns[2].Width = dtGV_quan_ly.Width * 15 / 100;
            //dtGV_quan_ly.Columns[3].Width = dtGV_quan_ly.Width * 15 / 100;
        }

        private bool check_info()
        {
            if (txt_id.Text == "")
            {
                MessageBox.Show("Please enter employee code", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_id.Focus();
                return false;
            }
            if (!is_number(txt_id.Text))
            {
                MessageBox.Show("Please enter a number for the ID box", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_id.Clear();
                txt_id.Focus();
                return false;
            }
            if (txt_name.Text == "")
            {
                MessageBox.Show("Please enter your full name", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_name.Focus();
                return false;
            }
            if (txt_age.Text == "")
            {
                MessageBox.Show("Please enter your age", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_age.Focus();
                return false;
            }
            if (!is_number(txt_age.Text))
            {
                MessageBox.Show("Please enter a number for the Age box", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_age.Clear();
                txt_age.Focus();
                return false;
            }
            if (!r_btn_male.Checked && !r_btn_female.Checked)
            {
                MessageBox.Show("Please select gender", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txt_img.Text == "")
            {
                MessageBox.Show("Please select a photo", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private string gender_check()
        {
            if (r_btn_male.Checked) { return "Male"; }
            return "Female";
        }

        private bool is_number(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }
        private void clear_info()
        {
            txt_id.Clear();
            txt_name.Clear();
            txt_age.Clear();
            r_btn_male.Checked = false;
            r_btn_female.Checked = false;
            txt_img.Clear();
            pb_img.ImageLocation = null;
            txt_id.Focus();
        }

        private bool isIDDuplicate(string newID)
        {
            foreach (DataGridViewRow row in dtGV_quan_ly.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == newID)
                {
                    return true;
                }
            }
            return false;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (check_info())
            {
                if (isIDDuplicate(txt_id.Text))
                {
                    MessageBox.Show("ID already exists. Please select another ID.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_id.Clear();
                    txt_id.Focus();
                }
                else
                {
                    dtGV_quan_ly.Rows.Add(txt_id.Text, txt_name.Text, txt_age.Text, gender_check(), txt_img.Text);
                    clear_info();
                }
            }
        }

        private void dtGV_quan_ly_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dtGV_quan_ly.Rows[e.RowIndex].Selected = true;
                DataGridViewRow row = dtGV_quan_ly.Rows[e.RowIndex];
                txt_id.Text = row.Cells[0].Value != null ? row.Cells[0].Value.ToString() : "";
                txt_name.Text = row.Cells[1].Value != null ? row.Cells[1].Value.ToString() : "";
                txt_age.Text = row.Cells[2].Value != null ? row.Cells[2].Value.ToString() : "";
                string gender = row.Cells[3].Value != null ? row.Cells[3].Value.ToString() : "";
                txt_img.Text = row.Cells[4].Value != null ? row.Cells[4].Value.ToString() : "";
                pb_img.ImageLocation = txt_img.Text;
                if (gender == "Male")
                {
                    r_btn_male.Checked = true;
                }
                else if (gender == "Female")
                {
                    r_btn_female.Checked = true;
                }
                else
                {
                    r_btn_male.Checked = false;
                    r_btn_female.Checked = false;
                }
            }
        }


        private void btn_del_Click(object sender, EventArgs e)
        {
            if (dtGV_quan_ly.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected line?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dtGV_quan_ly.SelectedRows)
                    {
                        if(txt_id.Text != "")
                        {
                          dtGV_quan_ly.Rows.Remove(row);
                        }
                        else
                        {
                            return;
                        }
                    }
                    clear_info();
                }
            }
            else
            {
                MessageBox.Show("Please select at least one line to delete", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dtGV_quan_ly.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to edit the selected line?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow row = dtGV_quan_ly.SelectedRows[0];
                    row.Cells[0].Value = txt_id.Text;
                    row.Cells[1].Value = txt_name.Text;
                    row.Cells[2].Value = txt_age.Text;
                    row.Cells[3].Value = gender_check();
                    row.Cells[4].Value = txt_img.Text;
                    clear_info();
                }

            }
            else
            {
                MessageBox.Show("Please select a line to edit", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pb_btn_img_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(dlg.FileName);
                if (fileInfo.Length <= 1024 * 1024 * 10)
                {
                    pb_img.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb_img.ImageLocation = dlg.FileName;
                    txt_img.Text = dlg.FileName;
                }
                else
                {
                    MessageBox.Show("Image file size exceeds 10MB.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear_info();
        }
    }
}
