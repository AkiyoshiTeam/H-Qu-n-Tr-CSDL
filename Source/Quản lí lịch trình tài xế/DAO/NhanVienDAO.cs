using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class NhanVienDAO
    {
        public static bool DangNhap(NhanVienDTO NV)
        {
            bool KQ = new bool();
            SqlConnection con = DataProvider.Connection();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_DangNhap", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Username", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Password", SqlDbType.VarChar);
                cmd.Parameters.Add("@Trave", SqlDbType.Int);
                cmd.Parameters["@Trave"].Direction = ParameterDirection.Output;

                cmd.Parameters["@Username"].Value = NV.Username;
                cmd.Parameters["@Password"].Value = NV.Password;
                cmd.ExecuteNonQuery();
                string Trave = cmd.Parameters["@Trave"].Value.ToString();
                if (Trave == "0")
                    KQ = false;
                else if (Trave == "1")
                    KQ = true;

            }
            catch
            {
                KQ = false;
            }
            finally
            {
                con = DataProvider.Disconnection();
            }
            return KQ;
        }

        public static string LayPQ(string Username)
        {
            string TenPQ = "";
            SqlConnection con = DataProvider.Connection();
            string sql = @"Select P.TenPQ From NhanVien N join PhanQuyen P on N.MaPQ=P.MaPQ Where N.Username ='" + Username + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                TenPQ = row["TenPQ"].ToString();
            }
            con = DataProvider.Disconnection();
            return TenPQ;
        }

        public static string LayTenND(string Username)
        {
            string TenND = "";
            SqlConnection con = DataProvider.Connection();
            string sql = @"Select HoTen From NhanVien Where Username ='" + Username + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                TenND = row["HoTen"].ToString();
            }
            con = DataProvider.Disconnection();
            return TenND;
        }

        public static string LayTinhTrang(string Username)
        {
            SqlConnection con = DataProvider.Connection();
            SqlCommand cmd = new SqlCommand("sp_LayTinhTrang", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@username", SqlDbType.NVarChar);
            cmd.Parameters.Add("@tenTT", SqlDbType.NVarChar);
            cmd.Parameters["@tenTT"].Direction = ParameterDirection.Output;
            cmd.Parameters["@tenTT"].Size = 50;

            cmd.Parameters["@username"].Value = Username;
            cmd.ExecuteNonQuery();
            string TinhTrang = cmd.Parameters["@tenTT"].Value.ToString();
            con = DataProvider.Disconnection();
            return TinhTrang;
        }

        public static NhanVienDTO LoadThongTinTaiXe(string Username)
        {
            NhanVienDTO NV = new NhanVienDTO();
            SqlConnection con = DataProvider.Connection();
            string sql = @"Select * From NhanVien Where Username ='" + Username + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                NV.MaNV = row["MaNV"].ToString();
                NV.HoTen = row["HoTen"].ToString();
                NV.DiaChi = row["DiaChi"].ToString();
                NV.CMND = row["CMND"].ToString();
                NV.DienThoai = row["DienThoai"].ToString();
                if (row["KhaNangLai"].ToString() == "")
                    NV.KhaNangLai = 0;
                else
                    NV.KhaNangLai = Int32.Parse(row["KhaNangLai"].ToString());
                NV.Username = row["Username"].ToString();
                NV.Password = row["Password"].ToString();
                if (row["MaTo"].ToString() == "")
                    NV.MaTo = 0;
                else
                    NV.MaTo = Int32.Parse(row["MaTo"].ToString());
            }
            con = DataProvider.Disconnection();
            return NV;
        }

        public static bool CapNhatThongTin(NhanVienDTO NV)
        {
            try
            {
                SqlConnection con = DataProvider.Connection();
                SqlCommand cmd = new SqlCommand("sp_CapNhatthongTin", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaNV", SqlDbType.VarChar);
                cmd.Parameters.Add("@Hoten", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Diachi", SqlDbType.NVarChar);
                cmd.Parameters.Add("@CMND", SqlDbType.VarChar);
                cmd.Parameters.Add("@Dienthoai", SqlDbType.VarChar);
                cmd.Parameters.Add("@Khananglai", SqlDbType.Int);

                cmd.Parameters["@MaNV"].Value = NV.MaNV;
                cmd.Parameters["@Hoten"].Value = NV.HoTen;
                cmd.Parameters["@Diachi"].Value = NV.DiaChi;
                cmd.Parameters["@CMND"].Value = NV.CMND;
                cmd.Parameters["@Dienthoai"].Value = NV.DienThoai;
                cmd.Parameters["@Khananglai"].Value = NV.KhaNangLai;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static string LayMatKhau(string Username)
        {
            string MatKhau = "";
            SqlConnection con = DataProvider.Connection();
            string sql = @"Select Password From NhanVien Where Username ='" + Username + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                MatKhau = row["Password"].ToString();
            }
            con = DataProvider.Disconnection();
            return MatKhau;
        }

        public static bool DoiMatKhau(NhanVienDTO NV)
        {
            try
            {
                SqlConnection con = DataProvider.Connection();
                SqlCommand cmd = new SqlCommand("sp_DoiMatKhau", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaNV", SqlDbType.VarChar);
                cmd.Parameters.Add("@Password", SqlDbType.VarChar);

                cmd.Parameters["@MaNV"].Value = NV.MaNV;
                cmd.Parameters["@Password"].Value = NV.Password;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static DataTable LoadNV()
        {
            SqlConnection con = DataProvider.Connection();
            string sql = @"Select * From NhanVien";
            SqlCommand cmd = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con = DataProvider.Disconnection();
            return dt;
        }

        public static DataTable LoadNVTrongTo(int MaTo)
        {
            SqlConnection con = DataProvider.Connection();
            string sql = @"Select * From NhanVien Where MaTo='" + MaTo.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con = DataProvider.Disconnection();
            return dt;
        }

        public static DataTable LoadNVTrongToTheoKhaNang(int MaTo,long KhoangCach)
        {
            SqlConnection con = DataProvider.Connection();
            string sql = @"Select * From NhanVien Where MaTo='" + MaTo.ToString() + "' and KhaNangLai >= " + KhoangCach;
            SqlCommand cmd = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con = DataProvider.Disconnection();
            return dt;
        }

        public static DataTable LoadNVTheoKhaNang(long KhoangCach)
        {
            SqlConnection con = DataProvider.Connection();
            string sql = @"Select * From NhanVien Where KhaNangLai >= " + KhoangCach;
            SqlCommand cmd = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con = DataProvider.Disconnection();
            return dt;
        }

        public static DataTable LoadToTruong()
        {
            SqlConnection con = DataProvider.Connection();
            string sql = @"Select ToTruong From Nhom";
            SqlCommand cmd = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con = DataProvider.Disconnection();
            return dt;
        }

        public static string GetIDNhanVien()
        {
            SqlConnection con = DataProvider.Connection();
            SqlCommand cmd = new SqlCommand("sp_GetIDNhanVien", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaNV", SqlDbType.VarChar);
            cmd.Parameters["@MaNV"].Direction = ParameterDirection.Output;
            cmd.Parameters["@MaNV"].Size = 10;
            cmd.ExecuteNonQuery();
            string MaSach = cmd.Parameters["@MaNV"].Value.ToString();
            con.Close();
            return MaSach;
        }

        public static bool ThemNV(NhanVienDTO NV)
        {
            try
            {
                SqlConnection con = DataProvider.Connection();
                SqlCommand cmd = new SqlCommand("sp_ThemNV", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaNV", SqlDbType.VarChar);
                cmd.Parameters.Add("@Hoten", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Diachi", SqlDbType.NVarChar);
                cmd.Parameters.Add("@CMND", SqlDbType.VarChar);
                cmd.Parameters.Add("@Dienthoai", SqlDbType.VarChar);
                cmd.Parameters.Add("@Khananglai", SqlDbType.Int);
                cmd.Parameters.Add("@Username", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Password", SqlDbType.VarChar);
                cmd.Parameters.Add("@MaPQ", SqlDbType.Int);
                cmd.Parameters.Add("@MaTo", SqlDbType.Int);

                cmd.Parameters["@MaNV"].Value = NV.MaNV;
                cmd.Parameters["@Hoten"].Value = NV.HoTen;
                cmd.Parameters["@Diachi"].Value = NV.DiaChi;
                cmd.Parameters["@CMND"].Value = NV.CMND;
                cmd.Parameters["@Dienthoai"].Value = NV.DienThoai;
                cmd.Parameters["@Khananglai"].Value = NV.KhaNangLai;
                cmd.Parameters["@Username"].Value = NV.Username;
                cmd.Parameters["@Password"].Value = NV.Password;
                cmd.Parameters["@MaPQ"].Value = NV.MaPQ;
                cmd.Parameters["@MaTo"].Value = NV.MaTo;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool XoaNV(string MaNV)
        {
            try
            {
                SqlConnection con = DataProvider.Connection();
                SqlCommand cmd = new SqlCommand("sp_XoaNV", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaNV", SqlDbType.VarChar);

                cmd.Parameters["@MaNV"].Value = MaNV;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool CapNhatNV(NhanVienDTO NV)
        {
            try
            {
                SqlConnection con = DataProvider.Connection();
                SqlCommand cmd = new SqlCommand("sp_CapNhatNV", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaNV", SqlDbType.VarChar);
                cmd.Parameters.Add("@Hoten", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Diachi", SqlDbType.NVarChar);
                cmd.Parameters.Add("@CMND", SqlDbType.VarChar);
                cmd.Parameters.Add("@Dienthoai", SqlDbType.VarChar);
                cmd.Parameters.Add("@Khananglai", SqlDbType.Int);
                cmd.Parameters.Add("@Username", SqlDbType.NVarChar);
                cmd.Parameters.Add("@MaPQ", SqlDbType.Int);
                cmd.Parameters.Add("@MaTo", SqlDbType.Int);

                cmd.Parameters["@MaNV"].Value = NV.MaNV;
                cmd.Parameters["@Hoten"].Value = NV.HoTen;
                cmd.Parameters["@Diachi"].Value = NV.DiaChi;
                cmd.Parameters["@CMND"].Value = NV.CMND;
                cmd.Parameters["@Dienthoai"].Value = NV.DienThoai;
                cmd.Parameters["@Khananglai"].Value = NV.KhaNangLai;
                cmd.Parameters["@Username"].Value = NV.Username;
                cmd.Parameters["@MaPQ"].Value = NV.MaPQ;
                cmd.Parameters["@MaTo"].Value = NV.MaTo;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Khoa(string MaNV)
        {
            try
            {
                SqlConnection con = DataProvider.Connection();
                SqlCommand cmd = new SqlCommand("sp_Khoa", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaNV", SqlDbType.VarChar);

                cmd.Parameters["@MaNV"].Value = MaNV;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool MoKhoa(string MaNV)
        {
            try
            {
                SqlConnection con = DataProvider.Connection();
                SqlCommand cmd = new SqlCommand("sp_MoKhoa", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaNV", SqlDbType.VarChar);

                cmd.Parameters["@MaNV"].Value = MaNV;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //
        public static bool DatVe(int MaLich, int SLVe)
        {
            try
            {
                SqlConnection con = DataProvider.Connection();
                SqlCommand cmd = new SqlCommand("sp_DatVe", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaLich", SqlDbType.Int);
                cmd.Parameters.Add("@SoLuongVeBanDuoc", SqlDbType.Int);

                cmd.Parameters["@MaLich"].Value = MaLich;
                cmd.Parameters["@SoLuongVeBanDuoc"].Value = SLVe;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        // 
        public static bool HuyVe(int MaLich, int SLVe)
        {
            try
            {
                SqlConnection con = DataProvider.Connection();
                SqlCommand cmd = new SqlCommand("sp_HuyVe", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaLich", SqlDbType.Int);
                cmd.Parameters.Add("@SoLuongVeBanDuoc", SqlDbType.Int);

                cmd.Parameters["@MaLich"].Value = MaLich;
                cmd.Parameters["@SoLuongVeBanDuoc"].Value = SLVe;
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
