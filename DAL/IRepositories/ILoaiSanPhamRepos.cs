using DAL.ViewModels;

namespace DAL.IRepositories
{
    public interface ILoaiSanPhamRepos
    {
        List<SanPhamVM> GetSanPhams(string TenLoaiSP);
    }
}