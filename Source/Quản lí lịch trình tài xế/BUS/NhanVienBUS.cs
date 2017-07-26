using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class NhanVienBUS
    {
        public static bool DangNhap(NhanVienDTO NV)
        {
            return NhanVienDAO.DangNhap(NV);
        }

        public static string LayPQ(string Username)
        {
            return NhanVienDAO.LayPQ(Username);
        }

        public static string LayTenND(string Username)
        {
            return NhanVienDAO.LayTenND(Username);
        }

        public static NhanVienDTO LoadThongTinTaiXe(string Username)
        {
            return NhanVienDAO.LoadThongTinTaiXe(Username);
        }

        public static bool CapNhatThongTin(NhanVienDTO NV)
        {
            return NhanVienDAO.CapNhatThongTin(NV);
        }

        public static string LayMatKhau(string Username)
        {
            return NhanVienDAO.LayMatKhau(Username);
        }

        public static bool DoiMatKhau(NhanVienDTO NV)
        {
            return NhanVienDAO.DoiMatKhau(NV);
        }

        public static DataTable LoadNV()
        {
            return NhanVienDAO.LoadNV(); 
        }

        public static DataTable LoadNVTrongTo(int MaTo)
        {
            return NhanVienDAO.LoadNVTrongTo(MaTo);
        }

        public static DataTable LoadNVTrongToTheoKhaNang(int MaTo, long KhoangCach)
        {
            return NhanVienDAO.LoadNVTrongToTheoKhaNang(MaTo, KhoangCach);
        }

        public static DataTable LoadToTruong()
        {
            return NhanVienDAO.LoadToTruong();
        }

        public static string GetIDNhanVien()
        {
            return NhanVienDAO.GetIDNhanVien();
        }

        public static bool ThemNV(NhanVienDTO NV)
        {
            return NhanVienDAO.ThemNV(NV);
        }

        public static bool XoaNV(string MaNV)
        {
            return NhanVienDAO.XoaNV(MaNV);
        }
    }
}
