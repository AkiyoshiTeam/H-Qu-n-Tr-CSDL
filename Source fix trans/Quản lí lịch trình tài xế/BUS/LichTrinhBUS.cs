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
    public class LichTrinhBUS
    {
        public static DataTable LoadLichTrinhCaNhan(string MaNV)
        {
            return LichTrinhDAO.LoadLichTrinhCaNhan(MaNV);
        }

        public static DataTable LoadLichTrinhTo(int MaTo)
        {
            return LichTrinhDAO.LoadLichTrinhTo(MaTo);
        }

        public static bool ThemLichTrinh(LichTrinhDTO L)
        {
            return LichTrinhDAO.ThemLichTrinh(L);
        }

        public static bool CapNhatLichTrinh(LichTrinhDTO L)
        {
            return LichTrinhDAO.CapNhatLichTrinh(L);
        }

        public static DataTable LoadLichTrinh()
        {
            return LichTrinhDAO.LoadLichTrinh();
        }

        public static bool XoaLichTrinh(int MaLich)
        {
            return LichTrinhDAO.XoaLichTrinh(MaLich);
        }

        public static DataTable LoadLichTrinhThang(int Thang)
        {
            return LichTrinhDAO.LoadLichTrinhThang(Thang);
        }
    }
}
