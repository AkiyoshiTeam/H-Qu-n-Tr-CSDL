using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChuyenXeDTO
    {
        string _maChuyen, _hangXe, _maTuyen;
        long _giaVe;

        public string MaChuyen { get => _maChuyen; set => _maChuyen = value; }
        public string HangXe { get => _hangXe; set => _hangXe = value; }
        public string MaTuyen { get => _maTuyen; set => _maTuyen = value; }
        public long GiaVe { get => _giaVe; set => _giaVe = value; }
    }
}
