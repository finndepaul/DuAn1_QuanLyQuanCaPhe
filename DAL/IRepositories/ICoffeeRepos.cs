
using DAL.Models;
using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface ICoffeeRepos
    {
        // Sản Phẩm
        public List<SanPhamVM> GetSanPhams(string searchText, string cbxLocLoaiSP, int cbxLocTrangThai);
        public bool GetImgage(string id, string fileImage);
        public bool AddSP(SanPham sanPham);
        public bool UpdateSP(string id,SanPham sanPham);
        public bool DeleteSP(string id);

        // Loại SP
        public List<LoaiSanPham> GetLoaiSanPhams();
        public bool AddLoaiSP(LoaiSanPham loaiSanPham);
        public bool UpdateLoaiSP(string id,LoaiSanPham loaiSanPham);
        public bool DeleteLoaiSP(string id);

        //Nhân viên
        List<NhanVien> GetNhanViens(string id, string loc);
        public bool AddNhanVien(NhanVien nhanVien);
        public bool UpdateNhanVien(string? id, NhanVien nhanVien);
        public bool DeleteNhanVien(string? id);
    }
}
