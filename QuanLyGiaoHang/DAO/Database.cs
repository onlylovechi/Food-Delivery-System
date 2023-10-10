using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyGiaoHang
{
    public class Database
    {
        private SqlConnection conn;
        public Database()
        {
            string connectionString = "Data Source=DESKTOP-5EU7M8G;Initial Catalog=QLHTGH;Integrated Security=True";
            try
            {
                conn = new SqlConnection(connectionString);

            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to connect" + e.Message);
            }
        }
        public Database(string id, string password)
        {
            string connectionString = "Data Source=(local);Initial Catalog=QLHTGH;User ID=" + id + ";Password=" + password;
            try
            {
                conn = new SqlConnection(connectionString);
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to connect" + e.Message);
            }
        }
        public bool _login(string name, string password)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM TAIKHOAN where TK='" + name + "' and MK='" + 123 + "'", conn);

            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            MessageBox.Show(dt.Rows[0][0].ToString());
            if (dt.Rows[0][0].ToString() == "1")
            {
                /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */
                return true;
            }
            else
                return false;
        }
        ~Database()
        {
            conn.Close();
        }
        public DataTable GetData()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select TenMon, MieuTa,Gia,TinhTrangMon from THUCDON", conn);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public List<String> GetInf(string taikhoan)
        {
            var inf = new List<string>();
            using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM KHACHHANG", conn))
            {
                conn.Open();
                using (var reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        inf.Add(reader.GetString(0));
                        inf.Add(reader.GetString(1));
                        inf.Add(reader.GetString(2));
                        inf.Add(reader.GetString(3));
                    }
                }
            }
            return inf;
        }
        public void get_Ds_DoiTac()
        {

        }

    }
}
