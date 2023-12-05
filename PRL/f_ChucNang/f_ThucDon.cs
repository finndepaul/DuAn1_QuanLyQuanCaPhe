using BUS.Services;
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
        ThucDonService _TDser = new ThucDonService();
        List<SanPhamVM> _lstSanPham;
        List<LoaiSanPham> _lstLoaiSP;
        List<string> _lstIdLoaiSP = new List<string>();
        string _idSPWhenClick;
        string _idLSPWhenClick;
        private string selectedImagePath;
        string _imageWhenClick;
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
        }
        private void Load_CBX_TrangThaiLSP()
        {
            cbx_TrangThaiLSP.Items.Clear();
            cbx_TrangThaiLSP.Items.Add("Đang Bán");
            cbx_TrangThaiLSP.Items.Add("Ngừng Bán");
        }

        private void Load_CBX_IDLoaiSP()
        {
            cbx_IDLoaiSP.Items.Clear();
            _lstIdLoaiSP.Clear();
            foreach (var item in _TDser.GetLoaiSanPhams())
            {
                //if (item.TrangThai == 1)
                //{
                //    cbx_IDLoaiSP.Items.Add(item.IdloaiSanPham);
                //    _lstIdLoaiSP.Add(item.IdloaiSanPham);
                //}
                //else
                //{
                //    continue;
                //}

                //

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
            _lstLoaiSP = _TDser.GetLoaiSanPhams();
            foreach (var item in _TDser.GetLoaiSanPhams())
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
            foreach (var item in _TDser.GetLoaiSanPhams())
            {
                if (item.TrangThai == 1)
                {
                    cbx_LocLoaiSanPham.Items.Add(item.TenLoaiSanPham);
                }
                else
                {
                    continue;
                }
            }
            cbx_LocLoaiSanPham.SelectedIndex = 0;
        }

        private void Load_DGV_SanPham(string searchText, string cbxLoaiSP, int cbxLocTrangThai)
        {
            dgv_SanPham.Rows.Clear();
            dgv_SanPham.ColumnCount = 10;
            dgv_SanPham.Columns[0].Name = "STT";
            dgv_SanPham.Columns[1].Name = "ID";
            dgv_SanPham.Columns[2].Name = "Tên Sản Phẩm";
            dgv_SanPham.Columns[3].Name = "Giá";
            dgv_SanPham.Columns[4].Name = "Trạng Thái";
            dgv_SanPham.Columns[5].Name = "Thuế";
            dgv_SanPham.Columns[6].Name = "Loại Sản Phẩm";
            dgv_SanPham.Columns[7].Name = "ID Loại SP";
            dgv_SanPham.Columns[8].Name = "ImagePath";
            dgv_SanPham.Columns[9].Name = "ID Nhân Viên";
            dgv_SanPham.Columns[7].Visible = false;
            dgv_SanPham.Columns[8].Visible = false;

            _lstSanPham = _TDser.GetSanPhams(searchText, cbxLoaiSP, cbxLocTrangThai);
            foreach (var item in _lstSanPham)
            {
                int stt = _lstSanPham.IndexOf(item) + 1;
                dgv_SanPham.Rows.Add(stt++, item.SanPham.IdsanPham, item.SanPham.TenSanPham, item.SanPham.Gia,
                    item.SanPham.TrangThai == 1 ? "Đang Bán" : "Ngừng Bán", item.SanPham.Thue, item.TenLoaiSP, item.SanPham.IdloaiSanPham, item.SanPham.HinhAnh, item.SanPham.IdnhanVien);
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
            if (string.IsNullOrEmpty(result.SanPham.HinhAnh))
            {
                pb_AnhSP.Image = null;
                _imageWhenClick = null;
            }
            else
            {
                pb_AnhSP.Image = Image.FromFile(result.SanPham.HinhAnh);
                _imageWhenClick = result.SanPham.HinhAnh;
            }
            txt_IDNVinSP.Text = result.SanPham.IdnhanVien;

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
        private void Clear_LoaiSP()
        {
            txt_IDLoaiSanPham.Text = "";
            txt_TenLoaiSanPham.Text = "";
            cbx_TrangThaiLSP.SelectedItem = null;
            txt_IDNhanVien.Text = "";
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
            var alert = MessageBox.Show("B xác nhận thêm mới loại sản phẩm", "Xác nhận", MessageBoxButtons.OKCancel);
            if (alert == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(txt_TenLoaiSanPham.Text))
                {
                    MessageBox.Show("Tên Loại sản phẩm không được NULL or Empty");
                    Clear_LoaiSP();
                    return;
                }
                if (string.IsNullOrEmpty(txt_IDNhanVien.Text))
                {
                    MessageBox.Show("ID nhân viên không được NULL or Empty");
                    Clear_LoaiSP();
                    return;
                }
                var regexTenSP = _TDser.Add_RegexTenLSP(txt_TenLoaiSanPham.Text);
                if (!regexTenSP)
                {
                    MessageBox.Show("Tên Loại sản phẩm đã có trong database!");
                    Clear_LoaiSP();
                    return;
                }
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
                var result = _TDser.AddLoaiSP(lsp);
                if (result)
                {
                    MessageBox.Show("B thêm thành công");                    
                    Load_DGV_LoaiSP();
                    Load_CBX_LocLoaiSP();
                    Load_CBX_TrangThaiFind();
                    Load_CBX_IDLoaiSP();
                    Clear_LoaiSP();                   
                }
                else
                {
                    MessageBox.Show("B thêm thất bại");
                }
            }
            else if (alert == DialogResult.Cancel)
            {
                return;
            }
        }

        private void btn_SuaLSP_Click(object sender, EventArgs e)
        {
            var alert = MessageBox.Show("B xác nhận cập nhật loại sản phẩm", "Xác nhận", MessageBoxButtons.OKCancel);
            if (alert == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(txt_TenLoaiSanPham.Text))
                {
                    MessageBox.Show("Tên Loại sản phẩm không được NULL or Empty");
                    Clear_LoaiSP();
                    return;
                }
                if (string.IsNullOrEmpty(txt_IDNhanVien.Text))
                {
                    MessageBox.Show("ID nhân viên không được NULL or Empty");
                    Clear_LoaiSP();
                    return;
                }
                var regexTenSP = _TDser.Update_RegexTenLSP(txt_TenLoaiSanPham.Text, _idLSPWhenClick);
                if (!regexTenSP)
                {
                    MessageBox.Show("Tên Loại sản phẩm đã có trong database!");
                    Clear_LoaiSP();
                    return;
                }
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
                var result = _TDser.UpdateLoaiSP(_idLSPWhenClick, lsp);
                if (result)
                {
                    MessageBox.Show("B cập nhật thành công");
                    Load_DGV_LoaiSP();
                    Load_CBX_LocLoaiSP();
                    Load_CBX_TrangThaiFind();
                    Load_CBX_IDLoaiSP();
                    Load_DGV_SanPham(null, null, 3);
                    Clear_LoaiSP();
                }
                else
                {
                    MessageBox.Show("B cập nhật thất bại");
                }
            }
            else if (alert == DialogResult.Cancel)
            {
                return;
            }
        }
        private void btn_AddImages_Click(object sender, EventArgs e) // Thêm hoặc cập nhật ảnh
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All files (*.*)|*.*";
                openFileDialog.Title = "Chọn ảnh sản phẩm";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = openFileDialog.FileName;
                    var result = _TDser.GetImgage(_idSPWhenClick, selectedImagePath);
                    if (result)
                    {
                        MessageBox.Show("Thêm ảnh thành công !!!");
                        Load_DGV_SanPham(null, null, 3);
                        Clear_SP();
                    }
                    else
                    {
                        MessageBox.Show("Thêm ảnh thất bại");
                    }
                }
            }
        }

        private void btn_ThemSP_Click(object sender, EventArgs e)
        {
            var alert = MessageBox.Show("B xác nhận thêm mới sản phẩm", "Xác nhận", MessageBoxButtons.OKCancel);
            if (alert == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(txt_TenSP.Text))
                {
                    MessageBox.Show("Tên sản phẩm không được NULL or Empty");
                    Clear_SP();
                    return;
                }
                if (string.IsNullOrEmpty(txt_thue.Text))
                {
                    MessageBox.Show("Thuế không được NULL or Empty");
                    Clear_SP();
                    return;
                }
                if (string.IsNullOrEmpty(txt_Gia.Text))
                {
                    MessageBox.Show("Giá không được NULL or Empty");
                    Clear_SP();
                    return;
                }
                var regexTenSP = _TDser.Add_RegexTenSP(txt_TenSP.Text);
                if (!regexTenSP)
                {
                    MessageBox.Show("Tên sản phẩm đã có trong database!");
                    Clear_SP();
                    return;
                }
                
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
                var result = _TDser.AddSP(sp);
                if (result)
                {
                    MessageBox.Show("B thêm thành công");
                    Load_CBX_TrangThaiFind();
                    Load_CBX_LocLoaiSP();
                    Load_DGV_SanPham(null, null, 3);
                }
                else
                {
                    MessageBox.Show("B thêm thất bại");
                }
            }
            else if (alert == DialogResult.Cancel)
            {
                return;
            }
        }

        private void btn_SuaSP_Click(object sender, EventArgs e)
        {
            var alert = MessageBox.Show("B xác nhận sửa sản phẩm", "Xác nhận", MessageBoxButtons.OKCancel);
            if (alert == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(txt_TenSP.Text))
                {
                    MessageBox.Show("Tên sản phẩm không được NULL or Empty");
                    Clear_SP();
                    return;
                }
                if (string.IsNullOrEmpty(txt_thue.Text))
                {
                    MessageBox.Show("Thuế không được NULL or Empty");
                    Clear_SP();
                    return;
                }
                if (string.IsNullOrEmpty(txt_Gia.Text))
                {
                    MessageBox.Show("Giá không được NULL or Empty");
                    Clear_SP();
                    return;
                }
                var regexTenSP = _TDser.Update_RegexTenSP(txt_TenSP.Text, _idSPWhenClick);
                if (!regexTenSP)
                {
                    MessageBox.Show("Tên sản phẩm đã có trong database!");
                    Clear_SP();
                    return;
                }
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
                sp.HinhAnh = _imageWhenClick; // cho string file path biến toàn cục
                var result = _TDser.UpdateSP(_idSPWhenClick, sp);
                if (result)
                {
                    MessageBox.Show("B sửa thành công");
                    Load_DGV_SanPham(null, null, 3);
                }
                else
                {
                    MessageBox.Show("B sửa thất bại");
                }
            }
            else if (alert == DialogResult.Cancel)
            {
                return;
            }
        }

    }
}
