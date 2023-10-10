using QLHTGH.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyGiaoHang.DAO;

namespace QLHTGH.DAO
{
    public class contractDAO
    {
        private static contractDAO instance;

        public static contractDAO Instance
        {
            get { if (instance == null) instance = new contractDAO(); return contractDAO.instance; }
            private set { contractDAO.instance = value; }
        }
        private contractDAO() { }

        public List<contract> LoadContractList()
        {
            List<contract> list = new List<contract>();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("select * from HOPDONG");


            foreach (DataRow row in dataTable.Rows)
            {
                contract order = new contract(row);
                list.Add(order);
            }


            return list;
        }

        public List<contract> LoadContractAgreeList()
        {
            List<contract> list = new List<contract>();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("sp_LoadContractAgreeList");


            foreach (DataRow row in dataTable.Rows)
            {
                contract order = new contract(row);
                list.Add(order);
            }


            return list;
        }

        public List<contract> LoadContractNotAgreeList()
        {
            List<contract> list = new List<contract>();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("sp_LoadContractNotAgreeList");


            foreach (DataRow row in dataTable.Rows)
            {
                contract order = new contract(row);
                list.Add(order);
            }


            return list;
        }
    }

    

}
