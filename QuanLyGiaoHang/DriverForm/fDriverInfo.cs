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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyGiaoHang
    
{
    
    public partial class fDriverInfo : Form
    {
        public static string MATX;
        public fDriverInfo(string matx)

        {
            MATX = matx;
            InitializeComponent();
            LoadDriverInfo(matx);
        }
        private void LoadDriverInfo(string matx)
        {
            textBox1.Text = DataProvider.Instance.ExecuteScalar("select MaTX from TAIXE where MaTX='"+ matx + "'");
            textBox2.Text = DataProvider.Instance.ExecuteScalar("select HoTen from TAIXE where MaTX='"+ matx + "'");
            textBox6.Text = DataProvider.Instance.ExecuteScalar("select SDT from TAIXE where MaTX='"+ matx + "'");
            textBox9.Text = DataProvider.Instance.ExecuteScalar("select CMND from TAIXE where MaTX='"+ matx + "'");
            textBox10.Text = DataProvider.Instance.ExecuteScalar("select DiaChi from TAIXE where MaTX='"+ matx + "'");
            textBox11.Text = DataProvider.Instance.ExecuteScalar("select BienSoXe from TAIXE where MaTX='"+ matx + "'");
            textBox12.Text = DataProvider.Instance.ExecuteScalar("select Email from TAIXE where MaTX='"+ matx + "'");
            textBox16.Text = DataProvider.Instance.ExecuteScalar("select TPHoatDong from TAIXE where MaTX='"+ matx + "'");
            textBox15.Text = DataProvider.Instance.ExecuteScalar("select QuanHoatDong from TAIXE where MaTX='"+ matx + "'");
            textBox8.Text = DataProvider.Instance.ExecuteScalar("select NganHang from TAIXE where MaTX='"+ matx + "'");
            textBox7.Text = DataProvider.Instance.ExecuteScalar("select STK from TAIXE where MaTX='"+ matx + "'");

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string madonhang;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == "" ||
            textBox6.Text == "" ||
            textBox9.Text == "" ||
            textBox10.Text == "" ||
            textBox11.Text == "" ||
            textBox12.Text == "" ||
            textBox16.Text == "" ||
            textBox15.Text == "" ||
            textBox8.Text == "" ||
            textBox7.Text == "" )

            {
                MessageBox.Show("Thông tin không được để trống!");
            }
            else if(textBox2.Text != DataProvider.Instance.ExecuteScalar("select HoTen from TAIXE where MaTX='"+ MATX + "'") ||
            textBox6.Text != DataProvider.Instance.ExecuteScalar("select SDT from TAIXE where MaTX='" + MATX + "'") ||
            textBox9.Text != DataProvider.Instance.ExecuteScalar("select CMND from TAIXE where MaTX='"+ MATX + "'")||
            textBox10.Text != DataProvider.Instance.ExecuteScalar("select DiaChi from TAIXE where MaTX='"+ MATX + "'")||
            textBox11.Text != DataProvider.Instance.ExecuteScalar("select BienSoXe from TAIXE where MaTX='"+ MATX + "'")||
            textBox12.Text != DataProvider.Instance.ExecuteScalar("select Email from TAIXE where MaTX='"+ MATX + "'")||
            textBox16.Text != DataProvider.Instance.ExecuteScalar("select TPHoatDong from TAIXE where MaTX='"+ MATX + "'")||
            textBox15.Text != DataProvider.Instance.ExecuteScalar("select QuanHoatDong from TAIXE where MaTX='"+ MATX + "'")||
            textBox8.Text != DataProvider.Instance.ExecuteScalar("select NganHang from TAIXE where MaTX='"+ MATX + "'")||
            textBox7.Text != DataProvider.Instance.ExecuteScalar("select STK from TAIXE where MaTX='"+ MATX + "'"))
                {
                string query = "sp_UpdateDriverInfo 'TX001',N'" + textBox2.Text + "','" + textBox6.Text + "','" + textBox9.Text + "',N'" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text +"','"
                    + textBox8.Text + "','" + textBox7.Text + "',N'" + textBox16.Text + "',N'" + textBox15.Text + "'";
                int result =DataProvider.Instance.ExecuteNonQuery(query);
                MessageBox.Show("Cập nhật thông tin thành công!");
            }
            LoadDriverInfo(MATX);
        }

        private void fDriverInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
