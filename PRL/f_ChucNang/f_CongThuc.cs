using BUS.Services;
using DAL.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System.Data;
using System.Windows.Forms;

namespace PRL.f_ChucNang
{
	public partial class f_CongThuc : Form
	{
		private readonly CongThucService _ct = new CongThucService();


		public f_CongThuc()
		{
			InitializeComponent();

		}
		private void f_CongThuc_Load(object sender, EventArgs e)
		{
			LoadDgv_NL();
			LoadDgv_PC();
			LoadCbbSanPham();
			LoadCbbNguyenLieu();
		}



		private void LoadCbbNguyenLieu()
		{
			cbx_NguyenLieu.Items.Clear();
			var c = _ct.GetAllNL(null);
			var b = c.Select(x => x.TenNguyenLieu);
			foreach (var item in b)
			{
				cbx_NguyenLieu.Items.Add(item);
			}
		}

		private void LoadCbbSanPham()
		{
			cbx_SanPham.Items.Clear();
			var c = _ct.GetAllSanPham();
			var b = c.Select(x => x.TenSanPham);
			foreach (var item in b)
			{
				cbx_SanPham.Items.Add(item);
			}
		}
		private void EmtyFormNguyenLieu()
		{
			txt_IdNguyenLieu.Text = string.Empty;
			txt_TenNguyenLieu.Text = string.Empty;
			txt_Gia.Text = string.Empty;
			txt_SoLuong.Text = string.Empty;
		}
		private void EmtyFormPhaChes()
		{
			cbx_SanPham.Text = string.Empty;
			cbx_NguyenLieu.Text = string.Empty;
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
			dgv_PhaChe.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			dgv_PhaChe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgv_PhaChe.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
		}
		private void LoadDgv_NL()
		{
			int stt = 1;
			dgv_NguyenLieu.Rows.Clear();
			dgv_NguyenLieu.ColumnCount = 5;
			dgv_NguyenLieu.Columns[0].Name = "STT";
			dgv_NguyenLieu.Columns[1].Name = "Id";
			dgv_NguyenLieu.Columns[2].Name = "Tên";
			dgv_NguyenLieu.Columns[3].Name = "Giá";
			dgv_NguyenLieu.Columns[4].Name = "Số Lượng";
			foreach (var item in _ct.GetAllNL(txt_TimKiemNL.Text))
			{
				dgv_NguyenLieu.Rows.Add(stt++, item.IdnguyenLieu, item.TenNguyenLieu, item.Gia
					, item.SoLuong);
			}
		}

		private void btn_ThemNguyenLieu_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("Bạn muốn thêm nguyên liệu này?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
				{
					if (_ct.GetByNameNL(txt_TenNguyenLieu.Text) == null)
					{
						var a = _ct.CreateNL(new DAL.Models.NguyenLieu
						{
							TenNguyenLieu = txt_TenNguyenLieu.Text,
							Gia = Convert.ToDouble(txt_Gia.Text),
							SoLuong = Convert.ToInt32(txt_SoLuong.Text)
						});
						MessageBox.Show("Thành công!!!");
					}
					else
					{
						MessageBox.Show("Nguyên liệu này đã có");
					}
					LoadDgv_NL();
					LoadCbbNguyenLieu();
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

					var check = Update_RegexTenNl(txt_TenNguyenLieu.Text, txt_IdNguyenLieu.Text);
					if (!check)
					{
						MessageBox.Show("Tên nguyên liệu này đã có");
						return;
					}
					a.TenNguyenLieu = txt_TenNguyenLieu.Text;
					a.Gia = Convert.ToDouble(txt_Gia.Text);
					a.SoLuong = Convert.ToInt32(txt_SoLuong.Text);
					_ct.UpdateNL(a);
					MessageBox.Show("Thành công!!!");
					LoadDgv_NL();
					LoadDgv_PC();
					EmtyFormNguyenLieu();
					LoadCbbNguyenLieu();
				}

			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Lỗi rồi");
			}

		}

