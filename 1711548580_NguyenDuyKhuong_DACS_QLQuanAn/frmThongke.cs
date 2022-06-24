using _1711548580_NguyenDuyKhuong_DACS_QLQuanAn.DAO;
using _1711548580_NguyenDuyKhuong_DACS_QLQuanAn.DTO;
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
    public partial class frmThongke : Form
    {
        public frmThongke()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            loadF();
            lblHoaDon.Visible = false;
            lvChiTiet.Visible = false;
            lblTongTien.Visible = false;
            txtTongTien.Visible = false;
        }
        HoaDonDAO hd = new HoaDonDAO();
        #region function
        void loadF()
        {
            DataTable dt = hd.ThongKe();
            dgvThongKe.DataSource = dt;
        }
        void chuaThanhToan()
        {
            DataTable dt = hd.ThongKeChuaTT();
            dgvThongKe.DataSource = dt;
        }
        void daThanhToan()
        {
            DataTable dt = hd.ThongKeDaTT();
            dgvThongKe.DataSource = dt;
        }
        void kiemtra()
        {
            int maHoaDon = (int)nudMa.Value;
            int kiemtra = hd.kiemtra(maHoaDon);
            if (kiemtra == 1)
            {
                xemChiTiet();
                lblHoaDon.Visible = false;
                lvChiTiet.Visible = true;
                lblTongTien.Visible = true;
                txtTongTien.Visible = true;
            }
            else
            {
                lblHoaDon.Visible = true;
                lvChiTiet.Visible = false;
                lblTongTien.Visible = false;
                txtTongTien.Visible = false;
            }
        }
        void xemChiTiet()
        {
            int maHoaDon = (int)nudMa.Value;
            DataTable dt = hd.Tke_ChiTiet(maHoaDon);
            lvChiTiet.Items.Clear();
            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem lvi = lvChiTiet.Items.Add(row["ten"].ToString());
                lvi.SubItems.Add(row["soluong"].ToString());
                lvi.SubItems.Add(row["dongia"].ToString());
                lvi.SubItems.Add(row["thanhtien"].ToString());
                i++;
            }
            int tongtien = hd.tongTien(maHoaDon);
            txtTongTien.Text = tongtien.ToString();
        }
        #endregion

        private void btnDaTT_Click(object sender, EventArgs e)
        {
            daThanhToan();
        }

        private void btnChuaTT_Click(object sender, EventArgs e)
        {
            chuaThanhToan();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            loadF();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            kiemtra();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDongF_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
