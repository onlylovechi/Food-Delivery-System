using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaoHang.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DataProvider();
                return DataProvider.instance;
            }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }
        private string connectStr = "Data Source=.\\KIMCHI;Initial Catalog=QLHTGH;Integrated Security=True";
        public DataSet ExecuteQuery1(string query)
        {
            DataSet dataset = new DataSet();
            using (SqlConnection connection = new SqlConnection(connectStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataset);
                connection.Close();
            }
            return dataset;
        }
        public DataTable ExecuteQuery(string query)
        {

            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
                connection.Close();
            }

            return dataTable;
        }
        public int ExecuteNonQuery(string query)
        {
            int result = 0;
            using (SqlConnection connection = new SqlConnection(connectStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                result = command.ExecuteNonQuery();
                connection.Close();
            }
            return result;
        }
        public string ExecuteScalar(string query)
        {
            string result = "";
            using (SqlConnection connection = new SqlConnection(connectStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                result = (string)command.ExecuteScalar();
                connection.Close();
            }
            return result;
        }
    }
}
