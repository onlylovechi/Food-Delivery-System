using QuanLyGiaoHang.DAO;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using QuanLyGiaoHang.Module;

namespace QuanLyGiaoHang
{
    public partial class fXuLyDonHang : Form
    {
        public static string MADT;
        public fXuLyDonHang(string madt)
        {
            MADT = madt;
            InitializeComponent();
            LoadWaitingOrder();
            LoadDeliveringOrder();
            LoadDeliveredOrder();
        }
        void LoadWaitingOrder()
        {
            flowLayoutPanel3.Controls.Clear();
            CultureInfo culture = new CultureInfo("vi-VN");
            textBox14.Text = 0.ToString("c", culture);
            textBox15.Text = 0.ToString("c", culture);
            textBox13.Text = 0.ToString("c", culture);
            List<Order> orderList = OrderDAO.Instance.LoadWaitingOrdeList(MADT);
            foreach (Order order in orderList)
            {

                Button button = new Button()
                {
                    Width = (int)OrderDAO.OrderWidth,
                    Height = (int)OrderDAO.OrderHeight,
                };
                button.Text = order.MaDH;
                flowLayoutPanel3.Controls.Add(button);
                button.Click += Button_Click; ;
                button.Tag = order;

            }


        }
        void LoadDeliveringOrder()
        {
            flowLayoutPanel1.Controls.Clear();
            CultureInfo culture = new CultureInfo("vi-VN");
            textBox7.Text = 0.ToString("c", culture);
            textBox6.Text = 0.ToString("c", culture);
            textBox5.Text = 0.ToString("c", culture);
            List<Order> orderList = OrderDAO.Instance.LoadDeliveringOrderList_DT(MADT);
            foreach (Order order in orderList)
            {

                Button button = new Button()
                {
                    Width = (int)OrderDAO.OrderWidth,
                    Height = (int)OrderDAO.OrderHeight,
                };
                button.Text = order.MaDH;
                flowLayoutPanel1.Controls.Add(button);
                button.Click += Button_Click1;
                button.Tag = order;

            }


        }
        void LoadDeliveredOrder()
        {
            flowLayoutPanel2.Controls.Clear();
            CultureInfo culture = new CultureInfo("vi-VN");
            textBox25.Text = 0.ToString("c", culture);
            textBox26.Text = 0.ToString("c", culture);
            textBox27.Text = 0.ToString("c", culture);
            List<Order> orderList = OrderDAO.Instance.LoadDeliveredOrderList_DT(MADT);
            foreach (Order order in orderList)
            {

                Button button = new Button()
                {
                    Width = (int)OrderDAO.OrderWidth,
                    Height = (int)OrderDAO.OrderHeight,
                };
                button.Text = order.MaDH;
                flowLayoutPanel2.Controls.Add(button);
                button.Click += Button_Click2;
                button.Tag = order;

            }


        }

        private void Button_Click2(object sender, EventArgs e)
        {
            
            string madh = ((sender as Button).Tag as Order).MaDH;
            textBox21.Text = ((sender as Button).Tag as Order).MaDH.ToString();
            textBox20.Text = ((sender as Button).Tag as Order).NameStore.ToString();
            textBox19.Text = ((sender as Button).Tag as Order).AddressFrom.ToString();
            textBox18.Text = ((sender as Button).Tag as Order).AddressTo.ToString();
            textBox17.Text = ((sender as Button).Tag as Order).Matx.ToString();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("select * from TAIXE");
            int i = 0;
            while (i < dataTable.Rows.Count)
            {
                if (dataTable.Rows[i]["MaTX"].ToString() == ((sender as Button).Tag as Order).Matx.ToString())
                { textBox16.Text = dataTable.Rows[i]["SDT"].ToString(); break; }
                i++;
            }
            ShowDeliveredOrderInfo(madh);
        }

        private void Button_Click1(object sender, EventArgs e)
        {
            string madh = ((sender as Button).Tag as Order).MaDH;
            textBox4.Text = ((sender as Button).Tag as Order).MaDH.ToString();
            textBox3.Text = ((sender as Button).Tag as Order).NameStore.ToString();
            textBox2.Text = ((sender as Button).Tag as Order).AddressFrom.ToString();
            textBox1.Text = ((sender as Button).Tag as Order).AddressTo.ToString();
            textBox22.Text = ((sender as Button).Tag as Order).Matx.ToString();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("select * from TAIXE");
            int i = 0;
            while (i<dataTable.Rows.Count)
            {
                if (dataTable.Rows[i]["MaTX"].ToString() == ((sender as Button).Tag as Order).Matx.ToString())
                { textBox23.Text = dataTable.Rows[i]["SDT"].ToString(); break; }
                i++;
            }    
            ShowDeliveringOrderInfo(madh);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            string madh = ((sender as Button).Tag as Order).MaDH;
            textBox30.Text = ((sender as Button).Tag as Order).MaDH.ToString();
            textBox29.Text = ((sender as Button).Tag as Order).NameStore.ToString();
            textBox28.Text = ((sender as Button).Tag as Order).AddressFrom.ToString();
            textBox27.Text = ((sender as Button).Tag as Order).AddressTo.ToString();
            textBox13.Text = ((sender as Button).Tag as Order).Shippingfee.ToString();
            ShowDeliveringOrderInfo(madh);
        }
        void ShowDeliveringOrderInfo(string madh)
        {
            listView1.Items.Clear();
            CultureInfo culture = new CultureInfo("vi-VN");
            List<OrderInfo> orderInfos = OrderInfoDAO.Instance.GetListOrderInfo(madh);
            
            int sumtotalprice = 0;
            int i = 0;
            foreach (OrderInfo info in orderInfos)
            {
                i++;
                sumtotalprice += (int)info.TotalPrice;
                ListViewItem listViewItem = new ListViewItem(info.Foodname.ToString());
                listViewItem.SubItems.Add(info.Count.ToString());
                listViewItem.SubItems.Add(info.Price.ToString());
                listViewItem.SubItems.Add(i.ToString());
                 listViewItem.SubItems.Add(info.TotalPrice.ToString());
                listView1.Items.Add(listViewItem);


            }
            textBox5.Text = sumtotalprice.ToString("c", culture);
            textBox7.Text = sumtotalprice.ToString("c", culture);
        }
        void ShowDeliveredOrderInfo(string madh)
        {
            listView2.Items.Clear();
            CultureInfo culture = new CultureInfo("vi-VN");
            List<OrderInfo> orderInfos = OrderInfoDAO.Instance.GetListOrderInfo(madh);
            int sumtotalprice = 0;
            int i = 0;
            foreach (OrderInfo info in orderInfos)
            {
                i++;
                sumtotalprice += (int)info.TotalPrice;
                ListViewItem listViewItem = new ListViewItem(info.Foodname.ToString());
                listViewItem.SubItems.Add(info.Count.ToString());
                listViewItem.SubItems.Add(info.Price.ToString());
                listViewItem.SubItems.Add(i.ToString());
                listViewItem.SubItems.Add(info.TotalPrice.ToString());
                listView2.Items.Add(listViewItem);


            }
            textBox27.Text = sumtotalprice.ToString("c", culture);
            textBox25.Text = sumtotalprice.ToString("c", culture);
        }
        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string madh = textBox12.Text;
            int result = DataProvider.Instance.ExecuteNonQuery("exec sp_DonHangDaXuLi '" + madh + "'");
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            listView4.Items.Clear();
            LoadWaitingOrder();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void fXuLyDonHang_Load(object sender, EventArgs e)
        {

        }
    }
}
