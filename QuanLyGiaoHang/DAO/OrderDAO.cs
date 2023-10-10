using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyGiaoHang.DTO;

namespace QuanLyGiaoHang.DAO
{
    public class OrderDAO
    {

        private static OrderDAO instance;
        public static OrderDAO Instance
        {
            get { if(instance == null) instance = new OrderDAO(); 
                return OrderDAO.instance; }
            private set { OrderDAO.instance = value; }
        }
        public static double OrderWidth = 80;
        public static double OrderHeight = 80;
        private OrderDAO() { }
        public List<Order> LoadOrderList(string matx)
        {
            List<Order> list = new List<Order>();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("sp_OrderList '"+ matx + "'");


            foreach(DataRow row in dataTable.Rows)
            {
                Order order = new Order(row);
                list.Add(order);
            }    


            return list;
        }
        public List<Order> LoadReceivedOrderList(string matx)
        {
            List<Order> list = new List<Order>();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("exec sp_ReceivedOrderList '"+ matx + "'");


            foreach (DataRow row in dataTable.Rows)
            {
                Order order = new Order(row);
                list.Add(order);
            }


            return list;
        }
        public List<Order> LoadDeliveringOrderList(string matx)
        {
            List<Order> list = new List<Order>();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("exec sp_DeliveringOrderList '"+ matx + "'");


            foreach (DataRow row in dataTable.Rows)
            {
                Order order = new Order(row);
                list.Add(order);
            }


            return list;
        }
        public List<Order> LoadDeliveringOrderList_DT(string madt)
        {
            List<Order> list = new List<Order>();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("exec sp_DT_OrderDeliveringList '" + madt+"'");


            foreach (DataRow row in dataTable.Rows)
            {
                Order order = new Order(row);
                list.Add(order);
            }


            return list;
        }
        public List<Order> LoadDeliveredOrderList_DT(string matx)
        {
            List<Order> list = new List<Order>();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("exec sp_DT_OrderDeliveredList '" + matx + "'");


            foreach (DataRow row in dataTable.Rows)
            {
                Order order = new Order(row);
                list.Add(order);
            }


            return list;
        }

        public List<Order> LoadDeliveredOrderList(string matx)
        {
            List<Order> list = new List<Order>();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("exec sp_DeliveredOrderList '" + matx + "'");


            foreach (DataRow row in dataTable.Rows)
            {
                Order order = new Order(row);
                list.Add(order);
            }


            return list;
        }
        public List<Order> LoadThuNhapList(string matx,string dateFrom, string dateTo)
        {
            List<Order> list = new List<Order>();
            string query = "exec sp_ThuNhap '" + dateFrom + "','" + dateTo + "','" + matx + "'";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            
            foreach (DataRow row in dataTable.Rows)
            {
                Order order = new Order(row);
                list.Add(order);
            }


            return list;
        }
        public List<Order> LoadWaitingOrdeList(string madt)
        {
            List<Order> list = new List<Order>();
            string query = "exec sp_WaititngOrderList '" +  madt+ "'";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);


            foreach (DataRow row in dataTable.Rows)
            {
                Order order = new Order(row);
                list.Add(order);
            }


            return list;
        }
    }
}
