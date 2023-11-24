using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface ILoaiSanPhamService
    {
        List<SanPhamVM> GetSanPhams(string TenLoaiSP);

    }
}
