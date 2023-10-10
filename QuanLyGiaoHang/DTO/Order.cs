using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiaoHang.DTO
{
    public class Order
    {
        public Order(string madh, string matx, string namestore , string addrFrom, string addrTo, int shippingfee, int price, string dateOrder, string macn)
        {
            this.maDH = madh;
            this.nameStore = namestore;
            this.addressFrom = addrFrom;
            this.addressTo = addrTo;
            this.shippingfee = shippingfee;
            this.price = price;
            this.dateOrder = dateOrder;
            this.macn = macn;
            this.matx = matx;
        }
        private string matx;
        public string Matx
        {
            get { return matx; }
            set { matx = value; }
        }
        private string macn;
        public string Macn
        {
            get { return macn; }
            set { macn = value; }
        }
        private string dateOrder;
        public string DateOrder
        {
            get { return dateOrder; }
            set { dateOrder = value; }
        }
        public Order(DataRow dataRow)
        {
            this.maDH = dataRow["madh"].ToString();
            this.nameStore = dataRow["nameStore"].ToString() + " " + dataRow["addrFrom2"].ToString();
            this.addressFrom = dataRow["addrFrom1"].ToString() + ", " + dataRow["addrFrom2"].ToString() + ", " + dataRow["addrFrom3"].ToString();
            this.addressTo = dataRow["addrTo1"].ToString() + ", " + dataRow["addrTo2"].ToString()+ ", " + dataRow["addrTo3"].ToString();
            this.shippingfee = (int)dataRow["shippingfee"];
            this.price = (int)dataRow["price"];
            this.dateOrder = dataRow["dateOrder"].ToString();
            this.macn = dataRow["macn"].ToString();
            this.matx = dataRow["matx"].ToString();
        }
        private int shippingfee;
        private int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Shippingfee
        {
            get { return shippingfee; }
            set { shippingfee = value; }
        }
        private string addressTo;
        private string maDH;
        private string addressFrom;
        private string nameStore;

        public string NameStore
        {
            get { return nameStore; }  
            set { nameStore = value; }
        }

        public string AddressFrom
        {
            get { return addressFrom; }
            set { addressFrom = value; }
        }

        public string AddressTo
        {
            get { return addressTo; }
            set { addressTo = value; }
        }
        public string MaDH
        {
            get { return maDH; }
            set { maDH = value; }
        }

    }
}
