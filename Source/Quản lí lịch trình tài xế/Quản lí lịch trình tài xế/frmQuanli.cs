using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace Quản_lí_lịch_trình_tài_xế
{
    public partial class frmQuanli : Form
    {
        string Username, MaNV;
        public frmQuanli(string Hoten, string PhanQuyen, string username)
        {
            InitializeComponent();
            lbHoten.Text = "Họ tên: " + Hoten;
            lbChucvu.Text = "Chức vụ: " + PhanQuyen;
            Username = username;
            NhanVienDTO NV = new NhanVienDTO();
            NV = NhanVienBUS.LoadThongTinTaiXe(Username);
            MaNV = NV.MaNV;
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }

        private void btnTuyenduong_Click(object sender, EventArgs e)
        {
            frmTuyenDuong frm = new frmTuyenDuong();
            frm.ShowDialog();
            //LoadData();
        }

        private void btnChuyenxe_Click(object sender, EventArgs e)
        {
            frmChuyenXe frm = new frmChuyenXe();
            frm.ShowDialog();
            //LoadData();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThayDoiPass frm = new frmThayDoiPass(Username, MaNV);
            frm.ShowDialog();
        }
    }
}
