using DAL.Models;
using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IGiamGIaService
    {
        public List<GiamGia> GetGiamGias();
        public List<SanPhamVM> GetSanPham(string idGiamGia);
        public bool CheckIdGiamGiaChiTiet(string idSanPham, string idGiamGia);

    }
}
