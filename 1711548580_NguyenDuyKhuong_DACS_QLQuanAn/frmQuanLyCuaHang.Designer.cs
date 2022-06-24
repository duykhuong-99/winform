namespace _1711548580_NguyenDuyKhuong_DACS_QLQuanAn
{
    partial class frmQuanLyCuaHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThongTinPhanMem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslblNgay = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tmnMenu = new System.Windows.Forms.ToolStripButton();
            this.tmnThongKe = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tmnDangXuat = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tmnThoat = new System.Windows.Forms.ToolStripButton();
            this.flpDsBan = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbDanhMuc = new System.Windows.Forms.ComboBox();
            this.cbbMenu = new System.Windows.Forms.ComboBox();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.btnDatBan = new System.Windows.Forms.Button();
            this.btnHuyDat = new System.Windows.Forms.Button();
            this.lblChiTiet = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.lblChonBan = new System.Windows.Forms.Label();
            this.lvChiTietBan = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnChucNang,
            this.mnHeThong});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1371, 41);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnChucNang
            // 
            this.mnChucNang.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mnChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnMenu,
            this.mnThongKe});
            this.mnChucNang.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnChucNang.Name = "mnChucNang";
            this.mnChucNang.Size = new System.Drawing.Size(147, 37);
            this.mnChucNang.Text = "Chức năng";
            // 
            // mnMenu
            // 
            this.mnMenu.Name = "mnMenu";
            this.mnMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.mnMenu.Size = new System.Drawing.Size(380, 38);
            this.mnMenu.Text = "Quản lý thực đơn";
            this.mnMenu.Click += new System.EventHandler(this.mnMenu_Click);
            // 
            // mnThongKe
            // 
            this.mnThongKe.Name = "mnThongKe";
            this.mnThongKe.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.mnThongKe.Size = new System.Drawing.Size(380, 38);
            this.mnThongKe.Text = "Thống kê";
            this.mnThongKe.Click += new System.EventHandler(this.mnThongKe_Click);
            // 
            // mnHeThong
            // 
            this.mnHeThong.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mnHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnThongTinPhanMem,
            this.mnDangXuat,
            this.mnThoat});
            this.mnHeThong.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnHeThong.Name = "mnHeThong";
            this.mnHeThong.Size = new System.Drawing.Size(128, 37);
            this.mnHeThong.Text = "Hệ thống";
            // 
            // mnThongTinPhanMem
            // 
            this.mnThongTinPhanMem.Name = "mnThongTinPhanMem";
            this.mnThongTinPhanMem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.mnThongTinPhanMem.Size = new System.Drawing.Size(407, 38);
            this.mnThongTinPhanMem.Text = "Thông tin phần mềm";
            this.mnThongTinPhanMem.Click += new System.EventHandler(this.mnThongTinPhanMem_Click);
            // 
            // mnDangXuat
            // 
            this.mnDangXuat.Name = "mnDangXuat";
            this.mnDangXuat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnDangXuat.Size = new System.Drawing.Size(407, 38);
            this.mnDangXuat.Text = "Đăng xuất";
            this.mnDangXuat.Click += new System.EventHandler(this.mnDangXuat_Click);
            // 
            // mnThoat
            // 
            this.mnThoat.Name = "mnThoat";
            this.mnThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnThoat.Size = new System.Drawing.Size(407, 38);
            this.mnThoat.Text = "Thoát";
            this.mnThoat.Click += new System.EventHandler(this.mnThoat_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblNgay});
            this.statusStrip1.Location = new System.Drawing.Point(0, 700);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1371, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslblNgay
            // 
            this.tslblNgay.Name = "tslblNgay";
            this.tslblNgay.Size = new System.Drawing.Size(44, 20);
            this.tslblNgay.Text = "Ngay";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmnMenu,
            this.tmnThongKe,
            this.toolStripSeparator2,
            this.tmnDangXuat,
            this.toolStripSeparator3,
            this.tmnThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 41);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1371, 40);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tmnMenu
            // 
            this.tmnMenu.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmnMenu.Image = global::_1711548580_NguyenDuyKhuong_DACS_QLQuanAn.Properties.Resources.menu;
            this.tmnMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tmnMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tmnMenu.Name = "tmnMenu";
            this.tmnMenu.Size = new System.Drawing.Size(239, 37);
            this.tmnMenu.Text = "Quản lý thực đơn";
            this.tmnMenu.Click += new System.EventHandler(this.tmnMenu_Click);
            // 
            // tmnThongKe
            // 
            this.tmnThongKe.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmnThongKe.Image = global::_1711548580_NguyenDuyKhuong_DACS_QLQuanAn.Properties.Resources.thongke;
            this.tmnThongKe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tmnThongKe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tmnThongKe.Name = "tmnThongKe";
            this.tmnThongKe.Size = new System.Drawing.Size(143, 37);
            this.tmnThongKe.Text = "Thống kê";
            this.tmnThongKe.Click += new System.EventHandler(this.tmnThongKe_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // tmnDangXuat
            // 
            this.tmnDangXuat.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmnDangXuat.Image = global::_1711548580_NguyenDuyKhuong_DACS_QLQuanAn.Properties.Resources.dangxuat;
            this.tmnDangXuat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tmnDangXuat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tmnDangXuat.Name = "tmnDangXuat";
            this.tmnDangXuat.Size = new System.Drawing.Size(158, 37);
            this.tmnDangXuat.Text = "Đăng xuất";
            this.tmnDangXuat.Click += new System.EventHandler(this.tmnDangXuat_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 40);
            // 
            // tmnThoat
            // 
            this.tmnThoat.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmnThoat.Image = global::_1711548580_NguyenDuyKhuong_DACS_QLQuanAn.Properties.Resources.thoat;
            this.tmnThoat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tmnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tmnThoat.Name = "tmnThoat";
            this.tmnThoat.Size = new System.Drawing.Size(108, 37);
            this.tmnThoat.Text = "Thoát";
            this.tmnThoat.Click += new System.EventHandler(this.tmnThoat_Click);
            // 
            // flpDsBan
            // 
            this.flpDsBan.BackColor = System.Drawing.Color.Silver;
            this.flpDsBan.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpDsBan.Location = new System.Drawing.Point(12, 119);
            this.flpDsBan.Name = "flpDsBan";
            this.flpDsBan.Size = new System.Drawing.Size(655, 580);
            this.flpDsBan.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(651, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Danh sách bàn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbDanhMuc
            // 
            this.cbbDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDanhMuc.FormattingEnabled = true;
            this.cbbDanhMuc.Location = new System.Drawing.Point(685, 85);
            this.cbbDanhMuc.Name = "cbbDanhMuc";
            this.cbbDanhMuc.Size = new System.Drawing.Size(142, 34);
            this.cbbDanhMuc.TabIndex = 2;
            this.cbbDanhMuc.SelectedValueChanged += new System.EventHandler(this.cbbMenu_SelectedValueChanged);
            // 
            // cbbMenu
            // 
            this.cbbMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMenu.FormattingEnabled = true;
            this.cbbMenu.Items.AddRange(new object[] {
            "Chọn"});
            this.cbbMenu.Location = new System.Drawing.Point(851, 85);
            this.cbbMenu.Name = "cbbMenu";
            this.cbbMenu.Size = new System.Drawing.Size(237, 34);
            this.cbbMenu.TabIndex = 3;
            this.cbbMenu.SelectedValueChanged += new System.EventHandler(this.cbbMenu_SelectedValueChanged_1);
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(1124, 85);
            this.nudSoLuong.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudSoLuong.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(54, 34);
            this.nudSoLuong.TabIndex = 4;
            this.nudSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnThemMon
            // 
            this.btnThemMon.Enabled = false;
            this.btnThemMon.Location = new System.Drawing.Point(1209, 85);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(133, 34);
            this.btnThemMon.TabIndex = 1;
            this.btnThemMon.Text = "Thêm món";
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // btnDatBan
            // 
            this.btnDatBan.Location = new System.Drawing.Point(747, 135);
            this.btnDatBan.Name = "btnDatBan";
            this.btnDatBan.Size = new System.Drawing.Size(148, 34);
            this.btnDatBan.TabIndex = 5;
            this.btnDatBan.Text = "Đặt bàn";
            this.btnDatBan.UseVisualStyleBackColor = true;
            this.btnDatBan.Click += new System.EventHandler(this.btnDatBan_Click);
            // 
            // btnHuyDat
            // 
            this.btnHuyDat.Location = new System.Drawing.Point(965, 135);
            this.btnHuyDat.Name = "btnHuyDat";
            this.btnHuyDat.Size = new System.Drawing.Size(148, 34);
            this.btnHuyDat.TabIndex = 6;
            this.btnHuyDat.Text = "Hủy đặt";
            this.btnHuyDat.UseVisualStyleBackColor = true;
            this.btnHuyDat.Click += new System.EventHandler(this.btnHuyDat_Click);
            // 
            // lblChiTiet
            // 
            this.lblChiTiet.AutoSize = true;
            this.lblChiTiet.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTiet.Location = new System.Drawing.Point(685, 186);
            this.lblChiTiet.Name = "lblChiTiet";
            this.lblChiTiet.Size = new System.Drawing.Size(150, 32);
            this.lblChiTiet.TabIndex = 15;
            this.lblChiTiet.Text = "Chi tiết bàn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(936, 662);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 27);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(1051, 659);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(141, 34);
            this.txtTongTien.TabIndex = 100;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(1213, 656);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(132, 41);
            this.btnThanhToan.TabIndex = 7;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // lblChonBan
            // 
            this.lblChonBan.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonBan.Location = new System.Drawing.Point(904, 378);
            this.lblChonBan.Name = "lblChonBan";
            this.lblChonBan.Size = new System.Drawing.Size(292, 88);
            this.lblChonBan.TabIndex = 20;
            this.lblChonBan.Text = "Mời chọn bàn";
            this.lblChonBan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvChiTietBan
            // 
            this.lvChiTietBan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvChiTietBan.GridLines = true;
            this.lvChiTietBan.Location = new System.Drawing.Point(691, 231);
            this.lvChiTietBan.Name = "lvChiTietBan";
            this.lvChiTietBan.Size = new System.Drawing.Size(668, 419);
            this.lvChiTietBan.TabIndex = 21;
            this.lvChiTietBan.UseCompatibleStateImageBehavior = false;
            this.lvChiTietBan.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên";
            this.columnHeader1.Width = 259;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 98;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn Giá";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 129;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tổng tiền";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 172;
            // 
            // frmQuanLyCuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1371, 725);
            this.ControlBox = false;
            this.Controls.Add(this.lvChiTietBan);
            this.Controls.Add(this.lblChonBan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblChiTiet);
            this.Controls.Add(this.btnHuyDat);
            this.Controls.Add(this.btnDatBan);
            this.Controls.Add(this.btnThemMon);
            this.Controls.Add(this.nudSoLuong);
            this.Controls.Add(this.cbbMenu);
            this.Controls.Add(this.cbbDanhMuc);
            this.Controls.Add(this.flpDsBan);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(1389, 772);
            this.MinimumSize = new System.Drawing.Size(1389, 772);
            this.Name = "frmQuanLyCuaHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ CỬA HÀNG";
            this.Load += new System.EventHandler(this.frmQuanLyCuaHang_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnChucNang;
        private System.Windows.Forms.ToolStripMenuItem mnHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnThongTinPhanMem;
        private System.Windows.Forms.ToolStripMenuItem mnDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnThoat;
        private System.Windows.Forms.ToolStripMenuItem mnThongKe;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslblNgay;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tmnThongKe;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tmnDangXuat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tmnThoat;
        private System.Windows.Forms.FlowLayoutPanel flpDsBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbDanhMuc;
        private System.Windows.Forms.ComboBox cbbMenu;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Button btnDatBan;
        private System.Windows.Forms.Button btnHuyDat;
        private System.Windows.Forms.Label lblChiTiet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label lblChonBan;
        private System.Windows.Forms.ListView lvChiTietBan;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripMenuItem mnMenu;
        private System.Windows.Forms.ToolStripButton tmnMenu;
    }
}