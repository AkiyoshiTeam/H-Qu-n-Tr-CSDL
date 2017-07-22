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
    public class TuyenDuongBUS
    {
        public static DataTable LoadTuyenDuong()
        {
            return TuyenDuongDAO.LoadTuyenDuong();
        }

        public static long LayKhoangCach(string MaTuyen)
        {
            return TuyenDuongDAO.LayKhoangCach(MaTuyen);
        }
    }
}
