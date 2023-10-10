using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiaoHang.Module
{
    internal class ListOrder
    {
        private string madh;
        private string macn;
        private string dongia;

        public string Madh { get => madh; set => madh = value; }
        public string Macn { get => macn; set => macn = value; }
        public string Dongia { get => dongia; set => dongia = value; }
        public ListOrder(DataRow row)
        {
            this.Madh = row["MaDH"].ToString();
            this.Macn = row["MaCN"].ToString();
            int tongtien = (int) row["DonGia"] + (int) row["PhiVanChuyen"];
            this.Dongia = tongtien.ToString();
        }
    }
}
