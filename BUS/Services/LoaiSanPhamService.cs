using BUS.IServices;
using DAL.Repositories;
using DAL.ViewModels;

namespace BUS.Services
{
    public class LoaiSanPhamService : ILoaiSanPhamService
    {
        private LoaiSanPhamRepos _res;

        public LoaiSanPhamService()
        {
            _res = new LoaiSanPhamRepos();
        }

        public List<SanPhamVM> GetSanPhams(string TenLoaiSP)
        {
            return _res.GetSanPhams(TenLoaiSP);
        }
    }
}