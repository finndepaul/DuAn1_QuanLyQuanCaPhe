namespace PRL.f_ChucNang
{
    partial class f_TaiKhoan
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
            cbx_ChucVu = new ComboBox();
            cbx_Loc = new ComboBox();
            dgv_TaiKhoan = new DataGridView();
            txt_TimKiem = new TextBox();
            lbl_TimKiem = new Label();
            cbx_TrangThai = new ComboBox();
            lbl_ChucVu = new Label();
            lbl_Password = new Label();
            label1 = new Label();
            lbl_status = new Label();
            btn_Sua = new Button();
            txt_Password = new TextBox();
            btn_Them = new Button();
            lbl_LoginName = new Label();
            txt_LoginName = new TextBox();
            txb_IdNhanVien = new TextBox();
            lbl_Id = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_TaiKhoan).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(cbx_ChucVu);
            groupBox1.Controls.Add(cbx_Loc);
            groupBox1.Controls.Add(dgv_TaiKhoan);
            groupBox1.Controls.Add(txt_TimKiem);
            groupBox1.Controls.Add(lbl_TimKiem);
            groupBox1.Controls.Add(cbx_TrangThai);
            groupBox1.Controls.Add(lbl_ChucVu);
            groupBox1.Controls.Add(lbl_Password);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lbl_status);
            groupBox1.Controls.Add(btn_Sua);
            groupBox1.Controls.Add(txt_Password);
            groupBox1.Controls.Add(btn_Them);
            groupBox1.Controls.Add(lbl_LoginName);
            groupBox1.Controls.Add(txt_LoginName);
            groupBox1.Controls.Add(txb_IdNhanVien);
            groupBox1.Controls.Add(lbl_Id);
            groupBox1.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1695, 931);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Tài Khoản";
            // 
            // cbx_ChucVu
            // 
            cbx_ChucVu.FormattingEnabled = true;
            cbx_ChucVu.Items.AddRange(new object[] { "Admin", "Nhân Viên" });
            cbx_ChucVu.Location = new Point(245, 370);
            cbx_ChucVu.Name = "cbx_ChucVu";
            cbx_ChucVu.Size = new Size(213, 30);
            cbx_ChucVu.TabIndex = 34;
            // 
            // cbx_Loc
            // 
            cbx_Loc.FormattingEnabled = true;
            cbx_Loc.Location = new Point(1507, 82);
            cbx_Loc.Name = "cbx_Loc";
            cbx_Loc.Size = new Size(182, 30);
            cbx_Loc.TabIndex = 31;
            cbx_Loc.SelectedIndexChanged += cbx_Loc_SelectedIndexChanged;
            // 
            // dgv_TaiKhoan
            // 
            dgv_TaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_TaiKhoan.Location = new Point(849, 144);
            dgv_TaiKhoan.Name = "dgv_TaiKhoan";
            dgv_TaiKhoan.RowHeadersWidth = 51;
            dgv_TaiKhoan.RowTemplate.Height = 29;
            dgv_TaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_TaiKhoan.Size = new Size(840, 781);
            dgv_TaiKhoan.TabIndex = 33;
            dgv_TaiKhoan.CellClick += dgv_TaiKhoan_CellClick;
            // 
            // txt_TimKiem
            // 
            txt_TimKiem.Location = new Point(956, 82);
            txt_TimKiem.Name = "txt_TimKiem";
            txt_TimKiem.PlaceholderText = "Nhập Id nhân viên cần tìm";
            txt_TimKiem.Size = new Size(347, 29);
            txt_TimKiem.TabIndex = 32;
            txt_TimKiem.TextChanged += txt_TimKiem_TextChanged;
            // 
            // lbl_TimKiem
            // 
            lbl_TimKiem.AutoSize = true;
            lbl_TimKiem.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_TimKiem.Location = new Point(849, 86);
            lbl_TimKiem.Name = "lbl_TimKiem";
            lbl_TimKiem.Size = new Size(95, 24);
            lbl_TimKiem.TabIndex = 30;
            lbl_TimKiem.Text = "Tìm Kiếm";
            // 
            // cbx_TrangThai
            // 
            cbx_TrangThai.FormattingEnabled = true;
            cbx_TrangThai.Items.AddRange(new object[] { "Kích Hoạt", "Chưa Kích Hoạt" });
            cbx_TrangThai.Location = new Point(245, 462);
            cbx_TrangThai.Name = "cbx_TrangThai";
            cbx_TrangThai.Size = new Size(539, 30);
            cbx_TrangThai.TabIndex = 29;
            // 
            // lbl_ChucVu
            // 
            lbl_ChucVu.AutoSize = true;
            lbl_ChucVu.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_ChucVu.Location = new Point(6, 368);
            lbl_ChucVu.Name = "lbl_ChucVu";
            lbl_ChucVu.Size = new Size(98, 28);
            lbl_ChucVu.TabIndex = 28;
            lbl_ChucVu.Text = "Chức Vụ";
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Password.Location = new Point(6, 274);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(107, 28);
            lbl_Password.TabIndex = 23;
            lbl_Password.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1385, 83);
            label1.Name = "label1";
            label1.Size = new Size(116, 28);
            label1.TabIndex = 21;
            label1.Text = "Trạng thái";
            // 
            // lbl_status
            // 
            lbl_status.AutoSize = true;
            lbl_status.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_status.Location = new Point(6, 462);
            lbl_status.Name = "lbl_status";
            lbl_status.Size = new Size(116, 28);
            lbl_status.TabIndex = 21;
            lbl_status.Text = "Trạng thái";
            // 
            // btn_Sua
            // 
            btn_Sua.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Sua.Location = new Point(492, 627);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(136, 63);
            btn_Sua.TabIndex = 26;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(245, 276);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(539, 29);
            txt_Password.TabIndex = 20;
            // 
            // btn_Them
            // 
            btn_Them.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Them.Location = new Point(245, 627);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(136, 63);
            btn_Them.TabIndex = 25;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // lbl_LoginName
            // 
            lbl_LoginName.AutoSize = true;
            lbl_LoginName.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_LoginName.Location = new Point(6, 180);
            lbl_LoginName.Name = "lbl_LoginName";
            lbl_LoginName.Size = new Size(124, 28);
            lbl_LoginName.TabIndex = 19;
            lbl_LoginName.Text = "LoginName";
            // 
            // txt_LoginName
            // 
            txt_LoginName.Location = new Point(245, 183);
            txt_LoginName.Name = "txt_LoginName";
            txt_LoginName.Size = new Size(539, 29);
            txt_LoginName.TabIndex = 18;
            // 
            // txb_IdNhanVien
            // 
            txb_IdNhanVien.Location = new Point(245, 90);
            txb_IdNhanVien.Name = "txb_IdNhanVien";
            txb_IdNhanVien.Size = new Size(539, 29);
            txb_IdNhanVien.TabIndex = 18;
            // 
            // lbl_Id
            // 
            lbl_Id.AutoSize = true;
            lbl_Id.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Id.Location = new Point(6, 86);
            lbl_Id.Name = "lbl_Id";
            lbl_Id.Size = new Size(148, 28);
            lbl_Id.TabIndex = 17;
            lbl_Id.Text = "ID Nhân Viên";
            // 
            // f_TaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1719, 955);
            Controls.Add(groupBox1);
            Name = "f_TaiKhoan";
            Text = "Tài Khoản";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_TaiKhoan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cbx_TrangThai;
        private Label lbl_ChucVu;
        private Label lbl_Password;
        private Label lbl_status;
        private Button btn_Sua;
        private TextBox txt_Password;
        private Button btn_Them;
        private Label lbl_LoginName;
        private TextBox txb_IdNhanVien;
        private Label lbl_Id;
        private TextBox txt_LoginName;
        private ComboBox cbx_Loc;
        private DataGridView dgv_TaiKhoan;
        private TextBox txt_TimKiem;
        private Label lbl_TimKiem;
        private ComboBox cbx_ChucVu;
        private Label label1;
    }
}