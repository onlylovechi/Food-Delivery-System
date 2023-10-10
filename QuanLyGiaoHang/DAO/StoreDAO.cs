using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyGiaoHang.DTO;

namespace QuanLyGiaoHang.DAO
{
    
    public class StoreDAO
    {
        private static StoreDAO instance;
        public static StoreDAO Instance
        {
            get { if (instance == null) instance = new StoreDAO(); return StoreDAO.instance; }
            private set { StoreDAO.instance = value; }
        }
    private StoreDAO() { }
        public List<Store> LoadStoreList(string madt)
        {
            List<Store> list = new List<Store>();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("sp_StoreList '"+madt+"'");


            foreach (DataRow row in dataTable.Rows)
            {
                Store order = new Store(row);
                list.Add(order);
            }


            return list;
        }

    }
}
