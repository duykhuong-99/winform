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
    public partial class frmTaiKhoan : Form
    {
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if(txtTaiKhoan.Text !="" || txtMkCu.Text !="" || txtMkMoi.Text != "" || txtNhapLaiMk.Text != "")
            {
                if(MessageBox.Show("Thông tin bạn đã nhập sẽ bị xóa ?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void cbHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienMK.Checked == true)
            {
                txtMkCu.UseSystemPasswordChar = false;
                txtMkMoi.UseSystemPasswordChar = false;
                txtNhapLaiMk.UseSystemPasswordChar = false;
            }
            else
            {
                txtMkCu.UseSystemPasswordChar = true;
                txtMkMoi.UseSystemPasswordChar = true;
                txtNhapLaiMk.UseSystemPasswordChar = true;
            }
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            //kiểm tra các textbox trống
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Chưa nhập tài khoản !","THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTaiKhoan.Focus();
            }
            else
            {
                if (txtMkCu.Text == "")
                {
                    MessageBox.Show("Chưa nhập mật khẩu cũ !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMkCu.Focus();
                }
                else if (txtMkMoi.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu mới !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMkMoi.Focus();
                }
                else if (txtNhapLaiMk.Text == "")
                {
                    MessageBox.Show("Vui lóng nhập lại mật khẩu mới !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNhapLaiMk.Focus();
                }
                else
                {
                    //kiểm tra nếu ko lỗi ---> thành công 
                    string e1 = errorProvider1.GetError(txtTaiKhoan).ToString();
                    string e2 = errorProvider2.GetError(txtMkCu).ToString();
                    string e3 = errorProvider3.GetError(txtMkMoi).ToString();
                    string e4 = errorProvider4.GetError(txtNhapLaiMk).ToString();
                    //kiểm tra mật khẩu mới có trùng mk cũ ?
                    if (e1=="" && e2=="" && e3=="" & e4=="")
                    {
                        if (txtMkCu.Text != txtMkMoi.Text)
                        {
                            lblDoiThanhCong.Visible = true;
                            lblTrungMkCu.Visible = false;
                            txtMkCu.Text = txtMkMoi.Text;
                            txtMkMoi.Text = "";
                            txtNhapLaiMk.Text = "";
                        }
                        else
                        {
                            lblTrungMkCu.Visible = true;
                            lblDoiThanhCong.Visible = false;
                            txtMkMoi.Text = "";
                            txtNhapLaiMk.Text = "";
                        }
                    }
                    
                }
            }
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            lblDoiThanhCong.Visible = false;
            lblTrungMkCu.Visible = false;
            
        }
        //kiểm tra tài khoản = admin ?
        private void txtTaiKhoan_Leave(object sender, EventArgs e)
        {
            if(txtTaiKhoan.Text != "admin")
            {
                errorProvider1.SetError(txtTaiKhoan,"tài khoản không hợp lệ");
            }
            else{
                errorProvider1.Clear();
            }
        }
        // kiểm tra mk cũ  = 123 ?
        private void txtMkCu_Leave(object sender, EventArgs e)
        {
            if (txtMkCu.Text != "123")
            {
                errorProvider2.SetError(txtMkCu, "Mật khẩu sai ");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void txtMkMoi_Leave(object sender, EventArgs e)
        {
            if (txtMkMoi.Text.Length < 3)
            {
                errorProvider3.SetError(txtMkMoi, "Mật khẩu từ 3 kí tự trở lên");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void txtNhapLaiMk_Leave(object sender, EventArgs e)
        {
            if (txtNhapLaiMk.Text != txtMkMoi.Text)
            {
                errorProvider4.SetError(txtNhapLaiMk, "Mật khẩu không trùng khớp");
                lblDoiThanhCong.Visible = false;
            }
            else
            {
                errorProvider4.Clear();
            }
        }
    }
}
