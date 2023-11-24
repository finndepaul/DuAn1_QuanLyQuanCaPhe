namespace PRL.f_ChucNang
{
	partial class f_CongThuc
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
			groupBox1 = new GroupBox();
			cbb_PC_NguyenLieu = new ComboBox();
			cbx_PC_SanPham = new ComboBox();
			dgv_PhaChe = new DataGridView();
			btn_XoaPhaChe = new Button();
			btn_SuaPhaChe = new Button();
			btn_ThemPhaChe = new Button();
			groupBox2 = new GroupBox();
			cbb_LocDate = new ComboBox();
			dtp_HanNgay = new DateTimePicker();
			dtp_NhapNgay = new DateTimePicker();
			btn_XoaNguyenLieu = new Button();
			txt_TimKiemNL = new TextBox();
			lbl_TimKiemPC = new Label();
			btn_SuaNguyenLieu = new Button();
			dgv_NguyenLieu = new DataGridView();
			txt_SoLuongNL = new TextBox();
			btn_ThemNguyenLieu = new Button();
			lbl_SoLuong = new Label();
			txt_GiaNguyenLieu = new TextBox();
			lbl_Han = new Label();
			lbl_Nhap = new Label();
			lbl_Gia = new Label();
			txt_TenNguyenLieu = new TextBox();
			txt_IdNguyenLieu = new TextBox();
			lbl_TenNguyenLieu = new Label();
			lbl_IdNguyenLieu = new Label();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgv_PhaChe).BeginInit();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgv_NguyenLieu).BeginInit();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(cbb_PC_NguyenLieu);
			groupBox1.Controls.Add(cbx_PC_SanPham);
			groupBox1.Controls.Add(dgv_PhaChe);
			groupBox1.Controls.Add(btn_XoaPhaChe);
			groupBox1.Controls.Add(btn_SuaPhaChe);
			groupBox1.Controls.Add(btn_ThemPhaChe);
			groupBox1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			groupBox1.Location = new Point(12, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(844, 931);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Quản Lý Pha Chế";
			// 
			// cbb_PC_NguyenLieu
			// 
			cbb_PC_NguyenLieu.FormattingEnabled = true;
			cbb_PC_NguyenLieu.Location = new Point(217, 140);
			cbb_PC_NguyenLieu.Name = "cbb_PC_NguyenLieu";
			cbb_PC_NguyenLieu.Size = new Size(410, 29);
			cbb_PC_NguyenLieu.TabIndex = 41;
			// 
			// cbx_PC_SanPham
			// 
			cbx_PC_SanPham.FormattingEnabled = true;
			cbx_PC_SanPham.Location = new Point(217, 54);
			cbx_PC_SanPham.Name = "cbx_PC_SanPham";
			cbx_PC_SanPham.Size = new Size(410, 29);
			cbx_PC_SanPham.TabIndex = 41;
			// 
			// dgv_PhaChe
			// 
			dgv_PhaChe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgv_PhaChe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv_PhaChe.Location = new Point(0, 264);
			dgv_PhaChe.Name = "dgv_PhaChe";
			dgv_PhaChe.RowHeadersWidth = 51;
			dgv_PhaChe.RowTemplate.Height = 29;
			dgv_PhaChe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv_PhaChe.Size = new Size(844, 427);
			dgv_PhaChe.TabIndex = 38;
			// 
			// btn_XoaPhaChe
			// 
			btn_XoaPhaChe.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btn_XoaPhaChe.Location = new Point(625, 765);
			btn_XoaPhaChe.Name = "btn_XoaPhaChe";
			btn_XoaPhaChe.Size = new Size(140, 66);
			btn_XoaPhaChe.TabIndex = 37;
			btn_XoaPhaChe.Text = "Xóa";
			btn_XoaPhaChe.UseVisualStyleBackColor = true;
			// 
			// btn_SuaPhaChe
			// 
			btn_SuaPhaChe.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btn_SuaPhaChe.Location = new Point(352, 765);
			btn_SuaPhaChe.Name = "btn_SuaPhaChe";
			btn_SuaPhaChe.Size = new Size(140, 66);
			btn_SuaPhaChe.TabIndex = 36;
			btn_SuaPhaChe.Text = "Sửa";
			btn_SuaPhaChe.UseVisualStyleBackColor = true;
			// 
			// btn_ThemPhaChe
			// 
			btn_ThemPhaChe.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btn_ThemPhaChe.Location = new Point(79, 765);
			btn_ThemPhaChe.Name = "btn_ThemPhaChe";
			btn_ThemPhaChe.Size = new Size(140, 66);
			btn_ThemPhaChe.TabIndex = 35;
			btn_ThemPhaChe.Text = "Thêm";
			btn_ThemPhaChe.UseVisualStyleBackColor = true;
			btn_ThemPhaChe.Click += btn_ThemPhaChe_Click;
			// 
			// groupBox2
			// 
			groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			groupBox2.Controls.Add(cbb_LocDate);
			groupBox2.Controls.Add(dtp_HanNgay);
			groupBox2.Controls.Add(dtp_NhapNgay);
			groupBox2.Controls.Add(btn_XoaNguyenLieu);
			groupBox2.Controls.Add(txt_TimKiemNL);
			groupBox2.Controls.Add(lbl_TimKiemPC);
			groupBox2.Controls.Add(btn_SuaNguyenLieu);
			groupBox2.Controls.Add(dgv_NguyenLieu);
			groupBox2.Controls.Add(txt_SoLuongNL);
			groupBox2.Controls.Add(btn_ThemNguyenLieu);
			groupBox2.Controls.Add(lbl_SoLuong);
			groupBox2.Controls.Add(txt_GiaNguyenLieu);
			groupBox2.Controls.Add(lbl_Han);
			groupBox2.Controls.Add(lbl_Nhap);
			groupBox2.Controls.Add(lbl_Gia);
			groupBox2.Controls.Add(txt_TenNguyenLieu);
			groupBox2.Controls.Add(txt_IdNguyenLieu);
			groupBox2.Controls.Add(lbl_TenNguyenLieu);
			groupBox2.Controls.Add(lbl_IdNguyenLieu);
			groupBox2.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			groupBox2.Location = new Point(862, 12);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(845, 931);
			groupBox2.TabIndex = 0;
			groupBox2.TabStop = false;
			groupBox2.Text = "Quản Lý Nguyên Liệu";
			// 
			// cbb_LocDate
			// 
			cbb_LocDate.FormattingEnabled = true;
			cbb_LocDate.Location = new Point(694, 395);
			cbb_LocDate.Name = "cbb_LocDate";
			cbb_LocDate.Size = new Size(151, 29);
			cbb_LocDate.TabIndex = 43;
			cbb_LocDate.SelectedIndexChanged += cbb_LocDate_SelectedIndexChanged;
			// 
			// dtp_HanNgay
			// 
			dtp_HanNgay.Location = new Point(268, 279);
			dtp_HanNgay.Name = "dtp_HanNgay";
			dtp_HanNgay.Size = new Size(250, 28);
			dtp_HanNgay.TabIndex = 42;
			// 
			// dtp_NhapNgay
			// 
			dtp_NhapNgay.Location = new Point(268, 223);
			dtp_NhapNgay.Name = "dtp_NhapNgay";
			dtp_NhapNgay.Size = new Size(250, 28);
			dtp_NhapNgay.TabIndex = 42;
			// 
			// btn_XoaNguyenLieu
			// 
			btn_XoaNguyenLieu.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btn_XoaNguyenLieu.Location = new Point(631, 848);
			btn_XoaNguyenLieu.Name = "btn_XoaNguyenLieu";
			btn_XoaNguyenLieu.Size = new Size(140, 66);
			btn_XoaNguyenLieu.TabIndex = 41;
			btn_XoaNguyenLieu.Text = "Xóa";
			btn_XoaNguyenLieu.UseVisualStyleBackColor = true;
			btn_XoaNguyenLieu.Click += btn_XoaNguyenLieu_Click;
			// 
			// txt_TimKiemNL
			// 
			txt_TimKiemNL.Location = new Point(338, 395);
			txt_TimKiemNL.Name = "txt_TimKiemNL";
			txt_TimKiemNL.PlaceholderText = "Nhập Tên nguyên Liệu";
			txt_TimKiemNL.Size = new Size(330, 28);
			txt_TimKiemNL.TabIndex = 38;
			txt_TimKiemNL.TextChanged += txt_TimKiemNL_TextChanged;
			// 
			// lbl_TimKiemPC
			// 
			lbl_TimKiemPC.AutoSize = true;
			lbl_TimKiemPC.Location = new Point(252, 398);
			lbl_TimKiemPC.Name = "lbl_TimKiemPC";
			lbl_TimKiemPC.Size = new Size(80, 21);
			lbl_TimKiemPC.TabIndex = 37;
			lbl_TimKiemPC.Text = "Tìm Kiếm";
			// 
			// btn_SuaNguyenLieu
			// 
			btn_SuaNguyenLieu.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btn_SuaNguyenLieu.Location = new Point(352, 848);
			btn_SuaNguyenLieu.Name = "btn_SuaNguyenLieu";
			btn_SuaNguyenLieu.Size = new Size(140, 66);
			btn_SuaNguyenLieu.TabIndex = 40;
			btn_SuaNguyenLieu.Text = "Sửa";
			btn_SuaNguyenLieu.UseVisualStyleBackColor = true;
			btn_SuaNguyenLieu.Click += btn_SuaNguyenLieu_Click;
			// 
			// dgv_NguyenLieu
			// 
			dgv_NguyenLieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgv_NguyenLieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv_NguyenLieu.Location = new Point(0, 436);
			dgv_NguyenLieu.Name = "dgv_NguyenLieu";
			dgv_NguyenLieu.RowHeadersWidth = 51;
			dgv_NguyenLieu.RowTemplate.Height = 29;
			dgv_NguyenLieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv_NguyenLieu.Size = new Size(845, 386);
			dgv_NguyenLieu.TabIndex = 36;
			dgv_NguyenLieu.CellClick += dgv_NguyenLieu_CellClick;
			// 
			// txt_SoLuongNL
			// 
			txt_SoLuongNL.Location = new Point(268, 335);
			txt_SoLuongNL.Name = "txt_SoLuongNL";
			txt_SoLuongNL.Size = new Size(496, 28);
			txt_SoLuongNL.TabIndex = 35;
			// 
			// btn_ThemNguyenLieu
			// 
			btn_ThemNguyenLieu.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btn_ThemNguyenLieu.Location = new Point(73, 848);
			btn_ThemNguyenLieu.Name = "btn_ThemNguyenLieu";
			btn_ThemNguyenLieu.Size = new Size(140, 66);
			btn_ThemNguyenLieu.TabIndex = 39;
			btn_ThemNguyenLieu.Text = "Thêm";
			btn_ThemNguyenLieu.UseVisualStyleBackColor = true;
			btn_ThemNguyenLieu.Click += btn_ThemNguyenLieu_Click;
			// 
			// lbl_SoLuong
			// 
			lbl_SoLuong.AutoSize = true;
			lbl_SoLuong.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lbl_SoLuong.Location = new Point(81, 334);
			lbl_SoLuong.Name = "lbl_SoLuong";
			lbl_SoLuong.Size = new Size(93, 24);
			lbl_SoLuong.TabIndex = 34;
			lbl_SoLuong.Text = "Số Lượng";
			// 
			// txt_GiaNguyenLieu
			// 
			txt_GiaNguyenLieu.Location = new Point(268, 167);
			txt_GiaNguyenLieu.Name = "txt_GiaNguyenLieu";
			txt_GiaNguyenLieu.Size = new Size(496, 28);
			txt_GiaNguyenLieu.TabIndex = 33;
			// 
			// lbl_Han
			// 
			lbl_Han.AutoSize = true;
			lbl_Han.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lbl_Han.Location = new Point(81, 279);
			lbl_Han.Name = "lbl_Han";
			lbl_Han.Size = new Size(135, 24);
			lbl_Han.TabIndex = 32;
			lbl_Han.Text = "Ngày Hết Hạn";
			// 
			// lbl_Nhap
			// 
			lbl_Nhap.AutoSize = true;
			lbl_Nhap.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lbl_Nhap.Location = new Point(81, 224);
			lbl_Nhap.Name = "lbl_Nhap";
			lbl_Nhap.Size = new Size(107, 24);
			lbl_Nhap.TabIndex = 32;
			lbl_Nhap.Text = "Ngày Nhập";
			// 
			// lbl_Gia
			// 
			lbl_Gia.AutoSize = true;
			lbl_Gia.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lbl_Gia.Location = new Point(81, 167);
			lbl_Gia.Name = "lbl_Gia";
			lbl_Gia.Size = new Size(39, 24);
			lbl_Gia.TabIndex = 32;
			lbl_Gia.Text = "Giá";
			// 
			// txt_TenNguyenLieu
			// 
			txt_TenNguyenLieu.Location = new Point(268, 111);
			txt_TenNguyenLieu.Name = "txt_TenNguyenLieu";
			txt_TenNguyenLieu.Size = new Size(496, 28);
			txt_TenNguyenLieu.TabIndex = 29;
			// 
			// txt_IdNguyenLieu
			// 
			txt_IdNguyenLieu.Location = new Point(268, 55);
			txt_IdNguyenLieu.Name = "txt_IdNguyenLieu";
			txt_IdNguyenLieu.Size = new Size(496, 28);
			txt_IdNguyenLieu.TabIndex = 29;
			// 
			// lbl_TenNguyenLieu
			// 
			lbl_TenNguyenLieu.AutoSize = true;
			lbl_TenNguyenLieu.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lbl_TenNguyenLieu.Location = new Point(81, 114);
			lbl_TenNguyenLieu.Name = "lbl_TenNguyenLieu";
			lbl_TenNguyenLieu.Size = new Size(160, 24);
			lbl_TenNguyenLieu.TabIndex = 28;
			lbl_TenNguyenLieu.Text = "Tên Nguyên Liệu";
			// 
			// lbl_IdNguyenLieu
			// 
			lbl_IdNguyenLieu.AutoSize = true;
			lbl_IdNguyenLieu.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lbl_IdNguyenLieu.Location = new Point(81, 59);
			lbl_IdNguyenLieu.Name = "lbl_IdNguyenLieu";
			lbl_IdNguyenLieu.Size = new Size(147, 24);
			lbl_IdNguyenLieu.TabIndex = 28;
			lbl_IdNguyenLieu.Text = "ID Nguyên Liệu";
			// 
			// f_CongThuc
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1719, 955);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Name = "f_CongThuc";
			Text = "Công Thức";
			WindowState = FormWindowState.Maximized;
			Load += f_CongThuc_Load;
			groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgv_PhaChe).EndInit();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgv_NguyenLieu).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private ComboBox cbx_PC_SanPham;
		private DataGridView dgv_PhaChe;
		private Button btn_XoaPhaChe;
		private Button btn_SuaPhaChe;
		private Button btn_ThemPhaChe;
		private Button btn_XoaNguyenLieu;
		private Button btn_SuaNguyenLieu;
		private Button btn_ThemNguyenLieu;
		private TextBox txt_TimKiemNL;
		private Label lbl_TimKiemPC;
		private DataGridView dgv_NguyenLieu;
		private TextBox txt_SoLuongNL;
		private Label lbl_SoLuong;
		private TextBox txt_GiaNguyenLieu;
		private Label lbl_Gia;
		private TextBox txt_IdNguyenLieu;
		private Label lbl_IdNguyenLieu;
		private ComboBox cbb_PC_NguyenLieu;
		private TextBox txt_TenNguyenLieu;
		private Label lbl_TenNguyenLieu;
		private DateTimePicker dtp_HanNgay;
		private DateTimePicker dtp_NhapNgay;
		private Label lbl_Han;
		private Label lbl_Nhap;
		private ComboBox cbb_LocDate;
	}
}