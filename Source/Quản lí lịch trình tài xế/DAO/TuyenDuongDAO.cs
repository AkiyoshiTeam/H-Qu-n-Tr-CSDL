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
    public class TuyenDuongDAO
    {
        public static DataTable LoadTuyenDuong()
        {
            SqlConnection con = DataProvider.Connection();
            DataTable dt = new DataTable();
            string sql = @"Select * From TuyenDuong";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con = DataProvider.Disconnection();
            return dt;
        }
    }
}
