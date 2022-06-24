using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1711548580_NguyenDuyKhuong_DACS_QLQuanAn
{
    class database
    {
        string ConnectionString = @"Data Source=LAPTOP-AUQ1M0U5\SQLEXPRESS;Initial Catalog=QLQuanAn;Integrated Security=True";
        public DataTable Execute(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connec = new SqlConnection(ConnectionString))
            {
                connec.Open();
                SqlCommand cmd = new SqlCommand(query, connec);
                if(parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach(string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(data);
                connec.Close();
            }
            return data;
        }
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connec = new SqlConnection(ConnectionString))
            {
                connec.Open();
                SqlCommand cmd = new SqlCommand(query, connec);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteNonQuery();
                connec.Close();
            }
            return data;
        }
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connec = new SqlConnection(ConnectionString))
            {
                connec.Open();
                SqlCommand cmd = new SqlCommand(query, connec);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteScalar();
                connec.Close();
            }
            return data;
        }
    }
}
