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

        public static string GetIDTuyenDuong()
        {
            SqlConnection con = DataProvider.Connection();
            SqlCommand cmd = new SqlCommand("sp_GetIDTuyenDuong", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaTuyen", SqlDbType.VarChar);
            cmd.Parameters["@MaTuyen"].Direction = ParameterDirection.Output;
            cmd.Parameters["@MaTuyen"].Size = 10;
            cmd.ExecuteNonQuery();
            string MaTuyen = cmd.Parameters["@MaTuyen"].Value.ToString();
            con.Close();
            return MaTuyen;
        }

        public static bool ThemTuyenDuong(TuyenDuongDTO T)
        {
            try
            {
                SqlConnection con = DataProvider.Connection();
                SqlCommand cmd = new SqlCommand("sp_ThemTuyenDuong", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaTuyen", SqlDbType.VarChar);
                cmd.Parameters.Add("@TenTuyen", SqlDbType.NVarChar);
                cmd.Parameters.Add("@KhoangCach", SqlDbType.BigInt);

                cmd.Parameters["@MaTuyen"].Value = T.MaTuyen;
                cmd.Parameters["@TenTuyen"].Value = T.TenTuyen;
                cmd.Parameters["@KhoangCach"].Value = T.KhoangCach;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool CapNhatTuyenDuong(TuyenDuongDTO T)
        {
            try
            {
                SqlConnection con = DataProvider.Connection();
                SqlCommand cmd = new SqlCommand("sp_CapNhatTuyenDuong", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaTuyen", SqlDbType.VarChar);
                cmd.Parameters.Add("@TenTuyen", SqlDbType.NVarChar);
                cmd.Parameters.Add("@KhoangCach", SqlDbType.BigInt);

                cmd.Parameters["@MaTuyen"].Value = T.MaTuyen;
                cmd.Parameters["@TenTuyen"].Value = T.TenTuyen;
                cmd.Parameters["@KhoangCach"].Value = T.KhoangCach;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool XoaTuyenDuong(string MaTuyen)
        {
            try
            {
                SqlConnection con = DataProvider.Connection();
                SqlCommand cmd = new SqlCommand("sp_XoaTuyenDuong", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaTuyen", SqlDbType.VarChar);

                cmd.Parameters["@MaTuyen"].Value = MaTuyen;
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
