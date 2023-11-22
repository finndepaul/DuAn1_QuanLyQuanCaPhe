namespace PRL
{
    partial class f_Admin
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
            btn_Logout = new Button();
            btn_ThucDon = new Button();
            btn_Sale = new Button();
            pn_Admin = new Panel();
            btn_Voucher = new Button();
            btn_KhachHang = new Button();
            btn_TaiKhoan = new Button();
            btn_DoanhThu = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btn_CongThuc = new Button();
            btn_TrangChu = new Button();
            SuspendLayout();
            // 
            // btn_Logout
            // 
            btn_Logout.Anchor = AnchorStyles.Bottom;
            btn_Logout.BackColor = Color.Tan;
            btn_Logout.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Logout.ForeColor = SystemColors.ControlText;
            btn_Logout.Image = Properties.Resources.Logout;
            btn_Logout.ImageAlign = ContentAlignment.TopCenter;
            btn_Logout.Location = new Point(12, 945);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new Size(157, 84);
            btn_Logout.TabIndex = 3;
            btn_Logout.Text = "Đăng Xuất";
            btn_Logout.TextAlign = ContentAlignment.BottomCenter;
            btn_Logout.UseVisualStyleBackColor = false;
            btn_Logout.Click += btn_Logout_Click;
            // 
            // btn_ThucDon
            // 
            btn_ThucDon.BackColor = Color.Tan;
            btn_ThucDon.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ThucDon.Image = Properties.Resources.Menu;
            btn_ThucDon.ImageAlign = ContentAlignment.TopCenter;
            btn_ThucDon.Location = new Point(12, 117);
            btn_ThucDon.Name = "btn_ThucDon";
            btn_ThucDon.Size = new Size(157, 84);
            btn_ThucDon.TabIndex = 5;
            btn_ThucDon.Text = "Thực Đơn";
            btn_ThucDon.TextAlign = ContentAlignment.BottomCenter;
            btn_ThucDon.UseVisualStyleBackColor = false;
            btn_ThucDon.Click += btn_ThucDon_Click;
            // 
            // btn_Sale
            // 
            btn_Sale.BackColor = Color.Tan;
            btn_Sale.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Sale.ForeColor = SystemColors.ControlText;
            btn_Sale.Image = Properties.Resources.Sale;
            btn_Sale.ImageAlign = ContentAlignment.TopCenter;
            btn_Sale.Location = new Point(12, 297);
            btn_Sale.Name = "btn_Sale";
            btn_Sale.Size = new Size(157, 84);
            btn_Sale.TabIndex = 6;
            btn_Sale.Text = "Sale";
            btn_Sale.TextAlign = ContentAlignment.BottomCenter;
            btn_Sale.UseVisualStyleBackColor = false;
            btn_Sale.Click += btn_Sale_Click;
            // 
            // pn_Admin
            // 
            pn_Admin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pn_Admin.Location = new Point(175, 27);
            pn_Admin.Name = "pn_Admin";
            pn_Admin.Size = new Size(1737, 1002);
            pn_Admin.TabIndex = 11;
            // 
            // btn_Voucher
            // 
            btn_Voucher.BackColor = Color.Tan;
            btn_Voucher.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Voucher.Image = Properties.Resources.Voucher;
            btn_Voucher.ImageAlign = ContentAlignment.TopCenter;
            btn_Voucher.Location = new Point(12, 207);
            btn_Voucher.Name = "btn_Voucher";
            btn_Voucher.Size = new Size(157, 84);
            btn_Voucher.TabIndex = 9;
            btn_Voucher.Text = "Voucher";
            btn_Voucher.TextAlign = ContentAlignment.BottomCenter;
            btn_Voucher.UseVisualStyleBackColor = false;
            btn_Voucher.Click += btn_Voucher_Click;
            // 
            // btn_KhachHang
            // 
            btn_KhachHang.BackColor = Color.Tan;
            btn_KhachHang.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_KhachHang.Image = Properties.Resources.Customer;
            btn_KhachHang.ImageAlign = ContentAlignment.TopCenter;
            btn_KhachHang.Location = new Point(12, 387);
            btn_KhachHang.Name = "btn_KhachHang";
            btn_KhachHang.Size = new Size(157, 84);
            btn_KhachHang.TabIndex = 9;
            btn_KhachHang.Text = "Khách Hàng";
            btn_KhachHang.TextAlign = ContentAlignment.BottomCenter;
            btn_KhachHang.UseVisualStyleBackColor = false;
            btn_KhachHang.Click += btn_KhachHang_Click;
            // 
            // btn_TaiKhoan
            // 
            btn_TaiKhoan.BackColor = Color.Tan;
            btn_TaiKhoan.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_TaiKhoan.Image = Properties.Resources.User;
            btn_TaiKhoan.ImageAlign = ContentAlignment.TopCenter;
            btn_TaiKhoan.Location = new Point(12, 477);
            btn_TaiKhoan.Name = "btn_TaiKhoan";
            btn_TaiKhoan.Size = new Size(157, 84);
            btn_TaiKhoan.TabIndex = 9;
            btn_TaiKhoan.Text = "Tài Khoản";
            btn_TaiKhoan.TextAlign = ContentAlignment.BottomCenter;
            btn_TaiKhoan.UseVisualStyleBackColor = false;
            btn_TaiKhoan.Click += btn_TaiKhoan_Click;
            // 
            // btn_DoanhThu
            // 
            btn_DoanhThu.BackColor = Color.Tan;
            btn_DoanhThu.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_DoanhThu.Image = Properties.Resources.Revenue;
            btn_DoanhThu.ImageAlign = ContentAlignment.TopCenter;
            btn_DoanhThu.Location = new Point(12, 567);
            btn_DoanhThu.Name = "btn_DoanhThu";
            btn_DoanhThu.Size = new Size(157, 84);
            btn_DoanhThu.TabIndex = 9;
            btn_DoanhThu.Text = "Doanh Thu";
            btn_DoanhThu.TextAlign = ContentAlignment.BottomCenter;
            btn_DoanhThu.UseVisualStyleBackColor = false;
            btn_DoanhThu.Click += btn_DoanhThu_Click;
            // 
            // btn_CongThuc
            // 
            btn_CongThuc.BackColor = Color.Tan;
            btn_CongThuc.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_CongThuc.ForeColor = SystemColors.ControlText;
            btn_CongThuc.Image = Properties.Resources.Recipe;
            btn_CongThuc.ImageAlign = ContentAlignment.TopCenter;
            btn_CongThuc.Location = new Point(12, 657);
            btn_CongThuc.Name = "btn_CongThuc";
            btn_CongThuc.Size = new Size(157, 84);
            btn_CongThuc.TabIndex = 6;
            btn_CongThuc.Text = "Công Thức";
            btn_CongThuc.TextAlign = ContentAlignment.BottomCenter;
            btn_CongThuc.UseVisualStyleBackColor = false;
            btn_CongThuc.Click += btn_CongThuc_Click;
            // 
            // btn_TrangChu
            // 
            btn_TrangChu.BackColor = Color.Tan;
            btn_TrangChu.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            btn_TrangChu.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            btn_TrangChu.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_TrangChu.ForeColor = SystemColors.ControlText;
            btn_TrangChu.Image = Properties.Resources.Home;
            btn_TrangChu.ImageAlign = ContentAlignment.TopCenter;
            btn_TrangChu.Location = new Point(12, 27);
            btn_TrangChu.Name = "btn_TrangChu";
            btn_TrangChu.Size = new Size(157, 84);
            btn_TrangChu.TabIndex = 2;
            btn_TrangChu.Text = "Trang Chủ";
            btn_TrangChu.TextAlign = ContentAlignment.BottomCenter;
            btn_TrangChu.UseVisualStyleBackColor = false;
            btn_TrangChu.Click += btn_TrangChu_Click;
            // 
            // f_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_app;
            ClientSize = new Size(1924, 1055);
            Controls.Add(btn_ThucDon);
            Controls.Add(btn_Sale);
            Controls.Add(btn_TrangChu);
            Controls.Add(btn_Logout);
            Controls.Add(btn_CongThuc);
            Controls.Add(pn_Admin);
            Controls.Add(btn_DoanhThu);
            Controls.Add(btn_TaiKhoan);
            Controls.Add(btn_KhachHang);
            Controls.Add(btn_Voucher);
            Name = "f_Admin";
            Text = "Admin";
            WindowState = FormWindowState.Maximized;
            Load += f_Main_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btn_Logout;
        private Button btn_ThucDon;
        private Button btn_Sale;
        private Panel pn_Admin;
        private Button btn_Voucher;
        private Button btn_KhachHang;
        private Button btn_TaiKhoan;
        private Button btn_DoanhThu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btn_CongThuc;
        private Button btn_TrangChu;
    }
}