using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiaoHang.DTO
{
    public class HopDong
    {
        public HopDong(string maHD, string madt, string manv, string tGHL, string mst, string ndd, string bn, string bnb, string hh, int slcn)

        {
            this.maHD = maHD;
            this.tGHieuLuc = tGHL;
            this.MaSoThue = mst;
            this.nguoiDaiDien = ndd;
            this.bankName = bn;
            this.bankNumber = bnb;
            this.hoaHong = hh;
            this.sLChiNhanhDangKy = slcn;
            this.maNV = manv;
            this.maDT = madt;

        }

        public HopDong(DataRow dr)
            {
            this.maHD = dr["MaHD"].ToString();
            this.tGHieuLuc = dr["TGHieuLuc"].ToString();
            this.maSoThue = dr["MaSoThue"].ToString();
            this.nguoiDaiDien = dr["NguoiDaiDien"].ToString();
            this.bankName = dr["NganHang"].ToString();
            this.bankNumber = dr["STK"].ToString(); ;
            this.hoaHong = dr["HoaHong"].ToString();
            this.sLChiNhanhDangKy = (int)dr["SLChiNhanhDangKy"];
            this.maNV = dr["MaDT"].ToString();
            this.maDT = dr["MaNV"].ToString();
        }
        private string maHD;
        private string maNV;
        private string maDT;
        private string tGHieuLuc;
        private string maSoThue;
        private string nguoiDaiDien;
        private string bankName;
        private string bankNumber;
        private string hoaHong;
        private int sLChiNhanhDangKy;
        public string HoaHong
        {
            get { return hoaHong; }
            set { hoaHong = value; }

        }
        public string TGHieuLuc
            { get { return tGHieuLuc; } set { tGHieuLuc = value; } }
        public string MaHD
        {
            get { return maHD; } set { maHD = value; } 
        }
        public string MaNV
        {
            get { return maNV; } set { maNV = value; } 
        }
        public string MaDT
        {
            get { return maDT; } set { maDT = value; } 
        }
        public string MaSoThue
        {
            get { return maSoThue; } set { maSoThue = value; }
        }    
        public string NguoiDaiDien
        {
            get { return nguoiDaiDien; }
            set { nguoiDaiDien = value; }
        }
        public string BankName
        {
            get { return bankName; }
            set { bankName = value; }
        }
        public string BankNumber
        {
            get { return bankNumber; }
            set { bankNumber = value; }
        }
        public int SLChiNhanhDangKy
        {
            get { return sLChiNhanhDangKy; }
            set { sLChiNhanhDangKy = value; }
        }
    }
}
