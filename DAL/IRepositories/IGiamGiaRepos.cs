using DAL.Models;
using DAL.ViewModels;

namespace DAL.IRepositories
{
    public interface IGiamGiaRepos
    {
        public List<GiamGia> GetGiamGias();

        public List<SanPhamVM> GetSanPham(string idGiamGia);

        public bool CheckIdGiamGiaChiTiet(string idSanPham, string idGiamGia);

        public bool UpdateGiaSale(string idGiamGia, string idSanPham);
    }
}