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
    public partial class frmCapNhatNV : Form
    {
        NhanVienDTO NV = new NhanVienDTO();
        public frmCapNhatNV(NhanVienDTO nv)
        {
            InitializeComponent();
            NV = nv;
        }

        private void frmCapNhatNV_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        string KiemTra()
        {
            string KT = "";
            if (txtHoten.Text == "")
                KT += "- Họ tên không được để trống.\n";
            if (txtUsername.Text == "")
                KT += "- Username không được để trống. \n";
            return KT;
        }

        void LoadData()
        {
            cboPhanQuyen.DataSource = PhanQuyenBUS.LoadPhanQuyen();
            cboPhanQuyen.DisplayMember = "TenPQ";
            cboPhanQuyen.ValueMember = "MaPQ";

            cboTo.DataSource = ToBUS.LoadTo();
            cboTo.DisplayMember = "MaTo";
            cboTo.ValueMember = "MaTo";

            txtMaNV.Text = NV.MaNV;
            txtHoten.Text = NV.HoTen;
            txtDiaChi.Text = NV.DiaChi;
            txtCMND.Text = NV.CMND;
            txtDienthoai.Text = NV.DienThoai;
            txtKhanang.Text = NV.KhaNangLai.ToString();
            txtUsername.Text = NV.Username;
            cboTo.SelectedValue = NV.MaTo;
            cboPhanQuyen.SelectedValue = NV.MaPQ;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (KiemTra() == "")
            {
                NhanVienDTO NV = new NhanVienDTO();
                NV.MaNV = txtMaNV.Text;
                NV.HoTen = txtHoten.Text;
                NV.DiaChi = txtDiaChi.Text;
                NV.CMND = txtCMND.Text;
                NV.DienThoai = txtDienthoai.Text;
                if (txtKhanang.Text == "")
                    NV.KhaNangLai = 0;
                else
                    NV.KhaNangLai = Int32.Parse(txtKhanang.Text);
                NV.Username = txtUsername.Text;
                if (cboPhanQuyen.SelectedValue.ToString() == "")
                    NV.MaPQ = 0;
                else
                    NV.MaPQ = Int32.Parse(cboPhanQuyen.SelectedValue.ToString());
                if (cboTo.SelectedValue.ToString() == "")
                    NV.MaTo = 0;
                else
                    NV.MaTo = Int32.Parse(cboTo.SelectedValue.ToString());

                if (NhanVienBUS.CapNhatNV(NV) == true)
                {
                    MessageBox.Show("Cập nhật nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (NhanVienBUS.CapNhatNV(NV) == false)
                {
                    MessageBox.Show("Cập nhật viên thất bại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show(KiemTra(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
