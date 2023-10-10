using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHTGH.DTO
{
    public class partner
    {
        public partner (string maDT, string email, string tenCH, string nguoiDD, string diachi, int slCN, string loaiAmThuc, string slDH, string ngayCapNhat, string sdt)
        {
            this.MaDT = maDT;
            this.Email = email;
            this.TenCuaHang = tenCH;
            this.NguoiDaiDien = nguoiDD;
            this.DiaChi = diachi;
            this.SlChiNhanh = slCN;
            this.LoaiAmThuc = loaiAmThuc;
            this.SlDonHang = slDH;
            this.NgayCapNhat = ngayCapNhat;
            this.SDT = sdt;
        }

        public partner(DataRow row)
        {
            this.MaDT = row["MaDT"].ToString();
            this.Email = row["email"].ToString();
            this.TenCuaHang = row["tenCuaHang"].ToString();
            this.NguoiDaiDien = row["nguoiDaiDien"].ToString();
            this.DiaChi = row["diaChi"].ToString();
            this.SlChiNhanh = (int)row["slChiNhanh"];
            this.LoaiAmThuc = row["loaiAmThuc"].ToString();
            this.SlDonHang = row["slDonHang"].ToString();
            this.NgayCapNhat = row["ngayCapNhat"].ToString();
            this.SDT = row["sDT"].ToString();
        }

        private string maDT;
        private string email;
        private string tenCuaHang;
        private string nguoiDaiDien;
        private string diaChi;
        private int slChiNhanh;
        private string loaiAmThuc;
        private string slDonHang;
        private string ngayCapNhat;
        private string sDT;

        public string MaDT { get => maDT; set => maDT = value; }
        public string Email { get => email; set => email = value; }
        public string TenCuaHang { get => tenCuaHang; set => tenCuaHang = value; }
        public string NguoiDaiDien { get => nguoiDaiDien; set => nguoiDaiDien = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public int SlChiNhanh { get => slChiNhanh; set => slChiNhanh = value; }
        public string LoaiAmThuc { get => loaiAmThuc; set => loaiAmThuc = value; }
        public string SlDonHang { get => slDonHang; set => slDonHang = value; }
        public string NgayCapNhat { get => ngayCapNhat; set => ngayCapNhat = value; }
        public string SDT { get => sDT; set => sDT = value; }
    }
}
