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
        
        private readonly VoucherService _ser = new();
        List<Voucher> _lstvoucher;
        Da1CoffeeContext _db = new Da1CoffeeContext();
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
        }
        private void LoadDgv()
        {
            dgv_Voucher.Rows.Clear();
            int stt = 1;
            dgv_Voucher.ColumnCount = 9;
            dgv_Voucher.Columns[0].Name = "STT";
            dgv_Voucher.Columns[1].Name = "ID Voucher";
            dgv_Voucher.Columns[2].Name = "Code";
            dgv_Voucher.Columns[3].Name = "Giảm tiền";
            dgv_Voucher.Columns[4].Name = "Số lượng";
            dgv_Voucher.Columns[5].Name = "Date Start";
            dgv_Voucher.Columns[6].Name = "Date End";
            dgv_Voucher.Columns[7].Name = "Điều kiện áp dụng";
            dgv_Voucher.Columns[8].Name = "Trạng thái";


            foreach (var item in _ser.GetVouchers(txt_TimKiemVocher.Text, cbx_TrangThaiFind.SelectedIndex))
            {
                dgv_Voucher.Rows.Add(stt++, item.Idvoucher, item.Code, item.GiamTien,
                    item.SoLuong, item.DateStart, item.DateEnd, item.DieuKienApDung, item.TrangThai == 0 ? "Hết hạn" : item.TrangThai == 1 ? "Đang áp dụng" : item.TrangThai == 2 ? "Chưa áp dụng" : null);
            }
        }

        private void LoadCmbAdd()
        {
            cmb_TrangThai.Items.Clear();
            cmb_TrangThai.Items.Add("Hết hạn");
            cmb_TrangThai.Items.Add("Đang áp dụng");
            cmb_TrangThai.Items.Add("Chưa áp dụng");
        }
        private void ClearForm()
        {
            txt_IdVocher.Text = "";
            txt_MaVocher.Text = "";
            txt_GiamTien.Text = "";
            txt_SoLuong.Text = "";
            txt_DKApDung.Text = "";
            cmb_TrangThai.SelectedItem = null;
            dtpNgayBatDau.Value = DateTime.Now;
            dtpNgayKetThuc.Value = DateTime.Now;
        }

        private void f_Voucher_Load(object sender, EventArgs e)
        {
            LoadDgv();
            LoadCmbSearch();
            LoadCmbAdd();
        }

        private void dgv_Voucher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= _ser.GetVouchers(null, 10).Count)
            {
                return;
            }
            var select = dgv_Voucher.Rows[e.RowIndex];
            txt_IdVocher.Text = select.Cells[1].Value.ToString();
            txt_MaVocher.Text = select.Cells[2].Value.ToString();
            txt_GiamTien.Text = select.Cells[3].Value.ToString();
            txt_SoLuong.Text = select.Cells[4].Value.ToString();
            dtpNgayBatDau.Text = select.Cells[5].Value.ToString();
            dtpNgayKetThuc.Text = select.Cells[6].Value.ToString();
            txt_DKApDung.Text = select.Cells[7].Value.ToString();
            cmb_TrangThai.Text = select.Cells[8].Value.ToString();
        }

        private void txt_TimKiemVocher_TextChanged(object sender, EventArgs e)
        {
            LoadDgv();
        }

        private void cbx_TrangThaiFind_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDgv();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Xác nhận thêm voucher", "Xác nhận", MessageBoxButtons.OKCancel);


            if (confirmResult == DialogResult.OK)
            {

                if (txt_MaVocher.Text == "" || txt_GiamTien.Text == "" || txt_SoLuong.Text == "" || txt_DKApDung.Text == "")
                {
                    MessageBox.Show("Bạn chưa điền đầy đủ thông tin thông tin");
                    ClearForm();
                }
                else
                {

                    if (_ser.GetByCode(txt_MaVocher.Text) == null)
                    {

                        var result = _ser.AddVoucher(new Voucher
                        {
                            Code = txt_MaVocher.Text,
                            GiamTien = Convert.ToDouble(txt_GiamTien.Text),
                            SoLuong = Convert.ToInt32(txt_SoLuong.Text),
                            DateStart = dtpNgayBatDau.Value.Date,
                            DateEnd = dtpNgayKetThuc.Value.Date,
                            DieuKienApDung = txt_DKApDung.Text,
                            TrangThai = cmb_TrangThai.SelectedIndex
                        });

                        if (result)
                        {
                            MessageBox.Show("Thêm thành công");
                            LoadDgv();

                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Voucher đã có");
                    }

                }


            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Xác nhận sửa voucher", "Xác nhận", MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {
                if (txt_MaVocher.Text == "" || txt_GiamTien.Text == "" || txt_SoLuong.Text == "" || txt_DKApDung.Text == "")
                {
                    MessageBox.Show("Bạn chưa điền đầy đủ thông tin thông tin");
                    ClearForm();
                }
                var search = _ser.GetByIdVC(txt_IdVocher.Text);
                if (search == null)
                {
                    MessageBox.Show("Bạn chưa chọn");
                }
                else
                {
                    if (txt_MaVocher.Text == search.Code)
                    {
                        search.Code = txt_MaVocher.Text;
                        search.GiamTien = Convert.ToDouble(txt_GiamTien.Text);
                        search.SoLuong = Convert.ToInt32(txt_SoLuong.Text);
                        search.DateStart = dtpNgayBatDau.Value.Date;
                        search.DateEnd = dtpNgayKetThuc.Value.Date;
                        search.DieuKienApDung = txt_DKApDung.Text;
                        search.TrangThai = cmb_TrangThai.SelectedIndex;
                        var upp = _ser.UpdateVocuher(search);
                        if (upp)
                        {
                            MessageBox.Show("Sửa thành công");
                            LoadDgv();
                        }
                        else
                        {
                            MessageBox.Show("Sửa thất bại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Voucher đã có");
                    }


                }
            }
        }
    }
}
