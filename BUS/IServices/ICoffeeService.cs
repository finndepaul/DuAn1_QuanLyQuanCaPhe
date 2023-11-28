
using DAL.Models;
using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface ICoffeeService
    {
       
        // Sản Phẩm
        public List<SanPhamVM> GetSanPhams(string searchText, string cbxLocLoaiSP, int cbxLocTrangThai);
        public bool GetImgage(string id, string fileImage);
        public bool AddSP(SanPham sanPham);
        public bool UpdateSP(string id, SanPham sanPham);
        public bool DeleteSP(string id);


        // Loại SP
        public List<LoaiSanPham> GetLoaiSanPhams();
        public bool AddLoaiSP(LoaiSanPham loaiSanPham);
        public bool UpdateLoaiSP(string id, LoaiSanPham loaiSanPham);
        public bool DeleteLoaiSP(string id);

        // Khách hàng

        public List<MemberShipRank> GetMemberShipRanks();
        public List<KhachHangVM> GetKhachHangVMs(string id);
        public bool AddKhachHang(KhachHang khachHang);
        public bool UpdateKhachHang(string id, KhachHang khachHang);
        public bool DeleteKhachHang(string id);

        //Nhân Viên

        public List<NhanVien> GetNhanViens(string id, string loc);
        public bool AddNhanVien(NhanVien nhanVien);
        public bool UpdateNhanVien(string ?id, NhanVien nhanVien);
        public bool DeleteNhanVien(string ?id);
    }
}
