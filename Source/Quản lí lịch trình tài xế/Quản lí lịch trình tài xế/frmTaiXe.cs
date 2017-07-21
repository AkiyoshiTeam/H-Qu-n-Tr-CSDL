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
    public partial class frmTaiXe : Form
    {
        string Username;
        public frmTaiXe(string Hoten,string PhanQuyen, string username)
        {
            InitializeComponent();
            lbHoten.Text = "Họ tên: " + Hoten;
            lbChucvu.Text = "Chức vụ: " + PhanQuyen;
            Username = username;
        }

        private void frmTaiXe_Load(object sender, EventArgs e)
        {
            LoadThongTin();
            btnUpdate.Enabled = false;
        }

        void LoadThongTin()
        {
            NhanVienDTO NV = new NhanVienDTO();
            NV = NhanVienBUS.LoadThongTinTaiXe(Username);
            txtMaNV.Text = NV.MaNV;
            txtHoten.Text = NV.HoTen;
            txtDiaChi.Text = NV.DiaChi;
            txtCMND.Text = NV.CMND;
            txtDienthoai.Text = NV.DienThoai;
            txtKhanang.Text = NV.KhaNangLai.ToString();
            txtUsername.Text = NV.Username;
            txtPassword.Text = NV.Password;
            txtTo.Text = NV.MaTo.ToString();

            dgvLichTrinh.DataSource = LichTrinhBUS.LoadLichTrinhCaNhan(NV.MaNV);
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

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Hãng xe";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvCol.DataPropertyName = "HangXe";
            dgvCol.ReadOnly = true;
            dgvCol.Width = 130;
            dgvLichTrinh.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Tuyến đường";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvCol.DataPropertyName = "TenTuyen";
            dgvCol.ReadOnly = true;
            dgvCol.Width = 350;
            dgvLichTrinh.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Khoảng cách";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCol.DataPropertyName = "KhoangCach";
            dgvCol.ReadOnly = true;
            dgvCol.DefaultCellStyle.Format = "#,0 km";
            dgvLichTrinh.Columns.Add(dgvCol);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            NhanVienDTO NV = new NhanVienDTO();
            NV.MaNV = txtMaNV.Text;
            NV.HoTen = txtHoten.Text;
            NV.DiaChi = txtDiaChi.Text;
            NV.CMND = txtCMND.Text;
            NV.DienThoai = txtDienthoai.Text;
            NV.KhaNangLai = Int32.Parse(txtKhanang.Text);

            if(NhanVienBUS.CapNhatThongTin(NV) == true)
            {
                MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadThongTin();
                btnUpdate.Enabled = false;
            }
            else if(NhanVienBUS.CapNhatThongTin(NV) == false)
            {
                MessageBox.Show("Cập nhật thất bại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtHoten_TextChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
        }

        private void txtDienthoai_TextChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
        }

        private void txtKhanang_TextChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            frmThayDoiPass frm = new frmThayDoiPass(Username, txtMaNV.Text);
            frm.ShowDialog();
            LoadThongTin();
            btnUpdate.Enabled = false;
        }

        private void btnLichTrinh_Click(object sender, EventArgs e)
        {
            frmLichTrinhTo frm = new frmLichTrinhTo(Int32.Parse(txtTo.Text));
            frm.ShowDialog();
            LoadThongTin();
            btnUpdate.Enabled = false;
        }
    }
}
