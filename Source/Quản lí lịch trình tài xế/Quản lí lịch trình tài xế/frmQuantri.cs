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
    public partial class frmQuantri : Form
    {
        string Username, MaNV;
        public frmQuantri(string Hoten, string PhanQuyen, string username)
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

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThayDoiPass frm = new frmThayDoiPass(Username, MaNV);
            frm.ShowDialog();
            LoadData();
        }

        private void frmQuantri_Load(object sender, EventArgs e)
        {
            LoadData();
            btnXoa.Enabled = false;
            btnCapnhat.Enabled = false;
            btnLock.Enabled = false;
            btnUnlock.Enabled = false;
        }

        void LoadData()
        {
            dgvDanhSach.DataSource = NhanVienBUS.LoadNV();
            Custom();
            dgvDanhSach.ClearSelection();
        }

        private void dgvDanhSach_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                if (e.Value != null)
                {
                    e.Value = new string('●', e.Value.ToString().Length);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemNV frm = new frmThemNV();
            frm.ShowDialog();
            btnXoa.Enabled = false;
            btnCapnhat.Enabled = false;
            btnLock.Enabled = false;
            btnUnlock.Enabled = false;
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn xóa nhân viên này ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (NhanVienBUS.XoaNV(dgvDanhSach.CurrentRow.Cells[0].Value.ToString()) == true)
                {
                    MessageBox.Show("Xóa nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnXoa.Enabled = false;
                    btnCapnhat.Enabled = false;
                    btnLock.Enabled = false;
                    btnUnlock.Enabled = false;
                    LoadData();
                }
                else if (NhanVienBUS.XoaNV(dgvDanhSach.CurrentRow.Cells[0].Value.ToString()) == false)
                    MessageBox.Show("Xóa nhân viên thất bại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            NhanVienDTO NV = new NhanVienDTO();
            NV.MaNV = dgvDanhSach.CurrentRow.Cells[0].Value.ToString();
            NV.HoTen = dgvDanhSach.CurrentRow.Cells[1].Value.ToString();
            NV.DiaChi = dgvDanhSach.CurrentRow.Cells[2].Value.ToString();
            NV.CMND = dgvDanhSach.CurrentRow.Cells[3].Value.ToString();
            NV.DienThoai = dgvDanhSach.CurrentRow.Cells[4].Value.ToString();
            if (dgvDanhSach.CurrentRow.Cells[5].Value.ToString() == "")
                NV.KhaNangLai = 0;
            else
                NV.KhaNangLai = Int32.Parse(dgvDanhSach.CurrentRow.Cells[5].Value.ToString());
            NV.Username = dgvDanhSach.CurrentRow.Cells[6].Value.ToString();
            if (dgvDanhSach.CurrentRow.Cells[8].Value.ToString() == "")
                NV.MaPQ = 0;
            else
                NV.MaPQ = Int32.Parse(dgvDanhSach.CurrentRow.Cells[8].Value.ToString());
            if (dgvDanhSach.CurrentRow.Cells[9].Value.ToString() == "")
                NV.MaTo = 0;
            else
                NV.MaTo = Int32.Parse(dgvDanhSach.CurrentRow.Cells[9].Value.ToString());

            frmCapNhatNV frm = new frmCapNhatNV(NV);
            frm.ShowDialog();
            btnXoa.Enabled = false;
            btnCapnhat.Enabled = false;
            btnLock.Enabled = false;
            btnUnlock.Enabled = false;
            LoadData();
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoa.Enabled = true;
            btnCapnhat.Enabled = true;
            if(dgvDanhSach.CurrentRow.Cells[10].Value.ToString()=="True")
            {
                btnLock.Enabled = true;
                btnUnlock.Enabled = false;
            }
            else if(dgvDanhSach.CurrentRow.Cells[10].Value.ToString() == "False")
            {
                btnUnlock.Enabled = true;
                btnLock.Enabled = false;
            }
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn khóa tài khoản này ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (NhanVienBUS.Khoa(dgvDanhSach.CurrentRow.Cells[0].Value.ToString()) == true)
                {
                    MessageBox.Show("Khóa tài khoản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnXoa.Enabled = false;
                    btnCapnhat.Enabled = false;
                    btnLock.Enabled = false;
                    btnUnlock.Enabled = false;
                    LoadData();
                }
                else
                    MessageBox.Show("Khóa tài khoản thất bại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn mở khóa tài khoản này ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (NhanVienBUS.MoKhoa(dgvDanhSach.CurrentRow.Cells[0].Value.ToString()) == true)
                {
                    MessageBox.Show("Mở khóa tài khoản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnXoa.Enabled = false;
                    btnCapnhat.Enabled = false;
                    btnLock.Enabled = false;
                    btnUnlock.Enabled = false;
                    LoadData();
                }
                else
                    MessageBox.Show("Mở khóa tài khoản thất bại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDanhSach_KeyUp(object sender, KeyEventArgs e)
        {
            btnXoa.Enabled = true;
            btnCapnhat.Enabled = true;
            if (dgvDanhSach.CurrentRow.Cells[10].Value.ToString() == "True")
            {
                btnLock.Enabled = true;
                btnUnlock.Enabled = false;
            }
            else if (dgvDanhSach.CurrentRow.Cells[10].Value.ToString() == "False")
            {
                btnUnlock.Enabled = true;
                btnLock.Enabled = false;
            }
        }

        private void dgvDanhSach_KeyDown(object sender, KeyEventArgs e)
        {
            btnXoa.Enabled = true;
            btnCapnhat.Enabled = true;
            if (dgvDanhSach.CurrentRow.Cells[10].Value.ToString() == "True")
            {
                btnLock.Enabled = true;
                btnUnlock.Enabled = false;
            }
            else if (dgvDanhSach.CurrentRow.Cells[10].Value.ToString() == "False")
            {
                btnUnlock.Enabled = true;
                btnLock.Enabled = false;
            }
        }

        void Custom()
        {
            dgvDanhSach.AutoGenerateColumns = false;
            dgvDanhSach.Columns.Clear();
            dgvDanhSach.AllowUserToAddRows = false;

            DataGridViewTextBoxColumn dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Mã nhân viên";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCol.DataPropertyName = "MaNV";
            dgvCol.ReadOnly = true;
            dgvDanhSach.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Họ tên";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvCol.DataPropertyName = "HoTen";
            dgvCol.Width = 160;
            dgvCol.ReadOnly = true;
            dgvDanhSach.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Địa chỉ";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvCol.DataPropertyName = "DiaChi";
            dgvCol.ReadOnly = true;
            dgvCol.Width = 300;
            dgvDanhSach.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "CMND";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvCol.DataPropertyName = "CMND";
            dgvCol.ReadOnly = true;
            dgvCol.Width = 120;
            dgvDanhSach.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Điện thoại";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvCol.DataPropertyName = "DienThoai";
            dgvCol.ReadOnly = true;
            dgvCol.Width = 110;
            dgvDanhSach.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Khả năng lái";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCol.DataPropertyName = "KhaNangLai";
            dgvCol.ReadOnly = true;
            dgvCol.DefaultCellStyle.Format = "#,0 km";
            dgvDanhSach.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Username";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCol.DataPropertyName = "Username";
            dgvCol.ReadOnly = true;
            dgvDanhSach.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Password";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCol.DataPropertyName = "Password";
            dgvCol.ReadOnly = true;
            dgvDanhSach.Columns.Add(dgvCol);

            DataGridViewComboBoxColumn dgvCo = new DataGridViewComboBoxColumn();
            dgvCo.HeaderText = "Phân quyền";
            dgvCo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCo.DataSource = PhanQuyenBUS.LoadPhanQuyen();
            dgvCo.DisplayMember = "TenPQ";
            dgvCo.ValueMember = "MaPQ";
            dgvCo.DataPropertyName = "MaPQ";
            dgvCo.ReadOnly = true;
            dgvCo.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dgvDanhSach.Columns.Add(dgvCo);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Tổ";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCol.DataPropertyName = "MaTo";
            dgvCol.ReadOnly = true;
            dgvDanhSach.Columns.Add(dgvCol);

            dgvCo = new DataGridViewComboBoxColumn();
            dgvCo.HeaderText = "Tình trạng";
            dgvCo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCo.DataSource = PhanQuyenBUS.LoadTinhTrang();
            dgvCo.DisplayMember = "TenTinhTrang";
            dgvCo.ValueMember = "MaTinhTrang";
            dgvCo.DataPropertyName = "TinhTrang";
            dgvCo.ReadOnly = true;
            dgvCo.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dgvDanhSach.Columns.Add(dgvCo);
        }
    }
}
