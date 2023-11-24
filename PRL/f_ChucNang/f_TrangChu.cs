using BUS.Services;
using DAL.Models;
using DAL.Repositories;
using Microsoft.IdentityModel.Tokens;
using System.Data;

namespace PRL
{
    public partial class f_TrangChu : Form
    {
        ThucDonServce _ser = new ThucDonServce();
        LoaiSanPhamRepos _LSPres = new LoaiSanPhamRepos();
        private int _btnHeight = 180;
        private int _btnWidth = 180;
        private int _labelHeight = 40;
        private int _labelWidth = 100;
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
            cbx_LoaiSP.Items.Clear();
            foreach (var item in _ser.GetLoaiSanPhams())
            {
                cbx_LoaiSP.Items.Add(item.TenLoaiSanPham);
            }
            cbx_LoaiSP.SelectedIndex = 0;

        }
        private void cbx_LoaiSP_SelectedValueChanged(object sender, EventArgs e)
        {
            //string sanPham = (string)cbx_LoaiSP.SelectedValue;

            //if (sanPham != null)
            //{
            //    var sp1 = _LSPres.GetSanPhams(sanPham);
            //    flp_Menu.Controls.Clear();

            //    foreach (var item in sp1)
            //    {
            //        Button bt = new Button
            //        {
            //            Text = item.SanPham.TenSanPham,
            //        };

            //        flp_Menu.Controls.Add(bt);
            //    }
            //}
            //else
            //{
            //    return;
            //}
        }

        private void cbx_LoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string sanPham = (string)cbx_LoaiSP.SelectedItem;
            //MessageBox.Show(sanPham);
            //if (sanPham != null)
            //{
            //    var sp = _LSPres.GetSanPhams(sanPham);
            //    flp_Menu.Controls.Clear();

            //    foreach (var item in sp)
            //    {
            //        Button bt = new Button
            //        {
            //            Text = item.SanPham.TenSanPham + item.SanPham.Gia,
            //            AutoSize = true,
            //            Name = item.SanPham.IdsanPham,
            //            BackgroundImage = item.SanPham.HinhAnh,

            //        };

            //        flp_Menu.Controls.Add(bt);
            //    }
            //}
            //else
            //{
            //    return;
            //}
            string sanPham = (string)cbx_LoaiSP.SelectedItem;

            if (sanPham != null)
            {
                var sp = _LSPres.GetSanPhams(sanPham);
                flp_Menu.Controls.Clear();

                foreach (var item in sp)
                {
                    // Create a Panel to hold Button and Label
                    Panel panel = new Panel();

                    // Create a Button
                    Button bt = new Button();
                    bt.BackgroundImage = Image.FromFile(item.SanPham.HinhAnh);
                    bt.BackgroundImageLayout = ImageLayout.Stretch;
                    bt.ImageAlign = ContentAlignment.TopCenter;
                    bt.Width = _btnWidth;
                    bt.Height = _btnHeight;

                    // Create a Label
                    Label lbl = new Label();
                    lbl.Dock = DockStyle.Bottom; // Set the label to dock at the bottom
                    lbl.TextAlign = ContentAlignment.MiddleCenter; // Adjust text alignment
                    lbl.Height = _labelHeight;
                    lbl.Width = _labelWidth;

                    // Check if Gia is not null or empty before assigning to the label
                    if (!string.IsNullOrEmpty(item.SanPham.Gia.ToString()))
                    {
                        //lbl.Text = ($"{item.SanPham.TenSanPham}\n{item.SanPham.Gia}" + donvi);
                        lbl.Text = ($"{item.SanPham.TenSanPham}\n{decimal.Parse(item.SanPham.Gia.ToString()):C0}");
                    }
                    else
                    {
                        lbl.Text = $"{item.SanPham.TenSanPham}\nN/A"; // Set a default value if Gia is null or empty
                    }

                    // Add Button and Label to the Panel
                    panel.Controls.Add(bt);
                    panel.Controls.Add(lbl);

                    // Set the size of the Panel
                    panel.Size = new Size(_btnWidth, _btnHeight + lbl.Height);

                    // Add the Panel to the FlowLayoutPanel
                    flp_Menu.Controls.Add(panel);
                }
            }
            else
            {
                return;
            }
        }
    }
}