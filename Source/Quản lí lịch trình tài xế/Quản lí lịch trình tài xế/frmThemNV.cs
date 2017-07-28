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
    public partial class frmThemNV : Form
    {
        public frmThemNV()
        {
            InitializeComponent();
        }

        private void frmThemNV_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            cboPhanQuyen.DataSource = PhanQuyenBUS.LoadPhanQuyen();
            cboPhanQuyen.DisplayMember = "TenPQ";
            cboPhanQuyen.ValueMember = "MaPQ";

            cboTo.DataSource = ToBUS.LoadTo();
            cboTo.DisplayMember = "MaTo";
            cboTo.ValueMember = "MaTo";

            txtMaNV.Text = NhanVienBUS.GetIDNhanVien();
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

        void Reset()
        {
            txtMaNV.Text = NhanVienBUS.GetIDNhanVien();
            txtHoten.ResetText();
            txtDiaChi.ResetText();
            txtCMND.ResetText();
            txtDienthoai.ResetText();
            txtKhanang.ResetText();
            txtUsername.ResetText();
            txtPassword.Text = "123456";
        }

        private void btnThem_Click(object sender, EventArgs e)
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
                NV.Password = txtPassword.Text;
                NV.MaPQ = Int32.Parse(cboPhanQuyen.SelectedValue.ToString());
                NV.MaTo = Int32.Parse(cboTo.SelectedValue.ToString());
                if (NhanVienBUS.ThemNV(NV) == true)
                {
                    MessageBox.Show("Thêm nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();

                }
                else if (NhanVienBUS.ThemNV(NV) == false)
                {
                    MessageBox.Show("Thêm nhân viên thất bại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show(KiemTra(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtKhanang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
