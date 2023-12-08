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
        public List<SanPhamVM> GetSanPham(string idGiamGia, string searchText);
        public bool AddGGCT(string idGiamGia, string idSanPham);
        public bool DeleteGGCT(string idGiamGia, string idSanPham);
        public GiamGia GetGiamGia(string id);

        // giảm giá
        public List<GiamGia> GetGiamGias(string searchText, int cbxTrangThai);
        public bool AddGiamGia(GiamGia giamGia);
        public bool UpdateGiamGia(string id, GiamGia giamGia);

        // Regex:
        public bool CheckIdGiamGiaChiTiet(string idSanPham, string idGiamGia);
        public bool CheckSanPham(string idSanPham);
        public void CheckTrangThai(string idGiamGia);
        public void CheckDate();

    }
}
