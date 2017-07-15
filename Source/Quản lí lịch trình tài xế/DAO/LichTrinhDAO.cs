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
            string sql = @"Select L.MaLich,L.Thang,L.GioDi,L.GioDen,L.NoiDi,L.NoiDen,C.HangXe,T.TenTuyen,T.KhoangCach " +
                          "From ((NhanVien N join LichTrinh L on N.MaNV=L.MaNV) join ChuyenXe C on L.MaChuyen=C.MaChuyen) join TuyenDuong T on C.MaTuyen=T.MaTuyen " +
                          "Where N.MaNV = '" + MaNV + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con = DataProvider.Disconnection();
            return dt;
        }
    }
}
