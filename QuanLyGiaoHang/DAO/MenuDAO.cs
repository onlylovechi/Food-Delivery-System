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
    internal class MenuDAO
    {
        private static MenuDAO instance;
        public static MenuDAO Instance
        {
            get
            {
                if (instance == null) instance = new MenuDAO();
                return MenuDAO.instance;
            }
            private set { MenuDAO.instance = value; }
        }
        private MenuDAO() { }
        public List<MenuInfo> getData(string chinhanh)
        {
            List<MenuInfo> data = new List<MenuInfo>();
            string query = "exec sp_MenuInfo" + " '" + chinhanh + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                MenuInfo menu = new MenuInfo(row);
                data.Add(menu);
            }
            return data;

        }
        public string DatHang(string macn, string makh, string diachichitiet, string quan, string thanhpho)
        {
            string query = "exec sp_TaoDonHang " + "'" + macn + "'," + "'" + makh + "'," + "'" + diachichitiet + "'," + "'" + quan + "'," + "'" + thanhpho + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                return row["MaDH"].ToString();
            }
            return null;
        }
        public void ThemChiTietDonHang(string madh, string macn, string tenmon, string soluong, string ghichu)
        {
            string query = "exec sp_ThemChiTietDonHang " + "'" + madh + "'," + "'" + macn + "'," + "'" + tenmon + "'," + "'" + soluong + "'," + "'" + ghichu + "'";
        }
        public List<Menuinf> getData1(string chinhanh)
        {
            List<Menuinf> data = new List<Menuinf>();
            string query = "exec sp_ThucDon"+" '"+chinhanh+"'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                Menuinf Menuinf = new Menuinf(row);
                data.Add(Menuinf);
            }
            return data;

        }
        public string DatHang1(string macn,string makh,string diachichitiet,string quan, string thanhpho)
        {
            string query = "exec sp_TaoHoaDon " + "'" + macn + "'," + "'" + "KH001" + "'," + "'" + diachichitiet + "'," + "'" + quan + "'," + "'" + thanhpho + "'";
            DataTable dt =DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in dt.Rows)
            {
                return row["MaDH"].ToString();
            }
            return null;
        }
        public int ThemChiTietDonHang1(string madh,string macn,string tenmon,string soluong,string ghichu)
        {
            
            
           string query ="exec sp_ThemChiTietHoaDon " + "'" + madh + "'," + "'" + macn + "'," + "N'" + tenmon + "'," + "'" + soluong + "'," + "'" + ghichu + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void CapNhatDonHang(string madh,string tongtien,string phivanchuyen)
        {
            string query = "exec sp_CapNhatDonHang " + "'" + madh + "'," + "'" + tongtien + "'," + "'" + phivanchuyen + "'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}