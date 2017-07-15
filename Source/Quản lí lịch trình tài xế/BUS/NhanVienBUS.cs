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
    }
}
