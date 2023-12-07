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
			txt_TraLai = new TextBox();
			txt_Voucher = new TextBox();
			txt_KhachDua = new TextBox();
			txt_MaThanhVien = new TextBox();
			label4 = new Label();
			label3 = new Label();
			label9 = new Label();
			label2 = new Label();
			gb_TacVu = new GroupBox();
			txt_DichVuPhatSinh = new TextBox();
			lbl_DichVuPhatSinh = new Label();
			txt_ChiTietDVPS = new TextBox();
			lbl_ChiTietDVPS = new Label();
			lb_Gia = new Label();
			lb_GiaSP = new Label();
			btn_Cho = new Button();
			label5 = new Label();
			lb_TenSP = new Label();
			lb_SP = new Label();
			lbGhiChu = new Label();
			txt_GhiChu = new TextBox();
			txt_TongTien = new TextBox();
			lb_LSP = new Label();
			numSL = new NumericUpDown();
			cbx_LoaiSP = new ComboBox();
			label8 = new Label();
			label1 = new Label();
			dgv_Order = new DataGridView();
			btn_Xoa = new Button();
			btn_ThanhToan = new Button();
			btn_Sua = new Button();
			btn_TamTinh = new Button();
			btn_Them = new Button();
			gb_SanPham = new GroupBox();
			flp_Menu = new FlowLayoutPanel();
			dgv_HoaDon = new DataGridView();
			gb_TacVu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numSL).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgv_Order).BeginInit();
			gb_SanPham.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgv_HoaDon).BeginInit();
			SuspendLayout();
			// 
			// txt_TraLai
			// 
			txt_TraLai.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			txt_TraLai.Location = new Point(173, 670);
			txt_TraLai.Margin = new Padding(3, 2, 3, 2);
			txt_TraLai.Name = "txt_TraLai";
			txt_TraLai.ReadOnly = true;
			txt_TraLai.Size = new Size(306, 29);
			txt_TraLai.TabIndex = 4;
			txt_TraLai.TextAlign = HorizontalAlignment.Right;
			// 
			// txt_Voucher
			// 
			txt_Voucher.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			txt_Voucher.Location = new Point(173, 577);
			txt_Voucher.Margin = new Padding(3, 2, 3, 2);
			txt_Voucher.Name = "txt_Voucher";
			txt_Voucher.ReadOnly = true;
			txt_Voucher.Size = new Size(306, 29);
			txt_Voucher.TabIndex = 4;
			txt_Voucher.TextAlign = HorizontalAlignment.Right;
			txt_Voucher.TextChanged += txt_Voucher_TextChanged;
			// 
			// txt_KhachDua
			// 
			txt_KhachDua.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			txt_KhachDua.Location = new Point(173, 625);
			txt_KhachDua.Margin = new Padding(3, 2, 3, 2);
			txt_KhachDua.Name = "txt_KhachDua";
			txt_KhachDua.Size = new Size(306, 29);
			txt_KhachDua.TabIndex = 4;
			txt_KhachDua.TextAlign = HorizontalAlignment.Right;
			txt_KhachDua.TextChanged += txt_KhachDua_TextChanged;
			// 
			// txt_MaThanhVien
			// 
			txt_MaThanhVien.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			txt_MaThanhVien.Location = new Point(173, 530);
			txt_MaThanhVien.Margin = new Padding(3, 2, 3, 2);
			txt_MaThanhVien.Name = "txt_MaThanhVien";
			txt_MaThanhVien.Size = new Size(306, 29);
			txt_MaThanhVien.TabIndex = 4;
			txt_MaThanhVien.TextAlign = HorizontalAlignment.Right;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(139, 728);
			label4.Name = "label4";
			label4.Size = new Size(0, 21);
			label4.TabIndex = 3;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(611, 465);
			label3.Name = "label3";
			label3.Size = new Size(95, 23);
			label3.TabIndex = 3;
			label3.Text = "Tổng Tiền";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			label9.Location = new Point(6, 673);
			label9.Name = "label9";
			label9.Size = new Size(67, 23);
			label9.TabIndex = 3;
			label9.Text = "Trả Lại";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(6, 578);
			label2.Name = "label2";
			label2.Size = new Size(79, 23);
			label2.TabIndex = 3;
			label2.Text = "Voucher";
			// 
			// gb_TacVu
			// 
			gb_TacVu.Anchor = AnchorStyles.Top;
			gb_TacVu.Controls.Add(txt_DichVuPhatSinh);
			gb_TacVu.Controls.Add(lbl_DichVuPhatSinh);
			gb_TacVu.Controls.Add(txt_ChiTietDVPS);
			gb_TacVu.Controls.Add(lbl_ChiTietDVPS);
			gb_TacVu.Controls.Add(lb_Gia);
			gb_TacVu.Controls.Add(lb_GiaSP);
			gb_TacVu.Controls.Add(btn_Cho);
			gb_TacVu.Controls.Add(label5);
			gb_TacVu.Controls.Add(lb_TenSP);
			gb_TacVu.Controls.Add(lb_SP);
			gb_TacVu.Controls.Add(lbGhiChu);
			gb_TacVu.Controls.Add(txt_GhiChu);
			gb_TacVu.Controls.Add(txt_TongTien);
			gb_TacVu.Controls.Add(txt_TraLai);
			gb_TacVu.Controls.Add(lb_LSP);
			gb_TacVu.Controls.Add(numSL);
			gb_TacVu.Controls.Add(txt_Voucher);
			gb_TacVu.Controls.Add(cbx_LoaiSP);
			gb_TacVu.Controls.Add(txt_KhachDua);
			gb_TacVu.Controls.Add(txt_MaThanhVien);
			gb_TacVu.Controls.Add(label4);
			gb_TacVu.Controls.Add(label3);
			gb_TacVu.Controls.Add(label9);
			gb_TacVu.Controls.Add(label2);
			gb_TacVu.Controls.Add(label8);
			gb_TacVu.Controls.Add(label1);
			gb_TacVu.Controls.Add(dgv_Order);
			gb_TacVu.Controls.Add(btn_Xoa);
			gb_TacVu.Controls.Add(btn_ThanhToan);
			gb_TacVu.Controls.Add(btn_Sua);
			gb_TacVu.Controls.Add(btn_TamTinh);
			gb_TacVu.Controls.Add(btn_Them);
			gb_TacVu.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
			gb_TacVu.Location = new Point(694, 4);
			gb_TacVu.Margin = new Padding(3, 2, 3, 2);
			gb_TacVu.Name = "gb_TacVu";
			gb_TacVu.Padding = new Padding(3, 2, 3, 2);
			gb_TacVu.Size = new Size(807, 703);
			gb_TacVu.TabIndex = 4;
			gb_TacVu.TabStop = false;
			gb_TacVu.Text = "Tác Vụ";
			// 
			// txt_DichVuPhatSinh
			// 
			txt_DichVuPhatSinh.AcceptsTab = true;
			txt_DichVuPhatSinh.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			txt_DichVuPhatSinh.Location = new Point(173, 443);
			txt_DichVuPhatSinh.Margin = new Padding(3, 2, 3, 2);
			txt_DichVuPhatSinh.Name = "txt_DichVuPhatSinh";
			txt_DichVuPhatSinh.Size = new Size(306, 29);
			txt_DichVuPhatSinh.TabIndex = 17;
			txt_DichVuPhatSinh.TextAlign = HorizontalAlignment.Right;
			txt_DichVuPhatSinh.TextChanged += txt_DichVuPhatSinh_TextChanged;
			// 
			// lbl_DichVuPhatSinh
			// 
			lbl_DichVuPhatSinh.AutoSize = true;
			lbl_DichVuPhatSinh.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			lbl_DichVuPhatSinh.Location = new Point(6, 446);
			lbl_DichVuPhatSinh.Name = "lbl_DichVuPhatSinh";
			lbl_DichVuPhatSinh.Size = new Size(161, 23);
			lbl_DichVuPhatSinh.TabIndex = 16;
			lbl_DichVuPhatSinh.Text = "Dịch Vụ Phát Sinh";
			// 
			// txt_ChiTietDVPS
			// 
			txt_ChiTietDVPS.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			txt_ChiTietDVPS.Location = new Point(173, 485);
			txt_ChiTietDVPS.Margin = new Padding(3, 2, 3, 2);
			txt_ChiTietDVPS.Name = "txt_ChiTietDVPS";
			txt_ChiTietDVPS.ReadOnly = true;
			txt_ChiTietDVPS.Size = new Size(306, 29);
			txt_ChiTietDVPS.TabIndex = 15;
			txt_ChiTietDVPS.TextChanged += txt_ChiTietDVPS_TextChanged;
			// 
			// lbl_ChiTietDVPS
			// 
			lbl_ChiTietDVPS.AutoSize = true;
			lbl_ChiTietDVPS.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			lbl_ChiTietDVPS.Location = new Point(6, 488);
			lbl_ChiTietDVPS.Name = "lbl_ChiTietDVPS";
			lbl_ChiTietDVPS.Size = new Size(68, 23);
			lbl_ChiTietDVPS.TabIndex = 14;
			lbl_ChiTietDVPS.Text = "Chi tiết";
			// 
			// lb_Gia
			// 
			lb_Gia.AutoSize = true;
			lb_Gia.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lb_Gia.Location = new Point(501, 50);
			lb_Gia.Name = "lb_Gia";
			lb_Gia.Size = new Size(0, 19);
			lb_Gia.TabIndex = 13;
			// 
			// lb_GiaSP
			// 
			lb_GiaSP.AutoSize = true;
			lb_GiaSP.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lb_GiaSP.Location = new Point(501, 26);
			lb_GiaSP.Name = "lb_GiaSP";
			lb_GiaSP.Size = new Size(38, 19);
			lb_GiaSP.TabIndex = 12;
			lb_GiaSP.Text = "Giá:";
			// 
			// btn_Cho
			// 
			btn_Cho.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			btn_Cho.Location = new Point(526, 620);
			btn_Cho.Margin = new Padding(3, 2, 3, 2);
			btn_Cho.Name = "btn_Cho";
			btn_Cho.Size = new Size(108, 40);
			btn_Cho.TabIndex = 11;
			btn_Cho.Text = "Chờ";
			btn_Cho.UseVisualStyleBackColor = true;
			btn_Cho.Click += btn_Cho_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(605, 26);
			label5.Name = "label5";
			label5.Size = new Size(79, 19);
			label5.TabIndex = 10;
			label5.Text = "Số lượng:";
			// 
			// lb_TenSP
			// 
			lb_TenSP.AutoSize = true;
			lb_TenSP.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lb_TenSP.Location = new Point(248, 50);
			lb_TenSP.Name = "lb_TenSP";
			lb_TenSP.Size = new Size(0, 19);
			lb_TenSP.TabIndex = 9;
			// 
			// lb_SP
			// 
			lb_SP.AutoSize = true;
			lb_SP.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lb_SP.Location = new Point(248, 26);
			lb_SP.Name = "lb_SP";
			lb_SP.Size = new Size(77, 19);
			lb_SP.TabIndex = 8;
			lb_SP.Text = "Tên Món:";
			// 
			// lbGhiChu
			// 
			lbGhiChu.AutoSize = true;
			lbGhiChu.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lbGhiChu.Location = new Point(6, 83);
			lbGhiChu.Name = "lbGhiChu";
			lbGhiChu.Size = new Size(66, 19);
			lbGhiChu.TabIndex = 7;
			lbGhiChu.Text = "Ghi Chú";
			// 
			// txt_GhiChu
			// 
			txt_GhiChu.Location = new Point(78, 84);
			txt_GhiChu.Name = "txt_GhiChu";
			txt_GhiChu.Size = new Size(376, 22);
			txt_GhiChu.TabIndex = 6;
			// 
			// txt_TongTien
			// 
			txt_TongTien.Enabled = false;
			txt_TongTien.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			txt_TongTien.Location = new Point(526, 513);
			txt_TongTien.Margin = new Padding(3, 2, 3, 2);
			txt_TongTien.Name = "txt_TongTien";
			txt_TongTien.ReadOnly = true;
			txt_TongTien.Size = new Size(269, 29);
			txt_TongTien.TabIndex = 4;
			txt_TongTien.TextAlign = HorizontalAlignment.Right;
			// 
			// lb_LSP
			// 
			lb_LSP.AutoSize = true;
			lb_LSP.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lb_LSP.Location = new Point(5, 26);
			lb_LSP.Name = "lb_LSP";
			lb_LSP.Size = new Size(73, 19);
			lb_LSP.TabIndex = 5;
			lb_LSP.Text = "Loại Món";
			// 
			// numSL
			// 
			numSL.Location = new Point(605, 50);
			numSL.Margin = new Padding(3, 2, 3, 2);
			numSL.Name = "numSL";
			numSL.Size = new Size(64, 22);
			numSL.TabIndex = 1;
			// 
			// cbx_LoaiSP
			// 
			cbx_LoaiSP.FormattingEnabled = true;
			cbx_LoaiSP.Location = new Point(5, 50);
			cbx_LoaiSP.Margin = new Padding(3, 2, 3, 2);
			cbx_LoaiSP.Name = "cbx_LoaiSP";
			cbx_LoaiSP.Size = new Size(232, 22);
			cbx_LoaiSP.TabIndex = 0;
			cbx_LoaiSP.SelectedIndexChanged += cbx_LoaiSP_SelectedIndexChanged;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			label8.Location = new Point(6, 626);
			label8.Name = "label8";
			label8.Size = new Size(103, 23);
			label8.TabIndex = 3;
			label8.Text = "Khách Đưa";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(6, 533);
			label1.Name = "label1";
			label1.Size = new Size(137, 23);
			label1.TabIndex = 3;
			label1.Text = "Mã Thành Viên";
			// 
			// dgv_Order
			// 
			dgv_Order.AllowUserToDeleteRows = false;
			dgv_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgv_Order.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv_Order.Location = new Point(6, 139);
			dgv_Order.Margin = new Padding(3, 2, 3, 2);
			dgv_Order.Name = "dgv_Order";
			dgv_Order.ReadOnly = true;
			dgv_Order.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			dgv_Order.RowTemplate.Height = 40;
			dgv_Order.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv_Order.Size = new Size(802, 300);
			dgv_Order.TabIndex = 2;
			dgv_Order.CellClick += dgv_Order_CellClick;
			// 
			// btn_Xoa
			// 
			btn_Xoa.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			btn_Xoa.Location = new Point(709, 83);
			btn_Xoa.Margin = new Padding(3, 2, 3, 2);
			btn_Xoa.Name = "btn_Xoa";
			btn_Xoa.Size = new Size(98, 32);
			btn_Xoa.TabIndex = 0;
			btn_Xoa.Text = "Xóa";
			btn_Xoa.UseVisualStyleBackColor = true;
			btn_Xoa.Click += btn_Xoa_Click;
			// 
			// btn_ThanhToan
			// 
			btn_ThanhToan.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			btn_ThanhToan.Location = new Point(687, 560);
			btn_ThanhToan.Margin = new Padding(3, 2, 3, 2);
			btn_ThanhToan.Name = "btn_ThanhToan";
			btn_ThanhToan.Size = new Size(108, 40);
			btn_ThanhToan.TabIndex = 0;
			btn_ThanhToan.Text = "Thanh Toán";
			btn_ThanhToan.UseVisualStyleBackColor = true;
			btn_ThanhToan.Click += btn_ThanhToan_Click;
			// 
			// btn_Sua
			// 
			btn_Sua.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			btn_Sua.Location = new Point(605, 83);
			btn_Sua.Margin = new Padding(3, 2, 3, 2);
			btn_Sua.Name = "btn_Sua";
			btn_Sua.Size = new Size(98, 32);
			btn_Sua.TabIndex = 0;
			btn_Sua.Text = "Sửa";
			btn_Sua.UseVisualStyleBackColor = true;
			btn_Sua.Click += btn_Sua_Click;
			// 
			// btn_TamTinh
			// 
			btn_TamTinh.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			btn_TamTinh.Location = new Point(526, 560);
			btn_TamTinh.Margin = new Padding(3, 2, 3, 2);
			btn_TamTinh.Name = "btn_TamTinh";
			btn_TamTinh.Size = new Size(108, 40);
			btn_TamTinh.TabIndex = 0;
			btn_TamTinh.Text = "Tạm Tính";
			btn_TamTinh.UseVisualStyleBackColor = true;
			// 
			// btn_Them
			// 
			btn_Them.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			btn_Them.Location = new Point(501, 83);
			btn_Them.Margin = new Padding(3, 2, 3, 2);
			btn_Them.Name = "btn_Them";
			btn_Them.Size = new Size(98, 32);
			btn_Them.TabIndex = 0;
			btn_Them.Text = "Thêm";
			btn_Them.UseVisualStyleBackColor = true;
			btn_Them.Click += btn_Them_Click;
			// 
			// gb_SanPham
			// 
			gb_SanPham.Anchor = AnchorStyles.Top;
			gb_SanPham.Controls.Add(flp_Menu);
			gb_SanPham.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
			gb_SanPham.Location = new Point(5, 4);
			gb_SanPham.Margin = new Padding(3, 2, 3, 2);
			gb_SanPham.Name = "gb_SanPham";
			gb_SanPham.Padding = new Padding(3, 2, 3, 2);
			gb_SanPham.Size = new Size(683, 418);
			gb_SanPham.TabIndex = 5;
			gb_SanPham.TabStop = false;
			gb_SanPham.Text = "Order";
			// 
			// flp_Menu
			// 
			flp_Menu.AutoScroll = true;
			flp_Menu.Location = new Point(5, 80);
			flp_Menu.Margin = new Padding(3, 2, 3, 2);
			flp_Menu.Name = "flp_Menu";
			flp_Menu.Size = new Size(673, 334);
			flp_Menu.TabIndex = 8;
			// 
			// dgv_HoaDon
			// 
			dgv_HoaDon.AllowUserToAddRows = false;
			dgv_HoaDon.AllowUserToDeleteRows = false;
			dgv_HoaDon.Anchor = AnchorStyles.Bottom;
			dgv_HoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgv_HoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv_HoaDon.Location = new Point(5, 427);
			dgv_HoaDon.Margin = new Padding(3, 2, 3, 2);
			dgv_HoaDon.Name = "dgv_HoaDon";
			dgv_HoaDon.ReadOnly = true;
			dgv_HoaDon.RowHeadersWidth = 51;
			dgv_HoaDon.RowTemplate.Height = 29;
			dgv_HoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv_HoaDon.Size = new Size(683, 280);
			dgv_HoaDon.TabIndex = 1;
			dgv_HoaDon.CellClick += dgv_HoaDon_CellClick;
			// 
			// f_TrangChu
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoScroll = true;
			ClientSize = new Size(1504, 716);
			Controls.Add(dgv_HoaDon);
			Controls.Add(gb_SanPham);
			Controls.Add(gb_TacVu);
			Margin = new Padding(3, 2, 3, 2);
			Name = "f_TrangChu";
			Text = "Trang chủ";
			WindowState = FormWindowState.Maximized;
			Load += f_TrangChu_Load;
			gb_TacVu.ResumeLayout(false);
			gb_TacVu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numSL).EndInit();
			((System.ComponentModel.ISupportInitialize)dgv_Order).EndInit();
			gb_SanPham.ResumeLayout(false);
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
		private GroupBox gb_TacVu;
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
		private Label lb_LSP;
		private DataGridView dgv_HoaDon;
		private FlowLayoutPanel flp_Menu;
		private Label lbGhiChu;
		private TextBox txt_GhiChu;
		private Label lb_SP;
		private Label label5;
		private Label lb_TenSP;
		private Button btn_Cho;
		private Label lb_Gia;
		private Label lb_GiaSP;
		private TextBox txt_DichVuPhatSinh;
		private Label lbl_DichVuPhatSinh;
		private TextBox txt_ChiTietDVPS;
		private Label lbl_ChiTietDVPS;
	}
}