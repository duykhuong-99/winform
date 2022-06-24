namespace _1711548580_NguyenDuyKhuong_DACS_QLQuanAn
{
    partial class frmThongke
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDong = new System.Windows.Forms.Button();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnChuaTT = new System.Windows.Forms.Button();
            this.btnDaTT = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnDongF = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.lvChiTiet = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nudMa = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMa)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1050, 635);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDong);
            this.tabPage1.Controls.Add(this.dgvThongKe);
            this.tabPage1.Controls.Add(this.btnAll);
            this.tabPage1.Controls.Add(this.btnChuaTT);
            this.tabPage1.Controls.Add(this.btnDaTT);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1042, 596);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thống kê";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(773, 0);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(192, 40);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvThongKe.Location = new System.Drawing.Point(3, 42);
            this.dgvThongKe.MultiSelect = false;
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.ReadOnly = true;
            this.dgvThongKe.RowTemplate.Height = 24;
            this.dgvThongKe.Size = new System.Drawing.Size(1036, 551);
            this.dgvThongKe.TabIndex = 4;
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(532, 0);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(192, 40);
            this.btnAll.TabIndex = 3;
            this.btnAll.Text = "Xem tất cả";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnChuaTT
            // 
            this.btnChuaTT.Location = new System.Drawing.Point(295, 0);
            this.btnChuaTT.Name = "btnChuaTT";
            this.btnChuaTT.Size = new System.Drawing.Size(192, 40);
            this.btnChuaTT.TabIndex = 2;
            this.btnChuaTT.Text = "Chưa thanh toán";
            this.btnChuaTT.UseVisualStyleBackColor = true;
            this.btnChuaTT.Click += new System.EventHandler(this.btnChuaTT_Click);
            // 
            // btnDaTT
            // 
            this.btnDaTT.Location = new System.Drawing.Point(68, 0);
            this.btnDaTT.Name = "btnDaTT";
            this.btnDaTT.Size = new System.Drawing.Size(192, 40);
            this.btnDaTT.TabIndex = 1;
            this.btnDaTT.Text = "Đã thanh toán";
            this.btnDaTT.UseVisualStyleBackColor = true;
            this.btnDaTT.Click += new System.EventHandler(this.btnDaTT_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblTongTien);
            this.tabPage2.Controls.Add(this.btnDongF);
            this.tabPage2.Controls.Add(this.txtTongTien);
            this.tabPage2.Controls.Add(this.lblHoaDon);
            this.tabPage2.Controls.Add(this.btnXem);
            this.tabPage2.Controls.Add(this.lvChiTiet);
            this.tabPage2.Controls.Add(this.nudMa);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1042, 596);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chi tiết";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(592, 563);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(109, 27);
            this.lblTongTien.TabIndex = 7;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // btnDongF
            // 
            this.btnDongF.Location = new System.Drawing.Point(927, 556);
            this.btnDongF.Name = "btnDongF";
            this.btnDongF.Size = new System.Drawing.Size(97, 34);
            this.btnDongF.TabIndex = 6;
            this.btnDongF.Text = "Đóng";
            this.btnDongF.UseVisualStyleBackColor = true;
            this.btnDongF.Click += new System.EventHandler(this.btnDongF_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(707, 559);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(214, 34);
            this.txtTongTien.TabIndex = 5;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoaDon.Location = new System.Drawing.Point(326, 259);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(581, 75);
            this.lblHoaDon.TabIndex = 4;
            this.lblHoaDon.Text = "Hóa đơn không tồn tại";
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(555, 6);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(97, 34);
            this.btnXem.TabIndex = 3;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // lvChiTiet
            // 
            this.lvChiTiet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvChiTiet.GridLines = true;
            this.lvChiTiet.Location = new System.Drawing.Point(9, 49);
            this.lvChiTiet.Name = "lvChiTiet";
            this.lvChiTiet.Size = new System.Drawing.Size(1025, 498);
            this.lvChiTiet.TabIndex = 2;
            this.lvChiTiet.UseCompatibleStateImageBehavior = false;
            this.lvChiTiet.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 338;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 214;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 221;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 242;
            // 
            // nudMa
            // 
            this.nudMa.Location = new System.Drawing.Point(473, 9);
            this.nudMa.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMa.Name = "nudMa";
            this.nudMa.Size = new System.Drawing.Size(76, 34);
            this.nudMa.TabIndex = 1;
            this.nudMa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // frmThongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 635);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(1068, 682);
            this.MinimumSize = new System.Drawing.Size(1068, 682);
            this.Name = "frmThongke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THỐNG KÊ";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnChuaTT;
        private System.Windows.Forms.Button btnDaTT;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.NumericUpDown nudMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvChiTiet;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Label lblHoaDon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnDongF;
        private System.Windows.Forms.Label lblTongTien;



    }
}