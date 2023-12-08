using BUS.Services;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.f_ChucNang
{
    public partial class f_KhachHang : Form
    {
        KhachHangService _ser = new KhachHangService();
        TaiKhoanService _serTK = new TaiKhoanService();
        string? _sdtWhenClick;
        string? _idRankClick;
        string _idNhanVienDangNhap;

        public f_KhachHang(string idNhanVien)
        {
            InitializeComponent();
            txt_IDNhanVien.Text = idNhanVien;
            _idNhanVienDangNhap = idNhanVien;
            var result = _serTK.GetNhanViens(null, null).Where(x => x.IdnhanVien == _idNhanVienDangNhap).Select(x => x.Role).FirstOrDefault();
            if (result == false)
            {
                btn_ThemMemberShip.Visible = false;
                btn_UpdateMemberShip.Visible = false;
            }
            else
            {
                btn_ThemMemberShip.Visible = true;
                btn_UpdateMemberShip.Visible = true;
            }
            LoadDataKhachHang(null);
            LoadDataMemberShip(null, null);
            LoadNameRank();
        }

        private void LoadNameRank()
        {
            var columnData = _ser.GetMemberShipRanks(null, null).Select(e => e.RankName).ToList();
            columnData.Insert(0, "All");
            cbx_TimKiemTheoRank.DataSource = columnData;
            cbx_TimKiemTheoRank.SelectedIndex = 0;
        }

        private void LoadDataMemberShip(string idRank, string nameRank)
        {
            dgv_Membership.Rows.Clear();
            dgv_Membership.ColumnCount = 5;
            dgv_Membership.Columns[0].Name = "Stt";
            dgv_Membership.Columns[1].Name = "IdRank";
            dgv_Membership.Columns[2].Name = "PointsNeed";
            dgv_Membership.Columns[3].Name = "Discount";
            dgv_Membership.Columns[4].Name = "RankName";
            foreach (var item in _ser.GetMemberShipRanks(idRank, nameRank))
            {
                int stt = _ser.GetMemberShipRanks(idRank, nameRank).IndexOf(item) + 1;
                dgv_Membership.Rows.Add(stt++, item.Idrank, item.PointsNeed, item.Discount, item.RankName);
            }
        }

        private void LoadDataKhachHang(string sdt)
        {
            dgv_KhachHang.Rows.Clear();
            dgv_KhachHang.ColumnCount = 8;
            dgv_KhachHang.Columns[0].Name = "Stt";
            dgv_KhachHang.Columns[1].Name = "SDT";
            dgv_KhachHang.Columns[2].Name = "Tên";
            dgv_KhachHang.Columns[3].Name = "Email";
            dgv_KhachHang.Columns[4].Name = "Địa chỉ";
            dgv_KhachHang.Columns[5].Name = "Point";
            dgv_KhachHang.Columns[6].Name = "Tên Rank";
            dgv_KhachHang.Columns[7].Name = "ID Nhân viên";
            foreach (var item in _ser.GetKhachHangs(sdt))
            {
                int stt = _ser.GetKhachHangs(sdt).IndexOf(item) + 1;
                var rankName = _ser.GetMemberShipRanks(null, null)
                           .FirstOrDefault(rank => rank.Idrank == item.Idrank)?.RankName;
                dgv_KhachHang.Rows.Add(stt++, item.Sdt, item.Name, item.Email, item.DiaChi, item.Point, rankName, item.IdnhanVien);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            KhachHang khachHang = new KhachHang();
            MemberShipRank memberShipRank = new MemberShipRank();
            //Thêm thông tin cho khách hàng
            if (string.IsNullOrWhiteSpace(txt_TenKhachHang.Text))
            {
                MessageBox.Show("Tên khách hàng không được để chống");
                return;
            }
            else if (!Regex.IsMatch(txt_TenKhachHang.Text.ToString(), @"^([\p{L}]+\s?)+$"))
            {
                MessageBox.Show("Tên khách hàng không hợp lệ");
                return;
            }

            else if (!Regex.IsMatch(txt_SoDienThoai.Text, @"^0\d{9}$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                return;
            }
            else if (txt_SoDienThoai.Text == null)
            {
                MessageBox.Show("Số điện thoại không được để chống");
                return;
            }
            else if (_ser.GetKhachHangs(null).Any(x => x.Sdt == txt_SoDienThoai.Text))
            {
                MessageBox.Show("Số điện thoại đã tồn tại");
                return;
            }
            else if (!Regex.IsMatch(txt_Email.Text, @"^[a-zA-Z0-9._%+-]+@gmail\.com$"))
            {
                MessageBox.Show("Email không hợp lệ");
                return;
            }
            else if (txt_Email.Text == null)
            {
                MessageBox.Show("Email không được để chống");
                return;
            }
            khachHang.Name = txt_TenKhachHang.Text;
            khachHang.Sdt = txt_SoDienThoai.Text;
            khachHang.Email = txt_Email.Text;
            khachHang.DiaChi = txt_DiaChi.Text;
            //Thêm id cho membership
            khachHang.IdnhanVien = _idNhanVienDangNhap;
            _ser.AddKhachHang(khachHang);
            MessageBox.Show("Lưu thành công (-_-)");
            LoadDataKhachHang(null);
            LoadDataMemberShip(null, null);
            Clear();
        }

        private void Clear()
        {
            txt_DiaChi.Text = "";
            txt_SoDienThoai.Text = "";
            txt_Point.Text = "";
            txt_Email.Text = "";
            txt_IDNhanVien.Text = "";
            txt_IDRank.Text = "";
            txt_TenKhachHang.Text = "";
            txt_TimKiemIdKhachHang.Text = "";
            txt_TimKiemRank.Text = "";
            txt_RankName.Text = "";
            txt_PointsNeed.Text = "";
            txt_Discount.Text = "";
            cbx_TimKiemTheoRank.SelectedIndex = 0;
        }

        private void dgv_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index == _ser.GetKhachHangs(null).Count)
            {
                return;
            }
            _sdtWhenClick = dgv_KhachHang.Rows[index].Cells[1].Value.ToString();
            var result = _ser.GetKhachHangs(null).FirstOrDefault(x => x.Sdt == _sdtWhenClick);
            if (result.Point >= 500000)
            {

                _idRankClick = dgv_KhachHang.Rows[index].Cells[6].Value.ToString();
            }
            else
            {
                _idRankClick = null;
            }
            txt_TenKhachHang.Text = result.Name;
            txt_SoDienThoai.Text = result.Sdt;
            txt_Email.Text = result.Email;
            txt_DiaChi.Text = result.DiaChi;
            txt_Point.Text = result.Point.ToString();
            txt_IDRank.Text = result.Idrank;
            txt_IDNhanVien.Text = result.IdnhanVien;
        }

        private void dgv_Membership_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index == _ser.GetMemberShipRanks(null, null).Count)
            {
                return;
            }
            _idRankClick = dgv_Membership.Rows[index].Cells[1].Value.ToString();
            var result = _ser.GetMemberShipRanks(null, null).FirstOrDefault(x => x.Idrank == _idRankClick);
            txt_RankName.Text = result.RankName;
            txt_Discount.Text = result.Discount.ToString();
            txt_PointsNeed.Text = result.PointsNeed.ToString();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            KhachHang khachHang = new KhachHang();
            if (txt_TenKhachHang.Text == null)
            {
                MessageBox.Show("Tên khách hàng không được để chống");
                Clear();
                return;
            }
            else if (!Regex.IsMatch(txt_TenKhachHang.Text.ToString(), @"^([\p{L}]+\s?)+$"))
            {
                MessageBox.Show("Tên khách hàng không hợp lệ");
                return;
            }

            else if (!Regex.IsMatch(txt_Email.Text, @"^[a-zA-Z0-9._%+-]+@gmail\.com$"))
            {
                MessageBox.Show("Email không hợp lệ");
                return;
            }
            else if (txt_Email.Text == null)
            {
                MessageBox.Show("Email không được để chống");
                Clear();
                return;
            }
            var thongBao = MessageBox.Show("Bạn có muốn thay đổi dữ liệu không", "Xác nhận", MessageBoxButtons.OKCancel);
            if (thongBao == DialogResult.OK)
            {
                //Check số điện thoại
                //if (txt_SoDienThoai.Text != _sdtWhenClick && _ser.GetKhachHangs(null).Any(x => x.Sdt != txt_SoDienThoai.Text))
                //{
                //    khachHang.Sdt = txt_SoDienThoai.Text;
                //}

                if (txt_SoDienThoai.Text != _sdtWhenClick)
                {
                    MessageBox.Show("Không thể sửa số điện thoại");
                    return;
                }
                khachHang.Name = txt_TenKhachHang.Text;
                khachHang.Email = txt_Email.Text;
                khachHang.DiaChi = txt_DiaChi.Text;
                khachHang.IdnhanVien = txt_IDNhanVien.Text;
                khachHang.Idrank = txt_IDRank.Text;
                if (_ser.UpdateKhachHang(_sdtWhenClick, khachHang))
                {
                    MessageBox.Show("Đã update thành công");
                    _sdtWhenClick = null;
                    LoadDataKhachHang(null);
                    LoadDataMemberShip(null, null);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Khách hàng chưa được update");
                    LoadDataKhachHang(null);
                    LoadDataMemberShip(null, null);
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu chưa thanh đổi");
            }
        }

        private void txt_TimKiemIdKhachHang_TextChanged(object sender, EventArgs e)
        {
            if (txt_TimKiemIdKhachHang.Text == null)
            {
                LoadDataKhachHang(null);
            }
            else
            {
                LoadDataKhachHang(txt_TimKiemIdKhachHang.Text);
            }
        }

        private void txt_TimKiemRank_TextChanged(object sender, EventArgs e)
        {
            if (txt_TimKiemRank.Text == null)
            {
                LoadDataMemberShip(null, null);
            }
            else
            {
                LoadDataMemberShip(txt_TimKiemRank.Text, null);
            }
        }

        private void cbx_TimKiemTheoRank_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_TimKiemTheoRank.SelectedIndex != 0)
            {
                if (cbx_TimKiemTheoRank.SelectedIndex == 1)
                {
                    LoadDataMemberShip(null, cbx_TimKiemTheoRank.SelectedItem.ToString());
                }
                else if (cbx_TimKiemTheoRank.SelectedIndex == 2)
                {
                    LoadDataMemberShip(null, cbx_TimKiemTheoRank.SelectedItem.ToString());
                }
                else if (cbx_TimKiemTheoRank.SelectedIndex == 3)
                {
                    LoadDataMemberShip(null, cbx_TimKiemTheoRank.SelectedItem.ToString());
                }

                else
                {
                    LoadDataMemberShip(null, cbx_TimKiemTheoRank.SelectedItem.ToString());
                }
            }
            if (cbx_TimKiemTheoRank.SelectedIndex == 0)
            {
                LoadDataMemberShip(null, null);
            }
        }

        private void btn_ThemMemberShip_Click(object sender, EventArgs e)
        {
            MemberShipRank member = new MemberShipRank();
            if (string.IsNullOrEmpty(txt_RankName.Text))
            {
                MessageBox.Show("Tên rank không đc để chống");
                return;
            }
            else if (!Regex.IsMatch(txt_RankName.Text.ToString(), @"^([\p{L}]+\s?)+$"))
            {
                MessageBox.Show("Tên rank không hợp lệ");
                return;
            }
            else if (_ser.GetMemberShipRanks(null, null).Any(x => x.RankName == txt_RankName.Text))
            {
                MessageBox.Show("Tên đã tồn tại");
                return;
            }
            else if (txt_RankName.Text != null && Regex.IsMatch(txt_RankName.Text.ToString(), @"^([\p{L}]+\s?)+$"))
            {
                member.RankName = txt_RankName.Text;
            }

            if (string.IsNullOrEmpty(txt_PointsNeed.Text))
            {
                MessageBox.Show("PointsNeed không được để chống");
                return;
            }
            else if (Convert.ToInt32(txt_PointsNeed.Text) < 0 || !Regex.IsMatch(txt_PointsNeed.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("PointsNeed không hợp lệ");
                return;
            }
            else if (_ser.GetMemberShipRanks(null, null).Any(x => x.PointsNeed == Convert.ToInt32(txt_PointsNeed.Text)))
            {
                MessageBox.Show("PointsNeed đã tồn tại");
                return;
            }

            else if (txt_PointsNeed.Text != null && Regex.IsMatch(txt_PointsNeed.Text, @"^[0-9]+$"))
            {
                member.PointsNeed = Convert.ToInt32(txt_PointsNeed.Text);
            }

            if (string.IsNullOrEmpty(txt_Discount.Text))
            {
                MessageBox.Show("Discount không được để chống");
                return;
            }
            else if (!Regex.IsMatch(txt_Discount.Text, @"^\d*\.\d+$"))
            {
                MessageBox.Show("Discount không hợp lệ");
                return;
            }
            else if (_ser.GetMemberShipRanks(null, null).Any(x => x.Discount == Convert.ToDouble(txt_Discount.Text)))
            {
                MessageBox.Show("Discount đã tồn tại");
                return;
            }
            else if (txt_Discount.Text != null && Regex.IsMatch(txt_Discount.Text, @"^\d*\.\d+$"))
            {
                member.Discount = Convert.ToDouble(txt_Discount.Text);
            }


            if (_ser.AddMemberShipRank(member))
            {
                MessageBox.Show("Lưu thành công");
                LoadDataKhachHang(null);
                LoadDataMemberShip(null, null);
                LoadNameRank();
                Clear();
            }

        }

        private void btn_UpdateMemberShip_Click(object sender, EventArgs e)
        {
            MemberShipRank member = new MemberShipRank();
            var thongBao = MessageBox.Show("Bạn có muốn thay đổi dữ liệu không", "Xác nhận", MessageBoxButtons.OKCancel);
            if (thongBao == DialogResult.OK)
            {
                var result = _ser.GetMemberShipRanks(null, null).FirstOrDefault(x => x.Idrank == _idRankClick);
                //Rank name
                if (string.IsNullOrEmpty(txt_RankName.Text))
                {
                    MessageBox.Show("Tên rank không đc để chống");
                    return;
                }
                else if (!Regex.IsMatch(txt_RankName.Text.ToString(), @"^([\p{L}]+\s?)+$"))
                {
                    MessageBox.Show("Tên rank không hợp lệ");
                    return;
                }
                else if (_ser.GetMemberShipRanks(null, null).Any(x => x.RankName != result.RankName && x.RankName == txt_RankName.Text))
                {
                    MessageBox.Show("Tên đã tồn tại");
                    return;
                }
                else if (txt_RankName.Text != null && _ser.GetMemberShipRanks(null, null).Any(x => x.RankName == result.RankName || x.RankName != txt_RankName.Text))
                {
                    member.RankName = txt_RankName.Text;
                }
                // PointsNeed
                if (string.IsNullOrEmpty(txt_PointsNeed.Text))
                {
                    MessageBox.Show("PointsNeed không được để chống");
                    return;
                }
                else if (int.Parse(txt_PointsNeed.Text) < 0 || !Regex.IsMatch(txt_PointsNeed.Text, @"^[0-9]+$"))
                {
                    MessageBox.Show("PointsNeed không hợp lệ");
                    return;
                }
                else if (_ser.GetMemberShipRanks(null, null).Any(x => x.PointsNeed != result.PointsNeed && x.PointsNeed == int.Parse(txt_PointsNeed.Text)))
                {
                    MessageBox.Show("PointsNeed đã tồn tại");
                    return;
                }
                else if (!string.IsNullOrEmpty(txt_PointsNeed.Text) && _ser.GetMemberShipRanks(null, null).Any(x => x.PointsNeed == result.PointsNeed || x.PointsNeed != int.Parse(txt_PointsNeed.Text)))
                {
                    member.PointsNeed = Convert.ToInt32(txt_PointsNeed.Text);
                }
                //Discount
                if (!Regex.IsMatch(txt_Discount.Text, @"^\d*\.\d+$"))
                {
                    MessageBox.Show("Discount không hợp lệ");
                    return;
                }
                else if (string.IsNullOrEmpty(txt_Discount.Text))
                {
                    MessageBox.Show("Discount không được để chống");
                    return;
                }
                else if (_ser.GetMemberShipRanks(null, null).Any(x => x.Discount != result.Discount && x.Discount == Convert.ToDouble(txt_Discount.Text)))
                {
                    MessageBox.Show("Discount đã tồn tại");
                    return;
                }
                else if (txt_Discount.Text != null && _ser.GetMemberShipRanks(null, null).Any(x => x.Discount == result.Discount || x.Discount != Convert.ToDouble(txt_Discount.Text)) && Regex.IsMatch(txt_Discount.Text, @"^\d*\.\d+$"))
                {
                    member.Discount = Convert.ToDouble(txt_Discount.Text);
                }




                if (_ser.UpdateMemberShip(_idRankClick, member))
                {
                    MessageBox.Show("Update thành công");
                    _idRankClick = null;
                    LoadDataKhachHang(null);
                    LoadDataMemberShip(null, null);
                    LoadNameRank();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Update thất bại");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Chưa update dữ liệu");
                Clear();
                return;
            }
        }

        
    }
}
