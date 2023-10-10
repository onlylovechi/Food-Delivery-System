using QuanLyGiaoHang.Module;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyGiaoHang.DAO;

namespace QuanLyGiaoHang.DAO
{
    internal class CustomerDAO
    {
        private static CustomerDAO instance;
        public static CustomerDAO Instance
        {
            get
            {
                if (instance == null) instance = new CustomerDAO();
                return CustomerDAO.instance;
            }
            private set { CustomerDAO.instance = value; }
        }
        private CustomerDAO() { }

        public List<ListOrder> OrderList()
        {
            List<ListOrder> list = new List<ListOrder>();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("exec sp_customer_orderlist 'KH001'");


            foreach (DataRow row in dataTable.Rows)
            {
                ListOrder ListOrder = new ListOrder(row);
                list.Add(ListOrder);
            }


            return list;
        }
        public List<ListOrder> LoadReceivedListOrderList()
        {
            List<ListOrder> list = new List<ListOrder>();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("exec sp_customer_ReceivedListOrderList 'KH001'");


            foreach (DataRow row in dataTable.Rows)
            {
                ListOrder ListOrder = new ListOrder(row);
                list.Add(ListOrder);
            }


            return list;
        }
        public List<ListOrder> LoadDeliveringListOrderList()
        {
            List<ListOrder> list = new List<ListOrder>();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("exec sp_customer_DeliveringListOrderList 'KH001'");

            foreach (DataRow row in dataTable.Rows)
            {
                ListOrder ListOrder = new ListOrder(row);
                list.Add(ListOrder);
            }


            return list;
        }

        public List<ListOrder> LoadDeliveredListOrderList()
        {
            List<ListOrder> list = new List<ListOrder>();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("exec sp_customer_DeliveredListOrderList 'KH001'");


            foreach (DataRow row in dataTable.Rows)
            {
                ListOrder ListOrder = new ListOrder(row);
                list.Add(ListOrder);
            }


            return list;
        }
        public string LayDiaChi(string madh)
        {
            string query = "exec sp_LayDiaChi '" + madh + "'";
            DataTable dataTable =DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in dataTable.Rows){
                return row["DiaChi"].ToString();
            }
            return "";
        }
        public DataTable getCustomerInf(string makh)
        {
            string query="exec sp_CustomerInf '"+makh + "'";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;
        }
    }
}
