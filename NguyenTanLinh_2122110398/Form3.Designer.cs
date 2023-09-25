namespace NguyenTanLinh_2122110398
{
    partial class Form3
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

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtx = new System.Windows.Forms.TextBox();
            this.txty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.tru = new System.Windows.Forms.Button();
            this.nhan = new System.Windows.Forms.Button();
            this.cong = new System.Windows.Forms.Button();
            this.chia = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số y";
            // 
            // txtx
            // 
            this.txtx.Location = new System.Drawing.Point(63, 10);
            this.txtx.Name = "txtx";
            this.txtx.Size = new System.Drawing.Size(168, 20);
            this.txtx.TabIndex = 2;
            // 
            // txty
            // 
            this.txty.Location = new System.Drawing.Point(62, 48);
            this.txty.Name = "txty";
            this.txty.Size = new System.Drawing.Size(169, 20);
            this.txty.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kết quả";
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(62, 82);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(169, 20);
            this.txtkq.TabIndex = 5;
            // 
            // tru
            // 
            this.tru.Location = new System.Drawing.Point(15, 144);
            this.tru.Name = "tru";
            this.tru.Size = new System.Drawing.Size(75, 23);
            this.tru.TabIndex = 6;
            this.tru.Text = "Trừ";
            this.tru.UseVisualStyleBackColor = true;
            this.tru.Click += new System.EventHandler(this.tru_Click);
            // 
            // nhan
            // 
            this.nhan.Location = new System.Drawing.Point(96, 144);
            this.nhan.Name = "nhan";
            this.nhan.Size = new System.Drawing.Size(75, 23);
            this.nhan.TabIndex = 7;
            this.nhan.Text = "Nhân";
            this.nhan.UseVisualStyleBackColor = true;
            this.nhan.Click += new System.EventHandler(this.nhan_Click);
            // 
            // cong
            // 
            this.cong.Location = new System.Drawing.Point(15, 173);
            this.cong.Name = "cong";
            this.cong.Size = new System.Drawing.Size(75, 23);
            this.cong.TabIndex = 9;
            this.cong.Text = "Cộng";
            this.cong.UseVisualStyleBackColor = true;
            this.cong.Click += new System.EventHandler(this.cong_Click);
            // 
            // chia
            // 
            this.chia.Location = new System.Drawing.Point(96, 173);
            this.chia.Name = "chia";
            this.chia.Size = new System.Drawing.Size(75, 23);
            this.chia.TabIndex = 10;
            this.chia.Text = "Chia";
            this.chia.UseVisualStyleBackColor = true;
            this.chia.Click += new System.EventHandler(this.chia_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(333, 173);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Thoát";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 203);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.chia);
            this.Controls.Add(this.cong);
            this.Controls.Add(this.nhan);
            this.Controls.Add(this.tru);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txty);
            this.Controls.Add(this.txtx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Phép tính";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtx;
        private System.Windows.Forms.TextBox txty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.Button tru;
        private System.Windows.Forms.Button nhan;
        private System.Windows.Forms.Button cong;
        private System.Windows.Forms.Button chia;
        private System.Windows.Forms.Button button5;
    }
}