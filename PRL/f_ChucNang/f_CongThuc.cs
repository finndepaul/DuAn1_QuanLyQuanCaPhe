using BUS.IServices;
using DAL.IRepositories;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PRL.f_ChucNang
{
	public partial class f_CongThuc : Form
	{
		private readonly CongThucRepos _ct = new CongThucRepos();

		public f_CongThuc()
		{
			InitializeComponent();

		}
		private void f_CongThuc_Load(object sender, EventArgs e)
		{
			LoadDgv_NL();
			LoadLocCbb();
			LoadDgv_PC();
		}

		private void LoadLocCbb()
		{
			cbb_LocDate.Items.Add("Tất cả");
			cbb_LocDate.Items.Add("Còn hạn");
			cbb_LocDate.Items.Add("Hết hạn");
		}
		private void EmtyForm()
		{
			txt_IdNguyenLieu.Text = string.Empty;
			txt_TenNguyenLieu.Text = string.Empty;
			txt_GiaNguyenLieu.Text = string.Empty;
			txt_SoLuongNL.Text = string.Empty;
		}

		private void LoadDgv_PC()
		{
			int stt = 1;
			dgv_PhaChe.Rows.Clear();
			dgv_PhaChe.ColumnCount = 3;
			dgv_PhaChe.Columns[0].Name = "STT";
			dgv_PhaChe.Columns[1].Name = "Tên Sản Phẩm";
			dgv_PhaChe.Columns[2].Name = "Nguyên liệu cần thiết";
			foreach (var item in _ct.GetAllPC())
			{
				dgv_PhaChe.Rows.Add(stt++, item.TenSanPham, item.TenNguyenLieu);
			}

		}
		private void LoadDgv_NL()
		{
			int stt = 1;
			dgv_NguyenLieu.Rows.Clear();
			dgv_NguyenLieu.ColumnCount = 7;
			dgv_NguyenLieu.Columns[0].Name = "STT";
			dgv_NguyenLieu.Columns[1].Name = "Id";
			dgv_NguyenLieu.Columns[2].Name = "Tên";
			dgv_NguyenLieu.Columns[3].Name = "Giá";
			dgv_NguyenLieu.Columns[4].Name = "Ngày Nhập";
			dgv_NguyenLieu.Columns[5].Name = "Ngày hết hạn";
			dgv_NguyenLieu.Columns[6].Name = "Số Lượng";
			foreach (var item in _ct.GetAllNL(txt_TimKiemNL.Text, cbb_LocDate.SelectedIndex))
			{
				dgv_NguyenLieu.Rows.Add(stt++, item.IdnguyenLieu, item.TenNguyenLieu, item.Gia, item.NgayNhap
					, item.NgayHetHan, item.SoLuong);
			}
		}

		private void btn_ThemNguyenLieu_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("Bạn muốn thêm nguyên liệu này?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
				{
					var a = _ct.CreateNL(new DAL.Models.NguyenLieu
					{
						IdnguyenLieu = txt_IdNguyenLieu.Text,
						TenNguyenLieu = txt_TenNguyenLieu.Text,
						Gia = Convert.ToDouble(txt_GiaNguyenLieu.Text),
						NgayNhap = dtp_NhapNgay.Value.Date,
						NgayHetHan = dtp_HanNgay.Value.Date,
						SoLuong = Convert.ToInt32(txt_SoLuongNL.Text)
					});
					MessageBox.Show("Thành công!!!");
					LoadDgv_NL();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Lỗi rồi");
			}
		}

		private void btn_SuaNguyenLieu_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("Bạn muốn sửa nguyên liệu này?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
				{
					var a = _ct.GetByIdNL(txt_IdNguyenLieu.Text);
					a.TenNguyenLieu = txt_TenNguyenLieu.Text;
					a.NgayNhap = dtp_NhapNgay.Value.Date;
					a.NgayHetHan = dtp_HanNgay.Value.Date;
					a.Gia = Convert.ToDouble(txt_GiaNguyenLieu.Text);
					a.SoLuong = Convert.ToInt32(txt_SoLuongNL.Text);
					_ct.UpdateNL(a);
					MessageBox.Show("Thành công!!!");
					LoadDgv_NL();
					EmtyForm();
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Lỗi rồi");
			}

		}

		private void dgv_NguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				var c = dgv_NguyenLieu.Rows[e.RowIndex];
				txt_IdNguyenLieu.Text = c.Cells[1].Value.ToString();
				txt_TenNguyenLieu.Text = c.Cells[2].Value.ToString();
				txt_GiaNguyenLieu.Text = c.Cells[3].Value.ToString();
				dtp_NhapNgay.Text = c.Cells[4].Value.ToString();
				dtp_HanNgay.Text = c.Cells[5].Value.ToString();
				txt_SoLuongNL.Text = c.Cells[6].Value.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Lỗi rồi");
			}

		}

		private void btn_XoaNguyenLieu_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("Bạn muốn xóa nguyên liệu này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
				{
					var a = _ct.GetByIdNL(txt_IdNguyenLieu.Text);
					_ct.DeleteNL(a);
					MessageBox.Show("Thành công!!!");
					LoadDgv_NL();
					EmtyForm();

				}


			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Lỗi rồi");
			}


		}

		private void txt_TimKiemNL_TextChanged(object sender, EventArgs e)
		{
			LoadDgv_NL();
		}

		private void cbb_LocDate_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadDgv_NL();
		}

		private void btn_ThemPhaChe_Click(object sender, EventArgs e)
		{
			var get = _ct.CreatePC(new DAL.Models.PhaChe
			{
				IdphaChe = "PC",
				
			}) ;
		}
	}
}
