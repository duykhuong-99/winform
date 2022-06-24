using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1711548580_NguyenDuyKhuong_DACS_QLQuanAn
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void cbHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if(cbHienMK.Checked == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát ứng dụng ?", "THÔNG BÁO", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "")
            {
                if (txtMatKhau.Text == "")
                {
                    MessageBox.Show("Chưa nhập thông tin !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTaiKhoan.Focus();
                }
                else
                {
                    MessageBox.Show("Tài khoản trống !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTaiKhoan.Focus();
                }
            }
            else
            {
                if (txtMatKhau.Text == "")
                {
                    MessageBox.Show("Chưa nhập mật khẩu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatKhau.Focus();
                }
                else
                {
                    if (txtTaiKhoan.Text == "admin")
                    {
                        if (txtMatKhau.Text == "123")
                        {
                            frmQuanLyCuaHang ql = new frmQuanLyCuaHang();
                            this.Hide();
                            ql.ShowDialog();
                            this.Show();
                        }
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTaiKhoan.Text = "admin";
            txtMatKhau.Text = "123";
            errorProvider1.Clear();
            errorProvider2.Clear();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void txtTaiKhoan_Leave(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text != "admin")
            {
                errorProvider1.SetError(txtTaiKhoan, "tài khoản không hợp lệ");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text != "123")
            {
                errorProvider2.SetError(txtMatKhau, "Mật khẩu sai ");
            }
            else
            {
                errorProvider2.Clear();
            }
        }
    }
}
