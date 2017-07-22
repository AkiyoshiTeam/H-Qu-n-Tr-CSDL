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
    }
}
