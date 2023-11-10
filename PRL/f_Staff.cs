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
        public f_Staff()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var mess = MessageBox.Show("B xac nhan dang xuat", "Xac nhan", MessageBoxButtons.OK);
            if (mess == DialogResult.OK)
            {
                this.Close();
            }
            
        }
    }
}
