using DAL.Models;

namespace DAL.IRepositories
{
    public interface IHoaDonRepos
    {
        HoaDon AddHoaDon(HoaDon hoaDon);

        HoaDon UpdateHoaDon(HoaDon hoaDon);

        HoaDon DeleteHoaDon(HoaDon hoaDon);

        HoaDon GetHoaDonById(string IdHoadon);

        List<HoaDon> GetAllHoaDonList();
    }
}