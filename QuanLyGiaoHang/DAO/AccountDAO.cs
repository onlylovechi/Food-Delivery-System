using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyGiaoHang.DAO;

namespace QuanLyGiaoHang.DAO
{
    internal class AccountDAO
    {   public static string username;
         public static string id;
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get
            {
                if (instance == null) instance = new AccountDAO();
                return AccountDAO.instance;
            }
            private set { AccountDAO.instance = value; }
        }
        private AccountDAO() { }
        public int login(string name, string password, string type)
        {
           string query="exec sp_DangNhap '"+name+"','"+password+"',N'"+type+"'";
            DataTable dt=DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                username = dr["username"].ToString();
                id = dr["UserID"].ToString();
                return 1;
            }
            return 0;
        }
        public bool register()
        {

            return false;
        }
        
    }
   
}
