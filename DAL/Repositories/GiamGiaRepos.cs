using DAL.IRepositories;
using DAL.Models;
using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class GiamGiaRepos : IGiamGiaRepos
    {
        Da1CoffeeContext _db;
        public GiamGiaRepos()
        {
            _db = new Da1CoffeeContext();
        }

        public List<GiamGia> GetGiamGias()
        {
            return _db.GiamGia.ToList();
        }

        public List<SanPhamVM> GetSanPham(string idGiamGia)
        {
            if (string.Equals(idGiamGia, "all", StringComparison.OrdinalIgnoreCase))
            {
                var query = from sp in _db.SanPhams
                            join gct in _db.GiamGiaChiTiets on sp.IdsanPham equals gct.IdsanPham into gj
                            from subGct in gj.DefaultIfEmpty()
                            select new SanPhamVM
                            {
                                SanPham = sp,
                                isCheck = subGct != null,
                                TenLoaiSP = null,
                            };

                return query.ToList();
            }
            else
            {
                var query = from sp in _db.SanPhams
                            join gct in _db.GiamGiaChiTiets on sp.IdsanPham equals gct.IdsanPham
                            join gg in _db.GiamGia on gct.IdgiamGia equals gg.IdgiamGia
                            where gg.IdgiamGia == idGiamGia
                            select new SanPhamVM
                            {
                                SanPham = sp,
                                isCheck = true,
                                TenLoaiSP = null,
                            };

                return query.ToList();
            }
        }
        public bool CheckIdGiamGiaChiTiet(string idSanPham, string idGiamGia)
        {
            // Thực hiện truy vấn để kiểm tra xem idSanPham đã tồn tại trong bảng GiamGiaChiTiets hay không
            // Trả về true nếu tồn tại, ngược lại trả về false
            return _db.GiamGiaChiTiets.Any(gct => gct.IdsanPham == idSanPham && gct.IdgiamGia == idGiamGia);
        }

        public bool UpdateGiaSale(string idGiamGia, string idSanPham)
        {
            throw new NotImplementedException();
        }
    }
}
