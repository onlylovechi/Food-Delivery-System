using QuanLyGiaoHang.Module;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyGiaoHang.DAO;
using QuanLyGiaoHang.DTO;

namespace QuanLyGiaoHang.DAO
{
    internal class OrderInfoDAO
    {
        private static OrderInfoDAO instance;
        public static OrderInfoDAO Instance
        {
            get
            {
                if (instance == null) instance = new OrderInfoDAO();
                return OrderInfoDAO.instance;
            }
            private set { OrderInfoDAO.instance = value; }
        }

        private OrderInfoDAO() { }
        public List<OrderInfo1> GetListOrderInfo1(string madh)

        {
            List<OrderInfo1> list = new List<OrderInfo1>();

            DataTable dataTable = DataProvider.Instance.ExecuteQuery("exec sp_OrderInfo1 '" + madh + "'");
            foreach (DataRow dr in dataTable.Rows)
            {
                OrderInfo1 orderInfo = new OrderInfo1(dr);
                list.Add(orderInfo);
            }
            return list;
        }

        public List<OrderInfo> GetListOrderInfo(string madh)

        {
            List<OrderInfo> list = new List<OrderInfo>();

            DataTable dataTable = DataProvider.Instance.ExecuteQuery("exec sp_OrderInfo '" + madh + "'");
            foreach (DataRow dr in dataTable.Rows)
            {
                OrderInfo orderInfo = new OrderInfo(dr);
                list.Add(orderInfo);
            }
            return list;
        }
        public bool deleteOrder(string madh)
        {
            string query = "exec sp_HuyDonHang '" + madh + "'";
            int t=DataProvider.Instance.ExecuteNonQuery(query);
            if (t > 0)
            {
                MessageBox.Show("Huỷ đơn hàng thành công");
                return true;
            }
            MessageBox.Show("Huỷ đơn hàng không thành công");
            return false;
        }
    }
}
