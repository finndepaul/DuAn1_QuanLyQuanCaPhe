using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IDoanhThuService
    {
        List<DoanhThuVM> GetAllHoaDon(DateTime? start, DateTime? end);

        List<DoanhThuRankSP> GetSanPhamRank(int? loc, string? txtloc, DateTime start, DateTime end);

        List<string> GetLoai(); 
    }
}
