using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiaoHang
{
    public class MenuInfo
    {
        public MenuInfo(string tenmon, string mieuta, string gia, string tinhtrang)
        {
            this.tenmon = tenmon;
            this.mieuta = mieuta;
            this.gia = gia;
            this.tinhtrang = tinhtrang;
        }
        public MenuInfo(DataRow row)
        {
            this.tenmon = row["TenMon"].ToString();
            this.mieuta = row["MieuTa"].ToString();
            this.gia = row["Gia"].ToString();
            this.tinhtrang = row["TinhTrangMon"].ToString();
        }
        private string tenmon;
        private string mieuta;
        private string gia;
        private string tinhtrang;

        public string Tenmon
        {
            get { return tenmon; }
            set { tenmon = value; }
        }
        public string Mieuta
        {
            get { return mieuta; }
            set { mieuta = value; }
        }
        public string Gia
        {
            get { return gia; }
            set { gia = value; }
        }
        public string TinhTrang
        {
            get { return tinhtrang; }
            set { tinhtrang = value; }
        }

    }
}
