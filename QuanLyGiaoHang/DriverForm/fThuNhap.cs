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
using QuanLyGiaoHang.DTO;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyGiaoHang
{
    public partial class fThuNhap : Form
    {
        public static string MATX;
        public fThuNhap(string matx)
        {
           
            InitializeComponent();
            MATX = matx;
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("vi-VN");

            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi_VN");

            CultureInfo culture = new CultureInfo("vi-VN");

            
            textBox1.Text = 0.ToString("c", culture);

            
        }
        void loadThongKe()
        {
            listView1.Items.Clear();
            //string dateFrom = "2022/5/10";
            //string dateTo = "2022/12/12";
            
            string dateFrom = dateTimePicker1.Value.Date.Year.ToString() + "/" + dateTimePicker1.Value.Date.Month.ToString() + "/" + dateTimePicker1.Value.Date.Day.ToString();
            string dateTo = dateTimePicker2.Value.Date.Year.ToString() + "/" + dateTimePicker2.Value.Date.Month.ToString() + "/" + dateTimePicker2.Value.Date.Day.ToString();
            List<Order> list = OrderDAO.Instance.LoadThuNhapList(MATX,dateFrom,dateTo);
            int totalThuNhap = 0;
            int i = 0;
            foreach (Order info in list)
            {
                
            ListViewItem listViewItem = new ListViewItem(info.MaDH.ToString());
                totalThuNhap += (int) info.Shippingfee;
            listViewItem.SubItems.Add(info.Shippingfee.ToString());
                string[] listItems = info.DateOrder.ToString().Split(' ');
                listViewItem.SubItems.Add(listItems[0]);
                i++;
                listViewItem.SubItems.Add(i.ToString());
            listView1.Items.Add(listViewItem);
            

            }
            CultureInfo culture = new CultureInfo("vi-VN");
            textBox1.Text = totalThuNhap.ToString("c", culture);

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadThongKe();
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fThuNhap_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
