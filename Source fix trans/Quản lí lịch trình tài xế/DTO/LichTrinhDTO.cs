using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LichTrinhDTO
    {
        int _maLich, _thang;
        string _maNV, _noiDi, _noiDen, _maChuyen;
        DateTime _gioDi, _gioDen;

        public int MaLich { get => _maLich; set => _maLich = value; }
        public int Thang { get => _thang; set => _thang = value; }
        public string MaNV { get => _maNV; set => _maNV = value; }
        public string NoiDi { get => _noiDi; set => _noiDi = value; }
        public string NoiDen { get => _noiDen; set => _noiDen = value; }
        public string MaChuyen { get => _maChuyen; set => _maChuyen = value; }
        public DateTime GioDi { get => _gioDi; set => _gioDi = value; }
        public DateTime GioDen { get => _gioDen; set => _gioDen = value; }
    }
}
