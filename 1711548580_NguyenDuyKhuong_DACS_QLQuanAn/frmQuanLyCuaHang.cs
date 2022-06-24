using _1711548580_NguyenDuyKhuong_DACS_QLQuanAn.DAO;
using _1711548580_NguyenDuyKhuong_DACS_QLQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1711548580_NguyenDuyKhuong_DACS_QLQuanAn
{
    public partial class frmQuanLyCuaHang : Form
    {
        public frmQuanLyCuaHang()
        {
            InitializeComponent();
        }
        private void frmQuanLyCuaHang_Load(object sender, EventArgs e)
        {
            loadForm();
            LoadDanhMuc();
            LoadDSBan();
        }
        #region Bien
        int IDBAN; string TENMON; int MAMON; int MAHOADON;
        #endregion

        /****************************************************************************************************************************
         ***************         ****    ***********    *****          ******     ***********   *****               *****************
         ***************   ***********    *********    ******   *************   *    ********   **********    ***********************
         ***************   ************    *******    *******   *************   ***    ******   **********    ***********************
         ***************         *******    *****    ********          ******   *****    ****   **********    ***********************
         ***************   **************    ***    *********   *************   *******    **   **********    ***********************
         ***************   ***************    *   ***********   *************   *********   *   **********    ***********************
         ***************         **********      ************          ******   **********      **********    ***********************
         ****************************************************************************************************************************/
        #region Events
        private void tmnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát ứng dụng ?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void tmnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất ?", "XÁC NHẬN", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        private void mnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất ?", "XÁC NHẬN", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        private void mnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát ứng dụng ?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }


        private void tmnThongKe_Click(object sender, EventArgs e)
        {
            frmThongke tke = new frmThongke();
            tke.ShowDialog();
        }

        private void mnThongKe_Click(object sender, EventArgs e)
        {
            frmThongke tke = new frmThongke();
            tke.ShowDialog();
        }

        private void mnThongTinPhanMem_Click(object sender, EventArgs e)
        {
            frmThongTinPM tt = new frmThongTinPM();
            tt.ShowDialog();
        }

        private void mnMenu_Click(object sender, EventArgs e)
        {
            frmMenu mn = new frmMenu();
            mn.ShowDialog();
        }

        private void tmnMenu_Click(object sender, EventArgs e)
        {
            frmMenu mn = new frmMenu();
            mn.ShowDialog();
        }

        private void cbbMenu_SelectedValueChanged(object sender, EventArgs e)
        {
            string menu = cbbDanhMuc.Text.ToString();
                if (menu == "Món ăn")
                {
                    LoadMon();
                }
                else if (menu == "Nước uống")
                {
                    LoadNuoc();
                }
        }
        //  CHỌN BÀN 
        void btn_Click(object sender, EventArgs e)
        {
            int idban = ((sender as Button).Tag as DanhSachBan).ID;
            IDBAN = idban;
            cbbMenu.Enabled = true;
            lvChiTietBan.Tag = (sender as Button).Tag;
            ClickBan();
            switch (((sender as Button).Tag as DanhSachBan).Status)
            {
                case "Có người":
                    btnDatBan.Enabled = false;
                    btnHuyDat.Enabled = false;
                    btnThanhToan.Enabled = true;
                    break;
                case "Đã đặt":
                    btnDatBan.Enabled = false;
                    btnHuyDat.Enabled = true;
                    btnThanhToan.Enabled = false;
                    break;
                default:
                    btnDatBan.Enabled = true;
                    btnHuyDat.Enabled = false;
                    btnThanhToan.Enabled = false;
                    break;
            }
            LayHoaDonTheoBan(idban);
        }

        private void btnDatBan_Click(object sender, EventArgs e)
        {
            ban.datBan(IDBAN); LoadDSBan(); btnDatBan.Enabled = false; btnHuyDat.Enabled = true;
        }

        private void btnHuyDat_Click(object sender, EventArgs e)
        {
            ban.huyDat(IDBAN); LoadDSBan(); btnDatBan.Enabled = true; btnHuyDat.Enabled = false;
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            themMon();
        }

        private void cbbMenu_SelectedValueChanged_1(object sender, EventArgs e)
        {
            TENMON = cbbMenu.Text;
            MAMON = menu.LayMa(TENMON);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            thanhToan();
        }

        #endregion


        /*
         *          ***********    ***           ***   *******      ***   **************                      *
         *          ***********    ***           ***   ********     ***   **************                      *                                                                           
         *          ***            ***           ***   ***   ***    ***   ***                                 *                                                                          
         *          ***            ***           ***   ***    ***   ***   ***                                 *                                                                       
         *          ***********    ***           ***   ***     ***  ***   ***                                 *                                                                          
         *          ***********    ***           ***   ***      *** ***   ***                                 *                                                                         
         *          ***            ***           ***   ***       ******   ***                                 *                                                                                
         *          ***            *****************   ***        *****   **************                      *                                                          
         *          ***            *****************   ***         ****   **************                      *                                                         
         */
        #region function
        void loadForm()
        {
            tslblNgay.Text = "Hôm nay là " + DateTime.Now.ToShortDateString();
            lblChonBan.Visible = true;
            lvChiTietBan.Visible = false;
            lblChiTiet.Visible = false;
            btnDatBan.Enabled = false;
            btnHuyDat.Enabled = false;
            btnThanhToan.Enabled = false;
            cbbMenu.Enabled = false;
            cbbDanhMuc.Enabled = false;
            nudSoLuong.Enabled = false;
            btnThemMon.Enabled = false;
        }

        void ClickBan()
        {
            idhoadon();
            lblChonBan.Visible = false;
            lvChiTietBan.Visible = true;
            lblChiTiet.Visible = true;
            lblChiTiet.Text = "Bàn " + IDBAN.ToString();
            cbbMenu.Enabled = true;
            cbbDanhMuc.Enabled = true;
            nudSoLuong.Enabled = true;
            btnThemMon.Enabled = true;
        }

        BanDAO ban = new BanDAO();
        menuDAO menu = new menuDAO();
        HoaDonDAO hd = new HoaDonDAO();
        ChiTietHdDAO ct = new ChiTietHdDAO();

        //  LOAD DANH SÁCH BÀN
        void LoadDSBan()
        {
            flpDsBan.Controls.Clear();
            List<DanhSachBan> tbl = ban.loadDSB();
            foreach (DanhSachBan item in tbl)
            {
                Button btn = new Button();
                btn.Width = 212;
                btn.Height = 187;
                btn.Text = item.Name + "\n" + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "Có người" :
                        btn.BackColor = Color.DarkOrange;
                        break;
                    case "Đã đặt":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.SpringGreen;
                        break;
                }
                flpDsBan.Controls.Add(btn);
            }
        }
        //  LOAD MENU
        void LoadDanhMuc()
        {
            DanhMucDAO dm = new DanhMucDAO();
            DataTable dt = dm.Danhmuc();
            cbbDanhMuc.DataSource = dt;
            cbbDanhMuc.DisplayMember = "tendanhmuc";
        }
        //  LOAD DS MÓN
        void LoadMon()
        {
            DataTable dt = menu.LayDsMonAn();
            cbbMenu.DataSource = dt;
            cbbMenu.DisplayMember = "Tên món";

        }
        //  LOAD DS NƯỚC
        void LoadNuoc()
        {
            DataTable dt = menu.LayDsNuoc();
            cbbMenu.DataSource = dt;
            cbbMenu.DisplayMember = "Tên nước";
        }
        // LẤY ID HÓA ĐƠN
        void idhoadon()
        {
            MAHOADON = hd.layMaHoaDon(IDBAN);
        }
        // TẠO HD MỚI
        void taoHdMoi()
        {
            hd.TaoHoaDonMoi(IDBAN);
            MAHOADON = hd.idMax();
        }
        // LẤY HÓA ĐƠN THEO BÀN
        void LayHoaDonTheoBan(int idban)
        {
            lvChiTietBan.Items.Clear();
            int ThanhTien = 0;
            List<HoaDonTheoBan> hdtb = hd.LayHoaDonTheoBan(idban);
            foreach(HoaDonTheoBan item in hdtb){
                ListViewItem lvi = lvChiTietBan.Items.Add(item.Ten.ToString());
                lvi.SubItems.Add(item.SoLuong.ToString());
                lvi.SubItems.Add(item.DonGia.ToString());
                lvi.SubItems.Add(item.TongTien.ToString());
                ThanhTien += item.TongTien;
            }
            CultureInfo f = new CultureInfo("vi-VN");
            txtTongTien.Text = ThanhTien.ToString("c", f);
        }
        // THÊM MÓN
        void themMon()
        {
            LoadDSBan();
            int soLuong = (int)nudSoLuong.Value;
            if (MAHOADON == -1)
            {
                taoHdMoi();
                hd.trong_CoNg(IDBAN);
                ct.ThemMon(MAHOADON, MAMON, soLuong);
                btnDatBan.Enabled = false; btnHuyDat.Enabled = false; btnThanhToan.Enabled = true;
                LayHoaDonTheoBan(IDBAN);
                LoadDSBan();
            }
            else
            {
                ct.ThemMon(MAHOADON, MAMON, soLuong);
                LayHoaDonTheoBan(IDBAN);
            }
        }
        // THANH TOÁN
        void thanhToan()
        {
            if (MessageBox.Show("Thanh toán hóa đơn cho bàn " + IDBAN , "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                hd.thanhToan(MAHOADON);
                hd.coNg_Trong(IDBAN);
                LayHoaDonTheoBan(IDBAN);
                LoadDSBan();
                btnThanhToan.Enabled = false; 
                btnDatBan.Enabled = true;
                btnThemMon.Enabled = false;
                lblChonBan.Text = "Đã thanh toán";
                lblChonBan.Visible = true;
                lvChiTietBan.Visible = false;
            }
        }
            // 1 dặt - có ng
            // 3 trống - có ng
        
        #endregion 


        

        

        

        

        

       

    }
}
