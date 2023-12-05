using DAL.Models;
using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface IGiamGiaRepos
    {
        //public List<GiamGia> GetGiamGias();
        public List<SanPhamVM> GetSanPham(string idGiamGia);
        public bool CheckIdGiamGiaChiTiet(string idSanPham, string idGiamGia);
        public bool UpdateGiaSale(string idGiamGia, string idSanPham);

    }
}
