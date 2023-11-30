using DAL.IRepositories;
using DAL.Models;
using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public bool AddGGCT(string idGiamGia, string idSanPham)
        {
            try
            {
                // Lấy thông tin giảm giá và sản phẩm từ database
                var giamGia = _db.GiamGia.FirstOrDefault(gg => gg.IdgiamGia == idGiamGia);
                var sanPham = _db.SanPhams.FirstOrDefault(sp => sp.IdsanPham == idSanPham);

                // Kiểm tra xem giảm giá và sản phẩm có tồn tại hay không
                if (giamGia == null || sanPham == null)
                {
                    // Nếu không tồn tại, không thể thêm vào GiamGiaChiTiets
                    return false;
                }

                // Tính giá mới dựa trên giảm giá
                float giamGiaPhanTram = (float)giamGia.PhanTram / 100;
                float giaMoi = (float)sanPham.Gia * (1 - giamGiaPhanTram);

                sanPham.GiaSale = giaMoi;

                // Tìm mã lớn nhất trong GiamGiaChiTiets
                var maxId = _db.GiamGiaChiTiets.Max(x => x.IdgiamGiaChiTiet);

                // Tạo mã mới dựa trên mã lớn nhất
                string nextId;
                if (string.IsNullOrEmpty(maxId))
                {
                    nextId = "GGCT001";
                }
                else
                {
                    int numberPart = int.Parse(Regex.Match(maxId, @"\d+").Value);
                    nextId = "GGCT" + (numberPart + 1).ToString("D3");
                }

                // Tạo GiamGiaChiTiet mới
                GiamGiaChiTiet giamGiaChiTiet = new GiamGiaChiTiet
                {
                    IdgiamGiaChiTiet = nextId,
                    IdsanPham = sanPham.IdsanPham,
                    IdgiamGia = giamGia.IdgiamGia
                };
                _db.GiamGiaChiTiets.Add(giamGiaChiTiet);
                _db.SaveChanges();
                _db.SanPhams.Update(sanPham);              
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                // Xử lý exception tùy theo yêu cầu
                Console.WriteLine($"Lỗi khi thêm GiamGiaChiTiet: {ex.Message}");
                return false;
            }
        }



        public bool DeleteGGCT(string idGiamGia, string idSanPham)
        {
            try
            {
                var ggct = _db.GiamGiaChiTiets.FirstOrDefault(x => x.IdgiamGia == idGiamGia && x.IdsanPham == idSanPham);
                // Kiểm tra xem giảm giá và sản phẩm có tồn tại hay không
                if (ggct == null)
                {
                    // Nếu không tồn tại, không thể xóa khỏi GiamGiaChiTiets
                    return false;
                }
                var sanPham = _db.SanPhams.FirstOrDefault(sp => sp.IdsanPham == idSanPham);
                sanPham.GiaSale = 0;
                _db.SanPhams.Update(sanPham);
                _db.SaveChanges();
                _db.GiamGiaChiTiets.Remove(ggct);               
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi xóa GiamGiaChiTiet: {ex.Message}");
                return false;
            }
        }
        public GiamGia GetGiamGia(string id)
        {
            return _db.GiamGia.FirstOrDefault(gg => gg.IdgiamGia == id);
        }




    }
}
