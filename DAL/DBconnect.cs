using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConnect
    {
        public SqlConnection con;
        public SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        string chuoikn = @"Data Source=Quinn\SQLEXPRESS;Initial Catalog=DoAn1;Integrated Security=True";
        public void ketnoi()
        {
            con = new SqlConnection(chuoikn);
            if (con.State == ConnectionState.Closed)
                con.Open();
        }
        public void dongketnoi()
        {
            con = new SqlConnection(chuoikn);
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public void thucthisql(string sql)
        {
            ketnoi();
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            dongketnoi();
        }
        public DataTable getData(string sql)
        {
            ketnoi();
            da = new SqlDataAdapter(sql, con);
            dt = new DataTable();
            da.Fill(dt);
            dongketnoi();
            return dt;
        }
        public int kiemtramatrung(string ma, string sql)
        {
            ketnoi();
            int i;
            cmd = new SqlCommand(sql, con);
            i = (int)cmd.ExecuteScalar();
            dongketnoi();
            return i;
        }

        
    }
}
