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
    public class LichTrinhDAO
    {
        public static DataTable LoadLichTrinhCaNhan(string MaNV)
        {
            SqlConnection con = DataProvider.Connection();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_LichTrinhCN", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaNV", SqlDbType.VarChar);
            cmd.Parameters["@MaNV"].Value = MaNV;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con = DataProvider.Disconnection();
            return dt;
        }

        public static DataTable LoadLichTrinhTo(int MaTo)
        {
            SqlConnection con = DataProvider.Connection();
            DataTable dt = new DataTable();
            string sql = @"Select L.MaLich,L.Thang,N.MaNV,L.GioDi,L.GioDen,L.NoiDi,L.NoiDen,C.MaChuyen,T.MaTuyen,T.KhoangCach " +
                          "From (((NhanVien N join LichTrinh L on N.MaNV=L.MaNV) join ChuyenXe C on L.MaChuyen=C.MaChuyen) join TuyenDuong T on C.MaTuyen=T.MaTuyen) join Nhom G on N.MaTo=G.MaTo " +
                          "Where G.MaTo = '" + MaTo.ToString() + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con = DataProvider.Disconnection();
            return dt;
        }

        public static DataTable LoadLichTrinh()
        {
            SqlConnection con = DataProvider.Connection();
            DataTable dt = new DataTable();
            string sql = @"Select L.MaLich,L.Thang,N.MaNV,L.GioDi,L.GioDen,L.NoiDi,L.NoiDen,C.MaChuyen,T.MaTuyen,T.KhoangCach " +
                          "From ((NhanVien N join LichTrinh L on N.MaNV=L.MaNV) join ChuyenXe C on L.MaChuyen=C.MaChuyen) join TuyenDuong T on C.MaTuyen=T.MaTuyen ";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con = DataProvider.Disconnection();
            return dt;
        }
        //
        public static DataTable LoadLichTrinhTheoTuyen(string MaTuyen)
        {
            SqlConnection con = DataProvider.Connection();
            DataTable dt = new DataTable();
            string sql = @"Select L.MaLich,L.Thang,N.MaNV,L.GioDi,L.GioDen,L.NoiDi,L.NoiDen,C.MaChuyen,T.KhoangCach,C.GiaVe,L.SoLuongVeBanDuoc " +
                          "From ((NhanVien N join LichTrinh L on N.MaNV=L.MaNV) join ChuyenXe C on L.MaChuyen=C.MaChuyen) join TuyenDuong T on C.MaTuyen=T.MaTuyen " +
                          "Where T.MaTuyen = '" + MaTuyen + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con = DataProvider.Disconnection();
            return dt;
        }
        //
        public static DataTable LoadLichTrinhThang(int Thang)
        {
            SqlConnection con = DataProvider.Connection();
            DataTable dt = new DataTable();
            string sql = @"Select L.MaLich,L.Thang,N.MaNV,L.GioDi,L.GioDen,L.NoiDi,L.NoiDen,C.MaChuyen,T.MaTuyen,T.KhoangCach " +
                          "From ((NhanVien N join LichTrinh L on N.MaNV=L.MaNV) join ChuyenXe C on L.MaChuyen=C.MaChuyen) join TuyenDuong T on C.MaTuyen=T.MaTuyen " +
                          "Where L.Thang = " + Thang.ToString();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con = DataProvider.Disconnection();
            return dt;
        }

        public static bool ThemLichTrinh(LichTrinhDTO L)
        {
            try
            {
                SqlConnection con = DataProvider.Connection();
                SqlCommand cmd = new SqlCommand("sp_ThemLichTrinh", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Thang", SqlDbType.Int);
                cmd.Parameters.Add("@MaNV", SqlDbType.VarChar);
                cmd.Parameters.Add("@GioDi", SqlDbType.DateTime);
                cmd.Parameters.Add("@GioDen", SqlDbType.DateTime);
                cmd.Parameters.Add("@NoiDi", SqlDbType.NVarChar);
                cmd.Parameters.Add("@NoiDen", SqlDbType.NVarChar);
                cmd.Parameters.Add("@MaChuyen", SqlDbType.VarChar);

                cmd.Parameters["@Thang"].Value = L.Thang;
                cmd.Parameters["@MaNV"].Value = L.MaNV;
                cmd.Parameters["@GioDi"].Value = L.GioDi;
                cmd.Parameters["@GioDen"].Value = L.GioDen;
                cmd.Parameters["@NoiDi"].Value = L.NoiDi;
                cmd.Parameters["@NoiDen"].Value = L.NoiDen;
                cmd.Parameters["@MaChuyen"].Value = L.MaChuyen;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool CapNhatLichTrinh(LichTrinhDTO L)
        {
            try
            {
                SqlConnection con = DataProvider.Connection();
                SqlCommand cmd = new SqlCommand("sp_CapNhatLichTrinh", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaLich", SqlDbType.Int);
                cmd.Parameters.Add("@Thang", SqlDbType.Int);
                cmd.Parameters.Add("@MaNV", SqlDbType.VarChar);
                cmd.Parameters.Add("@GioDi", SqlDbType.DateTime);
                cmd.Parameters.Add("@GioDen", SqlDbType.DateTime);
                cmd.Parameters.Add("@NoiDi", SqlDbType.NVarChar);
                cmd.Parameters.Add("@NoiDen", SqlDbType.NVarChar);
                cmd.Parameters.Add("@MaChuyen", SqlDbType.VarChar);

                cmd.Parameters["@MaLich"].Value = L.MaLich;
                cmd.Parameters["@Thang"].Value = L.Thang;
                cmd.Parameters["@MaNV"].Value = L.MaNV;
                cmd.Parameters["@GioDi"].Value = L.GioDi;
                cmd.Parameters["@GioDen"].Value = L.GioDen;
                cmd.Parameters["@NoiDi"].Value = L.NoiDi;
                cmd.Parameters["@NoiDen"].Value = L.NoiDen;
                cmd.Parameters["@MaChuyen"].Value = L.MaChuyen;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool XoaLichTrinh(int MaLich)
        {
            try
            {
                SqlConnection con = DataProvider.Connection();
                SqlCommand cmd = new SqlCommand("sp_XoaLichTrinh", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaLich", SqlDbType.Int);

                cmd.Parameters["@MaLich"].Value = MaLich;
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
