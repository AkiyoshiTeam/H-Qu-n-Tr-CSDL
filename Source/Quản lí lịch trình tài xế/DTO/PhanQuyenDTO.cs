using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhanQuyenDTO
    {
        int _maPQ;
        string _tenPQ;

        public int MaPQ { get => _maPQ; set => _maPQ = value; }
        public string TenPQ { get => _tenPQ; set => _tenPQ = value; }
    }
}
