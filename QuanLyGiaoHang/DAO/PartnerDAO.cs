using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLHTGH.DTO;
using QuanLyGiaoHang.DAO;

namespace QuanLyGiaoHang.DAO
{
    internal class PartnerDAO
    {
        private static PartnerDAO instance;
        public static PartnerDAO Instance
        {
            get
            {
                if (instance == null) instance = new PartnerDAO();
                return PartnerDAO.instance;
            }
            private set { PartnerDAO.instance = value; }
        }
        private PartnerDAO() { }
        public List<DoiTacInf> getData()
        {
            List<DoiTacInf> data = new List<DoiTacInf>();
            string query = "exec sp_dsDoiTac";
            DataTable dt=DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in dt.Rows)
            {
                DoiTacInf doiTacInf = new DoiTacInf(row);
                data.Add(doiTacInf);
            }
            return data;


        }
        public List<partner> LoadPartnerList()
        {
            List<partner> list = new List<partner>();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("exec sp_PartnerList");


            foreach (DataRow row in dataTable.Rows)
            {
                partner people = new partner(row);
                list.Add(people);
            }

            return list;
        }
    }
}
