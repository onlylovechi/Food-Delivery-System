using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyGiaoHang.DTO;

namespace QuanLyGiaoHang.DAO
{
    public class DoiTacDAO
    {
        public static DoiTacDAO instance;
        public static DoiTacDAO Instance
        {
            get
            {
                if (instance == null) instance = new DoiTacDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private DoiTacDAO() { }
        public List<DriverInfo> LoadDoiTacInfo(string madt)
        {
            List<DriverInfo> list = new List<DriverInfo>();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("sp_OrderList '"+madt+"'");


            foreach (DataRow row in dataTable.Rows)
            {
                //DriverInfo order = new DriverInfo(row);
                // list.Add(order);
            }


            return list;
        }
    }
}
