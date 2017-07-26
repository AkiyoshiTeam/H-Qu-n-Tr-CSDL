using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class ToDAO
    {
        public static DataTable LoadTo()
        {
            SqlConnection con = DataProvider.Connection();
            string sql = @"Select * From Nhom";
            SqlCommand cmd = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con = DataProvider.Disconnection();
            return dt;
        }
    }
}
