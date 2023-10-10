using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiaoHang.Module
{
    internal class OrderInfo
    {
       
            public OrderInfo(string madh, string foodname, int price, int count, int totalprice)
            {
                this.maDH = madh;
                this.foodname = foodname;
                this.price = price;
                this.totalPrice = totalprice;
                this.count = count;

            }
            public OrderInfo(DataRow dataRow)
            {
            this.maDH = dataRow["madh"].ToString();
            this.foodname = dataRow["foodname"].ToString();
            this.price = (int)dataRow["price"];
            this.totalPrice = (int)dataRow["totalPrice"];
            this.count = (int)dataRow["countfood"];
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
