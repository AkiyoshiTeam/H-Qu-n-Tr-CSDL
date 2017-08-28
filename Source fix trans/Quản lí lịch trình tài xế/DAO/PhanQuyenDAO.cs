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
    public class PhanQuyenDAO
    {
        public static DataTable LoadPhanQuyen()
        {
            SqlConnection con = DataProvider.Connection();
            string sql = @"Select * From PhanQuyen";
            SqlCommand cmd = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con = DataProvider.Disconnection();
            return dt;
        }

        public static DataTable LoadTinhTrang()
        {
            SqlConnection con = DataProvider.Connection();
            string sql = @"Select * From TinhTrang";
            SqlCommand cmd = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con = DataProvider.Disconnection();
            return dt;
        }
    }
}
