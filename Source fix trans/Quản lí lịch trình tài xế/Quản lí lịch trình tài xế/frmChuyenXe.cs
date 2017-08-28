using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Quản_lí_lịch_trình_tài_xế
{
    public partial class frmChuyenXe : Form
    {
        public frmChuyenXe()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChuyenXe_Load(object sender, EventArgs e)
        {
            LoadData();
            txtMaChuyen.Text = ChuyenXeBUS.GetIDChuyenXe();
            btnThem.Enabled = true;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
        }

        void LoadData()
        {
            dgvDanhSach.DataSource = ChuyenXeBUS.LoadChuyenXe();
            Custom();
            dgvDanhSach.ClearSelection();

            cboTuyenDuong.DataSource = TuyenDuongBUS.LoadTuyenDuong();
            cboTuyenDuong.DisplayMember = "TenTuyen";
            cboTuyenDuong.ValueMember = "MaTuyen";
        }

        void Custom()
        {
            dgvDanhSach.AutoGenerateColumns = false;
            dgvDanhSach.Columns.Clear();
            dgvDanhSach.AllowUserToAddRows = false;

            DataGridViewTextBoxColumn dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Mã chuyến";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCol.DataPropertyName = "MaChuyen";
            dgvCol.ReadOnly = true;
            dgvDanhSach.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Hãng xe";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCol.DataPropertyName = "HangXe";
            dgvCol.ReadOnly = true;
            dgvDanhSach.Columns.Add(dgvCol);

            DataGridViewComboBoxColumn dgvCo = new DataGridViewComboBoxColumn();
            dgvCo.HeaderText = "Tuyến đường";
            dgvCo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvCo.DataSource = TuyenDuongBUS.LoadTuyenDuong();
            dgvCo.DisplayMember = "TenTuyen";
            dgvCo.ValueMember = "MaTuyen";
            dgvCo.DataPropertyName = "MaTuyen";
            dgvCo.ReadOnly = true;
            dgvCo.Width = 320;
            dgvCo.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dgvDanhSach.Columns.Add(dgvCo);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Giá vé";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCol.DataPropertyName = "GiaVe";
            dgvCol.ReadOnly = true;
            dgvCol.DefaultCellStyle.Format = "#,0 VNĐ";
            dgvDanhSach.Columns.Add(dgvCol);
        }

        void Reset()
        {
            txtMaChuyen.Text = ChuyenXeBUS.GetIDChuyenXe();
            txtHangXe.ResetText();
            txtGiaVe.ResetText();
            btnThem.Enabled = true;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
        }

        string KiemTra()
        {
            string KT = "";
            if (txtHangXe.Text == "")
                KT += "- Hãng xe không được để trống.\n";
            if (txtGiaVe.Text == "")
                KT += "- Giá vé không được để trống.\n";
            return KT;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void txtGiaVe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaChuyen.Text = dgvDanhSach.CurrentRow.Cells[0].Value.ToString();
            txtHangXe.Text = dgvDanhSach.CurrentRow.Cells[1].Value.ToString();
            cboTuyenDuong.SelectedValue = dgvDanhSach.CurrentRow.Cells[2].Value.ToString();
            txtGiaVe.Text = dgvDanhSach.CurrentRow.Cells[3].Value.ToString();
            btnThem.Enabled = false;
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void dgvDanhSach_KeyDown(object sender, KeyEventArgs e)
        {
            txtMaChuyen.Text = dgvDanhSach.CurrentRow.Cells[0].Value.ToString();
            txtHangXe.Text = dgvDanhSach.CurrentRow.Cells[1].Value.ToString();
            cboTuyenDuong.SelectedValue = dgvDanhSach.CurrentRow.Cells[2].Value.ToString();
            txtGiaVe.Text = dgvDanhSach.CurrentRow.Cells[3].Value.ToString();
            btnThem.Enabled = false;
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void dgvDanhSach_KeyUp(object sender, KeyEventArgs e)
        {
            txtMaChuyen.Text = dgvDanhSach.CurrentRow.Cells[0].Value.ToString();
            txtHangXe.Text = dgvDanhSach.CurrentRow.Cells[1].Value.ToString();
            cboTuyenDuong.SelectedValue = dgvDanhSach.CurrentRow.Cells[2].Value.ToString();
            txtGiaVe.Text = dgvDanhSach.CurrentRow.Cells[3].Value.ToString();
            btnThem.Enabled = false;
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTra() == "")
            {
                ChuyenXeDTO C = new ChuyenXeDTO();
                C.MaChuyen = txtMaChuyen.Text;
                C.HangXe = txtHangXe.Text;
                C.GiaVe = Int64.Parse(txtGiaVe.Text);
                C.MaTuyen = cboTuyenDuong.SelectedValue.ToString();
                if (ChuyenXeBUS.ThemChuyenXe(C) == true)
                {
                    MessageBox.Show("Thêm chuyến xe thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    Reset();
                }
                else
                    MessageBox.Show("Thêm chuyến thất bại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show(KiemTra(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (KiemTra() == "")
            {
                ChuyenXeDTO C = new ChuyenXeDTO();
                C.MaChuyen = txtMaChuyen.Text;
                C.HangXe = txtHangXe.Text;
                C.GiaVe = Int64.Parse(txtGiaVe.Text);
                C.MaTuyen = cboTuyenDuong.SelectedValue.ToString();
                if (ChuyenXeBUS.CapNhatChuyenXe(C) == true)
                {
                    MessageBox.Show("Cập nhật chuyến xe thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    Reset();
                }
                else
                    MessageBox.Show("Cập nhật chuyến thất bại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show(KiemTra(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn xóa chuyến xe này ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ChuyenXeBUS.XoaChuyenXe(dgvDanhSach.CurrentRow.Cells[0].Value.ToString()) == true)
                {
                    MessageBox.Show("Xóa chuyến xe thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    Reset();
                }
                else
                    MessageBox.Show("Chuyến xe đã được phân công lịch trình, không thể xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
