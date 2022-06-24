namespace _1711548580_NguyenDuyKhuong_DACS_QLQuanAn
{
    partial class frmTaiKhoan
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMkCu = new System.Windows.Forms.TextBox();
            this.txtMkMoi = new System.Windows.Forms.TextBox();
            this.txtNhapLaiMk = new System.Windows.Forms.TextBox();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.cbHienMK = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblDoiThanhCong = new System.Windows.Forms.Label();
            this.lblTrungMkCu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu cũ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu mới:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập lại mật khẩu::";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(251, 93);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(242, 34);
            this.txtTaiKhoan.TabIndex = 4;
            this.txtTaiKhoan.Leave += new System.EventHandler(this.txtTaiKhoan_Leave);
            // 
            // txtMkCu
            // 
            this.txtMkCu.Location = new System.Drawing.Point(251, 165);
            this.txtMkCu.Name = "txtMkCu";
            this.txtMkCu.Size = new System.Drawing.Size(242, 34);
            this.txtMkCu.TabIndex = 5;
            this.txtMkCu.UseSystemPasswordChar = true;
            this.txtMkCu.Leave += new System.EventHandler(this.txtMkCu_Leave);
            // 
            // txtMkMoi
            // 
            this.txtMkMoi.Location = new System.Drawing.Point(251, 242);
            this.txtMkMoi.Name = "txtMkMoi";
            this.txtMkMoi.Size = new System.Drawing.Size(242, 34);
            this.txtMkMoi.TabIndex = 6;
            this.txtMkMoi.UseSystemPasswordChar = true;
            this.txtMkMoi.Leave += new System.EventHandler(this.txtMkMoi_Leave);
            // 
            // txtNhapLaiMk
            // 
            this.txtNhapLaiMk.Location = new System.Drawing.Point(251, 324);
            this.txtNhapLaiMk.Name = "txtNhapLaiMk";
            this.txtNhapLaiMk.Size = new System.Drawing.Size(242, 34);
            this.txtNhapLaiMk.TabIndex = 7;
            this.txtNhapLaiMk.UseSystemPasswordChar = true;
            this.txtNhapLaiMk.Leave += new System.EventHandler(this.txtNhapLaiMk_Leave);
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Location = new System.Drawing.Point(90, 442);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(161, 43);
            this.btnDoiMK.TabIndex = 8;
            this.btnDoiMK.Text = "Đổi mật khẩu";
            this.btnDoiMK.UseVisualStyleBackColor = true;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(313, 442);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(161, 43);
            this.btnDong.TabIndex = 9;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // cbHienMK
            // 
            this.cbHienMK.AutoSize = true;
            this.cbHienMK.Location = new System.Drawing.Point(251, 390);
            this.cbHienMK.Name = "cbHienMK";
            this.cbHienMK.Size = new System.Drawing.Size(175, 31);
            this.cbHienMK.TabIndex = 10;
            this.cbHienMK.Text = "Hiện mật khẩu";
            this.cbHienMK.UseVisualStyleBackColor = true;
            this.cbHienMK.CheckedChanged += new System.EventHandler(this.cbHienMK_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // lblDoiThanhCong
            // 
            this.lblDoiThanhCong.AutoSize = true;
            this.lblDoiThanhCong.ForeColor = System.Drawing.Color.Lime;
            this.lblDoiThanhCong.Location = new System.Drawing.Point(143, 34);
            this.lblDoiThanhCong.Name = "lblDoiThanhCong";
            this.lblDoiThanhCong.Size = new System.Drawing.Size(346, 27);
            this.lblDoiThanhCong.TabIndex = 11;
            this.lblDoiThanhCong.Text = "ĐỔI MẬT KHẨU THÀNH CÔNG";
            // 
            // lblTrungMkCu
            // 
            this.lblTrungMkCu.ForeColor = System.Drawing.Color.Red;
            this.lblTrungMkCu.Location = new System.Drawing.Point(12, 9);
            this.lblTrungMkCu.Name = "lblTrungMkCu";
            this.lblTrungMkCu.Size = new System.Drawing.Size(558, 65);
            this.lblTrungMkCu.TabIndex = 12;
            this.lblTrungMkCu.Text = "MẬT KHẨU NÀY ĐÃ DÙNG TRƯỚC ĐÓ, VUI LÒNG CHỌN MẬT KHẨU KHÁC";
            this.lblTrungMkCu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTrungMkCu.Visible = false;
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 525);
            this.Controls.Add(this.lblTrungMkCu);
            this.Controls.Add(this.lblDoiThanhCong);
            this.Controls.Add(this.cbHienMK);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnDoiMK);
            this.Controls.Add(this.txtNhapLaiMk);
            this.Controls.Add(this.txtMkMoi);
            this.Controls.Add(this.txtMkCu);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TÀI KHOẢN (Username: admin | Password: 123)";
            this.Load += new System.EventHandler(this.frmTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMkCu;
        private System.Windows.Forms.TextBox txtMkMoi;
        private System.Windows.Forms.TextBox txtNhapLaiMk;
        private System.Windows.Forms.Button btnDoiMK;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.CheckBox cbHienMK;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.Label lblDoiThanhCong;
        private System.Windows.Forms.Label lblTrungMkCu;
    }
}