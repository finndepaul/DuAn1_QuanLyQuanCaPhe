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
			btn_XoaPC = new Button();
			btn_Reset = new Button();
			cbx_NguyenLieu = new ComboBox();
			cbx_SanPham = new ComboBox();
			dgv_PhaChe = new DataGridView();
			btn_XoaNL = new Button();
			btn_ThemPC = new Button();
			groupBox2 = new GroupBox();
			txt_TimKiemNL = new TextBox();
			lbl_TimKiemPC = new Label();
			btn_SuaNL = new Button();
			dgv_NguyenLieu = new DataGridView();
			txt_SoLuong = new TextBox();
			btn_ThemNL = new Button();
			lbl_SoLuong = new Label();
			txt_Gia = new TextBox();
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
			groupBox1.Controls.Add(btn_XoaPC);
			groupBox1.Controls.Add(btn_Reset);
			groupBox1.Controls.Add(cbx_NguyenLieu);
			groupBox1.Controls.Add(cbx_SanPham);
			groupBox1.Controls.Add(dgv_PhaChe);
			groupBox1.Controls.Add(btn_XoaNL);
			groupBox1.Controls.Add(btn_ThemPC);
			groupBox1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			groupBox1.Location = new Point(10, 9);
			groupBox1.Margin = new Padding(3, 2, 3, 2);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(3, 2, 3, 2);
			groupBox1.Size = new Size(738, 698);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Quản Lý Pha Chế";
			// 
			// btn_XoaPC
			// 
			btn_XoaPC.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btn_XoaPC.Location = new Point(489, 574);
			btn_XoaPC.Margin = new Padding(3, 2, 3, 2);
			btn_XoaPC.Name = "btn_XoaPC";
			btn_XoaPC.Size = new Size(171, 50);
			btn_XoaPC.TabIndex = 43;
			btn_XoaPC.Text = "Xóa Pha Chế";
			btn_XoaPC.UseVisualStyleBackColor = true;
			btn_XoaPC.Click += btn_XoaPC_Click;
			// 
			// btn_Reset
			// 
			btn_Reset.Location = new Point(651, 14);
			btn_Reset.Margin = new Padding(3, 2, 3, 2);
			btn_Reset.Name = "btn_Reset";
			btn_Reset.Size = new Size(82, 22);
			btn_Reset.TabIndex = 42;
			btn_Reset.Text = "Hiện Thị";
			btn_Reset.UseVisualStyleBackColor = true;
			btn_Reset.Click += btn_Reset_Click;
			// 
			// cbx_NguyenLieu
			// 
			cbx_NguyenLieu.ForeColor = SystemColors.ControlText;
			cbx_NguyenLieu.FormattingEnabled = true;
			cbx_NguyenLieu.Location = new Point(190, 105);
			cbx_NguyenLieu.Margin = new Padding(3, 2, 3, 2);
			cbx_NguyenLieu.Name = "cbx_NguyenLieu";
			cbx_NguyenLieu.Size = new Size(359, 25);
			cbx_NguyenLieu.TabIndex = 41;
			// 
			// cbx_SanPham
			// 
			cbx_SanPham.ForeColor = SystemColors.ControlText;
			cbx_SanPham.FormattingEnabled = true;
			cbx_SanPham.Location = new Point(190, 40);
			cbx_SanPham.Margin = new Padding(3, 2, 3, 2);
			cbx_SanPham.Name = "cbx_SanPham";
			cbx_SanPham.Size = new Size(359, 25);
			cbx_SanPham.TabIndex = 41;
			// 
			// dgv_PhaChe
			// 
			dgv_PhaChe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgv_PhaChe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv_PhaChe.Location = new Point(0, 198);
			dgv_PhaChe.Margin = new Padding(3, 2, 3, 2);
			dgv_PhaChe.Name = "dgv_PhaChe";
			dgv_PhaChe.RowHeadersWidth = 51;
			dgv_PhaChe.RowTemplate.Height = 29;
			dgv_PhaChe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv_PhaChe.Size = new Size(738, 320);
			dgv_PhaChe.TabIndex = 38;
			dgv_PhaChe.CellClick += dgv_PhaChe_CellClick;
			// 
			// btn_XoaNL
			// 
			btn_XoaNL.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btn_XoaNL.Location = new Point(251, 574);
			btn_XoaNL.Margin = new Padding(3, 2, 3, 2);
			btn_XoaNL.Name = "btn_XoaNL";
			btn_XoaNL.Size = new Size(171, 50);
			btn_XoaNL.TabIndex = 37;
			btn_XoaNL.Text = "Xóa Nguyên Liệu";
			btn_XoaNL.UseVisualStyleBackColor = true;
			btn_XoaNL.Click += btn_XoaPhaChe_Click;
			// 
			// btn_ThemPC
			// 
			btn_ThemPC.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btn_ThemPC.Location = new Point(43, 574);
			btn_ThemPC.Margin = new Padding(3, 2, 3, 2);
			btn_ThemPC.Name = "btn_ThemPC";
			btn_ThemPC.Size = new Size(136, 50);
			btn_ThemPC.TabIndex = 35;
			btn_ThemPC.Text = "Thêm Pha Chế";
			btn_ThemPC.UseVisualStyleBackColor = true;
			btn_ThemPC.Click += btn_ThemPhaChe_Click;
			// 
			// groupBox2
			// 
			groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			groupBox2.Controls.Add(txt_TimKiemNL);
			groupBox2.Controls.Add(lbl_TimKiemPC);
			groupBox2.Controls.Add(btn_SuaNL);
			groupBox2.Controls.Add(dgv_NguyenLieu);
			groupBox2.Controls.Add(txt_SoLuong);
			groupBox2.Controls.Add(btn_ThemNL);
			groupBox2.Controls.Add(lbl_SoLuong);
			groupBox2.Controls.Add(txt_Gia);
			groupBox2.Controls.Add(lbl_Gia);
			groupBox2.Controls.Add(txt_TenNguyenLieu);
			groupBox2.Controls.Add(txt_IdNguyenLieu);
			groupBox2.Controls.Add(lbl_TenNguyenLieu);
			groupBox2.Controls.Add(lbl_IdNguyenLieu);
			groupBox2.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			groupBox2.Location = new Point(754, 9);
			groupBox2.Margin = new Padding(3, 2, 3, 2);
			groupBox2.Name = "groupBox2";
			groupBox2.Padding = new Padding(3, 2, 3, 2);
			groupBox2.Size = new Size(739, 698);
			groupBox2.TabIndex = 0;
			groupBox2.TabStop = false;
			groupBox2.Text = "Quản Lý Nguyên Liệu";
			// 
			// txt_TimKiemNL
			// 
			txt_TimKiemNL.Location = new Point(451, 302);
			txt_TimKiemNL.Margin = new Padding(3, 2, 3, 2);
			txt_TimKiemNL.Name = "txt_TimKiemNL";
			txt_TimKiemNL.PlaceholderText = "Nhập Tên nguyên Liệu";
			txt_TimKiemNL.Size = new Size(289, 24);
			txt_TimKiemNL.TabIndex = 38;
			txt_TimKiemNL.TextChanged += txt_TimKiemNL_TextChanged;
			// 
			// lbl_TimKiemPC
			// 
			lbl_TimKiemPC.AutoSize = true;
			lbl_TimKiemPC.Location = new Point(375, 304);
			lbl_TimKiemPC.Name = "lbl_TimKiemPC";
			lbl_TimKiemPC.Size = new Size(63, 17);
			lbl_TimKiemPC.TabIndex = 37;
			lbl_TimKiemPC.Text = "Tìm Kiếm";
			// 
			// btn_SuaNL
			// 
			btn_SuaNL.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btn_SuaNL.Location = new Point(516, 636);
			btn_SuaNL.Margin = new Padding(3, 2, 3, 2);
			btn_SuaNL.Name = "btn_SuaNL";
			btn_SuaNL.Size = new Size(162, 50);
			btn_SuaNL.TabIndex = 40;
			btn_SuaNL.Text = "Sửa Nguyên Liệu";
			btn_SuaNL.UseVisualStyleBackColor = true;
			btn_SuaNL.Click += btn_SuaNguyenLieu_Click;
			// 
			// dgv_NguyenLieu
			// 
			dgv_NguyenLieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgv_NguyenLieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv_NguyenLieu.Location = new Point(0, 327);
			dgv_NguyenLieu.Margin = new Padding(3, 2, 3, 2);
			dgv_NguyenLieu.Name = "dgv_NguyenLieu";
			dgv_NguyenLieu.RowHeadersWidth = 51;
			dgv_NguyenLieu.RowTemplate.Height = 29;
			dgv_NguyenLieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv_NguyenLieu.Size = new Size(739, 290);
			dgv_NguyenLieu.TabIndex = 36;
			dgv_NguyenLieu.CellClick += dgv_NguyenLieu_CellClick;
			// 
			// txt_SoLuong
			// 
			txt_SoLuong.Location = new Point(234, 251);
			txt_SoLuong.Margin = new Padding(3, 2, 3, 2);
			txt_SoLuong.Name = "txt_SoLuong";
			txt_SoLuong.Size = new Size(434, 24);
			txt_SoLuong.TabIndex = 35;
			// 
			// btn_ThemNL
			// 
			btn_ThemNL.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btn_ThemNL.Location = new Point(147, 636);
			btn_ThemNL.Margin = new Padding(3, 2, 3, 2);
			btn_ThemNL.Name = "btn_ThemNL";
			btn_ThemNL.Size = new Size(178, 50);
			btn_ThemNL.TabIndex = 39;
			btn_ThemNL.Text = "Thêm Nguyên Liệu";
			btn_ThemNL.UseVisualStyleBackColor = true;
			btn_ThemNL.Click += btn_ThemNguyenLieu_Click;
			// 
			// lbl_SoLuong
			// 
			lbl_SoLuong.AutoSize = true;
			lbl_SoLuong.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lbl_SoLuong.Location = new Point(71, 250);
			lbl_SoLuong.Name = "lbl_SoLuong";
			lbl_SoLuong.Size = new Size(77, 19);
			lbl_SoLuong.TabIndex = 34;
			lbl_SoLuong.Text = "Số Lượng";
			// 
			// txt_Gia
			// 
			txt_Gia.Location = new Point(234, 125);
			txt_Gia.Margin = new Padding(3, 2, 3, 2);
			txt_Gia.Name = "txt_Gia";
			txt_Gia.Size = new Size(434, 24);
			txt_Gia.TabIndex = 33;
			// 
			// lbl_Gia
			// 
			lbl_Gia.AutoSize = true;
			lbl_Gia.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lbl_Gia.Location = new Point(71, 125);
			lbl_Gia.Name = "lbl_Gia";
			lbl_Gia.Size = new Size(32, 19);
			lbl_Gia.TabIndex = 32;
			lbl_Gia.Text = "Giá";
			// 
			// txt_TenNguyenLieu
			// 
			txt_TenNguyenLieu.Location = new Point(234, 83);
			txt_TenNguyenLieu.Margin = new Padding(3, 2, 3, 2);
			txt_TenNguyenLieu.Name = "txt_TenNguyenLieu";
			txt_TenNguyenLieu.Size = new Size(434, 24);
			txt_TenNguyenLieu.TabIndex = 29;
			// 
			// txt_IdNguyenLieu
			// 
			txt_IdNguyenLieu.Enabled = false;
			txt_IdNguyenLieu.Location = new Point(234, 41);
			txt_IdNguyenLieu.Margin = new Padding(3, 2, 3, 2);
			txt_IdNguyenLieu.Name = "txt_IdNguyenLieu";
			txt_IdNguyenLieu.Size = new Size(434, 24);
			txt_IdNguyenLieu.TabIndex = 29;
			// 
			// lbl_TenNguyenLieu
			// 
			lbl_TenNguyenLieu.AutoSize = true;
			lbl_TenNguyenLieu.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lbl_TenNguyenLieu.Location = new Point(71, 86);
			lbl_TenNguyenLieu.Name = "lbl_TenNguyenLieu";
			lbl_TenNguyenLieu.Size = new Size(129, 19);
			lbl_TenNguyenLieu.TabIndex = 28;
			lbl_TenNguyenLieu.Text = "Tên Nguyên Liệu";
			// 
			// lbl_IdNguyenLieu
			// 
			lbl_IdNguyenLieu.AutoSize = true;
			lbl_IdNguyenLieu.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lbl_IdNguyenLieu.Location = new Point(71, 44);
			lbl_IdNguyenLieu.Name = "lbl_IdNguyenLieu";
			lbl_IdNguyenLieu.Size = new Size(119, 19);
			lbl_IdNguyenLieu.TabIndex = 28;
			lbl_IdNguyenLieu.Text = "ID Nguyên Liệu";
			// 
			// f_CongThuc
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1504, 716);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Margin = new Padding(3, 2, 3, 2);
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
		private ComboBox cbx_SanPham;
		private DataGridView dgv_PhaChe;
		private Button btn_XoaNL;
		private Button btn_ThemPC;
		private Button btn_SuaNL;
		private Button btn_ThemNL;
		private TextBox txt_TimKiemNL;
		private Label lbl_TimKiemPC;
		private DataGridView dgv_NguyenLieu;
		private TextBox txt_SoLuong;
		private Label lbl_SoLuong;
		private TextBox txt_Gia;
		private Label lbl_Gia;
		private TextBox txt_IdNguyenLieu;
		private Label lbl_IdNguyenLieu;
		private ComboBox cbx_NguyenLieu;
		private TextBox txt_TenNguyenLieu;
		private Label lbl_TenNguyenLieu;
		private Button btn_Reset;
		private Button btn_XoaPC;
	}
}