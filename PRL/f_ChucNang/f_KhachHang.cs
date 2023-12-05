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
        string? _sdtWhenClick;
        string? _idRankClick;

        public f_KhachHang(string idNhanVien)
        {
            InitializeComponent();
            txt_IDNhanVien.Text = idNhanVien;
            LoadDataKhachHang(null);
            LoadDataMemberShip(null, null);
            LoadNameRank();
        }

        private void f_KhachHang_Load(object sender, EventArgs e)
        {

        }
        public void LoadNameRank()
        {
            cbx_TimKiemTheoRank.Items.Clear();
            cbx_TimKiemTheoRank.Items.Add("All");
            cbx_TimKiemTheoRank.Items.Add("Chưa sếp hạng rank");
            cbx_TimKiemTheoRank.Items.Add("Rank đồng");
            cbx_TimKiemTheoRank.Items.Add("Rank bạc");
            cbx_TimKiemTheoRank.Items.Add("Ranks vàng");
            cbx_TimKiemTheoRank.Items.Add("Ranks kim cương");
        }

        private void LoadDataKhachHang(string sdt)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "Stt";
            dataGridView1.Columns[1].Name = "SDT";
            dataGridView1.Columns[2].Name = "Tên";
            dataGridView1.Columns[3].Name = "Email";
            dataGridView1.Columns[4].Name = "Địa chỉ";
            dataGridView1.Columns[5].Name = "Point";
            dataGridView1.Columns[6].Name = "IDRank";
            dataGridView1.Columns[7].Name = "ID Nhân viên";
            foreach (var item in _ser.GetKhachHangs(sdt))
            {
                int stt = _ser.GetKhachHangs(sdt).IndexOf(item) + 1;
                dataGridView1.Rows.Add(stt++, item.Sdt, item.Name, item.Email, item.DiaChi, item.Point, item.Idrank, item.IdnhanVien);
            }
        }

        private void LoadDataMemberShip(string idRank, string nameRank)
        {
            dataGridView2.Rows.Clear();
            dataGridView2.ColumnCount = 5;
            dataGridView2.Columns[0].Name = "Stt";
            dataGridView2.Columns[1].Name = "IdRank";
            dataGridView2.Columns[2].Name = "PointsNeed";
            dataGridView2.Columns[3].Name = "Discount";
            dataGridView2.Columns[4].Name = "RankName";
            foreach (var item in _ser.GetMemberShipRanks(idRank, nameRank))
            {
                int stt = _ser.GetMemberShipRanks(idRank, nameRank).IndexOf(item) + 1;
                dataGridView2.Rows.Add(stt++, item.Idrank, item.PointsNeed, item.Discount, item.RankName);
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
            if (_ser.GetMemberShipRanks(null, null).Count != 0)
            {
                var maxid = _ser.GetMemberShipRanks(null, null).Max(x => x.Idrank);
                int index = Convert.ToInt32(maxid.Substring(2)) + 1;
                memberShipRank.Idrank = "KH" + index.ToString("D3");
            }
            else
            {
                memberShipRank.Idrank = "KH001";
            }
            _ser.AddMemberShipRank(txt_SoDienThoai.Text, memberShipRank);
            khachHang.Idrank = _ser.GetMemberShipRanks(null, null).Max(x => x.Idrank);
            khachHang.IdnhanVien = txt_IDNhanVien.Text;
            _ser.AddKhachHang(khachHang);
            MessageBox.Show("Lưu thành công (-_-)");
            LoadDataKhachHang(null);
            LoadDataMemberShip(null, null);
            Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index == _ser.GetKhachHangs(null).Count)
            {
                return;
            }
            _sdtWhenClick = dataGridView1.Rows[index].Cells[1].Value.ToString();
            _idRankClick = dataGridView1.Rows[index].Cells[6].Value.ToString();
            var result = _ser.GetKhachHangs(null).FirstOrDefault(x => x.Sdt == _sdtWhenClick);
            txt_TenKhachHang.Text = result.Name;
            txt_SoDienThoai.Text = result.Sdt;
            txt_Email.Text = result.Email;
            txt_DiaChi.Text = result.DiaChi;
            txt_Point.Text = result.Point.ToString();
            txt_IDRank.Text = result.Idrank;
            txt_idNVClick.Text = result.IdnhanVien;
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index == _ser.GetMemberShipRanks(null, null).Count)
            {
                return;
            }
            _idRankClick = dataGridView2.Rows[index].Cells[1].Value.ToString();
            var result = _ser.GetKhachHangs(null).FirstOrDefault(x => x.Idrank == _idRankClick);
            txt_TenKhachHang.Text = result.Name;
            txt_SoDienThoai.Text = result.Sdt;
            txt_Email.Text = result.Email;
            txt_DiaChi.Text = result.DiaChi;
            txt_Point.Text = result.Point.ToString();
            txt_IDRank.Text = result.Idrank;
            txt_idNVClick.Text = result.IdnhanVien;
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            KhachHang khachHang = new KhachHang();
            MemberShipRank memberShipRank = new MemberShipRank();
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
                
                if(txt_SoDienThoai.Text != _sdtWhenClick)
                {
                    MessageBox.Show("Không thể sửa số điện thoại");
                    return;
                }
                khachHang.Name = txt_TenKhachHang.Text;
                khachHang.Email = txt_Email.Text;
                khachHang.DiaChi = txt_DiaChi.Text;
                khachHang.IdnhanVien = txt_idNVClick.Text;
                if (_ser.UpdateKhachHang(_sdtWhenClick, khachHang) && _ser.UpdateMemberShip(_idRankClick, _sdtWhenClick))
                {
                    MessageBox.Show("Sửa thành công");
                    _idRankClick = null;
                    _sdtWhenClick = null;
                    LoadDataKhachHang(null);
                    LoadDataMemberShip(null, null);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu chưa thanh đổi");
            }
        }
        public void Clear()
        {
            txt_DiaChi.Text = "";
            txt_SoDienThoai.Text = "";
            txt_Point.Text = "";
            txt_Email.Text = "";
            txt_idNVClick.Text = "";
            txt_IDRank.Text = "";
            txt_TenKhachHang.Text = "";
            txt_TimKiemIdKhachHang.Text = "";
            txt_TimKiemRank.Text = "";
            cbx_TimKiemTheoRank.SelectedIndex = 0;
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
            //if (txt_TimKiemRank.Text != null && cbx_TimKiemTheoRank.SelectedIndex != 0)
            //{
            //    if (cbx_TimKiemTheoRank.SelectedIndex == 1)
            //    {
            //        LoadDataMemberShip(txt_TimKiemRank.Text, "Chưa sếp hạng rank");
            //    }
            //    else if (cbx_TimKiemTheoRank.SelectedIndex == 2)
            //    {
            //        LoadDataMemberShip(txt_TimKiemRank.Text, "Rank đồng");
            //    }
            //    else if (cbx_TimKiemTheoRank.SelectedIndex == 3)
            //    {
            //        LoadDataMemberShip(txt_TimKiemRank.Text, "Rank bạc");
            //    }
            //    else if (cbx_TimKiemTheoRank.SelectedIndex == 4)
            //    {
            //        LoadDataMemberShip(txt_TimKiemRank.Text, "Ranks vàng");
            //    }
            //    else
            //    {
            //        LoadDataMemberShip(txt_TimKiemRank.Text, "Ranks kim cương");
            //    }
            //}
            //else if (txt_TimKiemRank.Text != null)
            //{
            //    LoadDataMemberShip(txt_TimKiemRank.Text, null);
            //}
            //else if (cbx_TimKiemTheoRank.SelectedIndex != 0)
            //{
            //    if (cbx_TimKiemTheoRank.SelectedIndex == 1)
            //    {
            //        LoadDataMemberShip(null, "Chưa sếp hạng rank");
            //    }
            //    else if (cbx_TimKiemTheoRank.SelectedIndex == 2)
            //    {
            //        LoadDataMemberShip(null, "Rank đồng");
            //    }
            //    else if (cbx_TimKiemTheoRank.SelectedIndex == 3)
            //    {
            //        LoadDataMemberShip(null, "Rank bạc");
            //    }
            //    else if (cbx_TimKiemTheoRank.SelectedIndex == 4)
            //    {
            //        LoadDataMemberShip(null, "Ranks vàng");
            //    }
            //    else
            //    {
            //        LoadDataMemberShip(null, "Ranks kim cương");
            //    }
            //}
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
            //if (txt_TimKiemRank.Text != null && cbx_TimKiemTheoRank.SelectedIndex != 0)
            //{
            //    if (cbx_TimKiemTheoRank.SelectedIndex == 1)
            //    {
            //        LoadDataMemberShip(txt_TimKiemRank.Text, "Chưa sếp hạng rank");
            //    }
            //    else if (cbx_TimKiemTheoRank.SelectedIndex == 2)
            //    {
            //        LoadDataMemberShip(txt_TimKiemRank.Text, "Rank đồng");
            //    }
            //    else if (cbx_TimKiemTheoRank.SelectedIndex == 3)
            //    {
            //        LoadDataMemberShip(txt_TimKiemRank.Text, "Rank bạc");
            //    }
            //    else if (cbx_TimKiemTheoRank.SelectedIndex == 4)
            //    {
            //        LoadDataMemberShip(txt_TimKiemRank.Text, "Ranks vàng");
            //    }
            //    else
            //    {
            //        LoadDataMemberShip(txt_TimKiemRank.Text, "Ranks kim cương");
            //    }
            //}
            //else if (txt_TimKiemRank.Text != null)
            //{
            //    LoadDataMemberShip(txt_TimKiemRank.Text, null);
            //}
            if (cbx_TimKiemTheoRank.SelectedIndex != 0)
            {
                if (cbx_TimKiemTheoRank.SelectedIndex == 1)
                {
                    LoadDataMemberShip(null, "Chưa sếp hạng rank");
                }
                else if (cbx_TimKiemTheoRank.SelectedIndex == 2)
                {
                    LoadDataMemberShip(null, "Rank đồng");
                }
                else if (cbx_TimKiemTheoRank.SelectedIndex == 3)
                {
                    LoadDataMemberShip(null, "Rank bạc");
                }
                else if (cbx_TimKiemTheoRank.SelectedIndex == 4)
                {
                    LoadDataMemberShip(null, "Ranks vàng");
                }
                else
                {
                    LoadDataMemberShip(null, "Ranks kim cương");
                }
            }
            if (cbx_TimKiemTheoRank.SelectedIndex == 0)
            {
                LoadDataMemberShip(null, null);
            }
        }
    }
}
