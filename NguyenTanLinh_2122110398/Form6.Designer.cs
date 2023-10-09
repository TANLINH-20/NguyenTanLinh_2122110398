namespace NguyenTanLinh_2122110398
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtGV_quan_ly = new System.Windows.Forms.DataGridView();
            this.Col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_img = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_age = new System.Windows.Forms.Label();
            this.lb_gender = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.r_btn_male = new System.Windows.Forms.RadioButton();
            this.r_btn_female = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_img = new System.Windows.Forms.TextBox();
            this.pb_btn_img = new System.Windows.Forms.Button();
            this.pb_img = new System.Windows.Forms.PictureBox();
            this.btn_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_quan_ly)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGV_quan_ly
            // 
            this.dtGV_quan_ly.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGV_quan_ly.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtGV_quan_ly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGV_quan_ly.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_id,
            this.Col_name,
            this.Col_age,
            this.Col_gender,
            this.Col_img});
            this.dtGV_quan_ly.Location = new System.Drawing.Point(6, 42);
            this.dtGV_quan_ly.Name = "dtGV_quan_ly";
            this.dtGV_quan_ly.ReadOnly = true;
            this.dtGV_quan_ly.RowHeadersWidth = 51;
            this.dtGV_quan_ly.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtGV_quan_ly.RowTemplate.Height = 24;
            this.dtGV_quan_ly.Size = new System.Drawing.Size(819, 250);
            this.dtGV_quan_ly.TabIndex = 0;
            this.dtGV_quan_ly.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGV_quan_ly_CellClick);
            // 
            // Col_id
            // 
            this.Col_id.HeaderText = "ID";
            this.Col_id.MinimumWidth = 6;
            this.Col_id.Name = "Col_id";
            this.Col_id.ReadOnly = true;
            // 
            // Col_name
            // 
            this.Col_name.HeaderText = "Full Name";
            this.Col_name.MinimumWidth = 6;
            this.Col_name.Name = "Col_name";
            this.Col_name.ReadOnly = true;
            // 
            // Col_age
            // 
            this.Col_age.HeaderText = "Age";
            this.Col_age.MinimumWidth = 6;
            this.Col_age.Name = "Col_age";
            this.Col_age.ReadOnly = true;
            // 
            // Col_gender
            // 
            this.Col_gender.HeaderText = "Gender";
            this.Col_gender.MinimumWidth = 6;
            this.Col_gender.Name = "Col_gender";
            this.Col_gender.ReadOnly = true;
            // 
            // Col_img
            // 
            this.Col_img.HeaderText = "Image";
            this.Col_img.MinimumWidth = 6;
            this.Col_img.Name = "Col_img";
            this.Col_img.ReadOnly = true;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.Location = new System.Drawing.Point(6, 34);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(23, 17);
            this.lb_id.TabIndex = 1;
            this.lb_id.Text = "ID";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(6, 72);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(49, 17);
            this.lb_name.TabIndex = 2;
            this.lb_name.Text = "Name";
            // 
            // lb_age
            // 
            this.lb_age.AutoSize = true;
            this.lb_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_age.Location = new System.Drawing.Point(6, 114);
            this.lb_age.Name = "lb_age";
            this.lb_age.Size = new System.Drawing.Size(36, 17);
            this.lb_age.TabIndex = 3;
            this.lb_age.Text = "Age";
            // 
            // lb_gender
            // 
            this.lb_gender.AutoSize = true;
            this.lb_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gender.Location = new System.Drawing.Point(6, 155);
            this.lb_gender.Name = "lb_gender";
            this.lb_gender.Size = new System.Drawing.Size(62, 17);
            this.lb_gender.TabIndex = 4;
            this.lb_gender.Text = "Gender";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(99, 31);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(209, 23);
            this.txt_id.TabIndex = 5;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(99, 69);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(209, 23);
            this.txt_name.TabIndex = 6;
            // 
            // txt_age
            // 
            this.txt_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_age.Location = new System.Drawing.Point(99, 111);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(66, 23);
            this.txt_age.TabIndex = 7;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(402, 578);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(95, 44);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_del
            // 
            this.btn_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.Location = new System.Drawing.Point(515, 578);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(93, 44);
            this.btn_del.TabIndex = 10;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(630, 578);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(93, 44);
            this.btn_edit.TabIndex = 11;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(745, 578);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(93, 44);
            this.btn_exit.TabIndex = 12;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // r_btn_male
            // 
            this.r_btn_male.AutoSize = true;
            this.r_btn_male.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r_btn_male.Location = new System.Drawing.Point(103, 153);
            this.r_btn_male.Name = "r_btn_male";
            this.r_btn_male.Size = new System.Drawing.Size(56, 21);
            this.r_btn_male.TabIndex = 13;
            this.r_btn_male.TabStop = true;
            this.r_btn_male.Text = "Male";
            this.r_btn_male.UseVisualStyleBackColor = true;
            // 
            // r_btn_female
            // 
            this.r_btn_female.AutoSize = true;
            this.r_btn_female.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r_btn_female.Location = new System.Drawing.Point(214, 153);
            this.r_btn_female.Name = "r_btn_female";
            this.r_btn_female.Size = new System.Drawing.Size(72, 21);
            this.r_btn_female.TabIndex = 14;
            this.r_btn_female.TabStop = true;
            this.r_btn_female.Text = "Female";
            this.r_btn_female.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtGV_quan_ly);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(831, 307);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_gender);
            this.groupBox2.Controls.Add(this.lb_id);
            this.groupBox2.Controls.Add(this.r_btn_male);
            this.groupBox2.Controls.Add(this.r_btn_female);
            this.groupBox2.Controls.Add(this.txt_id);
            this.groupBox2.Controls.Add(this.lb_name);
            this.groupBox2.Controls.Add(this.txt_name);
            this.groupBox2.Controls.Add(this.lb_age);
            this.groupBox2.Controls.Add(this.txt_age);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 341);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 201);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enter Employee Information";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_img);
            this.groupBox3.Controls.Add(this.pb_btn_img);
            this.groupBox3.Controls.Add(this.pb_img);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(402, 341);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(398, 201);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Photo Card";
            // 
            // txt_img
            // 
            this.txt_img.Location = new System.Drawing.Point(228, 149);
            this.txt_img.Name = "txt_img";
            this.txt_img.ReadOnly = true;
            this.txt_img.Size = new System.Drawing.Size(154, 23);
            this.txt_img.TabIndex = 2;
            // 
            // pb_btn_img
            // 
            this.pb_btn_img.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_btn_img.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pb_btn_img.Location = new System.Drawing.Point(228, 36);
            this.pb_btn_img.Name = "pb_btn_img";
            this.pb_btn_img.Size = new System.Drawing.Size(154, 50);
            this.pb_btn_img.TabIndex = 1;
            this.pb_btn_img.Text = "File Image...";
            this.pb_btn_img.UseVisualStyleBackColor = true;
            this.pb_btn_img.Click += new System.EventHandler(this.pb_btn_img_Click);
            // 
            // pb_img
            // 
            this.pb_img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_img.Location = new System.Drawing.Point(43, 36);
            this.pb_img.Name = "pb_img";
            this.pb_img.Size = new System.Drawing.Size(163, 138);
            this.pb_img.TabIndex = 0;
            this.pb_img.TabStop = false;
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(291, 578);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(95, 44);
            this.btn_clear.TabIndex = 18;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 634);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_add);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form6";
            this.Text = "Quan Ly Nhan Vien";
            this.Load += new System.EventHandler(this.Quan_ly_nhan_vien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_quan_ly)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGV_quan_ly;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_age;
        private System.Windows.Forms.Label lb_gender;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.RadioButton r_btn_male;
        private System.Windows.Forms.RadioButton r_btn_female;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_gender;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button pb_btn_img;
        private System.Windows.Forms.PictureBox pb_img;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_img;
        private System.Windows.Forms.TextBox txt_img;
        private System.Windows.Forms.Button btn_clear;
    }
}

