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
    public partial class f_login : Form
    {
        CoffeeServce _ser = new();
        f_Main f_Main = new f_Main();
        public f_login()
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
                    this.Close();
                    f_Main.ShowDialog();
                }
                else if (!user.Role)
                {
                    this.Close();
                    f_Main.ShowDialog();
                }

            }
            else
            {
                MessageBox.Show("Sai thông tin !!!");
            }
        }
    }
}
