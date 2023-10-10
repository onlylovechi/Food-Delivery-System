using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiaoHang.DTO
{
    internal class OrderInfo1
    {
        public OrderInfo1(string madh, string foodname, int price, int count, int totalprice)
        {
            this.maDH = madh;
            this.foodname = foodname;
            this.price = price;
            this.totalPrice = totalprice;
            this.count = count;

        }
        public OrderInfo1(DataRow dataRow)
        {
            this.maDH = dataRow["MaDH"].ToString();
            this.foodname = dataRow["TenMon"].ToString();
            this.price = (int)dataRow["Gia"];
            this.totalPrice = (int)dataRow["ThanhTien"];
            this.count = (int)dataRow["SoLuong"];
        }

        private string maDH;
        private string foodname;
        private int totalPrice;
        public int TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }
        public string Foodname
        {
            get { return foodname; }
            set { foodname = value; }
        }
        private int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }


        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        public string MaDH
        {
            get { return maDH; }
            set { maDH = value; }
        }

    }
}
