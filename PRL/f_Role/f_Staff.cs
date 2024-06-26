﻿using PRL.f_ChucNang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL
{
    public partial class f_Staff : Form
    {
        private Button lastClickedButton;
        string idNhanVien;
        public f_Staff(string idNhanVien)
        {
            InitializeComponent();
            this.idNhanVien = idNhanVien;
        }
        private void btn_Home_Click(object sender, EventArgs e) //
        {
            f_TrangChu objForm = new f_TrangChu(idNhanVien);
            objForm.TopLevel = false;
            pn_Staff.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();


            Button clickedButton = (Button)sender;
            // Thiết lập màu nền cho nút được nhấp
            clickedButton.BackColor = Color.Linen;

            // Thiết lập màu nền trở về mặc định cho nút trước đó (nếu có)
            if (lastClickedButton != null && lastClickedButton != clickedButton)
            {
                lastClickedButton.BackColor = Color.Tan;
            }

            // Lưu trữ nút được nhấp cuối cùng
            lastClickedButton = clickedButton;
        }

        private void f_Staff_Load(object sender, EventArgs e)
        {
            f_TrangChu objForm = new f_TrangChu(idNhanVien);
            objForm.TopLevel = false;
            pn_Staff.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            var mess = MessageBox.Show("Bạn xác nhận đăng xuất?", "Xác nhận", MessageBoxButtons.OKCancel);

            if (mess == DialogResult.OK)
            {
                // Ẩn form hiện tại
                this.Hide();

                // Tạo và hiển thị form đăng nhập mới
                f_Login f_Login = new f_Login();
                f_Login.ShowDialog();

                // Đóng form hiện tại khi form đăng nhập đóng
                this.Close();
            }
            else if (mess == DialogResult.Cancel)
            {
                // Do nothing or handle as needed
                return;
            }

        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            f_KhachHang objForm = new f_KhachHang(idNhanVien);
            objForm.TopLevel = false;
            pn_Staff.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();


            Button clickedButton = (Button)sender;
            // Thiết lập màu nền cho nút được nhấp
            clickedButton.BackColor = Color.Linen;

            // Thiết lập màu nền trở về mặc định cho nút trước đó (nếu có)
            if (lastClickedButton != null && lastClickedButton != clickedButton)
            {
                lastClickedButton.BackColor = Color.Tan;
            }

            // Lưu trữ nút được nhấp cuối cùng
            lastClickedButton = clickedButton;
        }
    }
}
