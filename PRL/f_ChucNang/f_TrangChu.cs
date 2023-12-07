﻿using BUS.Services;
using DAL.Models;
using DAL.Repositories;
using DAL.ViewModels;
using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;

namespace PRL
{
	public partial class f_TrangChu : Form
	{
		private Da1CoffeeContext _db = new Da1CoffeeContext();
		private ThucDonService _ser = new ThucDonService();
		private LoaiSanPhamService _LSPSer = new LoaiSanPhamService();
		private HoaDonChiTietRepos HDCTrepos = new HoaDonChiTietRepos();
		private HoaDonRepos HDrepos = new HoaDonRepos();
		private DichVuPhatSinhRepos DVPSrepos = new DichVuPhatSinhRepos();
		private List<DichVuPhatSinh> lstDVPS;
		private List<HoaDon> lstHoaDon;
		private List<HDCT_VM> lstHDCT;
		private int _btnHeight = 180;
		private int _btnWidth = 180;
		private int _labelHeight = 40;
		private int _labelWidth = 40;

		private string _idSPWhenClick;
		private string _tenSPWhenClick;
		private int SL;
		private string _idHDCTCellClick;
		private string _idHDCellClick = null;

		public f_TrangChu()
		{
			InitializeComponent();
		}

		private void f_TrangChu_Load(object sender, EventArgs e)
		{
			LoadCBX_LoaiSP();
			LoadDGVOrder(null);
			dgv_Order.Rows.Clear();
			LoadDGVHoaDon();
			txt_DichVuPhatSinh.ReadOnly = true;
			txt_KhachDua.ReadOnly = true;
			txt_MaThanhVien.ReadOnly = true;
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
						// Create a Panel to hold Button and Label
						Panel panel = new Panel();

						// Create a Label
						Label lbl = new Label();
						lbl.Dock = DockStyle.Bottom; // Set the label to dock at the bottom
						lbl.TextAlign = ContentAlignment.MiddleCenter; // Adjust text alignment
						lbl.Height = _labelHeight;
						lbl.Width = _labelWidth;

						// Check if Gia is not null or empty before assigning to the label
						if (!string.IsNullOrEmpty(item.SanPham.Gia.ToString()))
						{
							//lbl.Text = ($"{item.SanPham.TenSanPham}\n{item.SanPham.Gia}" + donvi);
							lbl.Text = ($"{item.SanPham.TenSanPham}\n{decimal.Parse(item.SanPham.Gia.ToString()):C0}");
						}
						else
						{
							lbl.Text = $"{item.SanPham.TenSanPham}\nN/A"; // Set a default value if Gia is null or empty
						}
						// Create a Button
						Button bt = new Button();
						bt.Tag = item.SanPham.IdsanPham.ToString();
						bt.Name = item.SanPham.TenSanPham.ToString();

						if (string.IsNullOrEmpty(item.SanPham.HinhAnh))
						{
							bt.BackgroundImage = null;
						}
						else
						{
							bt.BackgroundImage = Image.FromFile(item.SanPham.HinhAnh);
						}

						//bt.BackgroundImage = Image.FromFile(item.SanPham.HinhAnh);
						bt.BackgroundImageLayout = ImageLayout.Stretch;
						bt.ImageAlign = ContentAlignment.TopCenter;
						bt.Width = _btnWidth;
						bt.Height = _btnHeight;

						bt.Click += (sender, e) =>
						{
							_idSPWhenClick = bt.Tag.ToString();
							_tenSPWhenClick = bt.Name;
							lb_TenSP.Visible = true;
							lb_TenSP.Text = bt.Name;
							lb_Gia.Text = item.SanPham.Gia.ToString();
						};

						// Add Button and Label to the Panel
						panel.Controls.Add(bt);
						panel.Controls.Add(lbl);

						// Set the size of the Panel
						panel.Size = new Size(_btnWidth, _btnHeight + lbl.Height);

						// Add the Panel to the FlowLayoutPanel
						flp_Menu.Controls.Add(panel);
					}
					else if (item.SanPham.TrangThai == 0)
					{
						continue;
					}
					else
					{
						return;
					}
				}
			}
		}

		private void btn_Them_Click(object sender, EventArgs e)
		{
			var confirmResult = MessageBox.Show("Xác nhận thêm?", "Xác nhận.", MessageBoxButtons.OKCancel);
			if (confirmResult == DialogResult.OK)
			{
				if (string.IsNullOrEmpty(lb_TenSP.Text))
				{
					MessageBox.Show("Chưa chọn món.");
					return;
				}
				if (numSL.Value < 1)
				{
					MessageBox.Show("Chưa chọn số lượng.");
					return;
				}
				if (_idHDCellClick != null)
				{
					var maxIdHD = _db.HoaDons.Max(x => x.IdhoaDon);
					HoaDonChiTiet hdct = new HoaDonChiTiet();
					hdct.IdhoaDon = _idHDCellClick;
					hdct.IdsanPham = _idSPWhenClick;
					hdct.SoLuong = int.Parse(numSL.Value.ToString());
					hdct.GiaBan = double.Parse(lb_Gia.Text);
					hdct.GhiChu = txt_GhiChu.Text;
					var hdcts = HDCTrepos.AddHoaDonCT(hdct);

					var search = HDrepos.GetHoaDonById(_idHDCellClick);
					search.TongTien = 0;
					foreach (var t in lstHDCT = HDCTrepos.GetAllHoaDonCT(_idHDCellClick))
					{
						double? tong = 0;
						tong = t.GiaBan * t.SoLuong;
						search.TongTien += tong;
						var hds = HDrepos.UpdateHoaDon(search);
					}

					dgv_HoaDon.CurrentRow.Selected.Equals(_idHDCellClick);
					LoadDGVOrder(_idHDCellClick);
					dgv_Order.ClearSelection();
					LoadDGVHoaDon();
				}
				if (lstHoaDon.Count == 0)
				{
					HoaDon hd = new HoaDon();
					hd.IdnhanVien = "NV002";
					hd.TrangThai = 0;
					hd.NgayXuatDon = DateTime.Now;
					var hds = HDrepos.AddHoaDon(hd);
					HoaDonChiTiet hdct = new HoaDonChiTiet();
					var maxIdHD = _db.HoaDons.Max(x => x.IdhoaDon);
					hdct.IdhoaDon = maxIdHD;
					hdct.IdsanPham = _idSPWhenClick;
					hdct.SoLuong = int.Parse(numSL.Value.ToString());
					hdct.GiaBan = double.Parse(lb_Gia.Text);
					hdct.GhiChu = txt_GhiChu.Text;
					var hdcts = HDCTrepos.AddHoaDonCT(hdct);

					var search = HDrepos.GetHoaDonById(maxIdHD);
					search.TongTien = 0;
					foreach (var t in lstHDCT = HDCTrepos.GetAllHoaDonCT(maxIdHD))
					{
						double? tong = 0;
						tong = t.GiaBan * t.SoLuong;
						search.TongTien += tong;
						hds = HDrepos.UpdateHoaDon(search);
					}
					LoadDGVOrder(maxIdHD);
					dgv_Order.ClearSelection();
					_idHDCellClick = maxIdHD;
					LoadDGVHoaDon();
					dgv_HoaDon.CurrentRow.Selected.Equals(_idHDCellClick);
				}

				if (dgv_Order.Rows.Count == 1)
				{
					HoaDon hd = new HoaDon();
					hd.IdnhanVien = "NV002";
					hd.TrangThai = 0;
					hd.NgayXuatDon = DateTime.Now;
					var hds = HDrepos.AddHoaDon(hd);
					HoaDonChiTiet hdct = new HoaDonChiTiet();
					var maxIdHD = _db.HoaDons.Max(x => x.IdhoaDon);
					hdct.IdhoaDon = maxIdHD;
					hdct.IdsanPham = _idSPWhenClick;
					hdct.SoLuong = int.Parse(numSL.Value.ToString());
					hdct.GiaBan = double.Parse(lb_Gia.Text);
					hdct.GhiChu = txt_GhiChu.Text;
					var hdcts = HDCTrepos.AddHoaDonCT(hdct);

					var search = HDrepos.GetHoaDonById(maxIdHD);
					search.TongTien = 0;
					foreach (var t in lstHDCT = HDCTrepos.GetAllHoaDonCT(maxIdHD))
					{
						double? tong = 0;
						tong = t.GiaBan * t.SoLuong;
						search.TongTien += tong;
						hds = HDrepos.UpdateHoaDon(search);
					}

					LoadDGVOrder(maxIdHD);
					_idHDCellClick = maxIdHD;
					LoadDGVHoaDon();
					dgv_HoaDon.CurrentRow.Selected.Equals(_idHDCellClick);
				}
				ClearData();
			}
			else if (confirmResult == DialogResult.Cancel)
			{
				return;
			}
		}

		private void LoadDGVOrder(string idHD)
		{
			dgv_Order.Rows.Clear();
			dgv_Order.ColumnCount = 7;
			dgv_Order.Columns[0].Name = "STT";
			dgv_Order.Columns[1].Name = "Tên món";
			dgv_Order.Columns[2].Name = "Giá";
			dgv_Order.Columns[3].Name = "Số Lượng";
			dgv_Order.Columns[4].Name = "Ghi Chú";
			dgv_Order.Columns[5].Name = "IdHDCT";
			dgv_Order.Columns[5].Visible = false;
			dgv_Order.Columns[6].Name = "ID Hóa Đơn";
			lstHDCT = HDCTrepos.GetAllHoaDonCT(idHD);
			foreach (var item in lstHDCT)
			{
				int stt = lstHDCT.IndexOf(item) + 1;
				dgv_Order.Rows.Add(stt++, item.TenSanPham, item.GiaBan, item.SoLuong, item.GhiChu, item.IdHDCT, item.IdHD);
			}
			dgv_Order.Columns[4].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			dgv_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgv_Order.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dgv_Order.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
		}

		private void LoadDGVHoaDon()
		{
			dgv_HoaDon.Rows.Clear();
			dgv_HoaDon.ColumnCount = 6;
			dgv_HoaDon.Columns[0].Name = "STT";
			dgv_HoaDon.Columns[1].Name = "ID Hóa Đơn";
			dgv_HoaDon.Columns[2].Name = "Tổng tiền";
			dgv_HoaDon.Columns[3].Name = "Ngày tạo";
			dgv_HoaDon.Columns[4].Name = "ID Nhân viên";
			dgv_HoaDon.Columns[5].Name = "Trạng Thái";
			dgv_HoaDon.Columns[5].Visible = true;

			lstHoaDon = HDrepos.GetAllHoaDonList();
			if (lstHoaDon.Count > 0)
			{
				foreach (var item in lstHoaDon)
				{
					int stt = lstHoaDon.IndexOf(item) + 1;
					dgv_HoaDon.Rows.Add(stt++, item.IdhoaDon, item.TongTien, item.NgayXuatDon, item.IdnhanVien, item.TrangThai == 0 ? "Chưa thanh toán" : null);
				}

				dgv_HoaDon.ClearSelection();
				if (_idHDCellClick != null)
				{
					foreach (DataGridViewRow row in dgv_HoaDon.Rows)
					{
						if (row.Cells[1].ToString() == _idHDCellClick)
						{
							row.Selected = true;
							break;
						}
						else
						{
							break;
						}
					}
				}
			}
			else
			{
				return;
			}
		}

		private void btn_Xoa_Click(object sender, EventArgs e)
		{
			var confirmResult = MessageBox.Show("Xac nhan xoa", "Xac nhan", MessageBoxButtons.OKCancel);

			if (confirmResult == DialogResult.OK)
			{
				if (_idHDCTCellClick == null)
				{
					MessageBox.Show("Chưa chọn món");
				}
				else
				{
					var result = HDCTrepos.DeleteHoaDonCT(_idHDCTCellClick);
					lstHDCT = HDCTrepos.GetAllHoaDonCT(_idHDCellClick);
					if (lstHDCT.Count == 0)
					{
						var x = HDrepos.GetHoaDonById(_idHDCellClick);
						HDrepos.DeleteHoaDon(x);
					}
					var search = HDrepos.GetHoaDonById(_idHDCellClick);

					if (search != null)
					{
						search.TongTien = 0;
					}
					foreach (var t in lstHDCT = HDCTrepos.GetAllHoaDonCT(_idHDCellClick))
					{
						double? tong = 0;
						tong = t.GiaBan * t.SoLuong;
						search.TongTien += tong;
						var hds = HDrepos.UpdateHoaDon(search);
					}
					if (lstHoaDon.Count == 0)
					{
						_idHDCTCellClick = null;
						_idHDCellClick = null;
					}

					MessageBox.Show("Xóa thành công");
					LoadDGVOrder(_idHDCellClick);
					LoadDGVHoaDon();
					dgv_HoaDon.ClearSelection();
					dgv_Order.ClearSelection();
					ClearData();
				}
			}
			else
			{
				return;
			}
		}

		private void dgv_Order_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;

			if (index < 0 || index >= lstHDCT.Count)
			{
				return;
			}
			var objCellClick = lstHDCT[index];
			_idHDCTCellClick = objCellClick.IdHDCT;
			_idHDCellClick = objCellClick.IdHD;
			lb_TenSP.Text = objCellClick.TenSanPham;
			decimal sl = Convert.ToDecimal(objCellClick.SoLuong);
			numSL.Value = sl;
			lb_Gia.Text = objCellClick.GiaBan.ToString();
		}

		private void dgv_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;

			if (index < 0 || index >= lstHoaDon.Count)
			{
				return;
			}
			var objCellClick = lstHoaDon[index];
			_idHDCellClick = objCellClick.IdhoaDon;

			LoadDGVOrder(_idHDCellClick);
			dgv_Order.ClearSelection();
			ClearData();
			txt_TongTien.Text = objCellClick.TongTien.ToString();
			txt_DichVuPhatSinh.ReadOnly = false;
			txt_KhachDua.ReadOnly = false;
			txt_MaThanhVien.ReadOnly = false;
		}

		private void btn_ThanhToan_Click(object sender, EventArgs e)
		{
			var confirm1 = MessageBox.Show("Xác nhận thanh toán?", "Xác nhận", MessageBoxButtons.OKCancel);

			if (confirm1 == DialogResult.OK)
			{
				if (_idHDCellClick == null)
				{
					MessageBox.Show("Chưa chọn hóa đơn");
				}
				else
				{
					if (String.IsNullOrEmpty(txt_KhachDua.Text))
					{
						var confirm2 = MessageBox.Show("Chưa nhập số tiền khách đưa. Chọn OK để tiếp tục hoặc Cancel để quay lại", "Tiếp tục", MessageBoxButtons.OKCancel);
						if (confirm2 == DialogResult.OK)
						{
							if (txt_ChiTietDVPS.ReadOnly == false)
							{
								if (String.IsNullOrEmpty(txt_ChiTietDVPS.Text))
								{
									MessageBox.Show("Chưa nhập chi tiết dịch vụ phát sinh");
								}
								else
								{
									var search = HDrepos.GetHoaDonById(_idHDCellClick);

									search.TrangThai = 1;
									search.TongTien = Convert.ToDouble(txt_TongTien.Text);
									HDrepos.UpdateHoaDon(search);

									DichVuPhatSinh dvps = new DichVuPhatSinh();
									dvps.IdhoaDon = _idHDCellClick;
									dvps.ChiTiet = txt_ChiTietDVPS.Text;
									dvps.SoTien = Convert.ToDouble(txt_DichVuPhatSinh.Text);
									DVPSrepos.AddDVPS(dvps);

									_idHDCellClick = null;
									dgv_Order.Rows.Clear();
									txt_DichVuPhatSinh.ReadOnly = true;
									LoadDGVHoaDon();
									ClearData();
								}
							}
							else
							{
								var search = HDrepos.GetHoaDonById(_idHDCellClick);
								search.TrangThai = 1;
								HDrepos.UpdateHoaDon(search);
								_idHDCellClick = null;
								dgv_Order.Rows.Clear();
								txt_DichVuPhatSinh.ReadOnly = true;
								LoadDGVHoaDon();
								ClearData();
							}
						}
						else
						{
							return;
						}
					}
				}
			}
			else
			{
				return;
			}
		}

		private void btn_Cho_Click(object sender, EventArgs e)
		{
			dgv_Order.Rows.Clear();
			lb_TenSP.Text = null;
			numSL.Value = 0;
			lb_Gia.Text = null;
			_idHDCellClick = null;
			dgv_HoaDon.ClearSelection();
			ClearData();
			txt_DichVuPhatSinh.ReadOnly = true;
			txt_KhachDua.ReadOnly = true;
			txt_MaThanhVien.ReadOnly = true;
		}

		private void ClearData()
		{
			lb_Gia.Text = null;
			lb_TenSP.Text = null;
			numSL.Value = 0;
			txt_KhachDua.Text = null;
			txt_TraLai.Text = null;
			txt_TongTien.Text = null;
			txt_DichVuPhatSinh.Text = null;
			txt_ChiTietDVPS.Text = null;
		}

		private void btn_Sua_Click(object sender, EventArgs e)
		{
			var confirmResult = MessageBox.Show("Xác nhận sửa", "Xác nhận", MessageBoxButtons.OKCancel);

			if (confirmResult == DialogResult.OK)
			{
				if (_idHDCTCellClick == null)
				{
					MessageBox.Show("Chưa chọn món");
				}
				else
				{
					if (numSL.Value == 0)
					{
						MessageBox.Show("Số lượng phải lớn hơn 0");
					}
					else
					{
						var hdcts = HDCTrepos.GetHoaDonCTById(_idHDCTCellClick);
						hdcts.GhiChu = txt_GhiChu.Text;
						hdcts.SoLuong = int.Parse(numSL.Value.ToString());
						HDCTrepos.UpdateHoaDonCT(hdcts);
						var search = HDrepos.GetHoaDonById(_idHDCellClick);
						search.TongTien = 0;

						foreach (var t in lstHDCT = HDCTrepos.GetAllHoaDonCT(_idHDCellClick))
						{
							double? tong = 0;
							tong = t.GiaBan * t.SoLuong;
							search.TongTien += tong;
							var hds = HDrepos.UpdateHoaDon(search);
						}
						MessageBox.Show("Sửa thành công");
						LoadDGVOrder(_idHDCellClick);
						LoadDGVHoaDon();
						dgv_HoaDon.CurrentRow.Selected.Equals(_idHDCellClick);
						ClearData();
						//txt_TongTien.Text = search.TongTien.ToString();
					}
				}
			}
			else
			{
				return;
			}
		}

		private void txt_KhachDua_TextChanged(object sender, EventArgs e)
		{
			if (txt_TongTien.Text == null)
			{
				return;
			}
			string khachdua = txt_KhachDua.Text.ToString();
			if (Regex.IsMatch(khachdua, @"^\d+$") && !String.IsNullOrEmpty(khachdua))
			{
				string tratien = (Convert.ToInt32(txt_KhachDua.Text.Trim()) - Convert.ToInt32(txt_TongTien.Text.Trim())).ToString();
				txt_TraLai.Text = tratien.ToString();
			}
			else
			{
				txt_TraLai.Text = "Không tính được";
			}
		}

		private double? tongtien = 0;


		private void txt_DichVuPhatSinh_TextChanged(object sender, EventArgs e)
		{	
			if(_idHDCellClick != null) 
			{
				var get = HDrepos.GetHoaDonById(_idHDCellClick);
				tongtien = get.TongTien;
				if (String.IsNullOrEmpty(txt_DichVuPhatSinh.Text))
				{
					txt_ChiTietDVPS.ReadOnly = true;
					txt_TongTien.Text = get.TongTien.ToString();
					return;
				}
				else
				{
					if (Regex.IsMatch(txt_DichVuPhatSinh.Text, @"^\d+$") && !String.IsNullOrEmpty(txt_DichVuPhatSinh.Text))
					{
						txt_ChiTietDVPS.ReadOnly = false;
						double? tienNew = 0;
						double dvps = Convert.ToDouble(txt_DichVuPhatSinh.Text);
						tienNew = tongtien + dvps;
						txt_TongTien.Text = tienNew.ToString();
					}
					else
					{
						MessageBox.Show("Dịch vụ phát sinh chưa đúng định dạng");
						txt_DichVuPhatSinh.Clear();
					}
				}
			}
			else
			{
				return;
			}
			
		}

		private void txt_Voucher_TextChanged(object sender, EventArgs e)
		{
		}

		private void txt_ChiTietDVPS_TextChanged(object sender, EventArgs e)
		{
			
		}
	}
}