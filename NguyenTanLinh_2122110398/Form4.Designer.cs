﻿namespace NguyenTanLinh_2122110398
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.btnFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ảnh 3 x 4";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(175, 136);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(178, 20);
            this.textBox2.TabIndex = 5;
            // 
            // pbImg
            // 
            this.pbImg.Location = new System.Drawing.Point(186, 215);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(167, 148);
            this.pbImg.TabIndex = 6;
            this.pbImg.TabStop = false;
            // 
            // btnFile
            // 
            this.btnFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFile.Location = new System.Drawing.Point(403, 215);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(98, 30);
            this.btnFile.TabIndex = 7;
            this.btnFile.Text = "Chọn ảnh ...";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 428);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.pbImg);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.Button btnFile;
    }
}