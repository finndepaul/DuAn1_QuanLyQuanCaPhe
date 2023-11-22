
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
        // Nhân viên
        public List<NhanVien> GetNhanViens();

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


    }
}
