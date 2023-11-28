using BUS.Services;
using DAL.Models;
using DAL.Repositories;
using System.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BUS.IServices;

namespace PRL
{
    public partial class f_TrangChu : Form
    {
        ThucDonServce _ser = new ThucDonServce();
        LoaiSanPhamService _LSPSer = new LoaiSanPhamService();
        private int _btnHeight = 180;
        private int _btnWidth = 180;
        private int _labelHeight = 40;
        private int _labelWidth = 40;

        string _idSPWhenClick;
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
                if (item.TrangThai == 1)
                {
                    cbx_LoaiSP.Items.Add(item.TenLoaiSanPham);
                }
                else
                {
                    continue;
                }
            }
            cbx_LoaiSP.SelectedIndex = 0;

        }
        private void cbx_LoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sanPham = (string)cbx_LoaiSP.SelectedItem;

            if (sanPham != null)
            {
                var sp = _LSPSer.GetSanPhams(sanPham);
                flp_Menu.Controls.Clear();

                foreach (var item in sp)
                {
                    if (item.SanPham.TrangThai == 1)
                    {
                        // Create a Panel to hold Button and Label
                        Panel panel = new Panel();

                        // Create a Button
                        Button bt = new Button();
                        bt.Name = item.SanPham.IdsanPham.ToString();

                        if (string.IsNullOrEmpty(item.SanPham.HinhAnh))
                        {
                            bt.BackgroundImage = null;
                        }
                        else
                        {
                            bt.BackgroundImage = Image.FromFile(item.SanPham.HinhAnh);
                        }

                        //bt.BackgroundImage = Image.FromFile(item.SanPham.HinhAnh);
                        bt.BackgroundImageLayout = ImageLayout.Stretch;
                        bt.ImageAlign = ContentAlignment.TopCenter;
                        bt.Width = _btnWidth;
                        bt.Height = _btnHeight;

                        bt.Click += (sender, e) =>
                        {
                            _idSPWhenClick = bt.Name;
                        };

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
                    else if (item.SanPham.TrangThai == 0)
                    {
                        continue;
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Xac nhan them?", "Xac nhan", MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void LoadDGVOrder()
        {
            dgv_Order.Rows.Clear();
            dgv_Order.ColumnCount = 4;
            dgv_Order.Columns[0].Name = "Tên món";
            dgv_Order.Columns[1].Name = "Giá";
            dgv_Order.Columns[2].Name = "Số lượng";
            dgv_Order.Columns[3].Name = "Ghi chú";


        }
    }
}