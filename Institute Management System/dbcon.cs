using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Institute_Management_System
{
    public class dbcon
    {
        static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-K3SMJB9;Initial Catalog=onitka;Integrated Security=True");


       

        public static int SendQuery(String sendQuery)
        {
            con.Open();
            SqlDataAdapter SDA = new SqlDataAdapter(sendQuery,con);
            int x=SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            return x;
        }

        public static DataTable GetData(String getQuery)
        {
            con.Open();
            SqlDataAdapter SDA = new SqlDataAdapter(getQuery, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
