using DAL.ViewModels;

namespace BUS.IServices
{
    public interface ILoaiSanPhamService
    {
        List<SanPhamVM> GetSanPhams(string TenLoaiSP);
    }
}