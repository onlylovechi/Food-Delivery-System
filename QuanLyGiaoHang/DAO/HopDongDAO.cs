using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyGiaoHang.DTO;

namespace QuanLyGiaoHang.DAO
{
    public class HopDongDAO
    {
        public static HopDongDAO instance;
        public static HopDongDAO Instance
        {
            get
            {
                if (instance == null) instance = new HopDongDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private HopDongDAO() { }
        public List<HopDong> LoadHopDongInfo(string madt)
        {
            List<HopDong> list = new List<HopDong>();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("exec sp_HopDongInfo '"+madt+"'");


            foreach (DataRow row in dataTable.Rows)
            {
                HopDong order = new HopDong(row);
                list.Add(order);
            }


            return list;
        }


    }
}
