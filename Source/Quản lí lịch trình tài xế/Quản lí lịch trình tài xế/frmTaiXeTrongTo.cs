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
    public partial class frmTaiXeTrongTo : Form
    {
        int MaTo;
        public frmTaiXeTrongTo(int mato)
        {
            InitializeComponent();
            MaTo = mato;
            lbTitle.Text = "THÔNG TIN TÀI XẾ TRONG TỔ " + mato;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTaiXeTrongTo_Load(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = NhanVienBUS.LoadNVTrongTo(MaTo);
            Custom();
            dgvDanhSach.ClearSelection();
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
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCol.DataPropertyName = "HoTen";
            dgvCol.ReadOnly = true;
            dgvDanhSach.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Địa chỉ";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCol.DataPropertyName = "DiaChi";
            dgvCol.ReadOnly = true;
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

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Khả năng lái";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCol.DataPropertyName = "KhaNangLai";
            dgvCol.ReadOnly = true;
            dgvCol.DefaultCellStyle.Format = "#,0 km";
            dgvDanhSach.Columns.Add(dgvCol);
        }

        private void dgvDanhSach_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                if (e.Value != null)
                {
                    e.Value = new string('●', e.Value.ToString().Length);
                }
            }
        }

        private void dgvDanhSach_KeyUp(object sender, KeyEventArgs e)
        {
            txtMaNV.Text = dgvDanhSach.CurrentRow.Cells[0].Value.ToString();
            txtHoten.Text = dgvDanhSach.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dgvDanhSach.CurrentRow.Cells[2].Value.ToString();
            txtCMND.Text = dgvDanhSach.CurrentRow.Cells[3].Value.ToString();
            txtDienthoai.Text = dgvDanhSach.CurrentRow.Cells[4].Value.ToString();
            txtUsername.Text = dgvDanhSach.CurrentRow.Cells[5].Value.ToString();
            txtPassword.Text = dgvDanhSach.CurrentRow.Cells[6].Value.ToString();
            txtKhanang.Text = dgvDanhSach.CurrentRow.Cells[7].Value.ToString();
        }

        private void dgvDanhSach_KeyDown(object sender, KeyEventArgs e)
        {
            txtMaNV.Text = dgvDanhSach.CurrentRow.Cells[0].Value.ToString();
            txtHoten.Text = dgvDanhSach.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dgvDanhSach.CurrentRow.Cells[2].Value.ToString();
            txtCMND.Text = dgvDanhSach.CurrentRow.Cells[3].Value.ToString();
            txtDienthoai.Text = dgvDanhSach.CurrentRow.Cells[4].Value.ToString();
            txtUsername.Text = dgvDanhSach.CurrentRow.Cells[5].Value.ToString();
            txtPassword.Text = dgvDanhSach.CurrentRow.Cells[6].Value.ToString();
            txtKhanang.Text = dgvDanhSach.CurrentRow.Cells[7].Value.ToString();
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dgvDanhSach.CurrentRow.Cells[0].Value.ToString();
            txtHoten.Text = dgvDanhSach.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dgvDanhSach.CurrentRow.Cells[2].Value.ToString();
            txtCMND.Text = dgvDanhSach.CurrentRow.Cells[3].Value.ToString();
            txtDienthoai.Text = dgvDanhSach.CurrentRow.Cells[4].Value.ToString();
            txtUsername.Text = dgvDanhSach.CurrentRow.Cells[5].Value.ToString();
            txtPassword.Text = dgvDanhSach.CurrentRow.Cells[6].Value.ToString();
            txtKhanang.Text = dgvDanhSach.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
