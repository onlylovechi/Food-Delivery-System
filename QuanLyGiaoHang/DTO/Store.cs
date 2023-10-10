using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiaoHang.DTO
{
    public class Store
    {
        public Store(string macn, string madt, string addr1, string addr2, string addr3, string status, string timeactivity)
        {
            this.madt = madt;
            this.macn = macn;
            this.addr1 = addr1;
            this.addr2 = addr2;
            this.addr3 = addr3;
            this.status = status;
            this.timeactivity = timeactivity;
        }
        public Store(DataRow dataRow)
        {
            this.macn = dataRow["MaCN"].ToString();
            this.madt = dataRow["MaDT"].ToString();
            this.addr1 = dataRow["DiaChiChiTiet"].ToString();
            this.addr2 = dataRow["Quan"].ToString();
            this.addr3 = dataRow["ThanhPho"].ToString();
            this.status = dataRow["TinhTrangCH"].ToString();
            this.timeactivity = dataRow["TGHoatDong"].ToString();
        }
        private string madt;
        private string macn;
        private string addr1;
        private string addr2;
        private string addr3;
        private string status;
        private string timeactivity;
        public string Madt
        {
            get { return madt; }
            set { madt = value; }
        }
        public string MACN
        {
            get { return macn; }
            set { macn = value; }
        }
        public string Addr1
        {
            get { return addr1; }
            set { addr1 = value; }
        }
        public string Addr2
        {
            get { return addr2; }
            set { addr2 = value; }
        }
        public string Addr3
        {
            get { return addr3; }
            set { addr3 = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public string Timeactivity
        {
            get { return timeactivity; }
            set
            {
                timeactivity = value;
            }
        }
    }
}
