using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class ChuyenXeBUS
    {
        public static DataTable LoadChuyenXe()
        {
            return ChuyenXeDAO.LoadChuyenXe();
        }

        public static DataTable LoadChuyenXeTheoTuyenDuong(string MaTuyen)
        {
            return ChuyenXeDAO.LoadChuyenXeTheoTuyenDuong(MaTuyen);
        }

        public static string GetIDChuyenXe()
        {
            return ChuyenXeDAO.GetIDChuyenXe();
        }

        public static bool ThemChuyenXe(ChuyenXeDTO C)
        {
            return ChuyenXeDAO.ThemChuyenXe(C);
        }

        public static bool CapNhatChuyenXe(ChuyenXeDTO C)
        {
            return ChuyenXeDAO.CapNhatChuyenXe(C);
        }

        public static bool XoaChuyenXe(string MaChuyen)
        {
            return ChuyenXeDAO.XoaChuyenXe(MaChuyen);
        }
    }
}
