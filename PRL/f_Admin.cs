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
        public f_Admin()
        {
            InitializeComponent();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            f_Home objForm = new f_Home();
            objForm.TopLevel = false;
            panel1.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void f_Main_Load(object sender, EventArgs e)
        {
            f_Home objForm = new f_Home();
            objForm.TopLevel = false;
            panel1.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            var mess = MessageBox.Show("B xac nhan dang xuat", "Xac nhan", MessageBoxButtons.OKCancel);
            if (mess == DialogResult.OK)
            {
                this.Close();
            }
            if (mess == DialogResult.Cancel)
            {
                return;
            }
        }
    }
}
