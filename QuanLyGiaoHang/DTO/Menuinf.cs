using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiaoHang.Module
{
    internal class Menuinf
    {
        private string tenmon;
        private string mieuta;
        private string gia;
        private string tinhtrang;

        public string Tenmon { get => tenmon; set => tenmon = value; }
        public string Mieuta { get => mieuta; set => mieuta = value; }
        public string Gia { get => gia; set => gia = value; }
        public string Tinhtrang { get => tinhtrang; set => tinhtrang = value; }
        public Menuinf(DataRow row)
        {
            this.Tenmon = row["TenMon"].ToString();
            this.Mieuta = row["MieuTa"].ToString();
            this.Gia = row["Gia"].ToString();
            this.Tinhtrang = row["TinhTrangMon"].ToString();
        }
    }
}
