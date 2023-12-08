using DAL.Models;
using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
