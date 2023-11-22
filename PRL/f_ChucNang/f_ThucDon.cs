﻿using BUS.Services;
using DAL.Models;
using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRL.f_ChucNang
{
    public partial class f_ThucDon : Form
    {
        CoffeeServce _ser = new CoffeeServce();
        List<SanPhamVM> _lstSanPham;
        List<LoaiSanPham> _lstLoaiSP;
        List<string> _lstIdLoaiSP = new List<string>();
        List<string> _lstIdNhanVien = new List<string>();
        string _idSPWhenClick;
        string _idLSPWhenClick;
        private string selectedImagePath;
        public f_ThucDon()
        {
            InitializeComponent();
        }
        private void f_ThucDon_Load(object sender, EventArgs e)
        {
            // sản phẩm
            Load_DGV_SanPham(null, null, 3);
            Load_CBX_TrangThaiFind();
            Load_CBX_TrangThai();
            Load_CBX_IDLoaiSP();

            // loại sản phẩm
            Load_DGV_LoaiSP();
            Load_CBX_LocLoaiSP();
            Load_CBX_TrangThaiLSP();
            //Load_cbx_IDNhanVien();
        }

        private void Load_cbx_IDNhanVien()
        {
            throw new NotImplementedException();
        }

        private void Load_CBX_TrangThaiLSP()
        {
            cbx_TrangThaiLSP.Items.Clear();
            cbx_TrangThaiLSP.Items.Add("Đang Bán");
            cbx_TrangThaiLSP.Items.Add("Ngừng Bán");
        }

        private void Load_CBX_IDLoaiSP()
        {
            foreach (var item in _ser.GetLoaiSanPhams())
            {
                cbx_IDLoaiSP.Items.Add(item.IdloaiSanPham);
                _lstIdLoaiSP.Add(item.IdloaiSanPham);
            }
        }

        private void Load_DGV_LoaiSP()
        {
            dgv_LoaiSP.Rows.Clear();
            dgv_LoaiSP.ColumnCount = 5;
            dgv_LoaiSP.Columns[0].Name = "STT";
            dgv_LoaiSP.Columns[1].Name = "ID Loại Sản Phẩm";
            dgv_LoaiSP.Columns[2].Name = "Tên Loại Sản Phẩm";
            dgv_LoaiSP.Columns[3].Name = "Trạng Thái";
            dgv_LoaiSP.Columns[4].Name = "ID nhân viên";
            _lstLoaiSP = _ser.GetLoaiSanPhams();
            foreach (var item in _ser.GetLoaiSanPhams())
            {
                int stt = _lstLoaiSP.IndexOf(item) + 1;
                dgv_LoaiSP.Rows.Add(stt++, item.IdloaiSanPham, item.TenLoaiSanPham, item.TrangThai == 1 ? "Đang Bán" : "Ngừng Bán",
                    item.IdnhanVien);
            }
        }

        private void Load_CBX_TrangThai()
        {
            cbx_TrangThaiSP.Items.Clear();
            cbx_TrangThaiSP.Items.Add("Đang Bán");
            cbx_TrangThaiSP.Items.Add("Ngừng Bán");
        }

        private void Load_CBX_TrangThaiFind()
        {
            cbx_LocTrangThai.Items.Clear();
            cbx_LocTrangThai.Items.Add("All");
            cbx_LocTrangThai.Items.Add("Đang Bán");
            cbx_LocTrangThai.Items.Add("Ngừng Bán");
            cbx_LocTrangThai.SelectedIndex = 0;
        }

        private void Load_CBX_LocLoaiSP()
        {
            cbx_LocLoaiSanPham.Items.Clear();
            cbx_LocLoaiSanPham.Items.Add("All");
            foreach (var item in _ser.GetLoaiSanPhams())
            {
                cbx_LocLoaiSanPham.Items.Add(item.TenLoaiSanPham);
            }
            cbx_LocLoaiSanPham.SelectedIndex = 0;
        }

        private void Load_DGV_SanPham(string searchText, string cbxLoaiSP, int cbxLocTrangThai)
        {
            dgv_SanPham.Rows.Clear();
            dgv_SanPham.ColumnCount = 9;
            dgv_SanPham.Columns[0].Name = "STT";
            dgv_SanPham.Columns[1].Name = "ID";
            dgv_SanPham.Columns[2].Name = "Tên Sản Phẩm";
            dgv_SanPham.Columns[3].Name = "Giá";
            dgv_SanPham.Columns[4].Name = "Trạng Thái";
            dgv_SanPham.Columns[5].Name = "Thuế";
            dgv_SanPham.Columns[6].Name = "Loại Sản Phẩm";
            dgv_SanPham.Columns[7].Name = "ID Loại SP";
            dgv_SanPham.Columns[8].Name = "ImagePath";
            dgv_SanPham.Columns[7].Visible = false;
            dgv_SanPham.Columns[8].Visible = false;

            _lstSanPham = _ser.GetSanPhams(searchText, cbxLoaiSP, cbxLocTrangThai);
            foreach (var item in _lstSanPham)
            {
                int stt = _lstSanPham.IndexOf(item) + 1;
                dgv_SanPham.Rows.Add(stt++, item.SanPham.IdsanPham, item.SanPham.TenSanPham, item.SanPham.Gia,
                    item.SanPham.TrangThai == 1 ? "Đang Bán" : "Ngừng Bán", item.SanPham.Thue, item.TenLoaiSP, item.SanPham.IdloaiSanPham, item.SanPham.HinhAnh);
            }
        }

        private void txt_FindSP_TextChanged(object sender, EventArgs e)
        {
            Load_DGV_SanPham(txt_FindSP.Text, cbx_LocLoaiSanPham.Text, cbx_LocTrangThai.SelectedIndex);
        }

        private void cbx_LocTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_DGV_SanPham(txt_FindSP.Text, cbx_LocLoaiSanPham.Text, cbx_LocTrangThai.SelectedIndex);
        }

        private void cbx_LocTrangThai_SelectedValueChanged(object sender, EventArgs e)
        {
            Load_DGV_SanPham(txt_FindSP.Text, cbx_LocLoaiSanPham.Text, cbx_TrangThaiSP.SelectedIndex);
        }

        private void cbx_LocLoaiSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_DGV_SanPham(txt_FindSP.Text, cbx_LocLoaiSanPham.Text, cbx_LocTrangThai.SelectedIndex);
        }

        private void dgv_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= _lstSanPham.Count)
            {
                return;
            }
            var result = _lstSanPham[index];
            _idSPWhenClick = result.SanPham.IdsanPham;
            txt_IDSanPham.Text = result.SanPham.IdsanPham;
            txt_TenSP.Text = result.SanPham.TenSanPham;
            txt_Gia.Text = result.SanPham.Gia.ToString();
            if (result.SanPham.TrangThai == 1)
            {
                cbx_TrangThaiSP.SelectedIndex = 0;
            }
            if (result.SanPham.TrangThai == 0)
            {
                cbx_TrangThaiSP.SelectedIndex = 1;
            }
            txt_thue.Text = result.SanPham.Thue.ToString();
            var indexCBX_IDLoaiSP = _lstIdLoaiSP.FindIndex(x => x == result.SanPham.IdloaiSanPham);
            cbx_IDLoaiSP.SelectedIndex = indexCBX_IDLoaiSP;

            if (result.SanPham.HinhAnh == null)
            {
                pb_AnhSP.Image = null;
            }
            else
            {
                pb_AnhSP.Image = Image.FromFile(result.SanPham.HinhAnh);
            }
        }
        private void Clear_SP()
        {
            pb_AnhSP.Image = null;
            txt_IDSanPham.Text = "";
            txt_TenSP.Text = "";
            txt_Gia.Text = "";
            txt_thue.Text = "";
            cbx_TrangThaiSP.SelectedItem = null;
            cbx_IDLoaiSP.SelectedItem = null;

        }
        private void dgv_LoaiSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= _lstLoaiSP.Count)
            {
                return;
            }
            var result = _lstLoaiSP[index];
            _idLSPWhenClick = result.IdloaiSanPham;

            txt_IDLoaiSanPham.Text = result.IdloaiSanPham;
            txt_TenLoaiSanPham.Text = result.TenLoaiSanPham;
            if (result.TrangThai == 1)
            {
                cbx_TrangThaiLSP.SelectedIndex = 0;
            }
            if (result.TrangThai == 0)
            {
                cbx_TrangThaiLSP.SelectedIndex = 1;
            }
            txt_IDNhanVien.Text = result.IdnhanVien;
        }
        private void btn_ThemLSP_Click(object sender, EventArgs e)
        {
            var alert = MessageBox.Show("B xac nhan them moi loai san pham", "Xac nhan", MessageBoxButtons.OK);
            if (alert == DialogResult.OK)
            {
                LoaiSanPham lsp = new LoaiSanPham();
                lsp.IdloaiSanPham = txt_IDLoaiSanPham.Text;
                lsp.TenLoaiSanPham = txt_TenLoaiSanPham.Text;
                if (cbx_TrangThaiLSP.SelectedIndex == 0)
                {
                    lsp.TrangThai = 1;
                }
                else if (cbx_TrangThaiLSP.SelectedIndex == 1)
                {
                    lsp.TrangThai = 0;
                }
                lsp.IdnhanVien = txt_IDNhanVien.Text;
                var result = _ser.AddLoaiSP(lsp);
                if (result)
                {
                    MessageBox.Show("B them thanh cong");
                    Load_DGV_LoaiSP();
                    Load_CBX_LocLoaiSP();
                    Load_CBX_TrangThaiFind();
                }
                else
                {
                    MessageBox.Show("B them that bai");
                }
            }
            else
            {
                MessageBox.Show("B xac nhan KHONG them");
            }
        }

        private void btn_SuaLSP_Click(object sender, EventArgs e)
        {
            var alert = MessageBox.Show("B xac nhan cap nhat loai san pham", "Xac nhan", MessageBoxButtons.OK);
            if (alert == DialogResult.OK)
            {
                LoaiSanPham lsp = new LoaiSanPham();
                lsp.IdloaiSanPham = txt_IDLoaiSanPham.Text;
                lsp.TenLoaiSanPham = txt_TenLoaiSanPham.Text;
                if (cbx_TrangThaiLSP.SelectedIndex == 0)
                {
                    lsp.TrangThai = 1;
                }
                else if (cbx_TrangThaiLSP.SelectedIndex == 1)
                {
                    lsp.TrangThai = 0;
                }
                lsp.IdnhanVien = txt_IDNhanVien.Text;
                var result = _ser.UpdateLoaiSP(_idLSPWhenClick, lsp);
                if (result)
                {
                    MessageBox.Show("B cap nhat thanh cong");
                    Load_DGV_LoaiSP();
                }
                else
                {
                    MessageBox.Show("B cap nhat that bai");
                }
            }
            else
            {
                MessageBox.Show("B xac nhan KHONG them");
            }
        }
        private void btn_XoaLSP_Click(object sender, EventArgs e)
        {
            var alert = MessageBox.Show("B xac nhan xoa loai san pham", "Xac nhan", MessageBoxButtons.OK);
            if (alert == DialogResult.OK)
            {
                var result = _ser.DeleteLoaiSP(_idLSPWhenClick);
                if (result)
                {
                    MessageBox.Show("B xoa thanh cong");
                    Load_DGV_LoaiSP();
                }
                else
                {
                    MessageBox.Show("B xoa that bai");
                }
            }
            else
            {
                MessageBox.Show("B xac nhan KHONG xoa");
            }
        }
        private void btn_AddImages_Click(object sender, EventArgs e) // Thêm hoặc cập nhật ảnh
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All files (*.*)|*.*";
                openFileDialog.Title = "Chon anh san pham";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = openFileDialog.FileName;
                    var result = _ser.GetImgage(_idSPWhenClick, selectedImagePath);
                    if (result)
                    {
                        MessageBox.Show("Them anh thanh cong !!!");
                        Load_DGV_SanPham(null, null, 3);
                        Clear_SP();
                    }
                    else
                    {
                        MessageBox.Show("Them anh that bai");
                    }
                }
            }
        }

        private void btn_ThemSP_Click(object sender, EventArgs e)
        {
            var alert = MessageBox.Show("B xac nhan them moi san pham", "Xac nhan", MessageBoxButtons.OK);
            if (alert == DialogResult.OK)
            {
                SanPham sp = new SanPham();
                sp.IdsanPham = txt_IDSanPham.Text;
                sp.TenSanPham = txt_TenSP.Text;
                sp.Gia = double.Parse(txt_Gia.Text);
                if (cbx_TrangThaiSP.SelectedIndex == 0)
                {
                    sp.TrangThai = 1;
                }
                else if (cbx_TrangThaiSP.SelectedIndex == 1)
                {
                    sp.TrangThai = 0;
                }
                sp.Thue = double.Parse(txt_thue.Text);
                sp.IdloaiSanPham = _lstIdLoaiSP[cbx_IDLoaiSP.SelectedIndex];
                var result = _ser.AddSP(sp);
                if (result)
                {
                    MessageBox.Show("B them thanh cong");
                    Load_DGV_SanPham(null, null, 3);
                }
                else
                {
                    MessageBox.Show("B them that bai");
                }
            }
            else
            {
                MessageBox.Show("B xac nhan KHONG them");
            }
        }

        private void btn_SuaSP_Click(object sender, EventArgs e)
        {
            var alert = MessageBox.Show("B xac nhan sua san pham", "Xac nhan", MessageBoxButtons.OK);
            if (alert == DialogResult.OK)
            {
                SanPham sp = new SanPham();
                sp.IdsanPham = txt_IDSanPham.Text;
                sp.TenSanPham = txt_TenSP.Text;
                sp.Gia = double.Parse(txt_Gia.Text);
                if (cbx_TrangThaiSP.SelectedIndex == 0)
                {
                    sp.TrangThai = 1;
                }
                else if (cbx_TrangThaiSP.SelectedIndex == 1)
                {
                    sp.TrangThai = 0;
                }
                sp.Thue = double.Parse(txt_thue.Text);
                sp.IdloaiSanPham = _lstIdLoaiSP[cbx_IDLoaiSP.SelectedIndex];
                sp.HinhAnh = pb_AnhSP.ImageLocation;
                var result = _ser.UpdateSP(_idSPWhenClick, sp);
                if (result)
                {
                    MessageBox.Show("B sua thanh cong");
                    Load_DGV_SanPham(null, null, 3);
                }
                else
                {
                    MessageBox.Show("B sua that bai");
                }
            }
            else
            {
                MessageBox.Show("B xac nhan KHONG sua");
            }
        }

        private void btn_XoaSP_Click(object sender, EventArgs e)
        {
            var alert = MessageBox.Show("B xac nhan xoa san pham", "Xac nhan", MessageBoxButtons.OK);
            if (alert == DialogResult.OK)
            {
                var result = _ser.DeleteSP(_idSPWhenClick);
                if (result)
                {
                    MessageBox.Show("B xoa thanh cong");
                    Load_DGV_SanPham(null, null, 3);
                }
                else
                {
                    MessageBox.Show("B xoa that bai");
                }
            }
            else
            {
                MessageBox.Show("B xac nhan KHONG xoa");
            }

        }

        
    }
}