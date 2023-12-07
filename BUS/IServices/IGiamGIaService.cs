using DAL.Models;
using DAL.ViewModels;

namespace BUS.IServices
{
    public interface IGiamGIaService
    {
        public List<GiamGia> GetGiamGias();

        public List<SanPhamVM> GetSanPham(string idGiamGia);

        public bool CheckIdGiamGiaChiTiet(string idSanPham, string idGiamGia);
    }
}