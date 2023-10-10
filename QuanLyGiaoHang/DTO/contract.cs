using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHTGH.DTO
{
    public class contract
    {
        public contract(string MaHD, string MaSoThue, string MaDT, string NguoiDaiDien, string MaNV, int SLChiNhanhDangKy, string STK, string NganHang, string TGHieuLuc, int HoaHong)
        {
            this.MaHD = MaHD;
            this.MaSoThue = MaSoThue;
            this.MaDT = MaDT;
            this.NguoiDaiDien = NguoiDaiDien;
            this.MaNV = MaNV;
            this.SlChiNhanhDangKy = SLChiNhanhDangKy;
            this.Stk = STK;
            this.NganHang = NganHang;
            this.TgHieuLuc = TGHieuLuc;
            this.HoaHong = HoaHong;
        }

        public contract(DataRow row)
        {
            this.MaHD = row["MaHD"].ToString();
            this.MaSoThue = row["MaSoThue"].ToString();
            this.MaDT = row["MaDT"].ToString();
            this.NguoiDaiDien = row["NguoiDaiDien"].ToString();
            this.MaNV = row["MaNV"].ToString();
            this.SlChiNhanhDangKy = (int)row["SLChiNhanhDangKy"];
            this.Stk = row["STK"].ToString();
            this.NganHang = row["NganHang"].ToString();
            this.TgHieuLuc = row["TGHieuLuc"].ToString();
            //this.HoaHong = (float)Convert.ToDouble(row["HoaHong"].ToString());
        }

        private string maSoThue;
        public string MaSoThue { get => maSoThue; set => maSoThue = value; }

        private string maHD;
        public string MaHD { get => maHD; set => maHD = value; }

        private string maDT;
        public string MaDT { get => maDT; set => maDT = value; }

        private string nguoiDaiDien;
        public string NguoiDaiDien { get => nguoiDaiDien; set => nguoiDaiDien = value; }

        private string tgHieuLuc;
        public string TgHieuLuc { get => tgHieuLuc; set => tgHieuLuc = value; }

        private float hoaHong;
        public float HoaHong { get => hoaHong; set => hoaHong = value; }

        private string nganHang;
        public string NganHang { get => nganHang; set => nganHang = value; }

        private string stk;
        public string Stk { get => stk; set => stk = value; }

        private int slChiNhanhDangKy;
        public int SlChiNhanhDangKy { get => slChiNhanhDangKy; set => slChiNhanhDangKy = value; }

        private string maNV;
        public string MaNV { get => maNV; set => maNV = value; }

    }
}
