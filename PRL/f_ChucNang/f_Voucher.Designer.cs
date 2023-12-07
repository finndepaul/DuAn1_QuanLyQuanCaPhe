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
            btn_Clear = new Button();
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
            dataGridView1 = new DataGridView();
            cbx_TrangThai = new ComboBox();
            label8 = new Label();
            txt_TimKiemVocher = new TextBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(38, 350);
            label6.Name = "label6";
            label6.Size = new Size(144, 19);
            label6.TabIndex = 5;
            label6.Text = "Điều kiện áp dụng:";
            // 
            // txt_SoLuong
            // 
            txt_SoLuong.Location = new Point(254, 197);
            txt_SoLuong.Margin = new Padding(3, 2, 3, 2);
            txt_SoLuong.Name = "txt_SoLuong";
            txt_SoLuong.Size = new Size(336, 22);
            txt_SoLuong.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(43, 299);
            label5.Name = "label5";
            label5.Size = new Size(112, 19);
            label5.TabIndex = 4;
            label5.Text = "Ngày kết thúc:";
            // 
            // dtpNgayBatDau
            // 
            dtpNgayBatDau.CustomFormat = "dd/MM/yyyy";
            dtpNgayBatDau.Location = new Point(253, 246);
            dtpNgayBatDau.Margin = new Padding(3, 2, 3, 2);
            dtpNgayBatDau.Name = "dtpNgayBatDau";
            dtpNgayBatDau.Size = new Size(222, 22);
            dtpNgayBatDau.TabIndex = 10;
            // 
            // dtpNgayKetThuc
            // 
            dtpNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            dtpNgayKetThuc.Location = new Point(253, 296);
            dtpNgayKetThuc.Margin = new Padding(3, 2, 3, 2);
            dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            dtpNgayKetThuc.Size = new Size(222, 22);
            dtpNgayKetThuc.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(43, 44);
            label3.Name = "label3";
            label3.Size = new Size(86, 19);
            label3.TabIndex = 17;
            label3.Text = "ID Vocher:";
            // 
            // txt_IdVocher
            // 
            txt_IdVocher.Location = new Point(251, 45);
            txt_IdVocher.Margin = new Padding(3, 2, 3, 2);
            txt_IdVocher.Name = "txt_IdVocher";
            txt_IdVocher.ReadOnly = true;
            txt_IdVocher.Size = new Size(336, 22);
            txt_IdVocher.TabIndex = 18;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(cmb_TrangThai);
            groupBox1.Controls.Add(btn_Clear);
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
            groupBox1.Location = new Point(10, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(633, 698);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Voucher";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(43, 401);
            label9.Name = "label9";
            label9.Size = new Size(82, 19);
            label9.TabIndex = 20;
            label9.Text = "Trạng thái";
            // 
            // cmb_TrangThai
            // 
            cmb_TrangThai.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_TrangThai.FormattingEnabled = true;
            cmb_TrangThai.Location = new Point(251, 400);
            cmb_TrangThai.Margin = new Padding(3, 2, 3, 2);
            cmb_TrangThai.Name = "cmb_TrangThai";
            cmb_TrangThai.Size = new Size(231, 22);
            cmb_TrangThai.TabIndex = 21;
            // 
            // btn_Clear
            // 
            btn_Clear.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Clear.Location = new Point(452, 476);
            btn_Clear.Margin = new Padding(3, 2, 3, 2);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(125, 39);
            btn_Clear.TabIndex = 19;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            btn_Update.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Update.Location = new Point(254, 476);
            btn_Update.Margin = new Padding(3, 2, 3, 2);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(125, 39);
            btn_Update.TabIndex = 19;
            btn_Update.Text = "Sửa";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Add
            // 
            btn_Add.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Add.Location = new Point(56, 476);
            btn_Add.Margin = new Padding(3, 2, 3, 2);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(125, 39);
            btn_Add.TabIndex = 19;
            btn_Add.Text = "Thêm";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(43, 95);
            label1.Name = "label1";
            label1.Size = new Size(51, 19);
            label1.TabIndex = 0;
            label1.Text = "Code:";
            // 
            // txt_GiamTien
            // 
            txt_GiamTien.Location = new Point(251, 146);
            txt_GiamTien.Margin = new Padding(3, 2, 3, 2);
            txt_GiamTien.Name = "txt_GiamTien";
            txt_GiamTien.Size = new Size(336, 22);
            txt_GiamTien.TabIndex = 6;
            // 
            // txt_MaVocher
            // 
            txt_MaVocher.Location = new Point(251, 95);
            txt_MaVocher.Margin = new Padding(3, 2, 3, 2);
            txt_MaVocher.Name = "txt_MaVocher";
            txt_MaVocher.Size = new Size(336, 22);
            txt_MaVocher.TabIndex = 6;
            // 
            // txt_DKApDung
            // 
            txt_DKApDung.Location = new Point(251, 346);
            txt_DKApDung.Margin = new Padding(3, 2, 3, 2);
            txt_DKApDung.Name = "txt_DKApDung";
            txt_DKApDung.Size = new Size(336, 22);
            txt_DKApDung.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(38, 146);
            label2.Name = "label2";
            label2.Size = new Size(140, 19);
            label2.TabIndex = 1;
            label2.Text = "Phần trăm vocher:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(43, 197);
            label7.Name = "label7";
            label7.Size = new Size(79, 19);
            label7.TabIndex = 13;
            label7.Text = "Số lượng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(43, 248);
            label4.Name = "label4";
            label4.Size = new Size(109, 19);
            label4.TabIndex = 3;
            label4.Text = "Ngày bắt đầu:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(286, 29);
            label10.Name = "label10";
            label10.Size = new Size(82, 19);
            label10.TabIndex = 2;
            label10.Text = "Trạng thái";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 98);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(840, 596);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // cbx_TrangThai
            // 
            cbx_TrangThai.FormattingEnabled = true;
            cbx_TrangThai.Location = new Point(286, 56);
            cbx_TrangThai.Margin = new Padding(3, 2, 3, 2);
            cbx_TrangThai.Name = "cbx_TrangThai";
            cbx_TrangThai.Size = new Size(231, 22);
            cbx_TrangThai.TabIndex = 6;
            cbx_TrangThai.SelectedIndexChanged += cbx_TrangThai_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(5, 29);
            label8.Name = "label8";
            label8.Size = new Size(89, 19);
            label8.TabIndex = 0;
            label8.Text = "Tìm vocher";
            // 
            // txt_TimKiemVocher
            // 
            txt_TimKiemVocher.Location = new Point(5, 57);
            txt_TimKiemVocher.Margin = new Padding(3, 2, 3, 2);
            txt_TimKiemVocher.Name = "txt_TimKiemVocher";
            txt_TimKiemVocher.Size = new Size(181, 22);
            txt_TimKiemVocher.TabIndex = 5;
            txt_TimKiemVocher.TextChanged += txt_TimKiemVocher_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txt_TimKiemVocher);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(cbx_TrangThai);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(648, 9);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(845, 698);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tác Vụ";
            // 
            // f_Voucher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1504, 716);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "f_Voucher";
            Text = "Voucher";
            WindowState = FormWindowState.Maximized;
            Load += f_Voucher_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private ComboBox cbx_TrangThai;
        private Label label8;
        private TextBox txt_TimKiemVocher;
        private GroupBox groupBox2;
        private Button btn_Add;
        private TextBox txt_GiamTien;
        private TextBox txt_DKApDung;
        private Label label9;
        private ComboBox cmb_TrangThai;
        private Button btn_Clear;
        private Button btn_Update;
    }
}