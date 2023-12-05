using BUS.Services;
using PRL.f_ChucNang;
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
    public partial class f_Admin : Form
    {
        ThucDonService _ser = new ThucDonService();
        private Button lastClickedButton;
        string idNhanVien;
        public f_Admin(string idNhanVien)
        {
            InitializeComponent();
            this.idNhanVien = idNhanVien;
        }

        private void f_Main_Load(object sender, EventArgs e) // form Load
        {
            f_TrangChu objForm = new f_TrangChu();
            objForm.TopLevel = false;
            pn_Admin.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();



        }

        private void btn_Logout_Click(object sender, EventArgs e) // Đăng Xuất
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

        private void btn_TrangChu_Click(object sender, EventArgs e) // form Trang Chủ
        {


            f_TrangChu objForm = new f_TrangChu();
            objForm.TopLevel = false;
            pn_Admin.Controls.Add(objForm);
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

        private void btn_ThucDon_Click(object sender, EventArgs e) // form Thực Đơn
        {
            f_ThucDon f_ThucDon = new f_ThucDon();
            f_ThucDon.TopLevel = false;
            pn_Admin.Controls.Add(f_ThucDon);
            f_ThucDon.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f_ThucDon.Dock = DockStyle.Fill;
            f_ThucDon.Show();


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
        private void btn_Voucher_Click(object sender, EventArgs e) // form Voucher
        {
            f_Voucher objForm = new f_Voucher();
            objForm.TopLevel = false;
            pn_Admin.Controls.Add(objForm);
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

        private void btn_Sale_Click(object sender, EventArgs e)
        {
            f_Sale objForm = new f_Sale();
            objForm.TopLevel = false;
            pn_Admin.Controls.Add(objForm);
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

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            f_KhachHang objForm = new f_KhachHang(idNhanVien);
            objForm.TopLevel = false;
            pn_Admin.Controls.Add(objForm);
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

        private void btn_TaiKhoan_Click(object sender, EventArgs e)
        {
            f_TaiKhoan objForm = new f_TaiKhoan();
            objForm.TopLevel = false;
            pn_Admin.Controls.Add(objForm);
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

        private void btn_DoanhThu_Click(object sender, EventArgs e)
        {
            f_DanhThu objForm = new f_DanhThu();
            objForm.TopLevel = false;
            pn_Admin.Controls.Add(objForm);
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

        private void btn_CongThuc_Click(object sender, EventArgs e)
        {
            f_CongThuc objForm = new f_CongThuc();
            objForm.TopLevel = false;
            pn_Admin.Controls.Add(objForm);
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
