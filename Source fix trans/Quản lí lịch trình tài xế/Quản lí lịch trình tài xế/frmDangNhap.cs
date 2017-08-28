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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            NhanVienDTO NV = new NhanVienDTO();
            NV.Username = txtUsername.Text;
            NV.Password = txtPassword.Text;

            if (NhanVienBUS.LayTinhTrang(txtUsername.Text) == "Unlock")
            {
                if (NhanVienBUS.DangNhap(NV) == true)
                {
                    if (NhanVienBUS.LayPQ(txtUsername.Text) == "Quản lí")
                    {
                        frmQuanli frm = new frmQuanli(NhanVienBUS.LayTenND(txtUsername.Text), NhanVienBUS.LayPQ(txtUsername.Text), txtUsername.Text);
                        this.Hide();
                        frm.ShowDialog();
                        this.Show();
                        txtPassword.ResetText();
                    }
                    else if (NhanVienBUS.LayPQ(txtUsername.Text) == "Quản trị")
                    {
                        frmQuantri frm = new frmQuantri(NhanVienBUS.LayTenND(txtUsername.Text), NhanVienBUS.LayPQ(txtUsername.Text), txtUsername.Text);
                        this.Hide();
                        frm.ShowDialog();
                        this.Show();
                        txtPassword.ResetText();
                    }
                    else if (NhanVienBUS.LayPQ(txtUsername.Text) == "Tài xế")
                    {
                        frmTaiXe frm = new frmTaiXe(NhanVienBUS.LayTenND(txtUsername.Text), NhanVienBUS.LayPQ(txtUsername.Text), txtUsername.Text);
                        this.Hide();
                        frm.ShowDialog();
                        this.Show();
                        txtPassword.ResetText();
                    }
                }
                else if (NhanVienBUS.DangNhap(NV) == false)
                {
                    MessageBox.Show("Sai username hoặc mật khẩu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Tài khoản đã bị khóa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
