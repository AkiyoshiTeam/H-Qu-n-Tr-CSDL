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
    public partial class frmTo : Form
    {
        public frmTo()
        {
            InitializeComponent();
        }

        private void frmTo_Load(object sender, EventArgs e)
        {
            LoadData();
            txtMaTo.Text = "Chương trình phát sinh tự động.";
            dtkNgayLap.Value = DateTime.Now;
            btnThem.Enabled = true;
            cboToTruong.Enabled = false;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
        }

        void LoadData()
        {
            dgvDanhSach.DataSource = ToBUS.LoadTo();
            Custom();
            dgvDanhSach.ClearSelection();
        }

        void Custom()
        {
            dgvDanhSach.AutoGenerateColumns = false;
            dgvDanhSach.Columns.Clear();
            dgvDanhSach.AllowUserToAddRows = false;

            DataGridViewTextBoxColumn dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Mã tổ";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCol.DataPropertyName = "MaTo";
            dgvCol.ReadOnly = true;
            dgvDanhSach.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Ngày lập";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCol.DataPropertyName = "NgayLap";
            dgvCol.ReadOnly = true;
            dgvDanhSach.Columns.Add(dgvCol);

            DataGridViewComboBoxColumn dgvCo = new DataGridViewComboBoxColumn();
            dgvCo.HeaderText = "Tổ trưởng";
            dgvCo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCo.DataSource = NhanVienBUS.LoadNV();
            dgvCo.DisplayMember = "HoTen";
            dgvCo.ValueMember = "MaNV";
            dgvCo.DataPropertyName = "ToTruong";
            dgvCo.ReadOnly = true;
            dgvCo.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dgvDanhSach.Columns.Add(dgvCo);
        }

        void Reset()
        {
            txtMaTo.Text = "Chương trình phát sinh tự động.";
            dtkNgayLap.Value = DateTime.Now;
            cboToTruong.DataSource = null;
            cboToTruong.Enabled = false;
            btnThem.Enabled = true;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaTo.Text = dgvDanhSach.CurrentRow.Cells[0].Value.ToString();
            dtkNgayLap.Value = DateTime.Parse(dgvDanhSach.CurrentRow.Cells[1].Value.ToString());
            cboToTruong.DataSource = NhanVienBUS.LoadNVTrongTo(Int32.Parse(dgvDanhSach.CurrentRow.Cells[0].Value.ToString()));
            cboToTruong.DisplayMember = "HoTen";
            cboToTruong.ValueMember = "MaNV";
            cboToTruong.Enabled = true;
            cboToTruong.SelectedValue = dgvDanhSach.CurrentRow.Cells[2].Value.ToString();
            btnThem.Enabled = false;
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void dgvDanhSach_KeyUp(object sender, KeyEventArgs e)
        {
            txtMaTo.Text = dgvDanhSach.CurrentRow.Cells[0].Value.ToString();
            dtkNgayLap.Value = DateTime.Parse(dgvDanhSach.CurrentRow.Cells[1].Value.ToString());
            cboToTruong.DataSource = NhanVienBUS.LoadNVTrongTo(Int32.Parse(dgvDanhSach.CurrentRow.Cells[0].Value.ToString()));
            cboToTruong.DisplayMember = "HoTen";
            cboToTruong.ValueMember = "MaNV";
            cboToTruong.Enabled = true;
            cboToTruong.SelectedValue = dgvDanhSach.CurrentRow.Cells[2].Value.ToString();
            btnThem.Enabled = false;
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void dgvDanhSach_KeyDown(object sender, KeyEventArgs e)
        {
            txtMaTo.Text = dgvDanhSach.CurrentRow.Cells[0].Value.ToString();
            dtkNgayLap.Value = DateTime.Parse(dgvDanhSach.CurrentRow.Cells[1].Value.ToString());
            cboToTruong.DataSource = NhanVienBUS.LoadNVTrongTo(Int32.Parse(dgvDanhSach.CurrentRow.Cells[0].Value.ToString()));
            cboToTruong.DisplayMember = "HoTen";
            cboToTruong.ValueMember = "MaNV";
            cboToTruong.Enabled = true;
            cboToTruong.SelectedValue = dgvDanhSach.CurrentRow.Cells[2].Value.ToString();
            btnThem.Enabled = false;
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ToDTO T = new ToDTO();
            T.NgayLap = dtkNgayLap.Value;
            if (ToBUS.ThemTo(T) == true)
            {
                MessageBox.Show("Thêm tổ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                Reset();
            }
            else
                MessageBox.Show("Thêm tổ thất bại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            ToDTO T = new ToDTO();
            T.MaTo = Int32.Parse(txtMaTo.Text);
            T.NgayLap = dtkNgayLap.Value;
            try { T.ToTruong = cboToTruong.SelectedValue.ToString(); }
            catch { T.ToTruong = "NULL"; }
            if (ToBUS.CapNhatTo(T) == true)
            {
                MessageBox.Show("Cập nhật tổ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                Reset();
            }
            else
                MessageBox.Show("Cập nhật tổ thất bại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn xóa tổ này ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ToBUS.XoaTo(Int32.Parse(dgvDanhSach.CurrentRow.Cells[0].Value.ToString())) == true)
                {
                    MessageBox.Show("Xóa tổ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    Reset();
                }
                else
                    MessageBox.Show("Xóa tổ thất bại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
