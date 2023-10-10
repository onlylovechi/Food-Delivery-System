using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaoHang
{
    public partial class fThongtin : Form
    {
        public fThongtin(DataRow row)
        {
            
            InitializeComponent();
            ten.Text = row["HoTen"].ToString();
            gmail.Text = row["Email"].ToString();
            dienthoai.Text = row["SDT"].ToString();
            diachi.Text = row["DiaChi"].ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Database db=new Database();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fThaydoithongtin thaydoithongtin = new fThaydoithongtin();
            this.Hide();
            thaydoithongtin.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
