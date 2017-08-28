using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TuyenDuongDTO
    {
        string _maTuyen, _tenTuyen;
        long _khoangCach;

        public string MaTuyen { get => _maTuyen; set => _maTuyen = value; }
        public string TenTuyen { get => _tenTuyen; set => _tenTuyen = value; }
        public long KhoangCach { get => _khoangCach; set => _khoangCach = value; }
    }
}
