using DAL.IRepositories;
using DAL.Models;
using DAL.ViewModels;
using System.Text.RegularExpressions;

namespace DAL.Repositories
{
    public class HoaDonChiTietRepos : IHoaDonChiTiet
    {
        private Da1CoffeeContext _db = new Da1CoffeeContext();

        public Models.HoaDonChiTiet AddHoaDonCT(Models.HoaDonChiTiet hoaDonCT)
        {
            // Truy vấn IdsanPham lớn nhất
            var maxId = _db.HoaDonChiTiets.Max(sp => sp.IdhoaDonChiTiet);

            // Tăng giá trị lên 1
            string nextId;
            if (string.IsNullOrEmpty(maxId))
            {
                nextId = "HDCT001";
            }
            else
            {
                int numberPart = int.Parse(Regex.Match(maxId, @"\d+").Value);
                nextId = "HDCT" + (numberPart + 1).ToString("D3");
            }
            hoaDonCT.IdhoaDonChiTiet = nextId;

            _db.HoaDonChiTiets.Add(hoaDonCT);
            _db.SaveChanges();
            return hoaDonCT;
        }

        public bool DeleteHoaDonCT(string id)
        {
            var search = _db.HoaDonChiTiets.FirstOrDefault(x => x.IdhoaDonChiTiet == id);
            _db.HoaDonChiTiets.Remove(search);
            _db.SaveChanges();
            return true;
        }

        public List<HDCT_VM> GetAllHoaDonCT(string idHD)
        {
            var lsthdct = (from hdct in _db.HoaDonChiTiets
                           join sp in _db.SanPhams on hdct.IdsanPham equals sp.IdsanPham
                           join hd in _db.HoaDons on hdct.IdhoaDon equals hd.IdhoaDon
                           where hd.TrangThai == 0
                           select new HDCT_VM
                           {
                               TenSanPham = sp.TenSanPham,
                               SoLuong = hdct.SoLuong,
                               GiaBan = sp.Gia,
                               GhiChu = hdct.GhiChu,
                               IdHDCT = hdct.IdhoaDonChiTiet,
                               IdHD = hdct.IdhoaDon
                           });
            if (!String.IsNullOrEmpty(idHD))
            {
                return lsthdct.Where(x => x.IdHD == idHD).ToList();
            }
            return lsthdct.ToList();
        }

        public Models.HoaDonChiTiet GetHoaDonCTById(string IdHoadonCT)
        {
            var search = _db.HoaDonChiTiets.FirstOrDefault(x => x.IdhoaDonChiTiet == IdHoadonCT);
            return search;
        }

        public List<SanPhamVM> GetSanPhams(string TenLoaiSP)
        {
            throw new NotImplementedException();
        }

        public Models.HoaDonChiTiet UpdateHoaDonCT(Models.HoaDonChiTiet hoaDonCT)
        {
            _db.HoaDonChiTiets.Update(hoaDonCT);
            _db.SaveChanges();
            return hoaDonCT;
        }
    }
}