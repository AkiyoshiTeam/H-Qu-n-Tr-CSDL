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
