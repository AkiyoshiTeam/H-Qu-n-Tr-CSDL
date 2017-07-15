using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        string _maNV, _hoTen, _diaChi, _cMND, _dienThoai, _username, _password;
        int _khaNangLai, _maPQ, _maTo;
        bool _tinhTrang;

        public string MaNV { get => _maNV; set => _maNV = value; }
        public string HoTen { get => _hoTen; set => _hoTen = value; }
        public string DiaChi { get => _diaChi; set => _diaChi = value; }
        public string CMND { get => _cMND; set => _cMND = value; }
        public string DienThoai { get => _dienThoai; set => _dienThoai = value; }
        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public int KhaNangLai { get => _khaNangLai; set => _khaNangLai = value; }
        public int MaPQ { get => _maPQ; set => _maPQ = value; }
        public int MaTo { get => _maTo; set => _maTo = value; }
        public bool TinhTrang { get => _tinhTrang; set => _tinhTrang = value; }
    }
}
