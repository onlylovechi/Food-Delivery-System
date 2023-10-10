using QuanLyGiaoHang.DAO;
using QuanLyGiaoHang.DTO;
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

namespace QuanLyGiaoHang
{
    public partial class fXemDonHang : Form
    {
        private List<ListOrder> listOrders;
        private List<ListOrder> recieved;
        private List<ListOrder> delivering;
        private List<ListOrder> delivered;
        public fXemDonHang()
        {
            listOrders = CustomerDAO.Instance.OrderList();
            recieved = CustomerDAO.Instance.LoadReceivedListOrderList();
            delivering = CustomerDAO.Instance.LoadDeliveringListOrderList();
            delivered = CustomerDAO.Instance.LoadDeliveredListOrderList();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            listView1.Items.Clear();
            int tongtien = 0;
            int i = dataGridView1.CurrentCell.RowIndex;
            textBox1.Text = listOrders[i].Madh;
            textBox2.Text = listOrders[i].Macn;
            string diachi = CustomerDAO.Instance.LayDiaChi(listOrders[i].Madh);
            textBox4.Text = diachi;
            
            List<OrderInfo1> list=OrderInfoDAO.Instance.GetListOrderInfo1(listOrders[i].Madh);
            foreach(OrderInfo1 info in list)
            {
                ListViewItem listView = new ListViewItem(info.Foodname.ToString());
                listView.SubItems.Add(info.Count.ToString());
                listView.SubItems.Add(info.Price.ToString());
                listView.SubItems.Add(info.TotalPrice.ToString());
                listView1.Items.Add(listView);
                tongtien += info.TotalPrice;
            }
            

            int vanchuyen = tongtien / 10;
            textBox26.Text = tongtien.ToString();
            textBox25.Text = vanchuyen.ToString();
            textBox24.Text = (tongtien + vanchuyen).ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            listView3.Items.Clear();
            int tongtien = 0;
            int i = dataGridView2.CurrentCell.RowIndex;
            textBox8.Text = recieved[i].Madh.ToString();
            textBox7.Text = recieved[i].Macn.ToString();
            string diachi = CustomerDAO.Instance.LayDiaChi(recieved[i].Madh);
            textBox5.Text = diachi;

            List<OrderInfo> list = OrderInfoDAO.Instance.GetListOrderInfo(recieved[i].Madh);
            foreach (OrderInfo info in list)
            {
                ListViewItem listView = new ListViewItem(info.Foodname.ToString());
                listView.SubItems.Add(info.Count.ToString());
                listView.SubItems.Add(info.Price.ToString());
                listView.SubItems.Add(info.TotalPrice.ToString());
                listView3.Items.Add(listView);
                tongtien += info.TotalPrice;
            }
            int vanchuyen = tongtien / 10;
            textBox23.Text = tongtien.ToString();
            textBox16.Text = vanchuyen.ToString();
            textBox3.Text = (tongtien + vanchuyen).ToString();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            listView4.Items.Clear();
            int tongtien = 0;
            int i = dataGridView3.CurrentCell.RowIndex;
            textBox12.Text = delivering[i].Madh.ToString();
            textBox11.Text = delivering[i].Macn.ToString();
            string diachi = CustomerDAO.Instance.LayDiaChi(delivering[i].Madh);
            textBox9.Text = diachi;

            List<OrderInfo> list = OrderInfoDAO.Instance.GetListOrderInfo(delivering[i].Madh);
            foreach (OrderInfo info in list)
            {
                ListViewItem listView = new ListViewItem(info.Foodname.ToString());
                listView.SubItems.Add(info.Count.ToString());
                listView.SubItems.Add(info.Price.ToString());
                listView.SubItems.Add(info.TotalPrice.ToString());
                listView4.Items.Add(listView);
                tongtien += info.TotalPrice;
            }
            int vanchuyen = tongtien / 10;
            textBox13.Text = tongtien.ToString();
            textBox14.Text = vanchuyen.ToString();
            textBox15.Text = (tongtien + vanchuyen).ToString();
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            listView2.Items.Clear();
            int tongtien = 0;
            int i = dataGridView4.CurrentCell.RowIndex;
            textBox19.Text = delivered[i].Madh;
            textBox18.Text = delivered[i].Macn;
            string diachi = CustomerDAO.Instance.LayDiaChi(delivering[i].Madh);
            textBox17.Text = diachi;

            List<OrderInfo> list = OrderInfoDAO.Instance.GetListOrderInfo(listOrders[i].Madh);
            foreach (OrderInfo info in list)
            {
                ListViewItem listView = new ListViewItem(info.Foodname.ToString());
                listView.SubItems.Add(info.Count.ToString());
                listView.SubItems.Add(info.Price.ToString());
                listView.SubItems.Add(info.TotalPrice.ToString());
                listView2.Items.Add(listView);
                tongtien += info.TotalPrice;
            }
            int vanchuyen = tongtien / 10;
            textBox22.Text = tongtien.ToString();
            textBox21.Text = vanchuyen.ToString();
            textBox20.Text = (tongtien + vanchuyen).ToString();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentCell.RowIndex;
            string madh = listOrders[i].Madh;
            OrderInfoDAO.Instance.deleteOrder(madh);
            listOrders = CustomerDAO.Instance.OrderList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listOrders;
            textBox1.Text = "";
            textBox2.Text="";textBox4.Text=""; textBox26.Text = " ";textBox25.Text = "";textBox24.Text = "";
            
        }

        private void fXemDonHang_Load_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = listOrders;
            dataGridView2.DataSource = recieved;
            dataGridView3.DataSource = delivering;
            dataGridView4.DataSource = delivered;
        }
    }
}
