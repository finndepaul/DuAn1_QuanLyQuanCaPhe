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
            btn_HienThiAll = new Button();
            cbx_NguyenLieu = new ComboBox();
            cbx_SanPham = new ComboBox();
            dgv_PhaChe = new DataGridView();
            btn_XoaPC = new Button();
            btn_XoaNL = new Button();
            btn_ThemPC = new Button();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            txt_TimKiemNL = new TextBox();
            lbl_TimKiemPC = new Label();
            btn_SuaNL = new Button();
            dgv_NguyenLieu = new DataGridView();
            txt_SoLuong = new TextBox();
            btn_ThemNL = new Button();
            lbl_IdNguyenLieus = new Label();
            txt_Gia = new TextBox();
            lbl_IdSanPham = new Label();
            txt_TenNguyenLieu = new TextBox();
            txt_IdNguyenLieu = new TextBox();
            label1 = new Label();
            lbl_IdPhaChe = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_PhaChe).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_NguyenLieu).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_HienThiAll);
            groupBox1.Controls.Add(cbx_NguyenLieu);
            groupBox1.Controls.Add(cbx_SanPham);
            groupBox1.Controls.Add(dgv_PhaChe);
            groupBox1.Controls.Add(btn_XoaPC);
            groupBox1.Controls.Add(btn_XoaNL);
            groupBox1.Controls.Add(btn_ThemPC);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(844, 931);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản Lý Pha Chế";
            // 
            // btn_HienThiAll
            // 
            btn_HienThiAll.Location = new Point(744, 119);
            btn_HienThiAll.Name = "btn_HienThiAll";
            btn_HienThiAll.Size = new Size(94, 29);
            btn_HienThiAll.TabIndex = 42;
            btn_HienThiAll.Text = "Show All";
            btn_HienThiAll.UseVisualStyleBackColor = true;
            btn_HienThiAll.Click += btn_HienThiAll_Click;
            // 
            // cbx_NguyenLieu
            // 
            cbx_NguyenLieu.FormattingEnabled = true;
            cbx_NguyenLieu.Location = new Point(217, 177);
            cbx_NguyenLieu.Name = "cbx_NguyenLieu";
            cbx_NguyenLieu.Size = new Size(410, 29);
            cbx_NguyenLieu.TabIndex = 41;
            // 
            // cbx_SanPham
            // 
            cbx_SanPham.FormattingEnabled = true;
            cbx_SanPham.Location = new Point(217, 59);
            cbx_SanPham.Name = "cbx_SanPham";
            cbx_SanPham.Size = new Size(410, 29);
            cbx_SanPham.TabIndex = 41;
            // 
            // dgv_PhaChe
            // 
            dgv_PhaChe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_PhaChe.Location = new Point(0, 252);
            dgv_PhaChe.Name = "dgv_PhaChe";
            dgv_PhaChe.RowHeadersWidth = 51;
            dgv_PhaChe.RowTemplate.Height = 29;
            dgv_PhaChe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_PhaChe.Size = new Size(844, 439);
            dgv_PhaChe.TabIndex = 38;
            dgv_PhaChe.CellClick += dgv_PhaChe_CellClick;
            // 
            // btn_XoaPC
            // 
            btn_XoaPC.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_XoaPC.Location = new Point(615, 765);
            btn_XoaPC.Name = "btn_XoaPC";
            btn_XoaPC.Size = new Size(173, 66);
            btn_XoaPC.TabIndex = 37;
            btn_XoaPC.Text = "Xóa Pha Chế";
            btn_XoaPC.UseVisualStyleBackColor = true;
            btn_XoaPC.Click += btn_XoaPC_Click;
            // 
            // btn_XoaNL
            // 
            btn_XoaNL.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_XoaNL.Location = new Point(336, 765);
            btn_XoaNL.Name = "btn_XoaNL";
            btn_XoaNL.Size = new Size(173, 66);
            btn_XoaNL.TabIndex = 36;
            btn_XoaNL.Text = "Xóa Nguyên Liệu";
            btn_XoaNL.UseVisualStyleBackColor = true;
            btn_XoaNL.Click += btn_XoaNL_Click;
            // 
            // btn_ThemPC
            // 
            btn_ThemPC.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ThemPC.Location = new Point(57, 765);
            btn_ThemPC.Name = "btn_ThemPC";
            btn_ThemPC.Size = new Size(173, 66);
            btn_ThemPC.TabIndex = 35;
            btn_ThemPC.Text = "Thêm Pha Chế";
            btn_ThemPC.UseVisualStyleBackColor = true;
            btn_ThemPC.Click += btn_ThemPC_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(217, 139);
            label3.Name = "label3";
            label3.Size = new Size(178, 24);
            label3.TabIndex = 28;
            label3.Text = "Chọn Nguyên Liệu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(217, 24);
            label2.Name = "label2";
            label2.Size = new Size(157, 24);
            label2.TabIndex = 28;
            label2.Text = "Chọn Sản Phẩm:";
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
            groupBox2.Controls.Add(lbl_IdNguyenLieus);
            groupBox2.Controls.Add(txt_Gia);
            groupBox2.Controls.Add(lbl_IdSanPham);
            groupBox2.Controls.Add(txt_TenNguyenLieu);
            groupBox2.Controls.Add(txt_IdNguyenLieu);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(lbl_IdPhaChe);
            groupBox2.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(862, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(845, 931);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Quản Lý Nguyên Liệu";
            // 
            // txt_TimKiemNL
            // 
            txt_TimKiemNL.Location = new Point(515, 397);
            txt_TimKiemNL.Name = "txt_TimKiemNL";
            txt_TimKiemNL.PlaceholderText = "Nhập Tên nguyên Liệu";
            txt_TimKiemNL.Size = new Size(330, 28);
            txt_TimKiemNL.TabIndex = 38;
            txt_TimKiemNL.TextChanged += txt_TimKiemNL_TextChanged;
            // 
            // lbl_TimKiemPC
            // 
            lbl_TimKiemPC.AutoSize = true;
            lbl_TimKiemPC.Location = new Point(429, 400);
            lbl_TimKiemPC.Name = "lbl_TimKiemPC";
            lbl_TimKiemPC.Size = new Size(80, 21);
            lbl_TimKiemPC.TabIndex = 37;
            lbl_TimKiemPC.Text = "Tìm Kiếm";
            // 
            // btn_SuaNL
            // 
            btn_SuaNL.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_SuaNL.Location = new Point(492, 848);
            btn_SuaNL.Name = "btn_SuaNL";
            btn_SuaNL.Size = new Size(140, 66);
            btn_SuaNL.TabIndex = 40;
            btn_SuaNL.Text = "Sửa";
            btn_SuaNL.UseVisualStyleBackColor = true;
            btn_SuaNL.Click += btn_SuaNL_Click;
            // 
            // dgv_NguyenLieu
            // 
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
            // txt_SoLuong
            // 
            txt_SoLuong.Location = new Point(264, 299);
            txt_SoLuong.Name = "txt_SoLuong";
            txt_SoLuong.Size = new Size(496, 28);
            txt_SoLuong.TabIndex = 35;
            // 
            // btn_ThemNL
            // 
            btn_ThemNL.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ThemNL.Location = new Point(213, 848);
            btn_ThemNL.Name = "btn_ThemNL";
            btn_ThemNL.Size = new Size(140, 66);
            btn_ThemNL.TabIndex = 39;
            btn_ThemNL.Text = "Thêm";
            btn_ThemNL.UseVisualStyleBackColor = true;
            btn_ThemNL.Click += btn_ThemNL_Click;
            // 
            // lbl_IdNguyenLieus
            // 
            lbl_IdNguyenLieus.AutoSize = true;
            lbl_IdNguyenLieus.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_IdNguyenLieus.Location = new Point(81, 299);
            lbl_IdNguyenLieus.Name = "lbl_IdNguyenLieus";
            lbl_IdNguyenLieus.Size = new Size(93, 24);
            lbl_IdNguyenLieus.TabIndex = 34;
            lbl_IdNguyenLieus.Text = "Số Lượng";
            // 
            // txt_Gia
            // 
            txt_Gia.Location = new Point(264, 219);
            txt_Gia.Name = "txt_Gia";
            txt_Gia.Size = new Size(496, 28);
            txt_Gia.TabIndex = 33;
            // 
            // lbl_IdSanPham
            // 
            lbl_IdSanPham.AutoSize = true;
            lbl_IdSanPham.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_IdSanPham.Location = new Point(81, 219);
            lbl_IdSanPham.Name = "lbl_IdSanPham";
            lbl_IdSanPham.Size = new Size(39, 24);
            lbl_IdSanPham.TabIndex = 32;
            lbl_IdSanPham.Text = "Giá";
            // 
            // txt_TenNguyenLieu
            // 
            txt_TenNguyenLieu.Location = new Point(264, 139);
            txt_TenNguyenLieu.Name = "txt_TenNguyenLieu";
            txt_TenNguyenLieu.Size = new Size(496, 28);
            txt_TenNguyenLieu.TabIndex = 29;
            // 
            // txt_IdNguyenLieu
            // 
            txt_IdNguyenLieu.Location = new Point(264, 59);
            txt_IdNguyenLieu.Name = "txt_IdNguyenLieu";
            txt_IdNguyenLieu.ReadOnly = true;
            txt_IdNguyenLieu.Size = new Size(496, 28);
            txt_IdNguyenLieu.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(81, 139);
            label1.Name = "label1";
            label1.Size = new Size(160, 24);
            label1.TabIndex = 28;
            label1.Text = "Tên Nguyên Liệu";
            // 
            // lbl_IdPhaChe
            // 
            lbl_IdPhaChe.AutoSize = true;
            lbl_IdPhaChe.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_IdPhaChe.Location = new Point(81, 59);
            lbl_IdPhaChe.Name = "lbl_IdPhaChe";
            lbl_IdPhaChe.Size = new Size(147, 24);
            lbl_IdPhaChe.TabIndex = 28;
            lbl_IdPhaChe.Text = "ID Nguyên Liệu";
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
            groupBox1.PerformLayout();
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
        private Button btn_XoaPC;
        private Button btn_XoaNL;
        private Button btn_ThemPC;
        private Button btn_SuaNL;
        private Button btn_ThemNL;
        private TextBox txt_TimKiemNL;
        private Label lbl_TimKiemPC;
        private DataGridView dgv_NguyenLieu;
        private TextBox txt_SoLuong;
        private Label lbl_IdNguyenLieus;
        private TextBox txt_Gia;
        private Label lbl_IdSanPham;
        private TextBox txt_IdNguyenLieu;
        private Label lbl_IdPhaChe;
        private ComboBox cbx_NguyenLieu;
        private TextBox txt_TenNguyenLieu;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button btn_HienThiAll;
    }
}