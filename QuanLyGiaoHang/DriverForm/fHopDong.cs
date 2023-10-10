using QuanLyGiaoHang.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyGiaoHang.DAO;
using QuanLyGiaoHang.DTO;

namespace QuanLyGiaoHang
{
    public partial class fHopDong : Form
    {
        public static string MADT;
        public fHopDong(string madt)
        {
            InitializeComponent();
            MADT = madt;
            LoadHopDongInfo(madt);
        }
        public void LoadHopDongInfo(string madt)
        {
            List<HopDong> list = HopDongDAO.Instance.LoadHopDongInfo(MADT);
            textBox2.Text = list[0].MaHD;
            textBox1.Text = list[0].MaSoThue;
            textBox3.Text = list[0].TGHieuLuc;
            textBox4.Text = list[0].HoaHong + "%";
            textBox5.Text = list[0].SLChiNhanhDangKy.ToString();
            textBox6.Text = list[0].NguoiDaiDien;
            textBox7.Text = list[0].BankName;
            textBox8.Text = list[0].BankNumber;
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("select MaCN from CHITIETHOPDONG where MaHD = '" + list[0].MaHD+"'");
            dataGridView1.DataSource = dataTable;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            fTaoHopDong form = new fTaoHopDong(MADT);
            this.Hide();
            form.ShowDialog();

        }

        private void fHopDong_Load(object sender, EventArgs e)
        {

        }
    }
}
