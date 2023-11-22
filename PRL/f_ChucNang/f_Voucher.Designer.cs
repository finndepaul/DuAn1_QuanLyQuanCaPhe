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
            cbx_DieuKienApDung = new ComboBox();
            label6 = new Label();
            txt_SoLuong = new TextBox();
            label5 = new Label();
            dtpNgayBatDau = new DateTimePicker();
            dtpNgayKetThuc = new DateTimePicker();
            label3 = new Label();
            txt_IdVocher = new TextBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            txt_MaVocher = new TextBox();
            cbx_PhanTramVocher = new ComboBox();
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
            // cbx_DieuKienApDung
            // 
            cbx_DieuKienApDung.FormattingEnabled = true;
            cbx_DieuKienApDung.Location = new Point(278, 469);
            cbx_DieuKienApDung.Name = "cbx_DieuKienApDung";
            cbx_DieuKienApDung.Size = new Size(383, 28);
            cbx_DieuKienApDung.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(44, 468);
            label6.Name = "label6";
            label6.Size = new Size(179, 24);
            label6.TabIndex = 5;
            label6.Text = "Điều kiện áp dụng:";
            // 
            // txt_SoLuong
            // 
            txt_SoLuong.Location = new Point(278, 265);
            txt_SoLuong.Name = "txt_SoLuong";
            txt_SoLuong.Size = new Size(383, 27);
            txt_SoLuong.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(49, 404);
            label5.Name = "label5";
            label5.Size = new Size(140, 24);
            label5.TabIndex = 4;
            label5.Text = "Ngày kết thúc:";
            // 
            // dtpNgayBatDau
            // 
            dtpNgayBatDau.CustomFormat = "dd/MM/yyyy";
            dtpNgayBatDau.Location = new Point(280, 333);
            dtpNgayBatDau.Name = "dtpNgayBatDau";
            dtpNgayBatDau.Size = new Size(253, 27);
            dtpNgayBatDau.TabIndex = 10;
            // 
            // dtpNgayKetThuc
            // 
            dtpNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            dtpNgayKetThuc.Location = new Point(280, 401);
            dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            dtpNgayKetThuc.Size = new Size(253, 27);
            dtpNgayKetThuc.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(49, 59);
            label3.Name = "label3";
            label3.Size = new Size(105, 24);
            label3.TabIndex = 17;
            label3.Text = "ID Vocher:";
            // 
            // txt_IdVocher
            // 
            txt_IdVocher.Location = new Point(278, 60);
            txt_IdVocher.Name = "txt_IdVocher";
            txt_IdVocher.Size = new Size(383, 27);
            txt_IdVocher.TabIndex = 18;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_IdVocher);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbx_DieuKienApDung);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txt_MaVocher);
            groupBox1.Controls.Add(txt_SoLuong);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cbx_PhanTramVocher);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dtpNgayBatDau);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtpNgayKetThuc);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(723, 931);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(49, 128);
            label1.Name = "label1";
            label1.Size = new Size(108, 24);
            label1.TabIndex = 0;
            label1.Text = "Mã vocher:";
            // 
            // txt_MaVocher
            // 
            txt_MaVocher.Location = new Point(278, 128);
            txt_MaVocher.Name = "txt_MaVocher";
            txt_MaVocher.Size = new Size(383, 27);
            txt_MaVocher.TabIndex = 6;
            // 
            // cbx_PhanTramVocher
            // 
            cbx_PhanTramVocher.FormattingEnabled = true;
            cbx_PhanTramVocher.Items.AddRange(new object[] { "5%", "10%", "15%", "20%", "25%" });
            cbx_PhanTramVocher.Location = new Point(278, 196);
            cbx_PhanTramVocher.Name = "cbx_PhanTramVocher";
            cbx_PhanTramVocher.Size = new Size(383, 28);
            cbx_PhanTramVocher.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(44, 197);
            label2.Name = "label2";
            label2.Size = new Size(174, 24);
            label2.TabIndex = 1;
            label2.Text = "Phần trăm vocher:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(49, 266);
            label7.Name = "label7";
            label7.Size = new Size(95, 24);
            label7.TabIndex = 13;
            label7.Text = "Số lượng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(49, 335);
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 131);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(960, 794);
            dataGridView1.TabIndex = 9;
            // 
            // cbx_TrangThai
            // 
            cbx_TrangThai.FormattingEnabled = true;
            cbx_TrangThai.Location = new Point(327, 75);
            cbx_TrangThai.Name = "cbx_TrangThai";
            cbx_TrangThai.Size = new Size(263, 28);
            cbx_TrangThai.TabIndex = 6;
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
            txt_TimKiemVocher.Size = new Size(206, 27);
            txt_TimKiemVocher.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txt_TimKiemVocher);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(cbx_TrangThai);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(741, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(966, 931);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbx_DieuKienApDung;
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
        private ComboBox cbx_PhanTramVocher;
        private Label label2;
        private Label label7;
        private Label label4;
        private Label label10;
        private DataGridView dataGridView1;
        private ComboBox cbx_TrangThai;
        private Label label8;
        private TextBox txt_TimKiemVocher;
        private GroupBox groupBox2;
    }
}