using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiaoHang.DTO
{
    public class DoiTac
    {
        public DoiTac(string maDT, string email, string tenCuaHang, string nguoiDaiDien, string diaChi, string sLChiNhanh, string loaiAmThuc,
                        string sLDonHang, string ngayCapNhat, string sDT)
        {
            this.maDT = maDT;
            this.email = email;
            this.tenCuaHang = tenCuaHang;
            this.nguoiDaiDien = nguoiDaiDien;
            this.diaChi = diaChi;
            this.sLDonHang = sLDonHang;
            this.ngayCapNhat = ngayCapNhat;
            this.sLChiNhanh = sLChiNhanh;
            this.loaiAmThuc = loaiAmThuc;
            this.sDT = sDT;

        }
        public DoiTac(DataRow data)
        {
            this.maDT = data["MaDT"].ToString();
            this.email = data["Email"].ToString();
            this.tenCuaHang = data["TenCuaHang"].ToString();
            this.nguoiDaiDien = data["NguoiDaiDien"].ToString();
            this.diaChi = data["DiaChi"].ToString();
            this.sLDonHang = data["SLDonHang"].ToString();
            this.ngayCapNhat = data["NgayCapNhat"].ToString();
            this.sLChiNhanh = data["SLChiNhanh"].ToString();
            this.loaiAmThuc = data["LoaiAmThuc"].ToString();
            this.sDT = data["SDT"].ToString();
        }
        private string maDT;
        private string email;
        private string tenCuaHang;
        private string nguoiDaiDien;
        private string diaChi;
        private string sLChiNhanh;
        private string loaiAmThuc;
        private string sLDonHang;
        private string ngayCapNhat;
        private string sDT;

        public string MaDT
        {
            get { return maDT; }
            set { maDT = value; }
        }
        public string Email
        { get { return email; } set { email = value; } }
        public string TenCuaHang
        { get { return tenCuaHang; } set { tenCuaHang = value; } }
        public string NguoiDaiDien
        {
            get { return nguoiDaiDien; }
            set { nguoiDaiDien = value; }
        }
        public string DiaChi
        { get { return diaChi; } set { diaChi = value; } }
        public string SLChiNhanh
        {
            get { return sLChiNhanh; }
            set { sLChiNhanh = value; }
        }
        public string LoaiAmThuc
        {
            get { return loaiAmThuc; }
            set { loaiAmThuc = value; }
        }
        public string SLDonHang
        {
            get { return sLDonHang; }
            set
            {
                sLDonHang = value;
            }
        }
        public string NgayCapNhat
        {
            get { return ngayCapNhat; }
            set
            {
                ngayCapNhat = value;
            }
        }
        public string SDT
        {
            get { return sDT; }
            set
            {
                sDT = value;
            }
        }
    }
}
