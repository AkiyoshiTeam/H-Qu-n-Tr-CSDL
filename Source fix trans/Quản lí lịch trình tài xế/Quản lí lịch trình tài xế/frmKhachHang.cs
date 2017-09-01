using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lí_lịch_trình_tài_xế
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            cboTuyenDuong.DataSource = TuyenDuongBUS.LoadTuyenDuong();
            cboTuyenDuong.DisplayMember = "TenTuyen";
            cboTuyenDuong.ValueMember = "MaTuyen";
        }

        private void cboTuyenDuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvLichTrinh.DataSource = LichTrinhBUS.LoadLichTrinhTheoTuyen(cboTuyenDuong.SelectedValue.ToString());
            Custom();
            dgvLichTrinh.ClearSelection();
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
            dgvCo.HeaderText = "Tài xế";
            dgvCo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvCo.DataSource = NhanVienBUS.LoadNV();
            dgvCo.DisplayMember = "HoTen";
            dgvCo.ValueMember = "MaNV";
            dgvCo.DataPropertyName = "MaNV";
            dgvCo.ReadOnly = true;
            dgvCo.Width = 200;
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

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Khoảng cách";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCol.DataPropertyName = "KhoangCach";
            dgvCol.ReadOnly = true;
            dgvCol.DefaultCellStyle.Format = "#,0 km";
            dgvLichTrinh.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Giá vé";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvCol.DataPropertyName = "GiaVe";
            dgvCol.ReadOnly = true;
            dgvCol.DefaultCellStyle.Format = "#,0 VNĐ";
            dgvLichTrinh.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Vé bán được";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCol.DataPropertyName = "SoLuongVeBanDuoc";
            dgvCol.ReadOnly = true;
            dgvLichTrinh.Columns.Add(dgvCol);
        }

        private void btnDatve_Click(object sender, EventArgs e)
        {
            if (NhanVienBUS.DatVe(Int32.Parse(dgvLichTrinh.CurrentRow.Cells[0].Value.ToString()), Int32.Parse(dgvLichTrinh.CurrentRow.Cells[10].Value.ToString())) == true)
            {
                MessageBox.Show("Đặt vé thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvLichTrinh.DataSource = LichTrinhBUS.LoadLichTrinhTheoTuyen(cboTuyenDuong.SelectedValue.ToString());
                Custom();
                dgvLichTrinh.ClearSelection();
            }
            else
                MessageBox.Show("Đặt vé thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnHuyve_Click(object sender, EventArgs e)
        {
            if (NhanVienBUS.HuyVe(Int32.Parse(dgvLichTrinh.CurrentRow.Cells[0].Value.ToString()), Int32.Parse(dgvLichTrinh.CurrentRow.Cells[10].Value.ToString())) == true)
            {
                MessageBox.Show("Hủy vé thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvLichTrinh.DataSource = LichTrinhBUS.LoadLichTrinhTheoTuyen(cboTuyenDuong.SelectedValue.ToString());
                Custom();
                dgvLichTrinh.ClearSelection();
            }
            else
                MessageBox.Show("Hủy vé thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
