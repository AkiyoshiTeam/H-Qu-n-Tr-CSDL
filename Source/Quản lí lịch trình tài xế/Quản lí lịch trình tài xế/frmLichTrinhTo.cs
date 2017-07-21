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
    public partial class frmLichTrinhTo : Form
    {
        int MaTo;
        public frmLichTrinhTo(int mato)
        {
            InitializeComponent();
            MaTo = mato;
            lbTitle.Text = "LỊCH TRÌNH TRONG TỔ " + mato;
        }

        private void frmLichTrinhTo_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            dgvLichTrinh.DataSource = LichTrinhBUS.LoadLichTrinhTo(MaTo);
            Custom();
            dgvLichTrinh.ClearSelection();

            cboTuyenDuong.DataSource = TuyenDuongBUS.LoadTuyenDuong();
            cboTuyenDuong.DisplayMember = "TenTuyen";
            cboTuyenDuong.ValueMember = "MaTuyen";

            cboChuyenXe.DataSource = ChuyenXeBUS.LoadChuyenXe();
            cboChuyenXe.DisplayMember = "HangXe";
            cboChuyenXe.ValueMember = "MaChuyen";
            cboChuyenXe.Enabled = true;
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

        private void dgvLichTrinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLich.Text = dgvLichTrinh.CurrentRow.Cells[0].Value.ToString();
            txtThang.Text = dgvLichTrinh.CurrentRow.Cells[1].Value.ToString();
            txtMaNV.Text= dgvLichTrinh.CurrentRow.Cells[2].Value.ToString();
            txtGioDi.Text = dgvLichTrinh.CurrentRow.Cells[3].Value.ToString();
            txtGioDen.Text = dgvLichTrinh.CurrentRow.Cells[4].Value.ToString();
            txtNoiDi.Text = dgvLichTrinh.CurrentRow.Cells[5].Value.ToString();
            txtNoiDen.Text = dgvLichTrinh.CurrentRow.Cells[6].Value.ToString();
            cboChuyenXe.SelectedValue = dgvLichTrinh.CurrentRow.Cells[7].Value.ToString();
            cboTuyenDuong.SelectedValue = dgvLichTrinh.CurrentRow.Cells[8].Value.ToString();
            txtKhoangCach.Text = dgvLichTrinh.CurrentRow.Cells[9].Value.ToString();
        }

        private void dgvLichTrinh_KeyDown(object sender, KeyEventArgs e)
        {
            txtMaLich.Text = dgvLichTrinh.CurrentRow.Cells[0].Value.ToString();
            txtThang.Text = dgvLichTrinh.CurrentRow.Cells[1].Value.ToString();
            txtMaNV.Text = dgvLichTrinh.CurrentRow.Cells[2].Value.ToString();
            txtGioDi.Text = dgvLichTrinh.CurrentRow.Cells[3].Value.ToString();
            txtGioDen.Text = dgvLichTrinh.CurrentRow.Cells[4].Value.ToString();
            txtNoiDi.Text = dgvLichTrinh.CurrentRow.Cells[5].Value.ToString();
            txtNoiDen.Text = dgvLichTrinh.CurrentRow.Cells[6].Value.ToString();
            cboChuyenXe.SelectedValue = dgvLichTrinh.CurrentRow.Cells[7].Value.ToString();
            cboTuyenDuong.SelectedValue = dgvLichTrinh.CurrentRow.Cells[8].Value.ToString();
            txtKhoangCach.Text = dgvLichTrinh.CurrentRow.Cells[9].Value.ToString();
        }

        private void dgvLichTrinh_KeyUp(object sender, KeyEventArgs e)
        {
            txtMaLich.Text = dgvLichTrinh.CurrentRow.Cells[0].Value.ToString();
            txtThang.Text = dgvLichTrinh.CurrentRow.Cells[1].Value.ToString();
            txtMaNV.Text = dgvLichTrinh.CurrentRow.Cells[2].Value.ToString();
            txtGioDi.Text = dgvLichTrinh.CurrentRow.Cells[3].Value.ToString();
            txtGioDen.Text = dgvLichTrinh.CurrentRow.Cells[4].Value.ToString();
            txtNoiDi.Text = dgvLichTrinh.CurrentRow.Cells[5].Value.ToString();
            txtNoiDen.Text = dgvLichTrinh.CurrentRow.Cells[6].Value.ToString();
            cboChuyenXe.SelectedValue = dgvLichTrinh.CurrentRow.Cells[7].Value.ToString();
            cboTuyenDuong.SelectedValue = dgvLichTrinh.CurrentRow.Cells[8].Value.ToString();
            txtKhoangCach.Text = dgvLichTrinh.CurrentRow.Cells[9].Value.ToString();
        }
    }
}
