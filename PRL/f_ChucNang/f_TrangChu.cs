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

namespace PRL
{
    public partial class f_TrangChu : Form
    {
        ThucDonServce _ser = new ThucDonServce();
        LoaiSanPhamRepos _LSPres = new LoaiSanPhamRepos();
        private int _btnSPHeight = 150;
        private int _btnSPWidth = 120;
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
            //cbx_LoaiSP.SelectedIndex = 0;

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
                    Image img = Image.FromFile(item.SanPham.HinhAnh);
                    Button bt = new Button
                    {

                        Image = img,
                        Text = item.SanPham.TenSanPham + "\n" + item.SanPham.Gia,
                        Tag = item.SanPham.Gia.ToString(),
                        //AutoSize = true;
                        Name = item.SanPham.IdsanPham,
                        //AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly,
                        Height = _btnSPHeight,
                        Width = _btnSPWidth,
                        ImageAlign = ContentAlignment.MiddleCenter,
                        //BackgroundImageLayout = ImageLayout.Stretch,
                        TextImageRelation = TextImageRelation.ImageAboveText,
                        TextAlign = ContentAlignment.BottomCenter,
                    };
                    flp_Menu.Controls.Add(bt);
                }
            }
            else
            {
                return;
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Xac nhan them?", "Xac nhan", MessageBoxButtons.OKCancel);
            if(confirmResult == DialogResult.OK)
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