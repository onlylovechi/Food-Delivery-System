using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyGiaoHang.DTO;

namespace QuanLyGiaoHang.DAO
{
    public class DriverInfoDAO
    {
        public static DriverInfoDAO instance;
        public static DriverInfoDAO Instance
        {
            get {
                if (instance == null) instance = new DriverInfoDAO();
                return instance; }
            private set { instance = value; }
        }
        private DriverInfoDAO() { }
        public List<DriverInfo> LoadDriverInfo()
        {
            List<DriverInfo> list = new List<DriverInfo>();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("select * from TAIXE");


            foreach (DataRow row in dataTable.Rows)
            {
                //DriverInfo order = new DriverInfo(row);
               // list.Add(order);
            }


            return list;
        }
    }
}
