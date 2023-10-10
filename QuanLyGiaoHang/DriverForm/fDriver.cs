using QuanLyGiaoHang.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyGiaoHang.DAO;
using QuanLyGiaoHang.DTO;
using QuanLyGiaoHang.Module;

namespace QuanLyGiaoHang
{
    public partial class fDriver : Form
    {
        public static string MATX;
        public fDriver(string matx)
        {
            InitializeComponent();
            MATX = matx;
            LoadOrder();
            LoadReceivedOrder();
            LoadDeliveringOrder();
            LoadDeliveredOrder();
            
        }
        
        void LoadOrder()
        {
            flowLayoutPanel1.Controls.Clear();
            List<Order> orderList = OrderDAO.Instance.LoadOrderList(MATX);
            foreach(Order order in orderList)
            {

                Button button = new Button()
                {
                    Width = (int) OrderDAO.OrderWidth,
                    Height = (int) OrderDAO.OrderHeight,
                };
                button.Text = order.MaDH;
                flowLayoutPanel1.Controls.Add(button);
                button.Click += Button_Click;
                button.Tag = order;
                
                }    

        }
        void LoadReceivedOrder()
        {
            flowLayoutPanel2.Controls.Clear();
            List<Order> orderList = OrderDAO.Instance.LoadReceivedOrderList(MATX);
            foreach (Order order in orderList)
            {

                Button button = new Button()
                {
                    Width = (int)OrderDAO.OrderWidth,
                    Height = (int)OrderDAO.OrderHeight,
                };
                button.Text = order.MaDH;
                flowLayoutPanel2.Controls.Add(button);
                button.Click += Button_Click1;
                button.Tag = order;

            }

        }
        void LoadDeliveringOrder()
        {
            flowLayoutPanel3.Controls.Clear();
            CultureInfo culture = new CultureInfo("vi-VN");
            textBox14.Text = 0.ToString("c",culture);
            textBox15.Text = 0.ToString("c", culture);
            textBox13.Text = 0.ToString("c", culture);
            List<Order> orderList = OrderDAO.Instance.LoadDeliveringOrderList(MATX);
            foreach (Order order in orderList)
            {
                
                Button button = new Button()
                {
                    Width = (int)OrderDAO.OrderWidth,
                    Height = (int)OrderDAO.OrderHeight,
                };
                button.Text = order.MaDH;
                flowLayoutPanel3.Controls.Add(button);
                button.Click += Button_Click2;
                button.Tag = order;
                
            }
            

        }
        void LoadDeliveredOrder()
        {
            flowLayoutPanel4.Controls.Clear();
            CultureInfo culture = new CultureInfo("vi-VN");
            textBox21.Text = 0.ToString("c", culture);
            textBox20.Text = 0.ToString("c", culture);
            textBox22.Text = 0.ToString("c", culture);
            List<Order> orderList = OrderDAO.Instance.LoadDeliveredOrderList(MATX);
            foreach (Order order in orderList)
            {

                Button button = new Button()
                {
                    Width = (int)OrderDAO.OrderWidth,
                    Height = (int)OrderDAO.OrderHeight,
                };
                button.Text = order.MaDH;
                flowLayoutPanel4.Controls.Add(button);
                button.Click += Button_Click3;
                button.Tag = order;
                
            }


        }

        private void Button_Click3(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            string madh = ((sender as Button).Tag as Order).MaDH;
            textBox19.Text = ((sender as Button).Tag as Order).MaDH.ToString();
            textBox18.Text = ((sender as Button).Tag as Order).NameStore.ToString();
            textBox17.Text = ((sender as Button).Tag as Order).AddressFrom.ToString();
            textBox16.Text = ((sender as Button).Tag as Order).AddressTo.ToString();
            textBox21.Text = ((sender as Button).Tag as Order).Shippingfee.ToString("c", culture);
            textBox20.Text = ((sender as Button).Tag as Order).Price.ToString("c", culture);
            ShowDeliveredOrderInfo(madh);
        }

        private void Button_Click2(object sender, EventArgs e)
        {
            string madh = ((sender as Button).Tag as Order).MaDH;
            textBox12.Text = ((sender as Button).Tag as Order).MaDH.ToString();
            textBox11.Text = ((sender as Button).Tag as Order).NameStore.ToString();
            textBox10.Text = ((sender as Button).Tag as Order).AddressFrom.ToString();
            textBox9.Text = ((sender as Button).Tag as Order).AddressTo.ToString();
            
            ShowDeliveringOrderInfo(madh);
        }

        private void Button_Click1(object sender, EventArgs e)
        {
            string madh = ((sender as Button).Tag as Order).MaDH;
            textBox8.Text = ((sender as Button).Tag as Order).MaDH.ToString();
            textBox7.Text = ((sender as Button).Tag as Order).NameStore.ToString();
            textBox6.Text = ((sender as Button).Tag as Order).AddressFrom.ToString();
            textBox5.Text = ((sender as Button).Tag as Order).AddressTo.ToString();
            ShowReceivedOrderInfo(madh);
        }

