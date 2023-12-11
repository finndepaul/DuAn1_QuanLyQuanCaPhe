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
using BUS.IServices;
using DAL.ViewModels;
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
		private KhachHangService _kh = new KhachHangService();

		private int _btnHeight = 180;
		private int _btnWidth = 180;

		private int _labelHeight = 50;
		private int _labelWidth = 200;

		private string _idSPWhenClick;
		private string _tenSPWhenClick;
		private int SL;
		private string _idHDCTCellClick;
		private string _idHDCellClick = null;
		private double? _tongtienSP = 0;
		string _idNhanVien;
		public f_TrangChu(string idNhanVien)
		{
			InitializeComponent();
			_idNhanVien = idNhanVien;
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

		private void LoadDGVOrder(object value)
		{
			throw new NotImplementedException();
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

		//private void cbx_LoaiSP_SelectedIndexChanged(object sender, EventArgs e)
		//{
		//    string sanPham = (string)cbx_LoaiSP.SelectedItem;

		//    if (sanPham != null)
		//    {
		//        var sp = _LSPSer.GetSanPhams(sanPham);
		//        flp_Menu.Controls.Clear();

		//        foreach (var item in sp)
		//        {
		//            if (item.SanPham.TrangThai == 1)
		//            {
		//                // Create a Panel to hold Button and Label
		//                Panel panel = new Panel();

		//                // Create a Button
		//                Button bt = new Button();
		//                bt.Name = item.SanPham.IdsanPham.ToString();

		//                if (string.IsNullOrEmpty(item.SanPham.HinhAnh))
		//                {
		//                    bt.BackgroundImage = null;
		//                }
		//                else
		//                {
		//                    bt.BackgroundImage = Image.FromFile(item.SanPham.HinhAnh);
		//                }

		//                //bt.BackgroundImage = Image.FromFile(item.SanPham.HinhAnh);
		//                bt.BackgroundImageLayout = ImageLayout.Stretch;
		//                bt.ImageAlign = ContentAlignment.TopCenter;
		//                bt.Width = _btnWidth;
		//                bt.Height = _btnHeight;

		//                bt.Click += (sender, e) =>
		//                {
		//                    _idSPWhenClick = bt.Tag.ToString();
		//                    _tenSPWhenClick = bt.Name;
		//                    lb_TenSP.Visible = true;
		//                    lb_TenSP.Text = bt.Name;
		//                    lb_Gia.Text = item.SanPham.Gia.ToString();
		//                };

		//                // Create a Label
		//                Label lbl = new Label();
		//                lbl.Dock = DockStyle.Bottom; // Set the label to dock at the bottom
		//                lbl.TextAlign = ContentAlignment.MiddleCenter; // Adjust text alignment
		//                lbl.Height = _labelHeight;
		//                lbl.Width = _labelWidth;

		//                // Check if Gia is not null or empty before assigning to the label
		//                if (item.SanPham.GiaSale != null && item.SanPham.GiaSale > 0)
		//                {
		//                    lbl.Text = $"{item.SanPham.TenSanPham}\n{decimal.Parse(item.SanPham.Gia.ToString()):C0} - {decimal.Parse(item.SanPham.GiaSale.ToString()):C0}";
		//                }
		//                else
		//                {
		//                    lbl.Text = $"{item.SanPham.TenSanPham}\n{decimal.Parse(item.SanPham.Gia.ToString()):C0}";
		//                }


		//                // Add Button and Label to the Panel
		//                panel.Controls.Add(bt);
		//                panel.Controls.Add(lbl);

		//                // Set the size of the Panel
		//                panel.Size = new Size(_btnWidth, _btnHeight + lbl.Height);

		//                // Add the Panel to the FlowLayoutPanel
		//                flp_Menu.Controls.Add(panel);
		//            }
		//            else if (item.SanPham.TrangThai == 0)
		//            {
		//                continue;
		//            }
		//            else
		//            {
		//                return;
		//            }
		//        }
		//    }
		//}

		// gạch ngang được giá nhưng mà mất hình ảnh

		//private void cbx_LoaiSP_SelectedIndexChanged(object sender, EventArgs e)
		//{
		//    string sanPham = (string)cbx_LoaiSP.SelectedItem;

		//    if (sanPham != null)
		//    {
		//        var sp = _LSPSer.GetSanPhams(sanPham);
		//        flp_Menu.Controls.Clear();

		//        foreach (var item in sp)
		//        {
		//            if (item.SanPham.TrangThai == 1)
		//            {
		//                // Create a Panel to hold Button and Labels
		//                Panel panel = new Panel();

		//                // Create a Button
		//                Button bt = new Button();
		//                bt.Name = item.SanPham.IdsanPham.ToString();

		//                if (string.IsNullOrEmpty(item.SanPham.HinhAnh))
		//                {
		//                    bt.BackgroundImage = null;
		//                }
		//                else
		//                {
		//                    bt.BackgroundImage = Image.FromFile(item.SanPham.HinhAnh);
		//                }

		//                bt.BackgroundImageLayout = ImageLayout.Stretch;
		//                bt.ImageAlign = ContentAlignment.TopCenter;
		//                bt.Width = _btnWidth;
		//                bt.Height = _btnHeight;

		//                bt.Click += (sender, e) =>
		//                {
		//                    _idSPWhenClick = bt.Name;
		//                };

		//                // Create the Labels
		//                Label lblTenSanPham = new Label();
		//                lblTenSanPham.Dock = DockStyle.Top;
		//                lblTenSanPham.TextAlign = ContentAlignment.MiddleCenter;
		//                lblTenSanPham.Height = _labelHeight;
		//                lblTenSanPham.Width = _labelWidth;
		//                lblTenSanPham.Text = item.SanPham.TenSanPham;

		//                Label lblGia = new Label();
		//                lblGia.Dock = DockStyle.Left;
		//                lblGia.TextAlign = ContentAlignment.MiddleCenter;
		//                lblGia.Height = _labelHeight;
		//                lblGia.Width = _labelWidth / 2;

		//                if (item.SanPham.GiaSale != null && item.SanPham.GiaSale > 0)
		//                {
		//                    // Strikeout the original price
		//                    lblGia.Font = new Font(lblGia.Font, FontStyle.Strikeout);
		//                    lblGia.ForeColor = Color.Black;

		//                    // Display the original price and sale price
		//                    lblGia.Text = decimal.Parse(item.SanPham.Gia.ToString()).ToString("C0");

		//                    Label lblGiaSale = new Label();
		//                    lblGiaSale.Dock = DockStyle.Right;
		//                    lblGiaSale.TextAlign = ContentAlignment.MiddleCenter;
		//                    lblGiaSale.Height = _labelHeight;
		//                    lblGiaSale.Width = _labelWidth / 2;
		//                    lblGiaSale.Text = decimal.Parse(item.SanPham.GiaSale.ToString()).ToString("C0");

		//                    panel.Controls.Add(lblGia);
		//                    panel.Controls.Add(lblGiaSale);
		//                }
		//                else
		//                {
		//                    lblGia.Text = decimal.Parse(item.SanPham.Gia.ToString()).ToString("C0");

		//                    panel.Controls.Add(lblGia);
		//                }

		//                panel.Controls.Add(lblTenSanPham);
		//                panel.Controls.Add(bt);

		//                flp_Menu.Controls.Add(panel);
		//            }
		//        }
		//    }
		//}

		//

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
							lb_Gia.Visible = true;
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
					hd.IdnhanVien = _idNhanVien;
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
					hd.IdnhanVien = _idNhanVien;
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
			txt_Voucher.Text = null;
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
			var HDCellClick = lstHoaDon[index];
			_idHDCellClick = HDCellClick.IdhoaDon;
			_tongtienSP = HDCellClick.TongTien;
			LoadDGVOrder(_idHDCellClick);
			dgv_Order.ClearSelection();
			ClearData();
			txt_TongTien.Text = HDCellClick.TongTien.ToString();
			txt_DichVuPhatSinh.ReadOnly = false;
			txt_KhachDua.ReadOnly = false;
			txt_MaThanhVien.ReadOnly = false;
			txt_Voucher.ReadOnly = false;

		}

		private void btn_ThanhToan_Click(object sender, EventArgs e)
		{
			var confirm1 = MessageBox.Show("Xác nhận thanh toán?", "Xác nhận", MessageBoxButtons.OKCancel);
			var confirm2 = DialogResult;
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
						confirm2 = MessageBox.Show("Chưa nhập số tiền khách đưa. Chọn OK để tiếp tục hoặc Cancel để quay lại", "Tiếp tục", MessageBoxButtons.OKCancel);
					}


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
								if (!String.IsNullOrEmpty(txt_MaThanhVien.Text))
								{
									if (_kh.GetKhachHangs(null).FirstOrDefault(x => x.Sdt.Equals(txt_MaThanhVien.Text)) != null)
									{
										search.Sdt = txt_MaThanhVien.Text;
									}
									else
									{
										MessageBox.Show("Không tìm thấy mã thành viên");
										return;
									}

								}
								HDrepos.UpdateHoaDon(search);
								if (!String.IsNullOrEmpty(txt_MaThanhVien.Text))
								{
									HDrepos.UpdatePointKhachHang(search.Sdt);
								}
								if (!String.IsNullOrEmpty(txt_Voucher.Text))
								{
									if (HDrepos.SearchVoucher(txt_Voucher.Text) != null)
									{
										HDrepos.UpdateSoLuongVC(txt_Voucher.Text);
									}
									else
									{
										MessageBox.Show("Không tìm thấy voucher");
										return;
									}

								}

								DichVuPhatSinh dvps = new DichVuPhatSinh();
								dvps.IdhoaDon = _idHDCellClick;
								dvps.ChiTiet = txt_ChiTietDVPS.Text;
								dvps.SoTien = Convert.ToDouble(txt_DichVuPhatSinh.Text);
								DVPSrepos.AddDVPS(dvps);

								_idHDCellClick = null;
								dgv_Order.Rows.Clear();
								txt_DichVuPhatSinh.ReadOnly = true;
								txt_ChiTietDVPS.ReadOnly = true;
								txt_MaThanhVien.ReadOnly = true;
								txt_MaThanhVien.Text = string.Empty;
								txt_Voucher.ReadOnly = true;
								LoadDGVHoaDon();
								ClearData();
							}
						}
						else
						{
							var search = HDrepos.GetHoaDonById(_idHDCellClick);
							search.TrangThai = 1;
							if (!String.IsNullOrEmpty(txt_MaThanhVien.Text))
							{
								if (_kh.GetKhachHangs(null).FirstOrDefault(x => x.Sdt.Equals(txt_MaThanhVien.Text)) != null)
								{
									search.Sdt = txt_MaThanhVien.Text;
								}
								else
								{
									MessageBox.Show("Không tìm thấy mã thành viên");
									return;
								}

							}
							HDrepos.UpdateHoaDon(search);
							if (!String.IsNullOrEmpty(txt_MaThanhVien.Text))
							{
								HDrepos.UpdatePointKhachHang(search.Sdt);
							}
							if (!String.IsNullOrEmpty(txt_Voucher.Text))
							{
								if (HDrepos.SearchVoucher(txt_Voucher.Text) != null)
								{
									HDrepos.UpdateSoLuongVC(txt_Voucher.Text);
								}
								else
								{
									MessageBox.Show("Không tìm thấy voucher");
									return;
								}

							}

							_idHDCellClick = null;
							dgv_Order.Rows.Clear();
							txt_DichVuPhatSinh.ReadOnly = true;
							txt_ChiTietDVPS.ReadOnly = true;
							txt_MaThanhVien.ReadOnly = true;
							txt_MaThanhVien.Text = string.Empty;
							txt_Voucher.ReadOnly = true;
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
			if (_idHDCellClick != null)
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
					if (String.IsNullOrEmpty(txt_Voucher.Text))
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
							txt_ChiTietDVPS.ReadOnly = false;
							MessageBox.Show("Dịch vụ phát sinh chưa đúng định dạng");
							txt_DichVuPhatSinh.Clear();
						}
					}
					else
					{
						txt_TongTien.Text = (Convert.ToDouble(CheckVoucher()) + Convert.ToDouble(txt_DichVuPhatSinh.Text)).ToString();

					}

				}
			}
			else
			{
				return;
			}
		}

		private void txt_ChiTietDVPS_TextChanged(object sender, EventArgs e)
		{

		}
		private double? CheckVoucher()
		{
			double? kq = _tongtienSP;
			string code = txt_Voucher.Text;
			var get = HDrepos.SearchVoucher(code);
			if (get != null)
			{
				if (get.DieuKienApDung <= _tongtienSP && get.TrangThai == 1)
				{
					double? phantram = get.PhanTram;
					double? kqphantram = _tongtienSP * phantram;
					kq = _tongtienSP - kqphantram;
				}
				else
				{
					MessageBox.Show("Voucher nay chua du dieu kien su dung");
					return _tongtienSP;
				}
			}

			return kq;
		}

		private void txt_Voucher_TextChanged(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(txt_DichVuPhatSinh.Text))
			{
				txt_TongTien.Text = CheckVoucher().ToString();
			}
			else
			{
				txt_TongTien.Text = (CheckVoucher() + Convert.ToDouble(txt_DichVuPhatSinh.Text)).ToString();
			}

		}
	}
}