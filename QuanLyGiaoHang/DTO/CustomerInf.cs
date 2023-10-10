using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaoHang
{
    internal class CustomerInf
    {
        private static string user;
        private static string id;

        public static string User { get => user; set => user = value; }
        public static string Id { get => id; set => id = value; }

        CustomerInf(DataRow row)
        {
            User = row["username"].ToString();
            Id = row["id"].ToString();

        }

    }
}
