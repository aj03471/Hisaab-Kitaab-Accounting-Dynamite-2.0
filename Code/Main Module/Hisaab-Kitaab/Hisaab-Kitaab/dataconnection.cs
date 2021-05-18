using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Hisaab_Kitaab
{
    public class dataconnection
    {
        //public SqlConnection conn = new SqlConnection("Data Source=INARADESKTOP/SQLEXPRESS;Initial Catalog=ADS_2;Integrated Security=True");
        //public SqlConnection conn = new SqlConnection("Data Source=INARADESKTOP;Initial Catalog="+Program.db_name+";Integrated Security=True");
        public SqlConnection conn = new SqlConnection("Data Source=INARADESKTOP;Initial Catalog=ADS_2;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        public SqlConnection conn_users = new SqlConnection("Data Source=INARADESKTOP;Initial Catalog=USALS-2;Integrated Security=True");
        SqlCommand cmd_users = new SqlCommand();

        public void InsertQuery(string query)
        {
            try
            {
                conn.Open();
                cmd.CommandText = query;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }
        public DataTable SelectQuery(string query)
        {
            try
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
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return null;
            }

        }

        public void InsertQuery_Users(string query)
        {
            try
            {
                conn_users.Open();
                cmd_users.CommandText = query;
                cmd_users.Connection = conn_users;
                cmd_users.ExecuteNonQuery();
                conn_users.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        public DataTable SelectQuery_Users(string query)
        {
            try
            {
                conn_users.Open();
                cmd_users.CommandText = query;
                cmd_users.Connection = conn_users;
                SqlDataAdapter da = new SqlDataAdapter(cmd_users);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn_users.Close();

                return dt;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return null;
            }
        }


    }
}

         


