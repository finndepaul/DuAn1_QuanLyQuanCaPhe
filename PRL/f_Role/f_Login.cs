using BUS.Services;
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
    public partial class f_Login : Form
    {
        ThucDonServce _ser = new();
        f_Admin f_Admin = new f_Admin();
        f_Staff f_Staff = new f_Staff();
        public f_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string loginName = txt_loginName.Text;
            string pass = txt_Password.Text;
            if (string.IsNullOrEmpty(txt_loginName.Text))
            {
                MessageBox.Show("Username không được để trống");
                return;
            }
            if (string.IsNullOrEmpty(txt_Password.Text))
            {
                MessageBox.Show("Password không được để trống");
                return;
            }
            var user = _ser.GetNhanViens().FirstOrDefault(x => x.LoginName == loginName && x.Password == pass);
            if (user != null)
            {
                if (user.Role)
                {
                    this.Hide();
                    f_Admin.ShowDialog();
                }
                else if (!user.Role)
                {
                    this.Hide();
                    f_Staff.ShowDialog();
                }

            }
            else
            {
                MessageBox.Show("Sai thông tin !!!");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e) // để enter
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Gọi hàm xử lý khi Enter được ấn
                btn_Login.PerformClick();
            }
        }

        private void txt_loginName_KeyDown(object sender, KeyEventArgs e) // để tab nma phải set tab index
        {
            if (e.KeyCode == Keys.Tab)
            {
                // Di chuyển tới TextBox kế tiếp
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}