		public bool Update_RegexTenNl(string tennl, string Id)
		{
			// Lấy sản phẩm có id = id
			//SanPham sp = _db.SanPhams.FirstOrDefault(x => x.IdsanPham == Id);
			var nl = _ct.GetByIdNL(Id);
			// Nếu sản phẩm không tồn tại
			if (nl == null)
			{
				return false;
			}

			// Kiểm tra xem tên sản phẩm mới có trùng với tên sản phẩm của sản phẩm khác hay không
			//var result = _db.SanPhams.FirstOrDefault(x => x.TenSanPham == tenSP && x.IdsanPham != Id);
			var regex = _ct.CheckNameUpadte(tennl, Id);

			if (regex != null)
			{
				return false;
			}
			return true;
		}
		private void dgv_NguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;
			if (index < 0 || index >= _ct.GetAllNL(null).Count)
			{
				return;
			}
			var c = dgv_NguyenLieu.Rows[e.RowIndex];
			txt_IdNguyenLieu.Text = c.Cells[1].Value.ToString();
			txt_TenNguyenLieu.Text = c.Cells[2].Value.ToString();
			txt_Gia.Text = c.Cells[3].Value.ToString();
			txt_SoLuong.Text = c.Cells[4].Value.ToString();



		}



		private void txt_TimKiemNL_TextChanged(object sender, EventArgs e)
		{
			LoadDgv_NL();
		}

		private void btn_ThemPhaChe_Click(object sender, EventArgs e)
		{
			if (cbx_SanPham.SelectedItem == null || cbx_NguyenLieu.SelectedItem == null)
			{
				MessageBox.Show("Bạn chưa chọn!!!");
			}
			else
			{
				var getSP = _ct.GetByName(cbx_SanPham.SelectedItem.ToString());
				var idSanPham = getSP.IdsanPham;
				var getNL = _ct.GetByNameNL(cbx_NguyenLieu.SelectedItem.ToString());
				var idNguyenLieu = getNL.IdnguyenLieu;
				var getpc = _ct.GetByIdSP_IdNL(idSanPham, idNguyenLieu);
				if (getpc == null)
				{
					var get = _ct.CreatePC(new DAL.Models.PhaChe
					{
						IdsanPham = idSanPham,
						IdnguyenLieu = idNguyenLieu
					});
				}
				else
				{
					MessageBox.Show("Nguyên liệu này đã được thêm rồi");
				}

				LoadDgv_PC();
			}
		}


		private void dgv_PhaChe_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;
			if (index < 0 || index >= _ct.GetAllPC().Count)
			{
				return;
			}
			cbx_NguyenLieu.Items.Clear();
			cbx_SanPham.Items.Clear();
			var selected = dgv_PhaChe.Rows[e.RowIndex];
			var nl = selected.Cells[2].Value.ToString();
			string[] nls = nl.Split(",");
			cbx_NguyenLieu.Items.AddRange(nls);
			cbx_SanPham.Items.Add(selected.Cells[1].Value);
			cbx_SanPham.SelectedIndex = 0;
			cbx_NguyenLieu.SelectedIndex = 0;


		}

		private void btn_XoaPhaChe_Click(object sender, EventArgs e)
		{

			if (cbx_SanPham.SelectedItem == null && cbx_NguyenLieu.SelectedItem == null)
			{
				MessageBox.Show("Bạn chưa chọn sản phẩm và nguyên liệu!!!");
			}
			else if (cbx_SanPham.SelectedItem == null)
			{
				MessageBox.Show("Bạn chưa chọn sản phẩm!!!");
			}
			else if (cbx_NguyenLieu.SelectedItem == null)
			{
				MessageBox.Show("Bạn chưa chọn nguyên liệu!!!");
			}
			else
			{
				var getsp = _ct.GetByName(cbx_SanPham.SelectedItem.ToString());
				var sidsp = getsp.IdsanPham;
				var getnl = _ct.GetByNameNL(cbx_NguyenLieu.SelectedItem.ToString());
				var sidnl = getnl.IdnguyenLieu;
				var getpc = _ct.GetByIdSP_IdNL(sidsp, sidnl);
				if (getpc == null)
				{
					MessageBox.Show("Nguyên liệu này không tồn tại trong công thức pha chế");
				}
				else
				{
					var sidpc = getpc.IdphaChe;

					var getpcs = _ct.GetByIdPC(sidpc);
					if (_ct.GetByIdSP_PC(sidsp).Count == 1)
					{
						if (MessageBox.Show("Bạn muốn xóa pha chế sản phẩm này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
						{
							var del = _ct.DeletePC(getpcs);
							EmtyFormPhaChes();
						}
					}
					else
					{
						var del = _ct.DeletePC(getpcs);
						cbx_NguyenLieu.Items.Remove(cbx_NguyenLieu.SelectedItem);

					}
					LoadDgv_PC();
				}

			}


		}

		private void btn_Reset_Click(object sender, EventArgs e)
		{
			LoadCbbSanPham();
			LoadCbbNguyenLieu();
		}

		private void btn_XoaPC_Click(object sender, EventArgs e)
		{
			if (cbx_SanPham.SelectedItem == null || cbx_NguyenLieu.SelectedItem == null)
			{
				MessageBox.Show("Bạn chưa chọn!!!");
			}
			else
			{
				if (MessageBox.Show("Bạn muốn xóa pha chế sản phẩm này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
				{
					var getsp = _ct.GetByName(cbx_SanPham.SelectedItem.ToString());
					var sidsp = getsp.IdsanPham;
					var search = _ct.GetByIdSP_PC(sidsp);
					if (search.Count != 0)
					{
						_ct.DeleteAllPhaChe(search);
						MessageBox.Show("Xóa thành công");
						EmtyFormPhaChes();
						LoadCbbSanPham();
						LoadCbbNguyenLieu();
						LoadDgv_PC();
					}
					else
					{
						MessageBox.Show("Sản phẩm này không tồn tại trong công Nguyên liệu chế");

					}
				}
			}


		}
	}
}