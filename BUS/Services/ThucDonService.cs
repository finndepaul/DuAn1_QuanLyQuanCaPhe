using BUS.IServices;
using DAL.Models;
using DAL.Repositories;
using DAL.ViewModels;

namespace BUS.Services
{
    public class ThucDonService : IThucDonService
    {
        private ThucDonRepos _res;

        public ThucDonService()
        {
            _res = new ThucDonRepos();
        }

        public bool AddLoaiSP(LoaiSanPham loaiSanPham)
        {
            return _res.AddLoaiSP(loaiSanPham);
        }

        public bool UpdateLoaiSP(string id, LoaiSanPham loaiSanPham)
        {
            return _res.UpdateLoaiSP(id, loaiSanPham);
        }

        public bool GetImgage(string id, string fileImage)
        {
            return _res.GetImgage(id, fileImage);
        }

        public List<LoaiSanPham> GetLoaiSanPhams()
        {
            return _res.GetLoaiSanPhams();
        }

        public List<NhanVien> GetNhanViens()
        {
            return _res.GetNhanViens();
        }

        public List<SanPhamVM> GetSanPhams(string searchText, string cbxLoaiSP, int cbxLocTrangTha)
        {
            return _res.GetSanPhams(searchText, cbxLoaiSP, cbxLocTrangTha);
        }

        public bool AddSP(SanPham sanPham)
        {
            return _res.AddSP(sanPham);
        }

        public bool UpdateSP(string id, SanPham sanPham)
        {
            return _res.UpdateSP(id, sanPham);
        }

        public bool Add_RegexTenSP(string tenSP)
        {
            return _res.Add_RegexTenSP(tenSP);
        }

        public bool Update_RegexTenSP(string tenSP, string Id)
        {
            return _res.Update_RegexTenSP(tenSP, Id);
        }

        public bool Add_RegexTenLSP(string tenLSP)
        {
            return _res.Add_RegexTenLSP(tenLSP);
        }

        public bool Update_RegexTenLSP(string tenLSP, string Id)
        {
            return _res.Update_RegexTenLSP(tenLSP, Id);
        }
    }
}