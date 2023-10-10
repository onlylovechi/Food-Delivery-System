using QuanLyGiaoHang.DAO;
using QuanLyGiaoHang.Module;
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

namespace QuanLyGiaoHang
{
    public partial class fCustomer : Form
    {
        public string tk;
        public string mk;
        public string makh;
        private string madoitac;
        private string chinhanh;
        private List<Menuinf> menuinf;
        private List<Donhang> donhangs;
        private int curpos;
        Database db;
        public string Madoitac { get => madoitac; set => madoitac = value; }
        public string Chinhanh { get => chinhanh; set => chinhanh = value; }

        public fCustomer(string madoitac,string chinhanh)
        {
            db = new Database();
            donhangs= new List<Donhang>();
            this.Madoitac = madoitac;
            this.Chinhanh = chinhanh;
            InitializeComponent();
        }
        public fCustomer()
        {
            InitializeComponent();
        }
        private void đốiTácToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xếpHạngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                fLogin fLogin = new fLogin();
                fLogin.Show();
                
            }    
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fCustomer_Load(object sender, EventArgs e)
        {
            menuinf= MenuDAO.Instance.getData1(Chinhanh);
            dataGridView1.DataSource = menuinf;

        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            curpos=dataGridView1.CurrentCell.RowIndex;
            label3.Text = menuinf[curpos].Tenmon.ToString();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int total_money = 0;
            string tenmon = label3.Text.ToString();
            string soluong= numericUpDown1.Value.ToString();
            bool flag = true;
            if (label3.Text.Equals(""))
            {
                MessageBox.Show("Chọn món ăn muốn thêm vào đơn hàng");
            }
            else
            {
                if (soluong.Equals("0"))
                {
                    MessageBox.Show("Số lượng không hợp lệ");
                    return;
                }
            }
            foreach(Donhang donhang1 in donhangs)
            {
                if (donhang1.Tenmon.Equals(tenmon)){
                    int tmp = int.Parse(soluong) + int.Parse(donhang1.Soluong);
                    donhang1.Soluong = tmp.ToString();
                    int tongtien=int.Parse(donhang1.Dongia)*tmp/int.Parse(donhang1.Soluong);
                    donhang1.Dongia = tongtien.ToString();
                    flag = false;
                }
                
            }
            if (flag)
            {
                string tuychon = textBox3.Text.ToString();
                int gia = int.Parse(menuinf[curpos].Gia) * int.Parse(soluong);
                string thanhtien = gia.ToString();
                Donhang donhang = new Donhang(tenmon, soluong, tuychon, thanhtien);
                donhangs.Add(donhang);
            }
            foreach (Donhang donhang in donhangs)
            {
                total_money += int.Parse(donhang.Dongia) * int.Parse(donhang.Soluong);
            }
            label11.Text = total_money.ToString();
            label13.Text= (total_money/10).ToString();
            dataGridView2.DataSource= null;
            dataGridView2.DataSource = donhangs;
            label3.Text = " ";
            numericUpDown1.Value = 0;
            textBox3.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i=dataGridView2.CurrentCell.RowIndex;
            donhangs.Remove(donhangs[i]);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = donhangs;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(donhangs.Count == 0)
            {
                MessageBox.Show("Không có hàng trong giỏ.");
                return;
            }
            string diachichitiet = textBox1.Text.ToString();
            string quan = textBox5.Text.ToString();
            string thanhpho = textBox6.Text.ToString();
            string madh=MenuDAO.Instance.DatHang1(chinhanh,makh,diachichitiet,quan,thanhpho);
            foreach(Donhang donhang in donhangs)
            {
                MenuDAO.Instance.ThemChiTietDonHang1(madh, chinhanh, donhang.Tenmon, donhang.Soluong, donhang.Tuychon);
            }
            string tongtien=label11.Text.ToString();
            int phivanchuyen = int.Parse(tongtien) / 10;
            
            MenuDAO.Instance.CapNhatDonHang(madh, tongtien, phivanchuyen.ToString());
            MessageBox.Show("Đặt hàng thành công");
            dataGridView2.DataSource = null;
            textBox1.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            label11.Text = "";
            label13.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "") MessageBox.Show("Giá tiền tìm kiếm rỗng!");
            else
            {
                DataSet ds = DataProvider.Instance.ExecuteQuery1("sp_SearchbyPrice '" + chinhanh + "'," + textBox4.Text);
                DataTable table1 = ds.Tables[0];
                DataTable table2 = ds.Tables[1];
                dataGridView1.DataSource = table1;
                textBox7.Text = table1.Rows[0]["SL"].ToString();
                dataGridView1.DataSource = table2;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
           
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            DataSet ds = DataProvider.Instance.ExecuteQuery1("sp_ReloadMenu '" + chinhanh + "'");
            DataTable table1 = ds.Tables[0];
            DataTable table2 = ds.Tables[1];
            dataGridView1.DataSource = table1;
            textBox7.Text = table1.Rows[0]["SL"].ToString();
            dataGridView1.DataSource = table2;
        }
    }
}
