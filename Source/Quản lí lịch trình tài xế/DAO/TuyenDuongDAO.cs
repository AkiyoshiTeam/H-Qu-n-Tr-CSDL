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

        public static long LayKhoangCach(string MaTuyen)
        {
            long KQ = 0;
            SqlConnection con = DataProvider.Connection();
            DataTable dt = new DataTable();
            string sql = @"Select KhoangCach From TuyenDuong Where MaTuyen='" + MaTuyen + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                KQ = Int64.Parse(row["KhoangCach"].ToString());
            }
            con = DataProvider.Disconnection();
            return KQ;
        }
    }
}
