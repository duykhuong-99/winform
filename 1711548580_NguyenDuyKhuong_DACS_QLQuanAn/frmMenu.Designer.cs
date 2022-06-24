namespace _1711548580_NguyenDuyKhuong_DACS_QLQuanAn
{
    partial class frmMenu
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
            this.nudDonGia = new System.Windows.Forms.TabPage();
            this.btnDong = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nudDonGiaMon = new System.Windows.Forms.NumericUpDown();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoaMon = new System.Windows.Forms.Button();
            this.txtIdMon = new System.Windows.Forms.TextBox();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudDonGiaMon_Add = new System.Windows.Forms.NumericUpDown();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.txtTenMon_Add = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMon = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDongF = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCapNhatNuoc = new System.Windows.Forms.Button();
            this.nudDonGiaNuoc = new System.Windows.Forms.NumericUpDown();
            this.btnXoaNuoc = new System.Windows.Forms.Button();
            this.txtIdNuoc = new System.Windows.Forms.TextBox();
            this.txtTenNuoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nudDonGiaNuoc_Add = new System.Windows.Forms.NumericUpDown();
            this.btnThemNuoc = new System.Windows.Forms.Button();
            this.txtTenNuoc_Add = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvNuoc = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.nudDonGia.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGiaMon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGiaMon_Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMon)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGiaNuoc)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGiaNuoc_Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.nudDonGia);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1156, 661);
            this.tabControl1.TabIndex = 0;
            // 
            // nudDonGia
            // 
            this.nudDonGia.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nudDonGia.Controls.Add(this.btnDong);
            this.nudDonGia.Controls.Add(this.panel2);
            this.nudDonGia.Controls.Add(this.panel1);
            this.nudDonGia.Controls.Add(this.dgvMon);
            this.nudDonGia.Location = new System.Drawing.Point(4, 40);
            this.nudDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.nudDonGia.Name = "nudDonGia";
            this.nudDonGia.Padding = new System.Windows.Forms.Padding(4);
            this.nudDonGia.Size = new System.Drawing.Size(1148, 617);
            this.nudDonGia.TabIndex = 0;
            this.nudDonGia.Text = "Món ăn";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(800, 570);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(252, 39);
            this.btnDong.TabIndex = 9;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.nudDonGiaMon);
            this.panel2.Controls.Add(this.btnCapNhat);
            this.panel2.Controls.Add(this.btnXoaMon);
            this.panel2.Controls.Add(this.txtIdMon);
            this.panel2.Controls.Add(this.txtTenMon);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(672, 271);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 286);
            this.panel2.TabIndex = 8;
            // 
            // nudDonGiaMon
            // 
            this.nudDonGiaMon.Location = new System.Drawing.Point(135, 164);
            this.nudDonGiaMon.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.nudDonGiaMon.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDonGiaMon.Name = "nudDonGiaMon";
            this.nudDonGiaMon.Size = new System.Drawing.Size(308, 39);
            this.nudDonGiaMon.TabIndex = 9;
            this.nudDonGiaMon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDonGiaMon.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(96, 223);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(148, 43);
            this.btnCapNhat.TabIndex = 8;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoaMon
            // 
            this.btnXoaMon.Location = new System.Drawing.Point(304, 223);
            this.btnXoaMon.Name = "btnXoaMon";
            this.btnXoaMon.Size = new System.Drawing.Size(148, 43);
            this.btnXoaMon.TabIndex = 7;
            this.btnXoaMon.Text = "Xóa món";
            this.btnXoaMon.UseVisualStyleBackColor = true;
            this.btnXoaMon.Click += new System.EventHandler(this.btnXoaMon_Click);
            // 
            // txtIdMon
            // 
            this.txtIdMon.Location = new System.Drawing.Point(135, 28);
            this.txtIdMon.Name = "txtIdMon";
            this.txtIdMon.Size = new System.Drawing.Size(109, 39);
            this.txtIdMon.TabIndex = 5;
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(135, 97);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(308, 39);
            this.txtTenMon.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(5, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn giá";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(5, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 33);
            this.label5.TabIndex = 2;
            this.label5.Text = "ID";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(5, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 33);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tên món";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.nudDonGiaMon_Add);
            this.panel1.Controls.Add(this.btnThemMon);
            this.panel1.Controls.Add(this.txtTenMon_Add);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(672, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 233);
            this.panel1.TabIndex = 2;
            // 
            // nudDonGiaMon_Add
            // 
            this.nudDonGiaMon_Add.Location = new System.Drawing.Point(135, 96);
            this.nudDonGiaMon_Add.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.nudDonGiaMon_Add.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDonGiaMon_Add.Name = "nudDonGiaMon_Add";
            this.nudDonGiaMon_Add.Size = new System.Drawing.Size(308, 39);
            this.nudDonGiaMon_Add.TabIndex = 8;
            this.nudDonGiaMon_Add.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDonGiaMon_Add.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btnThemMon
            // 
            this.btnThemMon.Location = new System.Drawing.Point(304, 170);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(148, 43);
            this.btnThemMon.TabIndex = 7;
            this.btnThemMon.Text = "Thêm món";
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // txtTenMon_Add
            // 
            this.txtTenMon_Add.Location = new System.Drawing.Point(135, 19);
            this.txtTenMon_Add.Name = "txtTenMon_Add";
            this.txtTenMon_Add.Size = new System.Drawing.Size(308, 39);
            this.txtTenMon_Add.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(5, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đơn giá";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(5, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên món";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvMon
            // 
            this.dgvMon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMon.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvMon.Location = new System.Drawing.Point(4, 4);
            this.dgvMon.MultiSelect = false;
            this.dgvMon.Name = "dgvMon";
            this.dgvMon.ReadOnly = true;
            this.dgvMon.RowTemplate.Height = 24;
            this.dgvMon.Size = new System.Drawing.Size(658, 609);
            this.dgvMon.TabIndex = 0;
            this.dgvMon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMon_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage2.Controls.Add(this.btnDongF);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.dgvNuoc);
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1148, 617);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nước";
            // 
            // btnDongF
            // 
            this.btnDongF.Location = new System.Drawing.Point(799, 570);
            this.btnDongF.Name = "btnDongF";
            this.btnDongF.Size = new System.Drawing.Size(252, 39);
            this.btnDongF.TabIndex = 12;
            this.btnDongF.Text = "Đóng";
            this.btnDongF.UseVisualStyleBackColor = true;
            this.btnDongF.Click += new System.EventHandler(this.btnDongF_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnCapNhatNuoc);
            this.panel3.Controls.Add(this.nudDonGiaNuoc);
            this.panel3.Controls.Add(this.btnXoaNuoc);
            this.panel3.Controls.Add(this.txtIdNuoc);
            this.panel3.Controls.Add(this.txtTenNuoc);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(672, 271);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(464, 286);
            this.panel3.TabIndex = 11;
            // 
            // btnCapNhatNuoc
            // 
            this.btnCapNhatNuoc.Location = new System.Drawing.Point(96, 223);
            this.btnCapNhatNuoc.Name = "btnCapNhatNuoc";
            this.btnCapNhatNuoc.Size = new System.Drawing.Size(148, 43);
            this.btnCapNhatNuoc.TabIndex = 10;
            this.btnCapNhatNuoc.Text = "Cập nhật";
            this.btnCapNhatNuoc.UseVisualStyleBackColor = true;
            this.btnCapNhatNuoc.Click += new System.EventHandler(this.btnCapNhatNuoc_Click);
            // 
            // nudDonGiaNuoc
            // 
            this.nudDonGiaNuoc.Location = new System.Drawing.Point(135, 164);
            this.nudDonGiaNuoc.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.nudDonGiaNuoc.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDonGiaNuoc.Name = "nudDonGiaNuoc";
            this.nudDonGiaNuoc.Size = new System.Drawing.Size(308, 39);
            this.nudDonGiaNuoc.TabIndex = 9;
            this.nudDonGiaNuoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDonGiaNuoc.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btnXoaNuoc
            // 
            this.btnXoaNuoc.Location = new System.Drawing.Point(304, 223);
            this.btnXoaNuoc.Name = "btnXoaNuoc";
            this.btnXoaNuoc.Size = new System.Drawing.Size(148, 43);
            this.btnXoaNuoc.TabIndex = 7;
            this.btnXoaNuoc.Text = "Xóa nước";
            this.btnXoaNuoc.UseVisualStyleBackColor = true;
            this.btnXoaNuoc.Click += new System.EventHandler(this.btnXoaNuoc_Click);
            // 
            // txtIdNuoc
            // 
            this.txtIdNuoc.Location = new System.Drawing.Point(135, 28);
            this.txtIdNuoc.Name = "txtIdNuoc";
            this.txtIdNuoc.Size = new System.Drawing.Size(109, 39);
            this.txtIdNuoc.TabIndex = 5;
            this.txtIdNuoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTenNuoc
            // 
            this.txtTenNuoc.Location = new System.Drawing.Point(144, 98);
            this.txtTenNuoc.Name = "txtTenNuoc";
            this.txtTenNuoc.Size = new System.Drawing.Size(308, 39);
            this.txtTenNuoc.TabIndex = 4;
            this.txtTenNuoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(5, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đơn giá";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(5, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 33);
            this.label7.TabIndex = 2;
            this.label7.Text = "ID";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(5, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 33);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tên nước";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.nudDonGiaNuoc_Add);
            this.panel4.Controls.Add(this.btnThemNuoc);
            this.panel4.Controls.Add(this.txtTenNuoc_Add);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(672, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(464, 233);
            this.panel4.TabIndex = 10;
            // 
            // nudDonGiaNuoc_Add
            // 
            this.nudDonGiaNuoc_Add.Location = new System.Drawing.Point(135, 96);
            this.nudDonGiaNuoc_Add.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.nudDonGiaNuoc_Add.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDonGiaNuoc_Add.Name = "nudDonGiaNuoc_Add";
            this.nudDonGiaNuoc_Add.Size = new System.Drawing.Size(308, 39);
            this.nudDonGiaNuoc_Add.TabIndex = 8;
            this.nudDonGiaNuoc_Add.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDonGiaNuoc_Add.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btnThemNuoc
            // 
            this.btnThemNuoc.Location = new System.Drawing.Point(304, 170);
            this.btnThemNuoc.Name = "btnThemNuoc";
            this.btnThemNuoc.Size = new System.Drawing.Size(148, 43);
            this.btnThemNuoc.TabIndex = 7;
            this.btnThemNuoc.Text = "Thêm nước";
            this.btnThemNuoc.UseVisualStyleBackColor = true;
            this.btnThemNuoc.Click += new System.EventHandler(this.btnThemNuoc_Click);
            // 
            // txtTenNuoc_Add
            // 
            this.txtTenNuoc_Add.Location = new System.Drawing.Point(135, 19);
            this.txtTenNuoc_Add.Name = "txtTenNuoc_Add";
            this.txtTenNuoc_Add.Size = new System.Drawing.Size(308, 39);
            this.txtTenNuoc_Add.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(5, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 33);
            this.label9.TabIndex = 3;
            this.label9.Text = "Đơn giá";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(5, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 33);
            this.label10.TabIndex = 1;
            this.label10.Text = "Tên nước";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvNuoc
            // 
            this.dgvNuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNuoc.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvNuoc.Location = new System.Drawing.Point(4, 4);
            this.dgvNuoc.MultiSelect = false;
            this.dgvNuoc.Name = "dgvNuoc";
            this.dgvNuoc.ReadOnly = true;
            this.dgvNuoc.RowTemplate.Height = 24;
            this.dgvNuoc.Size = new System.Drawing.Size(658, 609);
            this.dgvNuoc.TabIndex = 1;
            this.dgvNuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNuoc_CellClick);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1156, 661);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thực đơn";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.tabControl1.ResumeLayout(false);
            this.nudDonGia.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGiaMon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGiaMon_Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMon)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGiaNuoc)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGiaNuoc_Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage nudDonGia;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvMon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenMon_Add;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnXoaMon;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridView dgvNuoc;
        private System.Windows.Forms.TextBox txtIdMon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudDonGiaMon_Add;
        private System.Windows.Forms.Button btnDongF;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnXoaNuoc;
        private System.Windows.Forms.TextBox txtIdNuoc;
        private System.Windows.Forms.TextBox txtTenNuoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nudDonGiaNuoc_Add;
        private System.Windows.Forms.Button btnThemNuoc;
        private System.Windows.Forms.TextBox txtTenNuoc_Add;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.NumericUpDown nudDonGiaMon;
        private System.Windows.Forms.NumericUpDown nudDonGiaNuoc;
        private System.Windows.Forms.Button btnCapNhatNuoc;
    }
}