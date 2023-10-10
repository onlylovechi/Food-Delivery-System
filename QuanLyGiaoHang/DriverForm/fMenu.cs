using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyGiaoHang.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using QuanLyGiaoHang.DTO;
using QuanLyGiaoHang.DAO;

namespace QuanLyGiaoHang
{
    public partial class fMenu : Form
    {
        public fMenu(string macn)
        {
            InitializeComponent();
            LoadMenuInfo(macn);
        }
        private void LoadMenuInfo(string macn)
        {
            dataGridView1.DataSource = MenuDAO.Instance.getData(macn);
            textBox6.Text = macn;
       }
        private void fMenu_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            MenuInfo menuInfo = new MenuInfo(row.Cells[0].ToString(), row.Cells[1].ToString(), row.Cells[2].ToString(), row.Cells[3].ToString());
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string macn = textBox6.Text;
            string tenmon = textBox1.Text;
            int result = DataProvider.Instance.ExecuteNonQuery("sp_DeleteFood '" + macn + "',N'" + tenmon + "'");
            if (result == 0) MessageBox.Show("Xóa thất bại!");
            else
            {
                MessageBox.Show("Xóa món ăn thành công!");
                LoadMenuInfo(macn);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string macn = textBox6.Text;
            string tenmon = textBox1.Text;
            List<MenuInfo> list = MenuDAO.Instance.getData(macn);
            
            foreach (MenuInfo info in list)
            {
                if(info.Tenmon==tenmon)
                {
                    if(info.Gia != textBox3.Text || info.Mieuta != textBox2.Text || info.TinhTrang != textBox4.Text)
                    {
                        string query = "sp_UpdateFood '" + macn + "',N'" + tenmon + "',N'" + textBox2.Text + "'," + textBox3.Text + ",N'" + textBox4.Text + "'";
                        if (textBox3.Text == "") query = "sp_UpdateFood '" + macn + "',N'" + tenmon + "',N'" + textBox2.Text + "'," + "null" + ",N'" + textBox4.Text + "'";
                        int result = DataProvider.Instance.ExecuteNonQuery(query);
                        if (result <= 0) MessageBox.Show("Cập nhật thất bại!");
                        else
                        {
                            MessageBox.Show("Cập nhật thông tin món thành công!");
                            LoadMenuInfo(macn);
                        }

                    }    
                }    
            }    
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string macn = textBox6.Text;
            string query = "sp_InsertFood N'" + textBox1.Text + "','" + macn + "',N'" + textBox2.Text + "'," + textBox3.Text + ",N'" + textBox4.Text + "',null";
            if (textBox3.Text == "") query = "sp_InsertFood N'" + textBox1.Text + "','" + macn + "',N'" + textBox2.Text + "'," + "null" + ",N'" + textBox4.Text + "',null";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            if (result <= 0) { MessageBox.Show("Thêm thất bại!");  }
            else
            {
                MessageBox.Show("Thêm món ăn thành công!");
                LoadMenuInfo(macn);

            }
            
        }
    }
}
