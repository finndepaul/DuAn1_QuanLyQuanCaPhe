using BUS.Services;
using DAL.Models;
using DAL.Repositories;
using DAL.ViewModels;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.f_ChucNang
{
    public partial class f_Sale : Form
    {
        List<SanPhamVM> _lstSanPham;
        List<GiamGia> _lstGiamGia;
        string _idGGClick;
        string _idSPclick;
        GiamGiaService _ser = new GiamGiaService();

        public f_Sale()
        {
            InitializeComponent();
        }

        private void f_Sale_Load(object sender, EventArgs e)
        {
            _ser.CheckDate();
            Load_DGV_GiamGia(null, 5);
            Load_cbx_TrangThai();
            Load_cbx_LocTrangThai();
        }

        private void Load_cbx_LocTrangThai()
        {
            cbx_LocTrangThai.Items.Clear();
            cbx_LocTrangThai.Items.Add("All");
            cbx_LocTrangThai.Items.Add("Đang Áp Dụng");
            cbx_LocTrangThai.Items.Add("Chưa Áp Dụng");
            cbx_LocTrangThai.Items.Add("Đã Hết Hạn");
            cbx_LocTrangThai.SelectedIndex = 0;
        }

        private void Load_cbx_TrangThai()
        {
            cbx_TrangThai.Items.Clear();
            cbx_TrangThai.Items.Add("Đang áp dụng");
            cbx_TrangThai.Items.Add("Chưa áp dụng");
            cbx_TrangThai.Items.Add("Đã hết hạn");
        }
        private void Load_DGV_GiamGia(string searchText, int cbxTrangThai)
        {
            dgv_GiamGia.Rows.Clear();
            dgv_GiamGia.ColumnCount = 7;
            dgv_GiamGia.Columns[0].Name = "STT";
            dgv_GiamGia.Columns[1].Name = "ID Giam Gia";
            dgv_GiamGia.Columns[2].Name = "Ten Chuong Trinh";
            dgv_GiamGia.Columns[3].Name = "Phan Tram";
            dgv_GiamGia.Columns[4].Name = "Ngay Bat Dau";
            dgv_GiamGia.Columns[5].Name = "Ngay Ket Thuc";
            dgv_GiamGia.Columns[6].Name = "Trang Thai";

            _lstGiamGia = _ser.GetGiamGias(searchText, cbxTrangThai);
            foreach (var item in _lstGiamGia)
            {
                int stt = _lstGiamGia.IndexOf(item) + 1;
                dgv_GiamGia.Rows.Add(stt++, item.IdgiamGia, item.TenChuongTrinh, item.PhanTram, item.NgayBatDau, item.NgayKetThuc,
        GetTrangThaiText(item.TrangThai.Value)
                     );
            }
        }
        private string GetTrangThaiText(int trangThai)
        {
            switch (trangThai)
            {
                case 0:
                    return "Đang áp dụng";
                case 1:
                    return "Chưa áp dụng";
                case 2:
                    return "Đã hết hạn";
                default:
                    return "Không xác định";
            }
        }

        private void dgv_GiamGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= _lstGiamGia.Count) return;
            var result = _lstGiamGia[index];
            _idGGClick = result.IdgiamGia;
            txt_IDGiamGia.Text = result.IdgiamGia.ToString();
            txt_TenChuongTrinh.Text = result.TenChuongTrinh;
            txt_PhanTram.Text = result.PhanTram.ToString();
            dtp_NgayBatDau.Value = result.NgayBatDau.Value;
            dtp_NgayKetThuc.Value = result.NgayKetThuc.Value;
            if (result.TrangThai == 0)
            {
                cbx_TrangThai.SelectedIndex = 0;
            }
            else if (result.TrangThai == 1)
            {
                cbx_TrangThai.SelectedIndex = 1;
            }
            else if (result.TrangThai == 2)
            {
                cbx_TrangThai.SelectedIndex = 2;
            }
            Load_DGV_SanPham(_idGGClick, null);
        }


        private void Load_DGV_SanPham(string id, string searchText)
        {
            dgv_SanPham.Rows.Clear();
            dgv_SanPham.ColumnCount = 5;
            dgv_SanPham.Columns[0].Name = "STT";
            dgv_SanPham.Columns[1].Name = "ID Sản Phẩm";
            dgv_SanPham.Columns[2].Name = "Tên Sản Phẩm";
            dgv_SanPham.Columns[3].Name = "Giá";
            dgv_SanPham.Columns[4].Name = "Giá Sale";

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Áp Dụng";
            checkBoxColumn.Name = "chb_ApDungSP";
            dgv_SanPham.Columns.Add(checkBoxColumn);

            // Đảm bảo rằng cột checkbox hiển thị ở cuối cùng
            checkBoxColumn.DisplayIndex = dgv_SanPham.Columns.Count - 1;
            _lstSanPham = _ser.GetSanPham(id, searchText);

            foreach (var item in _lstSanPham)
            {
                int stt = _lstSanPham.IndexOf(item) + 1;

                // Nếu id là "All" và item.isCheck là true nhưng id không tồn tại trong GiamGiaChiTiets
                if (id == "All" && item.isCheck && !_ser.CheckIdGiamGiaChiTiet(item.SanPham.IdsanPham, _idGGClick))
                {
                    item.isCheck = false; // Đặt giá trị của checkbox thành false
                }

                float giaMoi = (float)item.SanPham.Gia;
                var giamGia = _ser.GetGiamGia(_idGGClick);
                if (giamGia != null)
                {
                    float giamGiaPhanTram = (float)giamGia.PhanTram / 100;
                    giaMoi = giaMoi * (1 - giamGiaPhanTram);
                }

                int giaMoiNguyen = (int)Math.Round(giaMoi); // Làm tròn giá trị giáMoi thành số nguyên

                dgv_SanPham.Rows.Add(stt++, item.SanPham.IdsanPham, item.SanPham.TenSanPham, item.SanPham.Gia, giaMoiNguyen, item.isCheck);
            }
        }

        private void dgv_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= _lstSanPham.Count) return;
            var result = _lstSanPham[index];
            _idSPclick = result.SanPham.IdsanPham;
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            Load_DGV_SanPham("All", null);
        }
        private void dgv_SanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= _lstSanPham.Count)
            {
                Load_DGV_SanPham(_idGGClick, null);
                return;
            }
            if (e.ColumnIndex == dgv_SanPham.Columns["chb_ApDungSP"].Index && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)dgv_SanPham.Rows[e.RowIndex].Cells[e.ColumnIndex];
                bool isChecked = (bool)cell.Value;
                if (!isChecked)
                {
                    // Ô checkbox được chọn
                    // Thực hiện các hành động tương ứng
                    var checkGG = _ser.CheckSanPham(_idSPclick);
                    if (!checkGG)
                    {
                        MessageBox.Show("Sản Phẩm này đã được áp dụng ở chương trình khác");
                        Load_DGV_SanPham(_idGGClick, null);
                        return;
                    }
                    if (_idGGClick == null)
                    {
                        MessageBox.Show("Chưa chọn chương trình giảm giá");
                        Load_DGV_SanPham(_idGGClick, null);
                        return;
                    }
                    if (dtp_NgayBatDau.Value.Date < DateTime.Now.Date && dtp_NgayKetThuc.Value.Date < DateTime.Now.Date)
                    {
                        MessageBox.Show("Ngày bắt đầu và ngày kết không hợp lệ. Vui lòng chọn lại ngày để áp dụng sale!");
                        Load_DGV_SanPham(_idGGClick, null);
                        return;
                    }
                    else if (dtp_NgayBatDau.Value.Date < DateTime.Now.Date)
                    {
                        MessageBox.Show("Ngày bắt đầu không hợp lệ. Vui lòng chọn lại ngày để áp dụng sale!");
                        Load_DGV_SanPham(_idGGClick, null);
                        return;
                    }
                    if (dtp_NgayBatDau.Value > dtp_NgayKetThuc.Value)
                    {
                        MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!");
                        Load_DGV_SanPham(_idGGClick, null);
                        return;
                    }
                    _ser.AddGGCT(_idGGClick, _idSPclick);
                    _ser.CheckTrangThai(_idGGClick);
                    cell.Value = true;
                }
                else if (isChecked)
                {
                    _ser.DeleteGGCT(_idGGClick, _idSPclick);
                    _ser.CheckTrangThai(_idGGClick);
                    cell.Value = false;
                }
                else
                {
                    return;
                }
                //ClearData();
                //Load_DGV_GiamGia(null, 5);
                //Load_DGV_SanPham(_idGGClick, null);
                Load_cbx_TrangThai();
                Load_cbx_LocTrangThai();
                

            }
        }

        private void ClearData()
        {
            txt_IDGiamGia.Text = "";
            txt_TenChuongTrinh.Text = "";
            txt_PhanTram.Text = "";
            dtp_NgayBatDau.Value = DateTime.Now;
            dtp_NgayKetThuc.Value = DateTime.Now;
            cbx_TrangThai.SelectedItem = null;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            var alert = MessageBox.Show("B xác nhận thêm mới giảm giá", "Xác nhận", MessageBoxButtons.OKCancel);
            if (alert == DialogResult.OK)
            {
                if (dtp_NgayBatDau.Value.Date < DateTime.Now.Date && dtp_NgayKetThuc.Value.Date < DateTime.Now.Date)
                {
                    MessageBox.Show("Ngày bắt đầu và ngày kết không hợp lệ. Vui lòng chọn lại ngày để áp dụng sale!");
                    Load_DGV_SanPham(null, null);
                    return;
                }
                else if (dtp_NgayBatDau.Value.Date < DateTime.Now.Date)
                {
                    MessageBox.Show("Ngày bắt đầu không hợp lệ. Vui lòng chọn lại ngày để áp dụng sale!");
                    Load_DGV_SanPham(null, null);
                    return;
                }
                if (dtp_NgayBatDau.Value > dtp_NgayKetThuc.Value)
                {
                    MessageBox.Show("Ngày bắt đầu phải lớn hơn ngày kết thúc!");
                    Load_DGV_SanPham(null, null);
                    return;
                }
                if (string.IsNullOrEmpty(txt_TenChuongTrinh.Text))
                {
                    MessageBox.Show("Tên Chương Trình không được Null or empty");
                    return;
                }
                if (string.IsNullOrEmpty(txt_PhanTram.Text))
                {
                    MessageBox.Show("Giảm giá không được Null or empty");
                    return;
                }
                GiamGia gg = new GiamGia();
                gg.IdgiamGia = txt_IDGiamGia.Text;
                gg.TenChuongTrinh = txt_TenChuongTrinh.Text;
                gg.PhanTram = double.Parse(txt_PhanTram.Text);
                gg.NgayBatDau = dtp_NgayBatDau.Value;
                gg.NgayKetThuc = dtp_NgayKetThuc.Value;
                if (cbx_TrangThai.SelectedIndex == 0)
                {
                    gg.TrangThai = 0;
                }
                else if (cbx_TrangThai.SelectedIndex == 1)
                {
                    gg.TrangThai = 1;
                }
                else if (cbx_TrangThai.SelectedIndex == 2)
                {
                    gg.TrangThai = 2;
                }
                var result = _ser.AddGiamGia(gg);
                if (result)
                {
                    MessageBox.Show("B thêm thành công");
                    ClearData();
                    Load_DGV_GiamGia(null, 5);
                    Load_DGV_SanPham(null, null);
                    Load_cbx_LocTrangThai();
                    _idGGClick = null;
                    _idSPclick = null;
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

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var alert = MessageBox.Show("B xác nhận sửa giảm giá", "Xác nhận", MessageBoxButtons.OKCancel);
            if (alert == DialogResult.OK)
            {
                if (dtp_NgayBatDau.Value.Date < DateTime.Now.Date && dtp_NgayKetThuc.Value.Date < DateTime.Now.Date)
                {
                    MessageBox.Show("Ngày bắt đầu và ngày kết không hợp lệ. Vui lòng chọn lại ngày để áp dụng sale!");
                    Load_DGV_SanPham(null, null);
                    return;
                }
                else if (dtp_NgayBatDau.Value.Date < DateTime.Now.Date)
                {
                    MessageBox.Show("Ngày bắt đầu không hợp lệ. Vui lòng chọn lại ngày để áp dụng sale!");
                    Load_DGV_SanPham(null, null);
                    return;
                }

                if (dtp_NgayBatDau.Value > dtp_NgayKetThuc.Value)
                {
                    MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!");
                    Load_DGV_SanPham(null, null);
                    return;
                }
                if (string.IsNullOrEmpty(txt_TenChuongTrinh.Text))
                {
                    MessageBox.Show("Tên Chương Trình không được Null or empty");

                    return;
                }
                if (string.IsNullOrEmpty(txt_PhanTram.Text))
                {
                    MessageBox.Show("Giảm giá không được Null or empty");
                    return;
                }
                GiamGia gg = new GiamGia();
                gg.IdgiamGia = txt_IDGiamGia.Text;
                gg.TenChuongTrinh = txt_TenChuongTrinh.Text;
                gg.PhanTram = double.Parse(txt_PhanTram.Text);
                gg.NgayBatDau = dtp_NgayBatDau.Value;
                gg.NgayKetThuc = dtp_NgayKetThuc.Value;
                if (cbx_TrangThai.SelectedIndex == 0)
                {
                    gg.TrangThai = 0;
                }
                else if (cbx_TrangThai.SelectedIndex == 1)
                {
                    gg.TrangThai = 1;
                }
                else if (cbx_TrangThai.SelectedIndex == 2)
                {
                    gg.TrangThai = 2;
                }
                var result = _ser.UpdateGiamGia(_idGGClick, gg);
                if (result)
                {
                    MessageBox.Show("B sửa thành công");
                    Load_DGV_GiamGia(null, 5);
                    Load_DGV_SanPham(null, null);
                    Load_cbx_LocTrangThai();
                    ClearData();
                    _idGGClick = null;
                    _idSPclick = null;
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

        private void txt_TimKhuyenMai_TextChanged(object sender, EventArgs e)
        {
            Load_DGV_GiamGia(txt_TimKhuyenMai.Text, cbx_LocTrangThai.SelectedIndex);
        }

        private void cbx_LocTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_DGV_GiamGia(txt_TimKhuyenMai.Text, cbx_LocTrangThai.SelectedIndex);
        }

        private void txt_TimSanPham_TextChanged(object sender, EventArgs e)
        {
            Load_DGV_SanPham(_idGGClick,txt_TimSanPham.Text);
        }
    }
}
