using BUS.Services;

namespace PRL
{
    public partial class f_TrangChu : Form
    {
        ThucDonServce _ser = new ThucDonServce();
        public f_TrangChu()
        {
            InitializeComponent();
        }
        private void f_TrangChu_Load(object sender, EventArgs e)
        {
            LoadCBX_LoaiSP();
        }

        private void LoadCBX_LoaiSP()
        {
            foreach (var item in _ser.GetLoaiSanPhams())
            {
                cbx_LoaiSP.Items.Add(item.TenLoaiSanPham);
            }
            cbx_LoaiSP.SelectedIndex = 0;
        }

        private void cbx_LoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbx_LoaiSP.SelectedIndex;
            pn_SanPham.Controls.Clear();
            switch (selectedIndex)
            {
                case 0:
                    f_Coffee f_Coffee = new();
                    f_Coffee.TopLevel = false;
                    pn_SanPham.Controls.Add(f_Coffee);
                    f_Coffee.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    f_Coffee.Dock = DockStyle.Fill;
                    f_Coffee.Show();
                    break;
                case 1:
                    f_NuocEp f_NuocEp = new();
                    f_NuocEp.TopLevel = false;
                    pn_SanPham.Controls.Add(f_NuocEp);
                    f_NuocEp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    f_NuocEp.Dock = DockStyle.Fill;
                    f_NuocEp.Show();
                    break;
                case 2:
                    f_SinhTo f_SinhTo = new();
                    f_SinhTo.TopLevel = false;
                    pn_SanPham.Controls.Add(f_SinhTo);
                    f_SinhTo.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    f_SinhTo.Dock = DockStyle.Fill;
                    f_SinhTo.Show();
                    break;
                case 3:
                    f_SuaChua f_SuaChua = new();
                    f_SuaChua.TopLevel = false;
                    pn_SanPham.Controls.Add(f_SuaChua);
                    f_SuaChua.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    f_SuaChua.Dock = DockStyle.Fill;
                    f_SuaChua.Show();
                    break;
                default:
                    break;
            }
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {

        }

    }
}