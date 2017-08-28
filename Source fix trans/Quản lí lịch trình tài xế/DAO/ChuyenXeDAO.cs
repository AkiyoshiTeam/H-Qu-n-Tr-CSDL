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

        public static string GetIDChuyenXe()
        {
            SqlConnection con = DataProvider.Connection();
            SqlCommand cmd = new SqlCommand("sp_GetIDChuyenXe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaChuyen", SqlDbType.VarChar);
            cmd.Parameters["@MaChuyen"].Direction = ParameterDirection.Output;
            cmd.Parameters["@MaChuyen"].Size = 10;
            cmd.ExecuteNonQuery();
            string MaTuyen = cmd.Parameters["@MaChuyen"].Value.ToString();
            con.Close();
            return MaTuyen;
        }

        public static bool ThemChuyenXe(ChuyenXeDTO C)
        {
            try
            {
                SqlConnection con = DataProvider.Connection();
                SqlCommand cmd = new SqlCommand("sp_ThemChuyenXe", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaChuyen", SqlDbType.VarChar);
                cmd.Parameters.Add("@HangXe", SqlDbType.NVarChar);
                cmd.Parameters.Add("@GiaVe", SqlDbType.BigInt);
                cmd.Parameters.Add("@MaTuyen", SqlDbType.VarChar);

                cmd.Parameters["@MaChuyen"].Value = C.MaChuyen;
                cmd.Parameters["@HangXe"].Value = C.HangXe;
                cmd.Parameters["@GiaVe"].Value = C.GiaVe;
                cmd.Parameters["@MaTuyen"].Value = C.MaTuyen;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool CapNhatChuyenXe(ChuyenXeDTO C)
        {
            try
            {
                SqlConnection con = DataProvider.Connection();
                SqlCommand cmd = new SqlCommand("sp_CapNhatChuyenXe", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaChuyen", SqlDbType.VarChar);
                cmd.Parameters.Add("@HangXe", SqlDbType.NVarChar);
                cmd.Parameters.Add("@GiaVe", SqlDbType.BigInt);
                cmd.Parameters.Add("@MaTuyen", SqlDbType.VarChar);

                cmd.Parameters["@MaChuyen"].Value = C.MaChuyen;
                cmd.Parameters["@HangXe"].Value = C.HangXe;
                cmd.Parameters["@GiaVe"].Value = C.GiaVe;
                cmd.Parameters["@MaTuyen"].Value = C.MaTuyen;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool XoaChuyenXe(string MaChuyen)
        {
            try
            {
                SqlConnection con = DataProvider.Connection();
                SqlCommand cmd = new SqlCommand("sp_XoaChuyenXe", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaChuyen", SqlDbType.VarChar);
                cmd.Parameters["@MaChuyen"].Value = MaChuyen;
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
