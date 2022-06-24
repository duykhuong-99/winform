using _1711548580_NguyenDuyKhuong_DACS_QLQuanAn.DAO;
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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            layDsMon();
            layDsNuoc();
        }
        #region function
        menuDAO mn = new menuDAO();
        void resetmon()
        {
            txtTenMon.ResetText();
            txtTenMon_Add.ResetText();
            txtIdMon.ResetText();
            nudDonGiaMon.ResetText();
            nudDonGiaMon_Add.ResetText();
        }
        void resetNuoc()
        {
            txtTenNuoc.ResetText();
            txtTenNuoc_Add.ResetText();
            txtIdNuoc.ResetText();
            nudDonGiaNuoc.ResetText();
            nudDonGiaNuoc_Add.ResetText();
        }
        void layDsMon()
        {
            DataTable dt = mn.LayDsMonAn();
            dgvMon.DataSource = dt;
        }
        void layDsNuoc()
        {
            DataTable dt = mn.LayDsNuoc();
            dgvNuoc.DataSource = dt;
        }
        void themMon()
        {
            string madm = "MON";
            string ten = txtTenMon_Add.Text;
            if (ten == "")
            {
                ten = "(Chưa đặt tên)";
            }
            int dongia = (int)nudDonGiaMon_Add.Value;
            if (mn.ThemMon(madm, ten, dongia))
            {
                MessageBox.Show("Thêm thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetmon();
                layDsMon();
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void themNuoc()
        {
            string madm = "NUOC";
            string ten = txtTenNuoc_Add.Text;
            if (ten == "")
            {
                ten = "(Chưa đặt tên)";
            }
            int dongia = (int)nudDonGiaNuoc_Add.Value;
            if (mn.ThemMon(madm, ten, dongia))
            {
                MessageBox.Show("Thêm thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetNuoc();
                layDsNuoc();
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void xoaMon()
        {
            try
            {
                int idmon = Convert.ToInt32(txtIdMon.Text);
                if (mn.XoaMon(idmon))
                {
                    MessageBox.Show("Xóa thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetmon();
                    layDsMon();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Xóa thất bại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void xoaNuoc()
        {
            try
            {
                int id = Convert.ToInt32(txtIdNuoc.Text);
                if (mn.XoaMon(id))
                {
                    MessageBox.Show("Xóa thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetNuoc();
                    layDsNuoc();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Xóa thất bại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void updateMon()
        {
            try
            {
                string ten = txtTenMon.Text;
                int donGia = (int)nudDonGiaMon.Value;
                int id = Convert.ToInt32(txtIdMon.Text);
                if (mn.CapNhatMon(id, ten, donGia))
                {
                    MessageBox.Show("Cập nhật thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetmon();
                    layDsMon();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Cập nhật thất bại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void updateNuoc()
        {
            try
            {
                string ten = txtTenNuoc.Text;
                int donGia = (int)nudDonGiaNuoc.Value;
                int id = Convert.ToInt32(txtIdNuoc.Text);
                if (mn.CapNhatNuoc(id, ten, donGia))
                {
                    MessageBox.Show("Cập nhật thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetNuoc();
                    layDsNuoc();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Cập nhật thất bại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void btnDongF_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            themMon();
        }

        private void dgvMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rand;
            rand = e.RowIndex;
            try 
            {
                txtIdMon.Text = dgvMon.Rows[rand].Cells[0].Value.ToString();
                txtTenMon.Text = dgvMon.Rows[rand].Cells[1].Value.ToString();
                nudDonGiaMon.Text = dgvMon.Rows[rand].Cells[2].Value.ToString();
            }
            catch
            {
                resetmon();
            }
            
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            xoaMon();
        }

        private void dgvNuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rand;
            rand = e.RowIndex;
            try
            {
                txtIdNuoc.Text = dgvNuoc.Rows[rand].Cells[0].Value.ToString();
                txtTenNuoc.Text = dgvNuoc.Rows[rand].Cells[1].Value.ToString();
                nudDonGiaNuoc.Text = dgvNuoc.Rows[rand].Cells[2].Value.ToString();
            }
            catch
            {
                resetNuoc();
            }
        }

        private void btnThemNuoc_Click(object sender, EventArgs e)
        {
            themNuoc();
        }

        private void btnXoaNuoc_Click(object sender, EventArgs e)
        {
            xoaNuoc();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            updateMon();
        }

        private void btnCapNhatNuoc_Click(object sender, EventArgs e)
        {
            updateNuoc();
        }
    }
}
