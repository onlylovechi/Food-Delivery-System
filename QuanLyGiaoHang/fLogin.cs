using QuanLyGiaoHang.DAO;
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
using QuanLyGiaoHang.DAO;

namespace QuanLyGiaoHang
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        public static string name = "";
        public static string pass = "";
        public static string type = "";
        public static string id="";
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(text_tk.Text)
               || String.IsNullOrWhiteSpace(text_mk.Text))
            {
                MessageBox.Show("Tài khoản và mặt khẩu không được để trông!");
                return;
            }
            name = text_tk.Text.ToString();
           
            pass = text_mk.Text.ToString();
            type=comboBox1.Text.ToString();
            int flag = AccountDAO.Instance.login(name,pass,type);
            if (flag == 1 && type.Equals("Khách hàng"))
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
                DanhSachDoiTac danhSachDoiTac = new DanhSachDoiTac();
                danhSachDoiTac.ShowDialog();
                this.Show();
            }
            else if (flag == 1 && type.Equals("Đối tác"))
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
                fDoitac form = new fDoitac(AccountDAO.id);
                form.ShowDialog();
                this.Show();
            }
           
            
            else   if (flag == 1 && type.Equals("Tài xế"))
                {
                    MessageBox.Show("Đăng nhập thành công");
                    this.Hide();
                    fDriver form = new fDriver(AccountDAO.id);
                    form.ShowDialog();
                    this.Show();
                }
            else if (flag == 1 && type.Equals("Nhân viên"))
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
                NhanVien form = new NhanVien();
                form.ShowDialog();
                this.Show();
            }
            else {
                MessageBox.Show("Thông tin đăng nhập không đúng");
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
            

        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát?","Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            fRegister_KhachHang register=new fRegister_KhachHang();
            this.Hide();
            register.ShowDialog();
            this.Show();
        }
    }
}
