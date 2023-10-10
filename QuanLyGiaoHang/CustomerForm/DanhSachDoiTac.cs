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

namespace QuanLyGiaoHang
{
    public partial class DanhSachDoiTac : Form
    {
        private List<DoiTacInf> list;
        public DanhSachDoiTac()
        {
            InitializeComponent();
        }

        private void DanhSachDoiTac_Load(object sender, EventArgs e)
        {
            list = PartnerDAO.Instance.getData();
            dataGridView1.DataSource = list;
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentCell.RowIndex;
            string madoitac = list[i].ID;
            string chinhanh = list[i].Chinhanh.ToString();
            fCustomer fCustomer=new fCustomer(madoitac,chinhanh);
            this.Hide();
            fCustomer.ShowDialog();
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void đơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fXemDonHang fXemDonHang = new fXemDonHang();
            this.Hide();
            fXemDonHang.ShowDialog();
            this.Show();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt=CustomerDAO.Instance.getCustomerInf(AccountDAO.id);
            fThongtin fThongtin = new fThongtin(dt.Rows[0]);
            this.Hide();
            fThongtin.ShowDialog();
            this.Show();
          

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
