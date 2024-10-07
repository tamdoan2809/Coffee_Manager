using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLCF
{
    internal class Connect
    {
        public static string kt = "Data Source=LAPTOP-BS306ELL;Initial Catalog=QLQuanCoffee;Integrated Security=True";
        public SqlConnection con = new SqlConnection();
        public Connect()
        {
            con = new SqlConnection(kt);

        }
        public void Open()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void Close()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public int getNonQuery(string sqlquery)
        {
            Open();
            SqlCommand cmd = new SqlCommand(sqlquery, con);
            int kq = cmd.ExecuteNonQuery();
            Close();
            return kq;
        }
        public DataTable getDataTable(string sqlquery)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sqlquery, con);
            da.Fill(ds);
            return ds.Tables[0];
        }
        public int getScalar(string sqlquery)
        {
            Open();
            SqlCommand cmd = new SqlCommand(sqlquery, con);
            int kq = (int)cmd.ExecuteScalar();
            Close();
            return kq;
        }
    }
}
