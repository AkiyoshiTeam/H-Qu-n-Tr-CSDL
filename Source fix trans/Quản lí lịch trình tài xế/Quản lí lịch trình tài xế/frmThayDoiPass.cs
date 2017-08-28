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
    public partial class frmThayDoiPass : Form
    {
        string Username,MaNV;
        public frmThayDoiPass(string username, string manv)
        {
            InitializeComponent();
            Username = username;
            MaNV = manv;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            string Pass = NhanVienBUS.LayMatKhau(Username);
            if (txtMatkhaucu.Text == Pass)
            {
                if (txtMatkhaumoi.Text == txtNhaplai.Text)
                {
                    NhanVienDTO NV = new NhanVienDTO();
                    NV.MaNV = MaNV;
                    NV.Password = txtMatkhaumoi.Text;
                    if (NhanVienBUS.DoiMatKhau(NV) == true)
                    {
                        MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMatkhaucu.ResetText();
                        txtMatkhaumoi.ResetText();
                        txtNhaplai.ResetText();
                    }
                    else if (NhanVienBUS.DoiMatKhau(NV) == false)
                        MessageBox.Show("Đổi mật khẩu thất bại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Nhập lại mật khẩu không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMatkhaumoi.ResetText();
                    txtNhaplai.ResetText();
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatkhaucu.ResetText();
                txtMatkhaumoi.ResetText();
                txtNhaplai.ResetText();
            }
        }
    }
}
