using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
