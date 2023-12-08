using DAL.IRepositories;
using DAL.Models;

namespace DAL.Repositories
{
    public class HoaDonRepos : IHoaDonRepos
    {
        private Da1CoffeeContext _db;

        public HoaDonRepos()
        {
            _db = new Da1CoffeeContext();
        }

        public HoaDon AddHoaDon(HoaDon hoaDon)
        {
            if (_db.HoaDons.Any())
            {
                // Truy vấn IdsanPham lớn nhất
                var maxId = _db.HoaDons.Max(sp => sp.IdhoaDon);

                // Tăng giá trị lên 1
                int nextId = int.Parse(maxId.Substring(2)) + 1;

                // Tạo IdsanPham mới
                hoaDon.IdhoaDon = "HD" + nextId.ToString("D3");
            }
            else
            {
                // Nếu không có sản phẩm, mặc định IdHoaDons là "HD001"
                hoaDon.IdhoaDon = "HD001";
            }
            hoaDon.TrangThai = 0;
            _db.HoaDons.Add(hoaDon);
            _db.SaveChanges();
            return hoaDon;
        }

        public HoaDon DeleteHoaDon(HoaDon hoaDon)
        {
            _db.HoaDons.Remove(hoaDon);
            _db.SaveChanges();
            return hoaDon;
        }

        public List<HoaDon> GetAllHoaDonList()
        {
            var lstHD = _db.HoaDons.Where(x => x.TrangThai == 0).ToList();
            return lstHD;
        }

        public HoaDon GetHoaDonById(string IdHoadon)
        {
            var search = _db.HoaDons.FirstOrDefault(x => x.IdhoaDon == IdHoadon);
            return search;
        }

        public HoaDon UpdateHoaDon(HoaDon hoaDon)
        {
            _db.HoaDons.Update(hoaDon);
            _db.SaveChanges();
            return hoaDon;
        }
    }
}