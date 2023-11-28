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
            comboBox1 = new ComboBox();
            cbx_LocNguyenLieu = new ComboBox();
            dgv_NguyenLieu = new DataGridView();
            btn_XoaNL = new Button();
            btn_SuaNL = new Button();
            btn_ThemNL = new Button();
            groupBox2 = new GroupBox();
            txt_TimKiemPC = new TextBox();
            lbl_TimKiemPC = new Label();
            btn_SuaPC = new Button();
            dgv_PhaChe = new DataGridView();
            txt_PC_IdNguyenLieu = new TextBox();
            btn_ThemPC = new Button();
            lbl_IdNguyenLieus = new Label();
            txt_PC_IdSanPham = new TextBox();
            lbl_IdSanPham = new Label();
            textBox1 = new TextBox();
            txt_IdPhaChe = new TextBox();
            label1 = new Label();
            lbl_IdPhaChe = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_NguyenLieu).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_PhaChe).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(cbx_LocNguyenLieu);
            groupBox1.Controls.Add(dgv_NguyenLieu);
            groupBox1.Controls.Add(btn_XoaNL);
            groupBox1.Controls.Add(btn_SuaNL);
            groupBox1.Controls.Add(btn_ThemNL);
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(217, 177);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(410, 29);
            comboBox1.TabIndex = 41;
            // 
            // cbx_LocNguyenLieu
            // 
            cbx_LocNguyenLieu.FormattingEnabled = true;
            cbx_LocNguyenLieu.Location = new Point(217, 59);
            cbx_LocNguyenLieu.Name = "cbx_LocNguyenLieu";
            cbx_LocNguyenLieu.Size = new Size(410, 29);
            cbx_LocNguyenLieu.TabIndex = 41;
            // 
            // dgv_NguyenLieu
            // 
            dgv_NguyenLieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_NguyenLieu.Location = new Point(0, 252);
            dgv_NguyenLieu.Name = "dgv_NguyenLieu";
            dgv_NguyenLieu.RowHeadersWidth = 51;
            dgv_NguyenLieu.RowTemplate.Height = 29;
            dgv_NguyenLieu.Size = new Size(844, 439);
            dgv_NguyenLieu.TabIndex = 38;
            // 
            // btn_XoaNL
            // 
            btn_XoaNL.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_XoaNL.Location = new Point(615, 765);
            btn_XoaNL.Name = "btn_XoaNL";
            btn_XoaNL.Size = new Size(173, 66);
            btn_XoaNL.TabIndex = 37;
            btn_XoaNL.Text = "Xóa Pha Chế";
            btn_XoaNL.UseVisualStyleBackColor = true;
            // 
            // btn_SuaNL
            // 
            btn_SuaNL.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_SuaNL.Location = new Point(336, 765);
            btn_SuaNL.Name = "btn_SuaNL";
            btn_SuaNL.Size = new Size(173, 66);
            btn_SuaNL.TabIndex = 36;
            btn_SuaNL.Text = "Xóa Nguyên Liệu";
            btn_SuaNL.UseVisualStyleBackColor = true;
            // 
            // btn_ThemNL
            // 
            btn_ThemNL.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ThemNL.Location = new Point(57, 765);
            btn_ThemNL.Name = "btn_ThemNL";
            btn_ThemNL.Size = new Size(173, 66);
            btn_ThemNL.TabIndex = 35;
            btn_ThemNL.Text = "Thêm Pha Chế";
            btn_ThemNL.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.Controls.Add(txt_TimKiemPC);
            groupBox2.Controls.Add(lbl_TimKiemPC);
            groupBox2.Controls.Add(btn_SuaPC);
            groupBox2.Controls.Add(dgv_PhaChe);
            groupBox2.Controls.Add(txt_PC_IdNguyenLieu);
            groupBox2.Controls.Add(btn_ThemPC);
            groupBox2.Controls.Add(lbl_IdNguyenLieus);
            groupBox2.Controls.Add(txt_PC_IdSanPham);
            groupBox2.Controls.Add(lbl_IdSanPham);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(txt_IdPhaChe);
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
            // txt_TimKiemPC
            // 
            txt_TimKiemPC.Location = new Point(515, 397);
            txt_TimKiemPC.Name = "txt_TimKiemPC";
            txt_TimKiemPC.PlaceholderText = "Nhập Tên nguyên Liệu";
            txt_TimKiemPC.Size = new Size(330, 28);
            txt_TimKiemPC.TabIndex = 38;
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
            // btn_SuaPC
            // 
            btn_SuaPC.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_SuaPC.Location = new Point(492, 848);
            btn_SuaPC.Name = "btn_SuaPC";
            btn_SuaPC.Size = new Size(140, 66);
            btn_SuaPC.TabIndex = 40;
            btn_SuaPC.Text = "Sửa";
            btn_SuaPC.UseVisualStyleBackColor = true;
            // 
            // dgv_PhaChe
            // 
            dgv_PhaChe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_PhaChe.Location = new Point(0, 436);
            dgv_PhaChe.Name = "dgv_PhaChe";
            dgv_PhaChe.RowHeadersWidth = 51;
            dgv_PhaChe.RowTemplate.Height = 29;
            dgv_PhaChe.Size = new Size(845, 386);
            dgv_PhaChe.TabIndex = 36;
            // 
            // txt_PC_IdNguyenLieu
            // 
            txt_PC_IdNguyenLieu.Location = new Point(264, 299);
            txt_PC_IdNguyenLieu.Name = "txt_PC_IdNguyenLieu";
            txt_PC_IdNguyenLieu.Size = new Size(496, 28);
            txt_PC_IdNguyenLieu.TabIndex = 35;
            // 
            // btn_ThemPC
            // 
            btn_ThemPC.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ThemPC.Location = new Point(213, 848);
            btn_ThemPC.Name = "btn_ThemPC";
            btn_ThemPC.Size = new Size(140, 66);
            btn_ThemPC.TabIndex = 39;
            btn_ThemPC.Text = "Thêm";
            btn_ThemPC.UseVisualStyleBackColor = true;
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
            // txt_PC_IdSanPham
            // 
            txt_PC_IdSanPham.Location = new Point(264, 219);
            txt_PC_IdSanPham.Name = "txt_PC_IdSanPham";
            txt_PC_IdSanPham.Size = new Size(496, 28);
            txt_PC_IdSanPham.TabIndex = 33;
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
            // textBox1
            // 
            textBox1.Location = new Point(264, 139);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(496, 28);
            textBox1.TabIndex = 29;
            // 
            // txt_IdPhaChe
            // 
            txt_IdPhaChe.Location = new Point(264, 59);
            txt_IdPhaChe.Name = "txt_IdPhaChe";
            txt_IdPhaChe.Size = new Size(496, 28);
            txt_IdPhaChe.TabIndex = 29;
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_NguyenLieu).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_PhaChe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox cbx_LocNguyenLieu;
        private DataGridView dgv_NguyenLieu;
        private Button btn_XoaNL;
        private Button btn_SuaNL;
        private Button btn_ThemNL;
        private Button btn_SuaPC;
        private Button btn_ThemPC;
        private TextBox txt_TimKiemPC;
        private Label lbl_TimKiemPC;
        private DataGridView dgv_PhaChe;
        private TextBox txt_PC_IdNguyenLieu;
        private Label lbl_IdNguyenLieus;
        private TextBox txt_PC_IdSanPham;
        private Label lbl_IdSanPham;
        private TextBox txt_IdPhaChe;
        private Label lbl_IdPhaChe;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label1;
        private Label label3;
        private Label label2;
    }
}