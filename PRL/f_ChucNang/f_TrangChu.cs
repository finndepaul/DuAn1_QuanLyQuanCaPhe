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
        ThucDonService _ser = new ThucDonService();
        LoaiSanPhamService _LSPSer = new LoaiSanPhamService();
        private int _btnHeight = 180;
        private int _btnWidth = 180;
 
        private int _labelHeight = 50;
        private int _labelWidth = 200;

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

        //private void cbx_LoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string sanPham = (string)cbx_LoaiSP.SelectedItem;

        //    if (sanPham != null)
        //    {
        //        var sp = _LSPSer.GetSanPhams(sanPham);
        //        flp_Menu.Controls.Clear();

        //        foreach (var item in sp)
        //        {
        //            if (item.SanPham.TrangThai == 1)
        //            {
        //                // Create a Panel to hold Button and Label
        //                Panel panel = new Panel();

        //                // Create a Button
        //                Button bt = new Button();
        //                bt.Name = item.SanPham.IdsanPham.ToString();

        //                if (string.IsNullOrEmpty(item.SanPham.HinhAnh))
        //                {
        //                    bt.BackgroundImage = null;
        //                }
        //                else
        //                {
        //                    bt.BackgroundImage = Image.FromFile(item.SanPham.HinhAnh);
        //                }

        //                //bt.BackgroundImage = Image.FromFile(item.SanPham.HinhAnh);
        //                bt.BackgroundImageLayout = ImageLayout.Stretch;
        //                bt.ImageAlign = ContentAlignment.TopCenter;
        //                bt.Width = _btnWidth;
        //                bt.Height = _btnHeight;

        //                bt.Click += (sender, e) =>
        //                {
        //                    _idSPWhenClick = bt.Name;
        //                };

        //                // Create a Label
        //                Label lbl = new Label();
        //                lbl.Dock = DockStyle.Bottom; // Set the label to dock at the bottom
        //                lbl.TextAlign = ContentAlignment.MiddleCenter; // Adjust text alignment
        //                lbl.Height = _labelHeight;
        //                lbl.Width = _labelWidth;

        //                // Check if Gia is not null or empty before assigning to the label
        //                if (item.SanPham.GiaSale != null && item.SanPham.GiaSale > 0)
        //                {
        //                    lbl.Text = $"{item.SanPham.TenSanPham}\n{decimal.Parse(item.SanPham.Gia.ToString()):C0} - {decimal.Parse(item.SanPham.GiaSale.ToString()):C0}";
        //                }
        //                else
        //                {
        //                    lbl.Text = $"{item.SanPham.TenSanPham}\n{decimal.Parse(item.SanPham.Gia.ToString()):C0}";
        //                }


        //                // Add Button and Label to the Panel
        //                panel.Controls.Add(bt);
        //                panel.Controls.Add(lbl);

        //                // Set the size of the Panel
        //                panel.Size = new Size(_btnWidth, _btnHeight + lbl.Height);

        //                // Add the Panel to the FlowLayoutPanel
        //                flp_Menu.Controls.Add(panel);
        //            }
        //            else if (item.SanPham.TrangThai == 0)
        //            {
        //                continue;
        //            }
        //            else
        //            {
        //                return;
        //            }
        //        }
        //    }
        //}

        // gạch ngang được giá nhưng mà mất hình ảnh

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
                        // Create a Panel to hold Button and Labels
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

                        bt.BackgroundImageLayout = ImageLayout.Stretch;
                        bt.ImageAlign = ContentAlignment.TopCenter;
                        bt.Width = _btnWidth;
                        bt.Height = _btnHeight;

                        bt.Click += (sender, e) =>
                        {
                            _idSPWhenClick = bt.Name;
                        };

                        // Create the Labels
                        Label lblTenSanPham = new Label();
                        lblTenSanPham.Dock = DockStyle.Top;
                        lblTenSanPham.TextAlign = ContentAlignment.MiddleCenter;
                        lblTenSanPham.Height = _labelHeight;
                        lblTenSanPham.Width = _labelWidth;
                        lblTenSanPham.Text = item.SanPham.TenSanPham;

                        Label lblGia = new Label();
                        lblGia.Dock = DockStyle.Left;
                        lblGia.TextAlign = ContentAlignment.MiddleCenter;
                        lblGia.Height = _labelHeight;
                        lblGia.Width = _labelWidth / 2;

                        if (item.SanPham.GiaSale != null && item.SanPham.GiaSale > 0)
                        {
                            // Strikeout the original price
                            lblGia.Font = new Font(lblGia.Font, FontStyle.Strikeout);
                            lblGia.ForeColor = Color.Black;

                            // Display the original price and sale price
                            lblGia.Text = decimal.Parse(item.SanPham.Gia.ToString()).ToString("C0");

                            Label lblGiaSale = new Label();
                            lblGiaSale.Dock = DockStyle.Right;
                            lblGiaSale.TextAlign = ContentAlignment.MiddleCenter;
                            lblGiaSale.Height = _labelHeight;
                            lblGiaSale.Width = _labelWidth / 2;
                            lblGiaSale.Text = decimal.Parse(item.SanPham.GiaSale.ToString()).ToString("C0");

                            panel.Controls.Add(lblGia);
                            panel.Controls.Add(lblGiaSale);
                        }
                        else
                        {
                            lblGia.Text = decimal.Parse(item.SanPham.Gia.ToString()).ToString("C0");

                            panel.Controls.Add(lblGia);
                        }

                        panel.Controls.Add(lblTenSanPham);
                        panel.Controls.Add(bt);

                        flp_Menu.Controls.Add(panel);
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