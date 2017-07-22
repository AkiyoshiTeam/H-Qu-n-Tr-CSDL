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
    public class ChuyenXeDAO
    {
        public static DataTable LoadChuyenXe()
        {
            SqlConnection con = DataProvider.Connection();
            DataTable dt = new DataTable();
            string sql = @"Select * From ChuyenXe";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con = DataProvider.Disconnection();
            return dt;
        }

        public static DataTable LoadChuyenXeTheoTuyenDuong(string MaTuyen)
        {
            SqlConnection con = DataProvider.Connection();
            DataTable dt = new DataTable();
            string sql = @"Select * From ChuyenXe C join TuyenDuong T on C.MaTuyen=T.MaTuyen Where T.MaTuyen='" + MaTuyen + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con = DataProvider.Disconnection();
            return dt;
        }
    }
}
