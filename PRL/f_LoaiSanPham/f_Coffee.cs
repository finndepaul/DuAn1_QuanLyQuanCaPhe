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
    public partial class f_Coffee : Form
    {
        ThucDonServce _TDser = new ThucDonServce();
        public f_Coffee()
        {
            InitializeComponent();
        }

        private void f_Coffee_Load(object sender, EventArgs e)
        {
            foreach (var item in _TDser.GetSanPhams(null, null, 3))
            {
                if (item.SanPham.IdloaiSanPham.Equals("CO1") && item.SanPham.TrangThai == 1)
                {
                    string duongDanHinhAnh = Path.Combine("duongdanthumuc", item.SanPham.HinhAnh);
                    pb_CO1.Image = Image.FromFile(duongDanHinhAnh);
                }
            }
        }

        private void pb_CO1_Click(object sender, EventArgs e)
        {
            foreach (var item in _TDser.GetSanPhams(null, null, 3))
            {
                if (item.SanPham.IdloaiSanPham.Equals("CO1") && item.SanPham.TrangThai == 1)
                {
                    string duongDanHinhAnh = Path.Combine("duongdanthumuc", item.SanPham.HinhAnh);
                    pb_CO1.Image = Image.FromFile(duongDanHinhAnh);
                    string tenFileAnh = Path.GetFileNameWithoutExtension(duongDanHinhAnh);
                    MessageBox.Show(tenFileAnh);
                }    
            }
        }
    }
}
