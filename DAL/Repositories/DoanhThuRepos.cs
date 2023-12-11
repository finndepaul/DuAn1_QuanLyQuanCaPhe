using DAL.IRepositories;
using DAL.Models;
using DAL.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace DAL.Repositories
{
    public class DoanhThuRepos : IDoanhThuRepos
    {
        private readonly Da1CoffeeContext _db;

        public DoanhThuRepos()
        {
            _db = new();
        }

        public List<DoanhThuVM> GetAllHoaDon(DateTime? start, DateTime? end)
        {
            var query = from hd in _db.HoaDons
                        join hct in _db.HoaDonChiTiets on hd.IdhoaDon equals hct.IdhoaDon                  
                        where hd.TrangThai == 1
                        group hd by new { hd.IdhoaDon, hd.TongTien, hd.NgayXuatDon, hd.IdnhanVien, hd.Sdt } into g
                        select new DoanhThuVM()
                        {
                            IdhoaDon = g.Key.IdhoaDon,
                            TongTien = g.Key.TongTien,
                            NgayBan = g.Key.NgayXuatDon,
                            IdnhanVien = g.Key.IdnhanVien,
                            IdkhachHang = g.Key.Sdt,
                            IdsanPham = string.Join(",", g.SelectMany(x => _db.HoaDonChiTiets.Where(y => y.IdhoaDon == g.Key.IdhoaDon).Distinct()).Select(x => x.IdsanPham).Distinct())
                        };
            if (start.HasValue && end.HasValue)
            {
                return query.Where(x => x.NgayBan >= start && x.NgayBan <= end).ToList();
            }

            return query.ToList();



        }

        public List<string> GetLoai()
        {
            var search = _db.LoaiSanPhams.Select(x => x.TenLoaiSanPham).ToList();
            return search;
        }

        public List<DoanhThuRankSP> GetSanPhamRank(int? loc, string? txtloc, DateTime start, DateTime end)
        {
            var result = from h in _db.HoaDonChiTiets
                         join s in _db.SanPhams on h.IdsanPham equals s.IdsanPham
                         join l in _db.LoaiSanPhams on s.IdloaiSanPham equals l.IdloaiSanPham
                         join hd in _db.HoaDons on h.IdhoaDon equals hd.IdhoaDon
                         where hd.NgayXuatDon >= start && hd.NgayXuatDon <= end
                         group new { h, s, l } by new { h.IdsanPham, s.TenSanPham, l.TenLoaiSanPham } into g
                         orderby g.Sum(x => x.h.SoLuong) descending
                         select new DoanhThuRankSP
                         {
                             Idsanpham = g.Key.IdsanPham,
                             TenSanpham = g.Key.TenSanPham,
                             Soluong = g.Sum(x => x.h.SoLuong),
                             LoaiSanPham = g.Key.TenLoaiSanPham,
                         };
            if (loc.HasValue) // cbb duoc chon
            {
                if (loc != 0)
                {
                    return result.Where(x => x.LoaiSanPham.ToLower().Trim() == txtloc.ToLower().Trim()).ToList();
                }
                else
                {
                    return result.ToList();
                }

            }
            return result.ToList(); //loadform 

        }
    }
}