﻿namespace PRL.f_ChucNang
{
    partial class f_KhachHang
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
            cbx_TimKiemTheoRank = new ComboBox();
            txt_TimKiemRank = new TextBox();
            btn_Sua = new Button();
            btn_Them = new Button();
            txt_IDRank = new TextBox();
            txt_Point = new TextBox();
            txt_IDNhanVien = new TextBox();
            dgv_Membership = new DataGridView();
            dgv_KhachHang = new DataGridView();
            txt_SoDienThoai = new TextBox();
            txt_Email = new TextBox();
            txt_TenKhachHang = new TextBox();
            label7 = new Label();
            label10 = new Label();
            txt_TimKiemIdKhachHang = new TextBox();
            txt_DiaChi = new TextBox();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label9 = new Label();
            groupBox1 = new GroupBox();
            btn_UpdateMemberShip = new Button();
            btn_ThemMemberShip = new Button();
            txt_PointsNeed = new TextBox();
            txt_RankName = new TextBox();
            txt_Discount = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label1 = new Label();
            ID_NhanVien = new Label();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Membership).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_KhachHang).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // cbx_TimKiemTheoRank
            // 
            cbx_TimKiemTheoRank.FormattingEnabled = true;
            cbx_TimKiemTheoRank.Location = new Point(396, 543);
            cbx_TimKiemTheoRank.Name = "cbx_TimKiemTheoRank";
            cbx_TimKiemTheoRank.Size = new Size(256, 28);
            cbx_TimKiemTheoRank.TabIndex = 8;
            cbx_TimKiemTheoRank.SelectedIndexChanged += cbx_TimKiemTheoRank_SelectedIndexChanged;
            // 
            // txt_TimKiemRank
            // 
            txt_TimKiemRank.Location = new Point(6, 543);
            txt_TimKiemRank.Name = "txt_TimKiemRank";
            txt_TimKiemRank.Size = new Size(292, 27);
            txt_TimKiemRank.TabIndex = 6;
            txt_TimKiemRank.TextChanged += txt_TimKiemRank_TextChanged;
            // 
            // btn_Sua
            // 
            btn_Sua.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Sua.Location = new Point(360, 457);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(140, 51);
            btn_Sua.TabIndex = 15;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click_1;
            // 
            // btn_Them
            // 
            btn_Them.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Them.Location = new Point(141, 457);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(140, 51);
            btn_Them.TabIndex = 14;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // txt_IDRank
            // 
            txt_IDRank.Location = new Point(235, 325);
            txt_IDRank.Name = "txt_IDRank";
            txt_IDRank.ReadOnly = true;
            txt_IDRank.Size = new Size(349, 27);
            txt_IDRank.TabIndex = 13;
            // 
            // txt_Point
            // 
            txt_Point.Location = new Point(235, 269);
            txt_Point.Name = "txt_Point";
            txt_Point.ReadOnly = true;
            txt_Point.Size = new Size(349, 27);
            txt_Point.TabIndex = 12;
            // 
            // txt_IDNhanVien
            // 
            txt_IDNhanVien.Location = new Point(235, 387);
            txt_IDNhanVien.Name = "txt_IDNhanVien";
            txt_IDNhanVien.ReadOnly = true;
            txt_IDNhanVien.Size = new Size(349, 27);
            txt_IDNhanVien.TabIndex = 11;
            // 
            // dgv_Membership
            // 
            dgv_Membership.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Membership.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Membership.Location = new Point(6, 577);
            dgv_Membership.Name = "dgv_Membership";
            dgv_Membership.RowHeadersWidth = 51;
            dgv_Membership.RowTemplate.Height = 29;
            dgv_Membership.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Membership.Size = new Size(1037, 353);
            dgv_Membership.TabIndex = 5;
            dgv_Membership.CellClick += dgv_Membership_CellClick;
            // 
            // dgv_KhachHang
            // 
            dgv_KhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_KhachHang.Location = new Point(6, 113);
            dgv_KhachHang.Name = "dgv_KhachHang";
            dgv_KhachHang.RowHeadersWidth = 51;
            dgv_KhachHang.RowTemplate.Height = 29;
            dgv_KhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_KhachHang.Size = new Size(1037, 347);
            dgv_KhachHang.TabIndex = 4;
            dgv_KhachHang.CellClick += dgv_KhachHang_CellClick;
            // 
            // txt_SoDienThoai
            // 
            txt_SoDienThoai.Location = new Point(235, 95);
            txt_SoDienThoai.Name = "txt_SoDienThoai";
            txt_SoDienThoai.Size = new Size(349, 27);
            txt_SoDienThoai.TabIndex = 10;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(235, 152);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(349, 27);
            txt_Email.TabIndex = 9;
            // 
            // txt_TenKhachHang
            // 
            txt_TenKhachHang.Location = new Point(235, 34);
            txt_TenKhachHang.Name = "txt_TenKhachHang";
            txt_TenKhachHang.Size = new Size(349, 27);
            txt_TenKhachHang.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(39, 269);
            label7.Name = "label7";
            label7.Size = new Size(62, 24);
            label7.TabIndex = 6;
            label7.Text = "Point:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(396, 499);
            label10.Name = "label10";
            label10.Size = new Size(191, 24);
            label10.TabIndex = 7;
            label10.Text = "Tìm kiếm theo rank:";
            // 
            // txt_TimKiemIdKhachHang
            // 
            txt_TimKiemIdKhachHang.Location = new Point(283, 52);
            txt_TimKiemIdKhachHang.Name = "txt_TimKiemIdKhachHang";
            txt_TimKiemIdKhachHang.Size = new Size(292, 27);
            txt_TimKiemIdKhachHang.TabIndex = 3;
            txt_TimKiemIdKhachHang.TextChanged += txt_TimKiemIdKhachHang_TextChanged;
            // 
            // txt_DiaChi
            // 
            txt_DiaChi.Location = new Point(235, 211);
            txt_DiaChi.Name = "txt_DiaChi";
            txt_DiaChi.Size = new Size(349, 27);
            txt_DiaChi.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(6, 52);
            label8.Name = "label8";
            label8.Size = new Size(230, 24);
            label8.TabIndex = 0;
            label8.Text = "Tìm kiếm id khách hàng:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(39, 328);
            label6.Name = "label6";
            label6.Size = new Size(94, 24);
            label6.TabIndex = 5;
            label6.Text = "ID Rank :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(39, 210);
            label5.Name = "label5";
            label5.Size = new Size(71, 24);
            label5.TabIndex = 4;
            label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(39, 151);
            label4.Name = "label4";
            label4.Size = new Size(66, 24);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(39, 92);
            label3.Name = "label3";
            label3.Size = new Size(140, 24);
            label3.TabIndex = 2;
            label3.Text = "Số điện thoại: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(39, 33);
            label2.Name = "label2";
            label2.Size = new Size(165, 24);
            label2.TabIndex = 1;
            label2.Text = "Tên khách hàng: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(0, 499);
            label9.Name = "label9";
            label9.Size = new Size(260, 24);
            label9.TabIndex = 1;
            label9.Text = "Tìm kiếm MemberShipRank:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(btn_UpdateMemberShip);
            groupBox1.Controls.Add(btn_Sua);
            groupBox1.Controls.Add(btn_ThemMemberShip);
            groupBox1.Controls.Add(btn_Them);
            groupBox1.Controls.Add(txt_PointsNeed);
            groupBox1.Controls.Add(txt_IDRank);
            groupBox1.Controls.Add(txt_RankName);
            groupBox1.Controls.Add(txt_Point);
            groupBox1.Controls.Add(txt_Discount);
            groupBox1.Controls.Add(txt_IDNhanVien);
            groupBox1.Controls.Add(txt_SoDienThoai);
            groupBox1.Controls.Add(txt_Email);
            groupBox1.Controls.Add(txt_DiaChi);
            groupBox1.Controls.Add(txt_TenKhachHang);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ID_NhanVien);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(640, 931);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // btn_UpdateMemberShip
            // 
            btn_UpdateMemberShip.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_UpdateMemberShip.Location = new Point(360, 799);
            btn_UpdateMemberShip.Name = "btn_UpdateMemberShip";
            btn_UpdateMemberShip.Size = new Size(140, 51);
            btn_UpdateMemberShip.TabIndex = 15;
            btn_UpdateMemberShip.Text = "Sửa";
            btn_UpdateMemberShip.UseVisualStyleBackColor = true;
            btn_UpdateMemberShip.Click += btn_UpdateMemberShip_Click;
            // 
            // btn_ThemMemberShip
            // 
            btn_ThemMemberShip.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ThemMemberShip.Location = new Point(141, 799);
            btn_ThemMemberShip.Name = "btn_ThemMemberShip";
            btn_ThemMemberShip.Size = new Size(140, 51);
            btn_ThemMemberShip.TabIndex = 14;
            btn_ThemMemberShip.Text = "Thêm";
            btn_ThemMemberShip.UseVisualStyleBackColor = true;
            btn_ThemMemberShip.Click += btn_ThemMemberShip_Click;
            // 
            // txt_PointsNeed
            // 
            txt_PointsNeed.Location = new Point(235, 644);
            txt_PointsNeed.Name = "txt_PointsNeed";
            txt_PointsNeed.Size = new Size(349, 27);
            txt_PointsNeed.TabIndex = 13;
            // 
            // txt_RankName
            // 
            txt_RankName.Location = new Point(235, 577);
            txt_RankName.Name = "txt_RankName";
            txt_RankName.Size = new Size(349, 27);
            txt_RankName.TabIndex = 12;
            // 
            // txt_Discount
            // 
            txt_Discount.Location = new Point(235, 711);
            txt_Discount.Name = "txt_Discount";
            txt_Discount.Size = new Size(349, 27);
            txt_Discount.TabIndex = 11;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(39, 576);
            label12.Name = "label12";
            label12.Size = new Size(119, 24);
            label12.TabIndex = 6;
            label12.Text = "Rank Name:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(39, 643);
            label11.Name = "label11";
            label11.Size = new Size(114, 24);
            label11.TabIndex = 5;
            label11.Text = "Point Need:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(39, 710);
            label1.Name = "label1";
            label1.Size = new Size(94, 24);
            label1.TabIndex = 0;
            label1.Text = "Discount:";
            // 
            // ID_NhanVien
            // 
            ID_NhanVien.AutoSize = true;
            ID_NhanVien.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ID_NhanVien.Location = new Point(39, 387);
            ID_NhanVien.Name = "ID_NhanVien";
            ID_NhanVien.Size = new Size(128, 24);
            ID_NhanVien.TabIndex = 0;
            ID_NhanVien.Text = "ID Nhân Viên";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(cbx_TimKiemTheoRank);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txt_TimKiemRank);
            groupBox2.Controls.Add(dgv_Membership);
            groupBox2.Controls.Add(dgv_KhachHang);
            groupBox2.Controls.Add(txt_TimKiemIdKhachHang);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(658, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1049, 936);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // f_KhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1719, 955);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "f_KhachHang";
            Text = "Khách Hàng";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgv_Membership).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_KhachHang).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbx_TimKiemTheoRank;
        private TextBox txt_TimKiemRank;
        private Button btn_Sua;
        private Button btn_Them;
        private TextBox txt_IDRank;
        private TextBox txt_Point;
        private TextBox txt_IDNhanVien;
        private DataGridView dgv_Membership;
        private DataGridView dgv_KhachHang;
        private TextBox txt_SoDienThoai;
        private TextBox txt_Email;
        private TextBox txt_TenKhachHang;
        private Label label7;
        private Label label10;
        private TextBox txt_TimKiemIdKhachHang;
        private TextBox txt_DiaChi;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label9;
        private GroupBox groupBox1;
        private Label ID_NhanVien;
        private GroupBox groupBox2;
        private Button btn_UpdateMemberShip;
        private Button btn_ThemMemberShip;
        private TextBox txt_PointsNeed;
        private TextBox txt_RankName;
        private TextBox txt_Discount;
        private Label label12;
        private Label label11;
        private Label label1;
    }
}