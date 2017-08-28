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
    public partial class frmTuyenDuong : Form
    {
        public frmTuyenDuong()
        {
            InitializeComponent();
        }

        private void frmTuyenDuong_Load(object sender, EventArgs e)
        {
            LoadData();
            txtMaTuyen.Text = TuyenDuongBUS.GetIDTuyenDuong();
            btnThem.Enabled = true;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
        }

        void LoadData()
        {
            dgvDanhSach.DataSource = TuyenDuongBUS.LoadTuyenDuong();
            Custom();
            dgvDanhSach.ClearSelection();
        }

        void Custom()
        {
            dgvDanhSach.AutoGenerateColumns = false;
            dgvDanhSach.Columns.Clear();
            dgvDanhSach.AllowUserToAddRows = false;

            DataGridViewTextBoxColumn dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Mã tuyến";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCol.DataPropertyName = "MaTuyen";
            dgvCol.ReadOnly = true;
            dgvDanhSach.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Tên tuyến";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCol.DataPropertyName = "TenTuyen";
            dgvCol.Width = 320;
            dgvCol.ReadOnly = true;
            dgvDanhSach.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Khoảng cách";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCol.DataPropertyName = "KhoangCach";
            dgvCol.ReadOnly = true;
            dgvCol.DefaultCellStyle.Format = "#,0 km";
            dgvDanhSach.Columns.Add(dgvCol);
        }

        void Reset()
        {
            txtMaTuyen.Text = TuyenDuongBUS.GetIDTuyenDuong();
            txtTenTuyen.ResetText();
            txtKhoangCach.ResetText();
            btnThem.Enabled = true;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
        }

        string KiemTra()
        {
            string KT = "";
            if (txtTenTuyen.Text == "")
                KT += "- Tên tuyến đường không được để trống.\n";
            if (txtKhoangCach.Text == "")
                KT += "- Khoảng cách không được để trống.\n";
            return KT;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void txtKhoangCach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTra() == "")
            {
                TuyenDuongDTO T = new TuyenDuongDTO();
                T.MaTuyen = txtMaTuyen.Text;
                T.TenTuyen = txtTenTuyen.Text;
                T.KhoangCach = Int64.Parse(txtKhoangCach.Text);

                if (TuyenDuongBUS.ThemTuyenDuong(T) == true)
                {
                    MessageBox.Show("Thêm tuyến đường thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    Reset();
                }
                else
                    MessageBox.Show("Thêm tuyến đường thất bại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show(KiemTra(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (KiemTra() == "")
            {
                TuyenDuongDTO T = new TuyenDuongDTO();
                T.MaTuyen = txtMaTuyen.Text;
                T.TenTuyen = txtTenTuyen.Text;
                T.KhoangCach = Int64.Parse(txtKhoangCach.Text);

                if (TuyenDuongBUS.CapNhatTuyenDuong(T) == true)
                {
                    MessageBox.Show("Cập nhật tuyến đường thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    Reset();
                }
                else
                    MessageBox.Show("Cập nhật tuyến đường thất bại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show(KiemTra(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaTuyen.Text = dgvDanhSach.CurrentRow.Cells[0].Value.ToString();
            txtTenTuyen.Text = dgvDanhSach.CurrentRow.Cells[1].Value.ToString();
            txtKhoangCach.Text = dgvDanhSach.CurrentRow.Cells[2].Value.ToString();
            btnThem.Enabled = false;
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void dgvDanhSach_KeyUp(object sender, KeyEventArgs e)
        {
            txtMaTuyen.Text = dgvDanhSach.CurrentRow.Cells[0].Value.ToString();
            txtTenTuyen.Text = dgvDanhSach.CurrentRow.Cells[1].Value.ToString();
            txtKhoangCach.Text = dgvDanhSach.CurrentRow.Cells[2].Value.ToString();
            btnThem.Enabled = false;
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void dgvDanhSach_KeyDown(object sender, KeyEventArgs e)
        {
            txtMaTuyen.Text = dgvDanhSach.CurrentRow.Cells[0].Value.ToString();
            txtTenTuyen.Text = dgvDanhSach.CurrentRow.Cells[1].Value.ToString();
            txtKhoangCach.Text = dgvDanhSach.CurrentRow.Cells[2].Value.ToString();
            btnThem.Enabled = false;
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn xóa tuyến đường này ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (TuyenDuongBUS.XoaTuyenDuong(dgvDanhSach.CurrentRow.Cells[0].Value.ToString()) == true)
                {
                    MessageBox.Show("Xóa tuyến đường thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    Reset();
                }
                else
                    MessageBox.Show("Tuyến đường đã được phân công lịch trình, không thể xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
