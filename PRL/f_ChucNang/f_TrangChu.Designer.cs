namespace PRL
{
    partial class f_TrangChu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_TrangChu));
            txt_TraLai = new TextBox();
            txt_Voucher = new TextBox();
            txt_KhachDua = new TextBox();
            txt_MaThanhVien = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label9 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            label5 = new Label();
            lb_Gia = new Label();
            lb_TenSP = new Label();
            label12 = new Label();
            lb_SP = new Label();
            lbGhiChu = new Label();
            txt_GhiChu = new TextBox();
            txt_TongTien = new TextBox();
            lbl_LSP = new Label();
            numSL = new NumericUpDown();
            txt_ChiTietDVPS = new TextBox();
            cbx_LoaiSP = new ComboBox();
            txt_DichVuPhatSinh = new TextBox();
            label10 = new Label();
            label8 = new Label();
            label7 = new Label();
            label1 = new Label();
            dgv_Order = new DataGridView();
            btn_Xoa = new Button();
            btn_ThanhToan = new Button();
            btn_Sua = new Button();
            btn_Cho = new Button();
            btn_TamTinh = new Button();
            btn_Them = new Button();
            gb_SanPham = new GroupBox();
            flp_Menu = new FlowLayoutPanel();
            label6 = new Label();
            txt_TimKiemSanPham = new TextBox();
            dgv_HoaDon = new DataGridView();
            pd_HoaDon = new System.Drawing.Printing.PrintDocument();
            ppd_HoaDon = new PrintPreviewDialog();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Order).BeginInit();
            gb_SanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_HoaDon).BeginInit();
            SuspendLayout();
            // 
            // txt_TraLai
            // 
            txt_TraLai.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_TraLai.Location = new Point(208, 898);
            txt_TraLai.Name = "txt_TraLai";
            txt_TraLai.Size = new Size(320, 34);
            txt_TraLai.TabIndex = 4;
            // 
            // txt_Voucher
            // 
            txt_Voucher.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Voucher.Location = new Point(208, 776);
            txt_Voucher.Name = "txt_Voucher";
            txt_Voucher.ReadOnly = true;
            txt_Voucher.Size = new Size(320, 34);
            txt_Voucher.TabIndex = 4;
            txt_Voucher.TextChanged += txt_Voucher_TextChanged;
            // 
            // txt_KhachDua
            // 
            txt_KhachDua.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_KhachDua.Location = new Point(208, 837);
            txt_KhachDua.Name = "txt_KhachDua";
            txt_KhachDua.Size = new Size(320, 34);
            txt_KhachDua.TabIndex = 4;
            txt_KhachDua.TextChanged += txt_KhachDua_TextChanged;
            // 
            // txt_MaThanhVien
            // 
            txt_MaThanhVien.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_MaThanhVien.Location = new Point(208, 715);
            txt_MaThanhVien.Name = "txt_MaThanhVien";
            txt_MaThanhVien.Size = new Size(320, 34);
            txt_MaThanhVien.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(159, 971);
            label4.Name = "label4";
            label4.Size = new Size(0, 26);
            label4.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(698, 619);
            label3.Name = "label3";
            label3.Size = new Size(113, 28);
            label3.TabIndex = 3;
            label3.Text = "Tổng Tiền";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(7, 903);
            label9.Name = "label9";
            label9.Size = new Size(80, 28);
            label9.TabIndex = 3;
            label9.Text = "Trả Lại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(7, 779);
            label2.Name = "label2";
            label2.Size = new Size(95, 28);
            label2.TabIndex = 3;
            label2.Text = "Voucher";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top;
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(lb_Gia);
            groupBox3.Controls.Add(lb_TenSP);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(lb_SP);
            groupBox3.Controls.Add(lbGhiChu);
            groupBox3.Controls.Add(txt_GhiChu);
            groupBox3.Controls.Add(txt_TongTien);
            groupBox3.Controls.Add(txt_TraLai);
            groupBox3.Controls.Add(lbl_LSP);
            groupBox3.Controls.Add(numSL);
            groupBox3.Controls.Add(txt_ChiTietDVPS);
            groupBox3.Controls.Add(txt_Voucher);
            groupBox3.Controls.Add(cbx_LoaiSP);
            groupBox3.Controls.Add(txt_KhachDua);
            groupBox3.Controls.Add(txt_DichVuPhatSinh);
            groupBox3.Controls.Add(txt_MaThanhVien);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(dgv_Order);
            groupBox3.Controls.Add(btn_Xoa);
            groupBox3.Controls.Add(btn_ThanhToan);
            groupBox3.Controls.Add(btn_Sua);
            groupBox3.Controls.Add(btn_Cho);
            groupBox3.Controls.Add(btn_TamTinh);
            groupBox3.Controls.Add(btn_Them);
            groupBox3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(793, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(922, 937);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tác Vụ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(810, 35);
            label5.Name = "label5";
            label5.Size = new Size(95, 24);
            label5.TabIndex = 10;
            label5.Text = "Số lượng:";
            // 
            // lb_Gia
            // 
            lb_Gia.AutoSize = true;
            lb_Gia.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Gia.Location = new Point(678, 67);
            lb_Gia.Name = "lb_Gia";
            lb_Gia.Size = new Size(37, 24);
            lb_Gia.TabIndex = 8;
            lb_Gia.Text = "giá";
            lb_Gia.Visible = false;
            // 
            // lb_TenSP
            // 
            lb_TenSP.AutoSize = true;
            lb_TenSP.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_TenSP.Location = new Point(310, 67);
            lb_TenSP.Name = "lb_TenSP";
            lb_TenSP.Size = new Size(89, 24);
            lb_TenSP.TabIndex = 8;
            lb_TenSP.Text = "Tên món";
            lb_TenSP.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(678, 35);
            label12.Name = "label12";
            label12.Size = new Size(46, 24);
            label12.TabIndex = 8;
            label12.Text = "Giá:";
            // 
            // lb_SP
            // 
            lb_SP.AutoSize = true;
            lb_SP.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_SP.Location = new Point(310, 35);
            lb_SP.Name = "lb_SP";
            lb_SP.Size = new Size(94, 24);
            lb_SP.TabIndex = 8;
            lb_SP.Text = "Tên Món:";
            // 
            // lbGhiChu
            // 
            lbGhiChu.AutoSize = true;
            lbGhiChu.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbGhiChu.Location = new Point(7, 111);
            lbGhiChu.Name = "lbGhiChu";
            lbGhiChu.Size = new Size(79, 24);
            lbGhiChu.TabIndex = 7;
            lbGhiChu.Text = "Ghi Chú";
            // 
            // txt_GhiChu
            // 
            txt_GhiChu.Location = new Point(89, 112);
            txt_GhiChu.Margin = new Padding(3, 4, 3, 4);
            txt_GhiChu.Name = "txt_GhiChu";
            txt_GhiChu.Size = new Size(429, 26);
            txt_GhiChu.TabIndex = 6;
            // 
            // txt_TongTien
            // 
            txt_TongTien.Enabled = false;
            txt_TongTien.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_TongTien.Location = new Point(601, 684);
            txt_TongTien.Name = "txt_TongTien";
            txt_TongTien.Size = new Size(307, 34);
            txt_TongTien.TabIndex = 4;
            // 
            // lbl_LSP
            // 
            lbl_LSP.AutoSize = true;
            lbl_LSP.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_LSP.Location = new Point(6, 35);
            lbl_LSP.Name = "lbl_LSP";
            lbl_LSP.Size = new Size(90, 24);
            lbl_LSP.TabIndex = 5;
            lbl_LSP.Text = "Loại Món";
            // 
            // numSL
            // 
            numSL.Location = new Point(810, 67);
            numSL.Name = "numSL";
            numSL.Size = new Size(73, 26);
            numSL.TabIndex = 1;
            // 
            // txt_ChiTietDVPS
            // 
            txt_ChiTietDVPS.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_ChiTietDVPS.Location = new Point(208, 654);
            txt_ChiTietDVPS.Name = "txt_ChiTietDVPS";
            txt_ChiTietDVPS.ReadOnly = true;
            txt_ChiTietDVPS.Size = new Size(320, 34);
            txt_ChiTietDVPS.TabIndex = 4;
            txt_ChiTietDVPS.TextChanged += txt_ChiTietDVPS_TextChanged;
            // 
            // cbx_LoaiSP
            // 
            cbx_LoaiSP.FormattingEnabled = true;
            cbx_LoaiSP.Location = new Point(6, 67);
            cbx_LoaiSP.Name = "cbx_LoaiSP";
            cbx_LoaiSP.Size = new Size(265, 26);
            cbx_LoaiSP.TabIndex = 0;
            cbx_LoaiSP.SelectedIndexChanged += cbx_LoaiSP_SelectedIndexChanged;
            // 
            // txt_DichVuPhatSinh
            // 
            txt_DichVuPhatSinh.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_DichVuPhatSinh.Location = new Point(208, 593);
            txt_DichVuPhatSinh.Name = "txt_DichVuPhatSinh";
            txt_DichVuPhatSinh.Size = new Size(320, 34);
            txt_DichVuPhatSinh.TabIndex = 4;
            txt_DichVuPhatSinh.TextChanged += txt_DichVuPhatSinh_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(7, 655);
            label10.Name = "label10";
            label10.Size = new Size(89, 28);
            label10.TabIndex = 3;
            label10.Text = "Chi Tiết";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(7, 841);
            label8.Name = "label8";
            label8.Size = new Size(124, 28);
            label8.TabIndex = 3;
            label8.Text = "Khách Đưa";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(7, 593);
            label7.Name = "label7";
            label7.Size = new Size(195, 28);
            label7.TabIndex = 3;
            label7.Text = "Dịch Vụ Phát Sinh";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(7, 717);
            label1.Name = "label1";
            label1.Size = new Size(164, 28);
            label1.TabIndex = 3;
            label1.Text = "Mã Thành Viên";
            // 
            // dgv_Order
            // 
            dgv_Order.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Order.Location = new Point(6, 165);
            dgv_Order.Name = "dgv_Order";
            dgv_Order.RowHeadersWidth = 51;
            dgv_Order.RowTemplate.Height = 29;
            dgv_Order.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Order.Size = new Size(917, 400);
            dgv_Order.TabIndex = 2;
            dgv_Order.CellClick += dgv_Order_CellClick;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Xoa.Location = new Point(810, 111);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(112, 43);
            btn_Xoa.TabIndex = 0;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // btn_ThanhToan
            // 
            btn_ThanhToan.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ThanhToan.Location = new Point(698, 831);
            btn_ThanhToan.Name = "btn_ThanhToan";
            btn_ThanhToan.Size = new Size(123, 53);
            btn_ThanhToan.TabIndex = 0;
            btn_ThanhToan.Text = "Thanh Toán";
            btn_ThanhToan.UseVisualStyleBackColor = true;
            btn_ThanhToan.Click += btn_ThanhToan_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Sua.Location = new Point(691, 111);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(112, 43);
            btn_Sua.TabIndex = 0;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // btn_Cho
            // 
            btn_Cho.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Cho.Location = new Point(601, 748);
            btn_Cho.Name = "btn_Cho";
            btn_Cho.Size = new Size(123, 53);
            btn_Cho.TabIndex = 0;
            btn_Cho.Text = "Chờ";
            btn_Cho.UseVisualStyleBackColor = true;
            btn_Cho.Click += btn_Cho_Click;
            // 
            // btn_TamTinh
            // 
            btn_TamTinh.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_TamTinh.Location = new Point(785, 747);
            btn_TamTinh.Name = "btn_TamTinh";
            btn_TamTinh.Size = new Size(123, 53);
            btn_TamTinh.TabIndex = 0;
            btn_TamTinh.Text = "Tạm Tính";
            btn_TamTinh.UseVisualStyleBackColor = true;
            btn_TamTinh.Click += btn_TamTinh_Click;
            // 
            // btn_Them
            // 
            btn_Them.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Them.Location = new Point(573, 111);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(112, 43);
            btn_Them.TabIndex = 0;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // gb_SanPham
            // 
            gb_SanPham.Anchor = AnchorStyles.Top;
            gb_SanPham.Controls.Add(flp_Menu);
            gb_SanPham.Controls.Add(label6);
            gb_SanPham.Controls.Add(txt_TimKiemSanPham);
            gb_SanPham.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gb_SanPham.Location = new Point(6, 5);
            gb_SanPham.Name = "gb_SanPham";
            gb_SanPham.Size = new Size(781, 557);
            gb_SanPham.TabIndex = 5;
            gb_SanPham.TabStop = false;
            gb_SanPham.Text = "Order";
            // 
            // flp_Menu
            // 
            flp_Menu.AutoScroll = true;
            flp_Menu.Location = new Point(6, 107);
            flp_Menu.Name = "flp_Menu";
            flp_Menu.Size = new Size(769, 445);
            flp_Menu.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(6, 59);
            label6.Name = "label6";
            label6.Size = new Size(146, 24);
            label6.TabIndex = 7;
            label6.Text = "Tên Sản Phẩm:";
            // 
            // txt_TimKiemSanPham
            // 
            txt_TimKiemSanPham.Location = new Point(173, 59);
            txt_TimKiemSanPham.Name = "txt_TimKiemSanPham";
            txt_TimKiemSanPham.PlaceholderText = "Nhập để tìm kiếm sản phẩm";
            txt_TimKiemSanPham.Size = new Size(349, 26);
            txt_TimKiemSanPham.TabIndex = 6;
            // 
            // dgv_HoaDon
            // 
            dgv_HoaDon.Anchor = AnchorStyles.Bottom;
            dgv_HoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_HoaDon.Location = new Point(6, 569);
            dgv_HoaDon.Name = "dgv_HoaDon";
            dgv_HoaDon.RowHeadersWidth = 51;
            dgv_HoaDon.RowTemplate.Height = 29;
            dgv_HoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_HoaDon.Size = new Size(781, 373);
            dgv_HoaDon.TabIndex = 1;
            dgv_HoaDon.CellClick += dgv_HoaDon_CellClick;
            // 
            // pd_HoaDon
            // 
            pd_HoaDon.PrintPage += pd_HoaDon_PrintPage;
            // 
            // ppd_HoaDon
            // 
            ppd_HoaDon.AutoScrollMargin = new Size(0, 0);
            ppd_HoaDon.AutoScrollMinSize = new Size(0, 0);
            ppd_HoaDon.ClientSize = new Size(400, 300);
            ppd_HoaDon.Enabled = true;
            ppd_HoaDon.Icon = (Icon)resources.GetObject("ppd_HoaDon.Icon");
            ppd_HoaDon.Name = "ppd_HoaDon";
            ppd_HoaDon.Visible = false;
            // 
            // f_TrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1719, 955);
            Controls.Add(dgv_HoaDon);
            Controls.Add(gb_SanPham);
            Controls.Add(groupBox3);
            Name = "f_TrangChu";
            Text = "Trang chủ";
            WindowState = FormWindowState.Maximized;
            Load += f_TrangChu_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSL).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Order).EndInit();
            gb_SanPham.ResumeLayout(false);
            gb_SanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_HoaDon).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txt_TraLai;
        private TextBox txt_Voucher;
        private TextBox txt_KhachDua;
        private TextBox txt_MaThanhVien;
        private Label label4;
        private Label label3;
        private Label label9;
        private Label label2;
        private GroupBox groupBox3;
        private Label label8;
        private Label label1;
        private DataGridView dgv_Order;
        private NumericUpDown numSL;
        private Button btn_Xoa;
        private Button btn_ThanhToan;
        private Button btn_Sua;
        private Button btn_TamTinh;
        private Button btn_Them;
        private ComboBox cbx_LoaiSP;
        private GroupBox gb_SanPham;
        private TextBox txt_TongTien;
        private Label lbl_LSP;
        private DataGridView dgv_HoaDon;
        private Label label6;
        private TextBox txt_TimKiemSanPham;
        private FlowLayoutPanel flp_Menu;
        private Label lbGhiChu;
        private TextBox txt_GhiChu;
        private Label lb_SP;
        private Label label5;
        private Button btn_Cho;
        private TextBox txt_ChiTietDVPS;
        private TextBox txt_DichVuPhatSinh;
        private Label label10;
        private Label label7;
        private Label lb_Gia;
        private Label lb_TenSP;
        private Label label12;
        private System.Drawing.Printing.PrintDocument pd_HoaDon;
        private PrintPreviewDialog ppd_HoaDon;
    }
}