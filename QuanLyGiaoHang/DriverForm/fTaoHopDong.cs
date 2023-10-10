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
    public partial class fTaoHopDong : Form
    {
        public static string MADT;
        public static List<string> strings = new List<string>();
        
        public fTaoHopDong(string madt)
        {
            InitializeComponent();
            MADT = madt;
            LoadComboBox(madt);
        }
        public void LoadComboBox(string madt)
        {
            List<Store> list = StoreDAO.Instance.LoadStoreList(madt);
            List<String> strings = new List<String>();
            //foreach(Store s in list)
            //{
            //    if (s.Madt == madt) comboBox1.Items.Add(s.MACN);

            //}
            comboBox1.DataSource = list;
            comboBox1.DisplayMember="MaCN";

        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox6.Text =="" || textBox1.Text ==""||textBox7.Text==""||textBox8.Text=="" ||strings.Count==0)
            {
                MessageBox.Show("Thông tin không được bỏ trống", "Thông báo");
            }
            else {
                string chuoi = "";
                {
                    for (int i = 0; i < strings.Count; i++)
                    {
                        if (i == strings.Count - 1) chuoi +=strings[i];
                        else
                        {
                            chuoi += strings[i] + ",";
                        } 
                            
                    } }
                int result = DataProvider.Instance.ExecuteNonQuery("exec sp_TaoHopDong '" + MADT + "',N'" + textBox6.Text + "','" + textBox1.Text + "','" + textBox7.Text + "','" + textBox8.Text + "'," + textBox2.Text+",'"+chuoi+"'");

                MessageBox.Show("Tạo hợp đồng mới thành công!", "Thông báo");
                
            } 
                
        }

        private void fTaoHopDong_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int tam = 0;
            for (int i = 0; i < strings.Count; i++)
            {
                if (comboBox1.Text == strings[i]) tam++;
            }
            //if (tam == 0) strings.Add(comboBox1.ValueMember);
            if (tam ==0) {listBox1.Items.Add(comboBox1.Text); strings.Add(comboBox1.Text);}
            textBox2.Text = strings.Count.ToString();
            //listBox1.DataSource = strings;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(comboBox1.Text);
            strings.Remove(comboBox1.Text);
            textBox2.Text = strings.Count.ToString();
        }
    }
}
