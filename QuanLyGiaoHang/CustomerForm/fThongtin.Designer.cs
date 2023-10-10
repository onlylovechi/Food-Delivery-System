namespace QuanLyGiaoHang
{
    partial class fThongtin
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
            this.label4 = new System.Windows.Forms.Label();
            this.ten = new System.Windows.Forms.Label();
            this.gmail = new System.Windows.Forms.Label();
            this.dienthoai = new System.Windows.Forms.Label();
            this.diachi = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gmail";
            // 
            // ten
            // 
            this.ten.AutoSize = true;
            this.ten.Location = new System.Drawing.Point(155, 66);
            this.ten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(22, 13);
            this.ten.TabIndex = 4;
            this.ten.Text = "NA";
            // 
            // gmail
            // 
            this.gmail.AutoSize = true;
            this.gmail.Location = new System.Drawing.Point(155, 162);
            this.gmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gmail.Name = "gmail";
            this.gmail.Size = new System.Drawing.Size(22, 13);
            this.gmail.TabIndex = 5;
            this.gmail.Text = "NA";
            // 
            // dienthoai
            // 
            this.dienthoai.AutoSize = true;
            this.dienthoai.Location = new System.Drawing.Point(155, 128);
            this.dienthoai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dienthoai.Name = "dienthoai";
            this.dienthoai.Size = new System.Drawing.Size(22, 13);
            this.dienthoai.TabIndex = 6;
            this.dienthoai.Text = "NA";
            // 
            // diachi
            // 
            this.diachi.AutoSize = true;
            this.diachi.Location = new System.Drawing.Point(155, 98);
            this.diachi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.diachi.Name = "diachi";
            this.diachi.Size = new System.Drawing.Size(22, 13);
            this.diachi.TabIndex = 7;
            this.diachi.Text = "NA";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 235);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 19);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cập nhật";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(289, 235);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 19);
            this.button2.TabIndex = 9;
            this.button2.Text = "Quay lại";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fThongtin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 313);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.diachi);
            this.Controls.Add(this.dienthoai);
            this.Controls.Add(this.gmail);
            this.Controls.Add(this.ten);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fThongtin";
            this.Text = "Thông tin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ten;
        private System.Windows.Forms.Label gmail;
        private System.Windows.Forms.Label dienthoai;
        private System.Windows.Forms.Label diachi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}