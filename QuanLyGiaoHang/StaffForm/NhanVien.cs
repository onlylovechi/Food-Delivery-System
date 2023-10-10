using QuanLyGiaoHang.DAO;
using QuanLyGiaoHang.DTO;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using QLHTGH.DAO;

namespace QuanLyGiaoHang
{
    public partial class NhanVien : Form
    {
        BindingSource contractlist = new BindingSource();
        private string username;

        public NhanVien()
        {
            //dtgvContractNotAgree.DataSource = contractlist;

            InitializeComponent();
            LoadListPartner();
            LoadListContractAgree();
            LoadListContractNotAgree();

            addContractBinding();
            addAgreeContractBinding();
            tbMaNVstatic.Text = AccountDAO.id;
        }

        void addContractBinding()
        {
            tbMaHD.DataBindings.Add(new Binding("Text", dtgvContractNotAgree.DataSource, "MaHD"));
            tbMaDT.DataBindings.Add(new Binding("Text", dtgvContractNotAgree.DataSource, "MaDT"));
            tbMaSoThue.DataBindings.Add(new Binding("Text", dtgvContractNotAgree.DataSource, "MaSoThue"));
            tbNguoiDaiDien.DataBindings.Add(new Binding("Text", dtgvContractNotAgree.DataSource, "NguoiDaiDien"));
            tbSLCN.DataBindings.Add(new Binding("Text", dtgvContractNotAgree.DataSource, "SLChiNhanhDangKy"));
            //tbTGHieuLuc.DataBindings.Add(new Binding("Text", dtgvContractNotAgree.DataSource, "TGHieuLuc"));

        }

        void addAgreeContractBinding()
        {
            tbAgreeMaHD.DataBindings.Add(new Binding("Text", dtgvContractAgree.DataSource, "MaHD"));
            tbAgreeDate.DataBindings.Add(new Binding("Text", dtgvContractAgree.DataSource, "TGHieuLuc"));

        }

            #region Methods
            void LoadListContract()
        {
            dataGridView1.DataSource = contractDAO.Instance.LoadContractList();
        }

        void LoadListPartner()
        {
            dataGridView1.DataSource = PartnerDAO.Instance.LoadPartnerList();
        }

        void LoadListContractAgree()
        {
            dtgvContractAgree.DataSource = contractDAO.Instance.LoadContractAgreeList();
        }

        void LoadListContractNotAgree()
        {
            dtgvContractNotAgree.DataSource = contractDAO.Instance.LoadContractNotAgreeList();
        }
        #endregion

        private void Danh_Sach_DT_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void danhsachDoiTac_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mahd = tbMaHD.Text;
            string dateTo = dateAdd.Value.Date.Year.ToString() + "-" + dateAdd.Value.Date.Month.ToString() + "-" + dateAdd.Value.Date.Day.ToString();

            int result = DataProvider.Instance.ExecuteNonQuery("USP_AgreeContract '" + "NV001" + "', '" + mahd + "', '" + dateTo + "'");

            LoadListContractAgree();
            LoadListContractNotAgree();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string mahd = tbMaHD.Text;
            int result = DataProvider.Instance.ExecuteNonQuery("USP_CancelContract '" + mahd + "'");

            LoadListContractNotAgree();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void HD_Chua_Duyet_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            string mahd = tbAgreeMaHD.Text;
            string dateTo = tbAgreeToDate.Value.Date.Year.ToString() + "-" + tbAgreeToDate.Value.Date.Month.ToString() + "-" + tbAgreeToDate.Value.Date.Day.ToString();

            int result = DataProvider.Instance.ExecuteNonQuery("USP_SetTimeContract '" + mahd + "', '" + dateTo + "'");

            LoadListContractAgree();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            string mahd = tbMaHD.Text;

            int result = DataProvider.Instance.ExecuteNonQuery("USP_CancelContract '" + mahd + "'");

            LoadListContractAgree();
            LoadListContractNotAgree();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void NhanVien_Load(object sender, EventArgs e)
        {

        }

        private void tbMaNVstatic_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
