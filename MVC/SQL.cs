using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVC
{
    public class SQL
    {
        public static DataTable Execute(string srg)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MilliGame; Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionString);
            sqlcon.Open();
            SqlCommand sorgu = new SqlCommand(srg, sqlcon);
            SqlDataAdapter adapter = new SqlDataAdapter(sorgu);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            sqlcon.Close();
            return dt;
        }
    }
}