        void ShowOrderInfo(string madh)
        {
            listView1.Items.Clear();
            int i = 0;
            List<OrderInfo> orderInfos = OrderInfoDAO.Instance.GetListOrderInfo(madh);
            foreach(OrderInfo info in orderInfos)
            {
                ListViewItem listViewItem = new ListViewItem(info.Foodname.ToString());
                listViewItem.SubItems.Add(info.Count.ToString());
                listViewItem.SubItems.Add(info.Price.ToString());
                listViewItem.SubItems.Add(info.TotalPrice.ToString());
                listViewItem.SubItems.Add(info.TotalPrice.ToString());
                i++; listViewItem.SubItems.Add(i.ToString());
                listView1.Items.Add(listViewItem);
               
            }    
        }
        void ShowReceivedOrderInfo(string madh)
        {
            listView3.Items.Clear();
            List<OrderInfo> orderInfos = OrderInfoDAO.Instance.GetListOrderInfo(madh);
            int i = 0;
            foreach (OrderInfo info in orderInfos)
            {
                ListViewItem listViewItem = new ListViewItem(info.Foodname.ToString());
                listViewItem.SubItems.Add(info.Count.ToString());
                listViewItem.SubItems.Add(info.Price.ToString());
                listViewItem.SubItems.Add(info.TotalPrice.ToString());
                listViewItem.SubItems.Add(info.TotalPrice.ToString());
                i++; listViewItem.SubItems.Add(i.ToString());
                listView3.Items.Add(listViewItem);


            }
        }
        void ShowDeliveringOrderInfo(string madh)
        {
            listView4.Items.Clear();
            CultureInfo culture = new CultureInfo("vi-VN");
            List<OrderInfo> orderInfos = OrderInfoDAO.Instance.GetListOrderInfo(madh);
            int sumtotalprice = 0;
            int i = 0;
            foreach (OrderInfo info in orderInfos)
            {
                sumtotalprice += (int) info.TotalPrice;
                ListViewItem listViewItem = new ListViewItem(info.Foodname.ToString());
                listViewItem.SubItems.Add(info.Count.ToString());
                listViewItem.SubItems.Add(info.Price.ToString());
                listViewItem.SubItems.Add(info.TotalPrice.ToString());
                listViewItem.SubItems.Add(info.TotalPrice.ToString());
                i++; listViewItem.SubItems.Add(i.ToString());
                listView4.Items.Add(listViewItem);


            }
            textBox13.Text = sumtotalprice.ToString("c", culture);

        }
        void ShowDeliveredOrderInfo(string madh)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            listView2.Items.Clear();
            List<OrderInfo> orderInfos = OrderInfoDAO.Instance.GetListOrderInfo(madh);
            int sumtotalprice = 0;
            int i = 0;
            foreach (OrderInfo info in orderInfos)
            {
                sumtotalprice += (int)info.TotalPrice;
                ListViewItem listViewItem = new ListViewItem(info.Foodname.ToString());
                listViewItem.SubItems.Add(info.Count.ToString());
                listViewItem.SubItems.Add(info.Price.ToString());
                listViewItem.SubItems.Add(info.TotalPrice.ToString());
                i++;
                listViewItem.SubItems.Add(i.ToString());
                listView2.Items.Add(listViewItem);


            }
            textBox22.Text = sumtotalprice.ToString("c", culture);

        }
        private void Button_Click(object sender, EventArgs e)
        {
            string madh = ((sender as Button).Tag as Order).MaDH;
            textBox1.Text = ((sender as Button).Tag as Order).MaDH.ToString();
            textBox2.Text = ((sender as Button).Tag as Order).NameStore.ToString();
            textBox3.Text = ((sender as Button).Tag as Order).AddressFrom.ToString();
            textBox4.Text = ((sender as Button).Tag as Order).AddressTo.ToString();
            ShowOrderInfo(madh);
        }

        
        private void tàiXếToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fDriver_Load(object sender, EventArgs e)
        {

        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThuNhap fthunhap = new fThuNhap(MATX);
            this.Hide();
            fthunhap.ShowDialog();
            this.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string madh = ((sender as Button).Tag as Order).MaDH.ToString();
            string madh = textBox1.Text;
            int result = DataProvider.Instance.ExecuteNonQuery("exec sp_TaiXeNhanDon '"+ MATX+ "','" + madh + "'");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            listView1.Items.Clear();
            LoadOrder();
            LoadReceivedOrder();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string madh = textBox8.Text;
            int result = DataProvider.Instance.ExecuteNonQuery("exec sp_TaiXeDangGiao '"+MATX+"','" + madh + "'");
            textBox8.Text = "";
            textBox7.Text = "";
            textBox6.Text = "";
            textBox5.Text = "";
            listView3.Items.Clear();
            LoadReceivedOrder();
            LoadDeliveringOrder();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string madh = textBox12.Text;
            int result = DataProvider.Instance.ExecuteNonQuery("exec sp_TaiXeDaGiao '" + MATX + "','" + madh + "'");
            textBox12.Text = "";
            textBox11.Text = "";
            textBox10.Text = "";
            textBox9.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            listView4.Items.Clear();
            LoadDeliveringOrder();
            LoadDeliveredOrder();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinTàiKhoảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void đơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string madh = textBox19.Text;
            int result = DataProvider.Instance.ExecuteNonQuery("exec sp_TaiXeDaGiao '" + MATX + "','" + madh + "'");
            textBox19.Text = "";
            textBox18.Text = "";
            textBox17.Text = "";
            textBox16.Text = "";
            textBox20.Text = "";
            textBox21.Text = "";
            textBox22.Text = "";
            listView4.Items.Clear();
            LoadDeliveringOrder();
        }

        private void thôngTinCáNhânToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fDriverInfo form = new fDriverInfo(MATX);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
