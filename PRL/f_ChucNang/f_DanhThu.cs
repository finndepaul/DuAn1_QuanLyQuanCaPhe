using BUS.Services;
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

namespace PRL.f_ChucNang
{
	public partial class f_DanhThu : Form
	{
		public DoanhThuService _res = new DoanhThuService();
		public f_DanhThu()
		{
			InitializeComponent();
			dtp_Start.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month - 1, DateTime.Now.Day);
		}

		private void f_DanhThu_Load(object sender, EventArgs e)
		{
			LoadDtgDoanhThu(dtp_Start.Value, dtp_End.Value);
			LoadRank(dtp_Start.Value, dtp_End.Value);
			LoadCbb_Loc();
		}

		private void LoadRank(DateTime start, DateTime end)
		{
			int stt = 1;
			dgv_Rank.Rows.Clear();
			dgv_Rank.ColumnCount = 4;
			dgv_Rank.Columns[0].Name = "STT";
			dgv_Rank.Columns[1].Name = "Sản phẩm";
			dgv_Rank.Columns[2].Name = "Đã bán";
			dgv_Rank.Columns[3].Name = "Loại Sản phẩm";
			foreach (var item in _res.GetSanPhamRank(cbx_LocLoaiSP.SelectedIndex, cbx_LocLoaiSP.Text, start, end))
			{
				dgv_Rank.Rows.Add(stt++, item.Idsanpham, item.Soluong, item.LoaiSanPham);
			}
		}

		private void LoadCbb_Loc()
		{
			cbx_LocLoaiSP.Items.Clear();
			cbx_LocLoaiSP.Items.Add("All");
			foreach (var item in _res.GetLoai())
			{
				cbx_LocLoaiSP.Items.Add(item);
			}
			cbx_LocLoaiSP.SelectedIndex = 0;
		}

		private void LoadDtgDoanhThu(DateTime? start, DateTime? end)
		{
			int stt = 1;
			dgv_DoanhThu.Rows.Clear();
			dgv_DoanhThu.ColumnCount = 7;
			dgv_DoanhThu.Columns[0].Name = "STT";
			dgv_DoanhThu.Columns[1].Name = "Id";
			dgv_DoanhThu.Columns[2].Name = "Tổng tiền hóa đơn";
			dgv_DoanhThu.Columns[3].Name = "Ngày Bán";
			dgv_DoanhThu.Columns[4].Name = "Nhân Viên";
			dgv_DoanhThu.Columns[5].Name = "Khách Hàng";
			dgv_DoanhThu.Columns[6].Name = "Sản Phẩm";
			double? tong = 0;
			foreach (var item in _res.GetAllHoaDon(start, end))
			{
				dgv_DoanhThu.Rows.Add(stt++, item.IdhoaDon, item.TongTien, item.NgayBan
					, item.IdnhanVien == null ? "N/A" : item.IdnhanVien,
					item.IdkhachHang == null ? "N/A" : item.IdkhachHang,
					item.IdsanPham == null ? "N/A" : item.IdsanPham);
				tong = item.TongTien + tong;
			}
			lbl_Total.Visible = true;
			lbl_Total.Text = tong.ToString();
			dgv_DoanhThu.Columns[6].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			dgv_DoanhThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgv_DoanhThu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
		}

		private void btn_Loc_Click(object sender, EventArgs e)
		{
			if (dtp_Start.Value > dtp_End.Value)
			{
				MessageBox.Show("Thời gian không hợp lệ");
			}
			else
			{
				LoadDtgDoanhThu(dtp_Start.Value, dtp_End.Value);
				LoadRank(dtp_Start.Value, dtp_End.Value);
			}

		}

		private void cbx_LocLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (dtp_Start.Value > dtp_End.Value)
			{
				MessageBox.Show("Thời gian không hợp lệ");
			}
			else
			{
				LoadRank(dtp_Start.Value, dtp_End.Value);

			}
		}

		private void btn_TrongNgay_Click(object sender, EventArgs e)
		{
			DateTime now = DateTime.Now;

			// Lấy đầu ngày từ 0h00
			DateTime startOfDay = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0);

			// Lấy cuối ngày đến 23h59
			DateTime endOfDay = new DateTime(now.Year, now.Month, now.Day, 23, 59, 59);

			LoadDtgDoanhThu(startOfDay, endOfDay);
			LoadRank(startOfDay, endOfDay);

		}

		private void btn_BayNgay_Click(object sender, EventArgs e)
		{
			DateTime now = DateTime.Now;

			// Lấy đầu ngày từ 0h00
			// Lấy đầu ngày 7 ngày trước đó
			DateTime startOfPreviousWeek = now.AddDays(-7).Date;

			LoadDtgDoanhThu(startOfPreviousWeek, now);
			LoadRank(startOfPreviousWeek, now);

		}

		private void btn_MuoiBonNgay_Click(object sender, EventArgs e)
		{
			DateTime now = DateTime.Now;

			// Lấy đầu ngày từ 0h00
			// Lấy đầu ngày 7 ngày trước đó
			DateTime startOfPreviousWeek = now.AddDays(-14).Date;

			LoadDtgDoanhThu(startOfPreviousWeek, now);
			LoadRank(startOfPreviousWeek, now);
		}
	}
}
