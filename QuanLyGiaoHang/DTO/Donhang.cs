using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiaoHang.Module
{
    internal class Donhang
    {
        private string tenmon;
        private string soluong;
        private string tuychon;
        private string dongia;

        public string Tenmon { get => tenmon; set => tenmon = value; }
        public string Soluong { get => soluong; set => soluong = value; }
        public string Tuychon { get => tuychon; set => tuychon = value; }
        public string Dongia { get => dongia; set => dongia = value; }
        public Donhang(string tenmon,string soluong,string tuychon,string dongia)
        {
            this.Tenmon=tenmon;
            this.Soluong=soluong;
            this.Tuychon = tuychon;
            this.Dongia = dongia;
        }
    }
}
