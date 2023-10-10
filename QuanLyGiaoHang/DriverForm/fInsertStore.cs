using QuanLyGiaoHang.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaoHang
{
    public partial class fInsertStore : Form
    {
        public static string MADT;
        public fInsertStore(string madt)
        {
            InitializeComponent();
            MADT = madt;
            
        }
        public string MaDT(string madt)
        {
            return madt;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fInsertStore_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("sp_InsertStore '" + MADT + "',N'" + textBox7.Text + "',N'" + textBox6.Text + "',N'" + textBox1.Text + "',N'" + textBox2.Text + "','" + textBox3.Text + "'");
            if (result <=0) { MessageBox.Show("Thêm chi nhánh thất bại! Hãy đảm bảo đủ thông tin!"); }
            else
            {
                DialogResult dlr = MessageBox.Show("Thêm chi nhánh thành công!");
                if (dlr == DialogResult.Yes)
                {

                }
            }

            
        
        }
    }
}
