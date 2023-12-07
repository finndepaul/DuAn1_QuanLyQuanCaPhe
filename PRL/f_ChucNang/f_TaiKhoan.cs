using BUS.Services;
using DAL.Models;

namespace PRL.f_ChucNang
{
    public partial class f_TaiKhoan : Form
    {
        TaiKhoanService _ser = new TaiKhoanService();
        string? _idWhenClick;
        List<NhanVien> _lstnhanVien;
        public f_TaiKhoan()
        {
            InitializeComponent();
            LoadDataNhanVien("", "");
        }

        private void LoadDataNhanVien(string id, string loc)
        {
            dgv_TaiKhoan.Rows.Clear();
            dgv_TaiKhoan.ColumnCount = 6;
            dgv_TaiKhoan.Columns[0].Name = "STT";
            dgv_TaiKhoan.Columns[1].Name = "Id nhân viên";
            dgv_TaiKhoan.Columns[2].Name = "Login";
            dgv_TaiKhoan.Columns[3].Name = "Password";
            dgv_TaiKhoan.Columns[4].Name = "Role";
            dgv_TaiKhoan.Columns[5].Name = "Active";
            _lstnhanVien = _ser.GetNhanViens(id, loc);

            foreach (var item in _ser.GetNhanViens(id, loc))
            {
                int stt = _lstnhanVien.IndexOf(item) + 1;
                dgv_TaiKhoan.Rows.Add(stt++, item.IdnhanVien, item.LoginName, item.Password,
                    item.Role == true ? "Admin" : "Nhân viên", item.Active == true ? "Kích hoạt" : "Chưa kích hoạt");
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien();
            if (CheckThongTin(txt_LoginName.Text))
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu đã tồn tại. Vui lòng nhập tài khoản mới!!!");
                ClearData();
                return;
            }

            if (txt_LoginName.Text == "" || txt_Password.Text == "" || cbx_ChucVu.Items == null || cbx_TrangThai.Items == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !!!!");
                return;
            }

            if (_ser.GetNhanViens("", "").Count != 0)
            {
                var maxId = _ser.GetNhanViens("", "").Max(x => x.IdnhanVien);
                int nexid = Convert.ToInt32(maxId.Substring(2)) + 1;
                nhanVien.IdnhanVien = "NV" + nexid.ToString("D3");
            }
            else
            {
                nhanVien.IdnhanVien = "NV001";
            }

            nhanVien.LoginName = txt_LoginName.Text;
            nhanVien.Password = txt_Password.Text;
            if (cbx_ChucVu.SelectedIndex == 0)
            {
                nhanVien.Role = true;
            }
            else
            {
                nhanVien.Role = false;
            }
            if (cbx_TrangThai.SelectedIndex == 0)
            {
                nhanVien.Active = true;
            }
            else
            {
                nhanVien.Active = false;
            }
            _ser.AddNhanVien(nhanVien);
            MessageBox.Show("Lưu thông tin thành công");
            LoadDataNhanVien("", "");
            ClearData();
        }
        private bool CheckThongTin(string login)
        {
            return _ser.GetNhanViens("", "").Any(x => x.LoginName == login);
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (CheckThongTin(txt_LoginName.Text))
            {
                MessageBox.Show("Tài khoản đã tồn tại vui lòng đổi tài khoản khác!!!!");
                ClearData();
                return;
            }
            var thongBao = MessageBox.Show("Bạn muốn sửa thông tin nhân viên", "Xác nhận", MessageBoxButtons.OKCancel);
            if (thongBao == DialogResult.OK)
            {
                NhanVien nhanVien = new NhanVien();
                nhanVien.LoginName = txt_LoginName.Text;
                nhanVien.Password = txt_Password.Text;
                if (cbx_ChucVu.SelectedIndex == 0)
                {
                    nhanVien.Role = true;
                }
                else
                {
                    nhanVien.Role = false;
                }
                if (cbx_TrangThai.SelectedIndex == 0)
                {
                    nhanVien.Active = true;
                }
                else
                {
                    nhanVien.Active = false;
                }
                if (_ser.UpdateNhanVien(_idWhenClick, nhanVien))
                {
                    MessageBox.Show("Sửa thành công");
                    LoadDataNhanVien("", "");
                    _idWhenClick = null;
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                    ClearData();
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu chưa được thay đổi");
            }
        }

        private void dgv_TaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index == _ser.GetNhanViens("", "").Count)
            {
                return;
            }
            _idWhenClick = dgv_TaiKhoan.Rows[index].Cells[1].Value.ToString();
            var result = _ser.GetNhanViens("", "").First(x => x.IdnhanVien == _idWhenClick);
            txb_IdNhanVien.Text = result.IdnhanVien;
            txt_LoginName.Text = result.LoginName;
            txt_Password.Text = result.Password;
            if (result.Role == true)
            {
                cbx_ChucVu.SelectedIndex = 0;
            }
            else
            {
                cbx_ChucVu.SelectedIndex = 1;
            }
            if (result.Active == true)
            {
                cbx_TrangThai.SelectedIndex = 0;
            }
            else
            {
                cbx_TrangThai.SelectedIndex = 1;
            }
        }
        private void ClearData()
        {
            txb_IdNhanVien.Text = "";
            txt_LoginName.Text = "";
            txt_Password.Text = "";
            cbx_ChucVu.SelectedItem = null;
            cbx_TrangThai.SelectedItem = null;
            cbx_Loc.SelectedItem = null;
            txt_TimKiem.Text = "";
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txt_TimKiem.Text.Length == 0 || txt_TimKiem.Text == null)
            {
                LoadDataNhanVien(null, "");
            }
            else
            {
                LoadDataNhanVien(txt_TimKiem.Text, null);
            }
        }

        private void cbx_Loc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Loc.SelectedIndex == 0)
            {
                LoadDataNhanVien("", "");
            }
            else if (cbx_Loc.SelectedIndex == 1)
            {
                LoadDataNhanVien("", true.ToString());
            }
            else
            {
                LoadDataNhanVien("", false.ToString());
            }
        }
    }
}