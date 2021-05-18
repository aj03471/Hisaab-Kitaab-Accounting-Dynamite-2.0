using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserSecurity
{
    public class DBConnection
    {

        //SqlConnection conn = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = USALS-2;Integrated Security = True; Connect Timeout = 60; Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlConnection conn = new SqlConnection("Data Source = LFK-HP; Initial Catalog = USALS-2; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();

        public void InsertQuery(string query)
        {
            conn.Open();
            cmd.CommandText = query;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable SelectQuery(string query)
        {
            conn.Open();
            cmd.CommandText = query;
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            return dt;
        }

    }
}

