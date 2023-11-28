
using DAL.Models;
using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface IThucDonRepos
    {
        // Nhân viên
        public List<NhanVien> GetNhanViens();

        // Sản Phẩm
        public List<SanPhamVM> GetSanPhams(string searchText, string cbxLocLoaiSP, int cbxLocTrangThai);
        public bool GetImgage(string id, string fileImage);
        public bool AddSP(SanPham sanPham);
        public bool UpdateSP(string id,SanPham sanPham);
        public bool Add_RegexTenSP(string tenSP);
        public bool Update_RegexTenSP(string tenSP, string Id);

        // Loại SP
        public List<LoaiSanPham> GetLoaiSanPhams();
        public bool AddLoaiSP(LoaiSanPham loaiSanPham);
        public bool UpdateLoaiSP(string id,LoaiSanPham loaiSanPham);
        public bool Add_RegexTenLSP(string tenLSP);
        public bool Update_RegexTenLSP(string tenLSP, string Id);


    }
}
