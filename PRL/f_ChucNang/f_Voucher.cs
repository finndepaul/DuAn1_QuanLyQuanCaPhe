using BUS.Services;
using DAL.Models;
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
    public partial class f_Voucher : Form
    {
        VoucherService _ser = new VoucherService();
        List<Voucher> _lstVoucher;
        string _idVoucherClick;
        
        public f_Voucher()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            InitializeComponent();
            
        }
        private void LoadCmbSearch()
        {
            cbx_TrangThaiFind.Items.Clear();
            cbx_TrangThaiFind.Items.Add("All");
            cbx_TrangThaiFind.Items.Add("Hết hạn");
            cbx_TrangThaiFind.Items.Add("Đang áp dụng");
            cbx_TrangThaiFind.Items.Add("Chưa áp dụng");

            cbx_TrangThaiFind.SelectedIndex = 0;
        }
        private void LoadDgv(string searchText, int cbx)
        {
            dgv_Voucher.Rows.Clear();
            dgv_Voucher.ColumnCount = 9;
            dgv_Voucher.Columns[0].Name = "STT";
            dgv_Voucher.Columns[1].Name = "IDVoucher";
            dgv_Voucher.Columns[2].Name = "Code";
            dgv_Voucher.Columns[3].Name = "Phan Tram";
            dgv_Voucher.Columns[4].Name = "So Luong";
            dgv_Voucher.Columns[5].Name = "Ngay Bat Dau";
            dgv_Voucher.Columns[6].Name = "Ngay Ket Thuc";
            dgv_Voucher.Columns[7].Name = "Dieu Kien Ap Dung";
            dgv_Voucher.Columns[8].Name = "Trang Thai";
            _lstVoucher = _ser.GetVouchers(searchText,cbx);
            foreach (var item in _lstVoucher)
            {
                int stt = _lstVoucher.IndexOf(item) + 1;
                dgv_Voucher.Rows.Add(stt++, item.Idvoucher, item.Code, item.PhanTram, item.SoLuong, item.DateStart, item.DateEnd, 
                    item.DieuKienApDung, GetTrangThaiText(item.TrangThai.Value));
            }
        }
        private string GetTrangThaiText(int trangThai)
        {
            switch (trangThai)
            {
                case 0:
                    return "Hết hạn";                  
                case 1:
                    return "Đang áp dụng";
                case 2:
                    return "Chưa áp dụng";
                default:
                    return "Không xác định";
            }
        }
        private void LoadCmbAdd()
        {
            cbx_TrangThai.Items.Clear();
            cbx_TrangThai.Items.Add("Hết hạn");
            cbx_TrangThai.Items.Add("Đang áp dụng");
            cbx_TrangThai.Items.Add("Chưa áp dụng");
        }
        private void ClearForm()
        {
            txt_IdVocher.Text = "";
            txt_MaVocher.Text = "";
            txt_GiamTien.Text = "";
            txt_SoLuong.Text = "";
            txt_DKApDung.Text = "";
            cbx_TrangThai.SelectedItem = null;
            dtpNgayBatDau.Value = DateTime.Now;
            dtpNgayKetThuc.Value = DateTime.Now;
        }

        private void f_Voucher_Load(object sender, EventArgs e)
        {
            _ser.checkTrangThai();
            LoadDgv(null,4);
            LoadCmbSearch();
            LoadCmbAdd();

        }

        private void dgv_Voucher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= _lstVoucher.Count)
            {
                return;
            }
            var result = _lstVoucher[index];
            _idVoucherClick = result.Idvoucher;
            txt_IdVocher.Text = result.Idvoucher;
            txt_MaVocher.Text = result.Code;
            txt_GiamTien.Text = result.PhanTram.ToString();
            txt_SoLuong.Text = result.SoLuong.ToString();
            dtpNgayBatDau.Value = result.DateStart.Value;
            dtpNgayKetThuc.Value = result.DateEnd.Value;
            txt_DKApDung.Text = result.DieuKienApDung.ToString();
            if (result.TrangThai == 0)
            {
                cbx_TrangThai.SelectedIndex = 0;
            }
            else if(result.TrangThai == 1)
            {
                cbx_TrangThai.SelectedIndex = 1;
            }
            else if (result.TrangThai == 2)
            {
                cbx_TrangThai.SelectedIndex = 2;
            }
        }

        private void txt_TimKiemVocher_TextChanged(object sender, EventArgs e)
        {
            LoadDgv(txt_TimKiemVocher.Text,cbx_TrangThaiFind.SelectedIndex);
        }

        private void cbx_TrangThaiFind_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDgv(txt_TimKiemVocher.Text, cbx_TrangThaiFind.SelectedIndex);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var alert = MessageBox.Show("B xác nhận thêm mới Voucher", "Xác nhận", MessageBoxButtons.OKCancel);
            if (alert == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(txt_MaVocher.Text))
                {
                    MessageBox.Show("Mã voucher không được null or empty !");
                    return;

                }
                if (string.IsNullOrEmpty(txt_GiamTien.Text))
                {
                    MessageBox.Show("Phần Trăm không được null or empty !");
                    return;

                }
                if (string.IsNullOrEmpty(txt_SoLuong.Text))
                {
                    MessageBox.Show("Số lượng không được null or empty !");
                    return;

                }
                if (string.IsNullOrEmpty(txt_DKApDung.Text))
                {
                    MessageBox.Show("Điều kiện áp dụng không được null or empty !");
                    return;

                }
                if (cbx_TrangThai.SelectedIndex == null)
                {
                    MessageBox.Show("B chưa chọn trạng thái");
                    return;
                }
                if (dtpNgayBatDau.Value.Date < DateTime.Now.Date && dtpNgayKetThuc.Value.Date < DateTime.Now.Date)
                {
                    MessageBox.Show("Ngày bắt đầu và ngày kết không hợp lệ. Vui lòng chọn lại ngày để áp dụng sale!");                   
                    return;
                }
                else if (dtpNgayBatDau.Value.Date < DateTime.Now.Date)
                {
                    MessageBox.Show("Ngày bắt đầu không hợp lệ. Vui lòng chọn lại ngày để áp dụng sale!");
                    return;
                }
                var vc = new Voucher()
                {
                    Idvoucher = txt_IdVocher.Text,
                    Code = txt_MaVocher.Text,
                    PhanTram = Convert.ToDouble(txt_GiamTien.Text),
                    SoLuong = Convert.ToInt32(txt_SoLuong.Text),
                    DateStart = dtpNgayBatDau.Value,
                    DateEnd = dtpNgayKetThuc.Value,
                    DieuKienApDung = Convert.ToInt32(txt_DKApDung.Text),
                    TrangThai = cbx_TrangThai.SelectedIndex,
                };
                var result = _ser.AddVoucher(vc);
                if (result)
                {
                    MessageBox.Show("B thêm thành công");
                    LoadDgv(null, 4);
                    LoadCmbSearch();
                    ClearForm();
                    _idVoucherClick = null;
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

        private void btn_Update_Click(object sender, EventArgs e)
        {
            var alert = MessageBox.Show("B xác nhận cập nhật Voucher", "Xác nhận", MessageBoxButtons.OKCancel);
            if (alert == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(txt_MaVocher.Text))
                {
                    MessageBox.Show("Mã voucher không được null or empty !");
                    return;
                }
                if (string.IsNullOrEmpty(txt_GiamTien.Text))
                {
                    MessageBox.Show("Phần Trăm không được null or empty !");
                    return;
                }
                if (string.IsNullOrEmpty(txt_SoLuong.Text))
                {
                    MessageBox.Show("Số lượng không được null or empty !");
                    return;
                }
                if (string.IsNullOrEmpty(txt_DKApDung.Text))
                {
                    MessageBox.Show("Điều kiện áp dụng không được null or empty !");
                    return;
                }
                if (cbx_TrangThai.SelectedIndex == null)
                {
                    MessageBox.Show("B chưa chọn trạng thái");
                    return;
                }
                if (dtpNgayBatDau.Value.Date < DateTime.Now.Date && dtpNgayKetThuc.Value.Date < DateTime.Now.Date)
                {
                    MessageBox.Show("Ngày bắt đầu và ngày kết không hợp lệ. Vui lòng chọn lại ngày để áp dụng sale!");
                    return;
                }
                else if (dtpNgayBatDau.Value.Date < DateTime.Now.Date)
                {
                    MessageBox.Show("Ngày bắt đầu không hợp lệ. Vui lòng chọn lại ngày để áp dụng sale!");
                    return;
                }
                var vc = new Voucher()
                {
                    Idvoucher = txt_IdVocher.Text,
                    Code = txt_MaVocher.Text,
                    PhanTram = Convert.ToDouble(txt_GiamTien.Text),
                    SoLuong = Convert.ToInt32(txt_SoLuong.Text),
                    DateStart = dtpNgayBatDau.Value,
                    DateEnd = dtpNgayKetThuc.Value,
                    DieuKienApDung = Convert.ToInt32(txt_DKApDung.Text),
                    TrangThai = cbx_TrangThai.SelectedIndex,
                };
                //var checkvc = _ser.checkVoucher(cbx_TrangThai.SelectedIndex);
                //if (checkvc)
                //{
                //    MessageBox.Show("Đã có voucher đang được áp dụng !");
                //    return;
                //}

                var result = _ser.UpdateVocuher(_idVoucherClick,vc);
                if (result == 2)
                {
                    MessageBox.Show("Đã có voucher đang được áp dụng !");
                    return;
                }
                if (result == 0)
                {
                    MessageBox.Show("B sửa thành công");
                    LoadDgv(null, 4);
                    LoadCmbSearch();
                    ClearForm();
                    _idVoucherClick = null;
                }
                else if (result == 1)
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
