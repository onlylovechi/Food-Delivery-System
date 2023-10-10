using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaoHang
{
    public partial class fRegister_KhachHang : Form
    {
        public fRegister_KhachHang()
        {
            InitializeComponent();
        }

        private void fRegister_KhachHang_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) return;
            fRegister_TaiXe fRegister_TaiXe = new fRegister_TaiXe();
            this.Hide();
            fRegister_TaiXe.ShowDialog();
            this.Show();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_dk_Click(object sender, EventArgs e)
        {

        }
    }
}
