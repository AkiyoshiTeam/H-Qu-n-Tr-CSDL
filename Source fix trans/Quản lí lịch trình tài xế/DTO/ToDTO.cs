using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ToDTO
    {
        int _maTo;
        DateTime _ngayLap;
        string _toTruong;

        public int MaTo { get => _maTo; set => _maTo = value; }
        public DateTime NgayLap { get => _ngayLap; set => _ngayLap = value; }
        public string ToTruong { get => _toTruong; set => _toTruong = value; }
    }
}
