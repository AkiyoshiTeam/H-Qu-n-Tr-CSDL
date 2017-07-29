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

        public static bool ThemTo(ToDTO T)
        {
            try
            {
                SqlConnection con = DataProvider.Connection();
                SqlCommand cmd = new SqlCommand("sp_ThemTo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NgayLap", SqlDbType.Date);

                cmd.Parameters["@NgayLap"].Value = T.NgayLap;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool CapNhatTo(ToDTO T)
        {
            try
            {
                SqlConnection con = DataProvider.Connection();
                SqlCommand cmd = new SqlCommand("sp_CapNhatTo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaTo", SqlDbType.Int);
                cmd.Parameters.Add("@NgayLap", SqlDbType.Date);
                cmd.Parameters.Add("@ToTruong", SqlDbType.VarChar);

                cmd.Parameters["@MaTo"].Value = T.MaTo;
                cmd.Parameters["@NgayLap"].Value = T.NgayLap;
                cmd.Parameters["@ToTruong"].Value = T.ToTruong;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool XoaTo(int MaTo)
        {
            try
            {
                SqlConnection con = DataProvider.Connection();
                SqlCommand cmd = new SqlCommand("sp_XoaTo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaTo", SqlDbType.Int);

                cmd.Parameters["@MaTo"].Value = MaTo;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
