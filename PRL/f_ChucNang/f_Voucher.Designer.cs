namespace PRL.f_ChucNang
{
    partial class f_Voucher
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
            label6 = new Label();
            txt_SoLuong = new TextBox();
            label5 = new Label();
            dtpNgayBatDau = new DateTimePicker();
            dtpNgayKetThuc = new DateTimePicker();
            label3 = new Label();
            txt_IdVocher = new TextBox();
            groupBox1 = new GroupBox();
            label9 = new Label();
            cmb_TrangThai = new ComboBox();
            btn_Update = new Button();
            btn_Add = new Button();
            label1 = new Label();
            txt_GiamTien = new TextBox();
            txt_MaVocher = new TextBox();
            txt_DKApDung = new TextBox();
            label2 = new Label();
            label7 = new Label();
            label4 = new Label();
            label10 = new Label();
            dgv_Voucher = new DataGridView();
            cbx_TrangThaiFind = new ComboBox();
            label8 = new Label();
            txt_TimKiemVocher = new TextBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Voucher).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(49, 460);
            label6.Name = "label6";
            label6.Size = new Size(179, 24);
            label6.TabIndex = 5;
            label6.Text = "Điều kiện áp dụng:";
            // 
            // txt_SoLuong
            // 
            txt_SoLuong.Location = new Point(287, 261);
            txt_SoLuong.Name = "txt_SoLuong";
            txt_SoLuong.Size = new Size(383, 26);
            txt_SoLuong.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(49, 395);
            label5.Name = "label5";
            label5.Size = new Size(140, 24);
            label5.TabIndex = 4;
            label5.Text = "Ngày kết thúc:";
            // 
            // dtpNgayBatDau
            // 
            dtpNgayBatDau.CustomFormat = "dd/MM/yyyy";
            dtpNgayBatDau.Location = new Point(289, 328);
            dtpNgayBatDau.Name = "dtpNgayBatDau";
            dtpNgayBatDau.Size = new Size(253, 26);
            dtpNgayBatDau.TabIndex = 10;
            // 
            // dtpNgayKetThuc
            // 
            dtpNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            dtpNgayKetThuc.Location = new Point(289, 395);
            dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            dtpNgayKetThuc.Size = new Size(253, 26);
            dtpNgayKetThuc.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(49, 59);
            label3.Name = "label3";
            label3.Size = new Size(116, 24);
            label3.TabIndex = 17;
            label3.Text = "ID Voucher:";
            // 
            // txt_IdVocher
            // 
            txt_IdVocher.Location = new Point(287, 60);
            txt_IdVocher.Name = "txt_IdVocher";
            txt_IdVocher.ReadOnly = true;
            txt_IdVocher.Size = new Size(383, 26);
            txt_IdVocher.TabIndex = 18;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(cmb_TrangThai);
            groupBox1.Controls.Add(btn_Update);
            groupBox1.Controls.Add(btn_Add);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_IdVocher);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txt_GiamTien);
            groupBox1.Controls.Add(txt_MaVocher);
            groupBox1.Controls.Add(txt_DKApDung);
            groupBox1.Controls.Add(txt_SoLuong);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dtpNgayBatDau);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtpNgayKetThuc);
            groupBox1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(723, 931);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Voucher";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(49, 531);
            label9.Name = "label9";
            label9.Size = new Size(102, 24);
            label9.TabIndex = 20;
            label9.Text = "Trạng thái";
            // 
            // cmb_TrangThai
            // 
            cmb_TrangThai.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_TrangThai.FormattingEnabled = true;
            cmb_TrangThai.Location = new Point(287, 533);
            cmb_TrangThai.Name = "cmb_TrangThai";
            cmb_TrangThai.Size = new Size(263, 26);
            cmb_TrangThai.TabIndex = 21;
            // 
            // btn_Update
            // 
            btn_Update.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Update.Location = new Point(403, 666);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(143, 52);
            btn_Update.TabIndex = 19;
            btn_Update.Text = "Sửa";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Add
            // 
            btn_Add.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Add.Location = new Point(177, 666);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(143, 52);
            btn_Add.TabIndex = 19;
            btn_Add.Text = "Thêm";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(49, 125);
            label1.Name = "label1";
            label1.Size = new Size(62, 24);
            label1.TabIndex = 0;
            label1.Text = "Code:";
            // 
            // txt_GiamTien
            // 
            txt_GiamTien.Location = new Point(287, 194);
            txt_GiamTien.Name = "txt_GiamTien";
            txt_GiamTien.Size = new Size(383, 26);
            txt_GiamTien.TabIndex = 6;
            // 
            // txt_MaVocher
            // 
            txt_MaVocher.Location = new Point(287, 127);
            txt_MaVocher.Name = "txt_MaVocher";
            txt_MaVocher.Size = new Size(383, 26);
            txt_MaVocher.TabIndex = 6;
            // 
            // txt_DKApDung
            // 
            txt_DKApDung.Location = new Point(287, 462);
            txt_DKApDung.Name = "txt_DKApDung";
            txt_DKApDung.Size = new Size(383, 26);
            txt_DKApDung.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(49, 192);
            label2.Name = "label2";
            label2.Size = new Size(174, 24);
            label2.TabIndex = 1;
            label2.Text = "Phần trăm vocher:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(49, 259);
            label7.Name = "label7";
            label7.Size = new Size(95, 24);
            label7.TabIndex = 13;
            label7.Text = "Số lượng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(49, 328);
            label4.Name = "label4";
            label4.Size = new Size(136, 24);
            label4.TabIndex = 3;
            label4.Text = "Ngày bắt đầu:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(327, 39);
            label10.Name = "label10";
            label10.Size = new Size(102, 24);
            label10.TabIndex = 2;
            label10.Text = "Trạng thái";
            // 
            // dgv_Voucher
            // 
            dgv_Voucher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Voucher.Location = new Point(6, 131);
            dgv_Voucher.Name = "dgv_Voucher";
            dgv_Voucher.RowHeadersWidth = 51;
            dgv_Voucher.RowTemplate.Height = 29;
            dgv_Voucher.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Voucher.Size = new Size(960, 794);
            dgv_Voucher.TabIndex = 9;
            dgv_Voucher.CellClick += dgv_Voucher_CellClick;
            // 
            // cbx_TrangThaiFind
            // 
            cbx_TrangThaiFind.FormattingEnabled = true;
            cbx_TrangThaiFind.Location = new Point(327, 75);
            cbx_TrangThaiFind.Name = "cbx_TrangThaiFind";
            cbx_TrangThaiFind.Size = new Size(263, 26);
            cbx_TrangThaiFind.TabIndex = 6;
            cbx_TrangThaiFind.SelectedIndexChanged += cbx_TrangThaiFind_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(6, 39);
            label8.Name = "label8";
            label8.Size = new Size(109, 24);
            label8.TabIndex = 0;
            label8.Text = "Tìm vocher";
            // 
            // txt_TimKiemVocher
            // 
            txt_TimKiemVocher.Location = new Point(6, 76);
            txt_TimKiemVocher.Name = "txt_TimKiemVocher";
            txt_TimKiemVocher.Size = new Size(206, 26);
            txt_TimKiemVocher.TabIndex = 5;
            txt_TimKiemVocher.TextChanged += txt_TimKiemVocher_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txt_TimKiemVocher);
            groupBox2.Controls.Add(dgv_Voucher);
            groupBox2.Controls.Add(cbx_TrangThaiFind);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(741, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(966, 931);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tác Vụ";
            // 
            // f_Voucher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1719, 955);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "f_Voucher";
            Text = "Voucher";
            WindowState = FormWindowState.Maximized;
            Load += f_Voucher_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Voucher).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label6;
        private TextBox txt_SoLuong;
        private Label label5;
        private DateTimePicker dtpNgayBatDau;
        private DateTimePicker dtpNgayKetThuc;
        private Label label3;
        private TextBox txt_IdVocher;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txt_MaVocher;
        private Label label2;
        private Label label7;
        private Label label4;
        private Label label10;
        private DataGridView dgv_Voucher;
        private ComboBox cbx_TrangThaiFind;
        private Label label8;
        private TextBox txt_TimKiemVocher;
        private GroupBox groupBox2;
        private Button btn_Add;
        private TextBox txt_GiamTien;
        private TextBox txt_DKApDung;
        private Label label9;
        private ComboBox cmb_TrangThai;
        private Button btn_Update;
    }
}