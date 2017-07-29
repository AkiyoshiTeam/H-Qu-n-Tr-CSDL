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
        long KhoangCach;
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
            LoadData();
        }

        private void btnChuyenxe_Click(object sender, EventArgs e)
        {
            frmChuyenXe frm = new frmChuyenXe();
            frm.ShowDialog();
            LoadData();
        }

        private void btnTo_Click(object sender, EventArgs e)
        {
            frmTo frm = new frmTo();
            frm.ShowDialog();
        }

        private void frmQuanli_Load(object sender, EventArgs e)
        {
            LoadData();
            txtKhoangCach.ResetText();
            txtMaLich.Text = "Chương trình phát sinh tự động.";
            btnXoa.Enabled = false;
            cboChuyenXe.Enabled = false;
            cboMaNV.Enabled = false;
            btnCapNhat.Enabled = false;
        }

        void LoadData()
        {
            dgvLichTrinh.DataSource = LichTrinhBUS.LoadLichTrinh();
            Custom();
            dgvLichTrinh.ClearSelection();

            cboTuyenDuong.DataSource = TuyenDuongBUS.LoadTuyenDuong();
            cboTuyenDuong.DisplayMember = "TenTuyen";
            cboTuyenDuong.ValueMember = "MaTuyen";

            cboChuyenXe.DataSource = ChuyenXeBUS.LoadChuyenXe();
            cboChuyenXe.DisplayMember = "HangXe";
            cboChuyenXe.ValueMember = "MaChuyen";

            cboMaNV.DataSource = NhanVienBUS.LoadNV();
            cboMaNV.DisplayMember = "HoTen";
            cboMaNV.ValueMember = "MaNV";
        }

        void Custom()
        {
            dgvLichTrinh.AutoGenerateColumns = false;
            dgvLichTrinh.Columns.Clear();
            dgvLichTrinh.AllowUserToAddRows = false;

            DataGridViewTextBoxColumn dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Mã lịch";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCol.DataPropertyName = "MaLich";
            dgvCol.ReadOnly = true;
            dgvLichTrinh.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Tháng";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCol.DataPropertyName = "Thang";
            dgvCol.ReadOnly = true;
            dgvLichTrinh.Columns.Add(dgvCol);

            DataGridViewComboBoxColumn dgvCo = new DataGridViewComboBoxColumn();
            dgvCo.HeaderText = "Họ tên";
            dgvCo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvCo.DataSource = NhanVienBUS.LoadNV();
            dgvCo.DisplayMember = "HoTen";
            dgvCo.ValueMember = "MaNV";
            dgvCo.DataPropertyName = "MaNV";
            dgvCo.ReadOnly = true;
            dgvCo.Width = 150;
            dgvCo.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dgvLichTrinh.Columns.Add(dgvCo);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Giờ đi";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvCol.DataPropertyName = "GioDi";
            dgvCol.ReadOnly = true;
            dgvCol.Width = 156;
            dgvLichTrinh.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Giờ đến";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvCol.DataPropertyName = "GioDen";
            dgvCol.ReadOnly = true;
            dgvCol.Width = 156;
            dgvLichTrinh.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Nơi đi";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvCol.DataPropertyName = "NoiDi";
            dgvCol.ReadOnly = true;
            dgvCol.Width = 230;
            dgvLichTrinh.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Nơi đến";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvCol.DataPropertyName = "NoiDen";
            dgvCol.ReadOnly = true;
            dgvCol.Width = 230;
            dgvLichTrinh.Columns.Add(dgvCol);

            dgvCo = new DataGridViewComboBoxColumn();
            dgvCo.HeaderText = "Hãng xe";
            dgvCo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvCo.DataSource = ChuyenXeBUS.LoadChuyenXe();
            dgvCo.DisplayMember = "HangXe";
            dgvCo.ValueMember = "MaChuyen";
            dgvCo.DataPropertyName = "MaChuyen";
            dgvCo.ReadOnly = true;
            dgvCo.Width = 150;
            dgvCo.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dgvLichTrinh.Columns.Add(dgvCo);

            dgvCo = new DataGridViewComboBoxColumn();
            dgvCo.HeaderText = "Tuyến đường";
            dgvCo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvCo.DataSource = TuyenDuongBUS.LoadTuyenDuong();
            dgvCo.DisplayMember = "TenTuyen";
            dgvCo.ValueMember = "MaTuyen";
            dgvCo.DataPropertyName = "MaTuyen";
            dgvCo.ReadOnly = true;
            dgvCo.Width = 320;
            dgvCo.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dgvLichTrinh.Columns.Add(dgvCo);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Khoảng cách";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCol.DataPropertyName = "KhoangCach";
            dgvCol.ReadOnly = true;
            dgvCol.DefaultCellStyle.Format = "#,0 km";
            dgvLichTrinh.Columns.Add(dgvCol);
        }

        string KiemTra()
        {
            string KT = "";
            if (txtThang.Text == "")
                KT += "- Tháng không được để trống.\n";
            if (txtNoiDi.Text == "")
                KT += "- Nơi đi không được để trống.\n";
            if (txtNoiDen.Text == "")
                KT += "- Nơi đến không được để trống.\n";
            if (txtKhoangCach.Text == "")
                KT += "- Khoảng cách không được để trống.\n";
            return KT;
        }

        void Reset()
        {
            txtMaLich.Text = "Chương trình phát sinh tự động.";
            txtThang.ResetText();
            dtkGioDi.Value = DateTime.Now;
            dtkGioDen.Value = DateTime.Now;
            txtNoiDi.ResetText();
            txtNoiDen.ResetText();
            txtKhoangCach.ResetText();
            cboMaNV.Enabled = false;
            cboChuyenXe.Enabled = false;
            btnThem.Enabled = true;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            dgvLichTrinh.ClearSelection();
        }

        private void dgvLichTrinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoa.Enabled = true;
            cboChuyenXe.Enabled = true;
            cboMaNV.Enabled = true;
            btnCapNhat.Enabled = true;
            btnThem.Enabled = false;

            txtMaLich.Text = dgvLichTrinh.CurrentRow.Cells[0].Value.ToString();
            txtThang.Text = dgvLichTrinh.CurrentRow.Cells[1].Value.ToString();
            dtkGioDi.Value = DateTime.Parse(dgvLichTrinh.CurrentRow.Cells[3].Value.ToString());
            dtkGioDen.Value = DateTime.Parse(dgvLichTrinh.CurrentRow.Cells[4].Value.ToString());
            txtNoiDi.Text = dgvLichTrinh.CurrentRow.Cells[5].Value.ToString();
            txtNoiDen.Text = dgvLichTrinh.CurrentRow.Cells[6].Value.ToString();
            cboTuyenDuong.SelectedValue = dgvLichTrinh.CurrentRow.Cells[8].Value.ToString();
            cboMaNV.SelectedValue = dgvLichTrinh.CurrentRow.Cells[2].Value.ToString();
            cboChuyenXe.SelectedValue = dgvLichTrinh.CurrentRow.Cells[7].Value.ToString();
            txtKhoangCach.Text = dgvLichTrinh.CurrentRow.Cells[9].Value.ToString();
        }

        private void dgvLichTrinh_KeyDown(object sender, KeyEventArgs e)
        {
            btnXoa.Enabled = true;
            cboChuyenXe.Enabled = true;
            cboMaNV.Enabled = true;
            btnCapNhat.Enabled = true;
            btnThem.Enabled = false;

            txtMaLich.Text = dgvLichTrinh.CurrentRow.Cells[0].Value.ToString();
            txtThang.Text = dgvLichTrinh.CurrentRow.Cells[1].Value.ToString();
            dtkGioDi.Value = DateTime.Parse(dgvLichTrinh.CurrentRow.Cells[3].Value.ToString());
            dtkGioDen.Value = DateTime.Parse(dgvLichTrinh.CurrentRow.Cells[4].Value.ToString());
            txtNoiDi.Text = dgvLichTrinh.CurrentRow.Cells[5].Value.ToString();
            txtNoiDen.Text = dgvLichTrinh.CurrentRow.Cells[6].Value.ToString();
            cboTuyenDuong.SelectedValue = dgvLichTrinh.CurrentRow.Cells[8].Value.ToString();
            cboMaNV.SelectedValue = dgvLichTrinh.CurrentRow.Cells[2].Value.ToString();
            cboChuyenXe.SelectedValue = dgvLichTrinh.CurrentRow.Cells[7].Value.ToString();
            txtKhoangCach.Text = dgvLichTrinh.CurrentRow.Cells[9].Value.ToString();
        }

        private void dgvLichTrinh_KeyUp(object sender, KeyEventArgs e)
        {
            btnXoa.Enabled = true;
            cboChuyenXe.Enabled = true;
            cboMaNV.Enabled = true;
            btnCapNhat.Enabled = true;
            btnThem.Enabled = false;

            txtMaLich.Text = dgvLichTrinh.CurrentRow.Cells[0].Value.ToString();
            txtThang.Text = dgvLichTrinh.CurrentRow.Cells[1].Value.ToString();
            dtkGioDi.Value = DateTime.Parse(dgvLichTrinh.CurrentRow.Cells[3].Value.ToString());
            dtkGioDen.Value = DateTime.Parse(dgvLichTrinh.CurrentRow.Cells[4].Value.ToString());
            txtNoiDi.Text = dgvLichTrinh.CurrentRow.Cells[5].Value.ToString();
            txtNoiDen.Text = dgvLichTrinh.CurrentRow.Cells[6].Value.ToString();
            cboTuyenDuong.SelectedValue = dgvLichTrinh.CurrentRow.Cells[8].Value.ToString();
            cboMaNV.SelectedValue = dgvLichTrinh.CurrentRow.Cells[2].Value.ToString();
            cboChuyenXe.SelectedValue = dgvLichTrinh.CurrentRow.Cells[7].Value.ToString();
            txtKhoangCach.Text = dgvLichTrinh.CurrentRow.Cells[9].Value.ToString();
        }

        private void cboTuyenDuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboChuyenXe.Enabled = true;
            cboChuyenXe.DataSource = ChuyenXeBUS.LoadChuyenXeTheoTuyenDuong(cboTuyenDuong.SelectedValue.ToString());
            cboChuyenXe.DisplayMember = "HangXe";
            cboChuyenXe.ValueMember = "MaChuyen";

            KhoangCach = TuyenDuongBUS.LayKhoangCach(cboTuyenDuong.SelectedValue.ToString());
            txtKhoangCach.Text = KhoangCach.ToString();
            cboMaNV.Enabled = true;
            cboMaNV.DataSource = NhanVienBUS.LoadNVTheoKhaNang(KhoangCach);
            cboMaNV.DisplayMember = "HoTen";
            cboMaNV.ValueMember = "MaNV";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTra() == "")
            {
                LichTrinhDTO L = new LichTrinhDTO();
                L.Thang = int.Parse(txtThang.Text);
                L.MaNV = cboMaNV.SelectedValue.ToString();
                L.GioDi = dtkGioDi.Value;
                L.GioDen = dtkGioDen.Value;
                L.NoiDi = txtNoiDi.Text;
                L.NoiDen = txtNoiDen.Text;
                L.MaChuyen = cboChuyenXe.SelectedValue.ToString();
                if (LichTrinhBUS.ThemLichTrinh(L) == true)
                {
                    MessageBox.Show("Thêm lịch trình thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvLichTrinh.DataSource = LichTrinhBUS.LoadLichTrinh();
                    Custom();
                    dgvLichTrinh.ClearSelection();
                    Reset();
                }
                else if (LichTrinhBUS.ThemLichTrinh(L) == false)
                {
                    MessageBox.Show("Thêm lịch trình thất bại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show(KiemTra(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (KiemTra() == "")
            {
                LichTrinhDTO L = new LichTrinhDTO();
                L.MaLich = int.Parse(txtMaLich.Text);
                L.Thang = int.Parse(txtThang.Text);
                L.MaNV = cboMaNV.SelectedValue.ToString();
                L.GioDi = dtkGioDi.Value;
                L.GioDen = dtkGioDen.Value;
                L.NoiDi = txtNoiDi.Text;
                L.NoiDen = txtNoiDen.Text;
                L.MaChuyen = cboChuyenXe.SelectedValue.ToString();
                if (LichTrinhBUS.CapNhatLichTrinh(L) == true)
                {
                    MessageBox.Show("Cập nhật lịch trình thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvLichTrinh.DataSource = LichTrinhBUS.LoadLichTrinh();
                    Custom();
                    dgvLichTrinh.ClearSelection();
                    Reset();
                }
                else if (LichTrinhBUS.CapNhatLichTrinh(L) == false)
                {
                    MessageBox.Show("Cập nhật lịch trình thất bại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show(KiemTra(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn xóa lịch trình này ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (LichTrinhBUS.XoaLichTrinh(Int32.Parse(dgvLichTrinh.CurrentRow.Cells[0].Value.ToString())) == true)
                {
                    MessageBox.Show("Xóa lịch trình thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvLichTrinh.DataSource = LichTrinhBUS.LoadLichTrinh();
                    Custom();
                    dgvLichTrinh.ClearSelection();
                    Reset();
                }
                else
                    MessageBox.Show("Xóa lịch trình thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtThang_TextChanged(object sender, EventArgs e)
        {
            if (txtThang.Text != "")
            {
                dgvLichTrinh.DataSource = LichTrinhBUS.LoadLichTrinhThang(Int32.Parse(txtThang.Text));
                Custom();
                dgvLichTrinh.ClearSelection();
            }
            else
            {
                dgvLichTrinh.DataSource = LichTrinhBUS.LoadLichTrinh();
                Custom();
                dgvLichTrinh.ClearSelection();
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThayDoiPass frm = new frmThayDoiPass(Username, MaNV);
            frm.ShowDialog();
        }
    }
}
