using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiaoHang.DTO
{
    public class DriverInfo
    {
        public DriverInfo(string matx, string driverName, string biensoxe, string sdt, string addr, string bankname, 
            string banknumber, string cmnd, string email, string tphoatdong, string quanhoatdong)

        {
            this.maTX = matx;
            this.driverName = driverName;
            this.bienSoxe = biensoxe;
            this.sdt = sdt;
        }

        private string driverName;
        private string maTX;
        private string bienSoxe;
        private string sdt;
        private string addr;
        private string bankName;
        private string bankNumber;
        private string cmnd;
        private string email;
        private string tpHoatdong;
        private string quanHoatdong;
        public string DriverName
        {
            get { return driverName; }
            set { driverName = value; }
        }
        public string MaTX
        {
            get { return maTX; }
            set { maTX = value; }
        }
        public string BienSoxe
        {
            get { return bienSoxe; }
            set { bienSoxe = value;}
        }
        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }
        public string Addr
        {
            get { return addr; }
            set { addr = value; }
        }
        public string BankName
        {
            get { return bankName; }
            set { bankName = value;}
        }
        public string BankNumber
        {
            get { return bankNumber; }
            set { bankNumber = value; }
        }
        public string Cmnd
        {
            get { return cmnd; }
            set { cmnd = value;}
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string TpHoatdong
        {
            get { return tpHoatdong; }
            set
            {
                tpHoatdong = value;
            }
        }
        public string QuanHoatdong
        {
               get { return quanHoatdong; }
            set
            {
                quanHoatdong = value;
            }
        }
        
    }
}
