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
    public class PhanQuyenBUS
    {
        public static DataTable LoadPhanQuyen()
        {
            return PhanQuyenDAO.LoadPhanQuyen();
        }

        public static DataTable LoadTinhTrang()
        {
            return PhanQuyenDAO.LoadTinhTrang();
        }
    }
}
