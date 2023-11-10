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
        CoffeeServce _ser = new();
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
    }
}
