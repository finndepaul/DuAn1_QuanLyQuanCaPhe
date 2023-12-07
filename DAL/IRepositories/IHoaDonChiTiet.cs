using DAL.Models;
using DAL.ViewModels;

namespace DAL.IRepositories
{
    public interface IHoaDonChiTiet
    {
        HoaDonChiTiet AddHoaDonCT(HoaDonChiTiet hoaDonCT);

        HoaDonChiTiet UpdateHoaDonCT(HoaDonChiTiet hoaDonCT);

        bool DeleteHoaDonCT(string id);

        HoaDonChiTiet GetHoaDonCTById(string IdHoadonCT);

        List<HDCT_VM> GetAllHoaDonCT(string idHD);
    }
}