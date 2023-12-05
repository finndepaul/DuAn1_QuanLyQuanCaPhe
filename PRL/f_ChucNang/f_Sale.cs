using BUS.Services;
using DAL.Models;
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
            Load_DGV_GiamGia();

            Load_cbx_TrangThai();
        }

        private void Load_cbx_TrangThai()
        {
            cbx_TrangThai.Items.Clear();
            cbx_TrangThai.Items.Add("Đang áp dụng");
            cbx_TrangThai.Items.Add("Chưa áp dụng");
            cbx_TrangThai.Items.Add("Đã hết hạn");
        }
        private void Load_DGV_GiamGia()
        {
        //    dgv_GiamGia.Rows.Clear();
        //    dgv_GiamGia.ColumnCount = 7;
        //    dgv_GiamGia.Columns[0].Name = "STT";
        //    dgv_GiamGia.Columns[1].Name = "ID Giam Gia";
        //    dgv_GiamGia.Columns[2].Name = "Ten Chuong Trinh";
        //    dgv_GiamGia.Columns[3].Name = "Phan Tram";
        //    dgv_GiamGia.Columns[4].Name = "Ngay Bat Dau";
        //    dgv_GiamGia.Columns[5].Name = "Ngay Ket Thuc";
        //    dgv_GiamGia.Columns[6].Name = "Trang Thai";

        //    _lstGiamGia = _ser.GetGiamGias();
        //    foreach (var item in _lstGiamGia)
        //    {
        //        int stt = _lstGiamGia.IndexOf(item) + 1;
        //        dgv_GiamGia.Rows.Add(stt++, item.IdgiamGia, item.TenChuongTrinh, item.PhanTram, item.NgayKetThuc, item.NgayKetThuc,
        //GetTrangThaiText(item.TrangThai.Value)
        //             );
        //    }
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
            Load_DGV_SanPham(_idGGClick);
        }
        private void Load_DGV_SanPham(string id)
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
            _lstSanPham = _ser.GetSanPham(id);

            foreach (var item in _lstSanPham)
            {
                int stt = _lstSanPham.IndexOf(item) + 1;

                // Nếu id là "All" và item.isCheck là true nhưng id không tồn tại trong GiamGiaChiTiets
                if (id == "All" && item.isCheck && !_ser.CheckIdGiamGiaChiTiet(item.SanPham.IdsanPham, _idGGClick))
                {
                    item.isCheck = false; // Đặt giá trị của checkbox thành false
                }

                dgv_SanPham.Rows.Add(stt++, item.SanPham.IdsanPham, item.SanPham.TenSanPham, item.SanPham.Gia, item.SanPham.GiaSale, item.isCheck);
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
            Load_DGV_SanPham("All");
        }
        private void dgv_SanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_SanPham.Columns["chb_ApDungSP"].Index && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)dgv_SanPham.Rows[e.RowIndex].Cells[e.ColumnIndex];
                bool isChecked = (bool)cell.Value;
                if (!isChecked)
                {
                    // Ô checkbox được chọn
                    // Thực hiện các hành động tương ứng
                    MessageBox.Show("Đang được chọn");
                    cell.Value = true; // Bỏ chọn ô checkbox
                    //isChecked = false;
                }
                else
                {
                    MessageBox.Show("Bỏ chọn");
                    // Ô checkbox không được chọn
                    // Thực hiện các hành động tương ứng
                    cell.Value = false; // Chọn ô checkbox
                }
            }


        }
    }
}
