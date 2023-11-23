using DAL.IRepositories;
using DAL.Models;
using DAL.ViewModels;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ThucDonRepos : IThucDonRepos
    {
        Da1CoffeeContext _db;
        public ThucDonRepos()
        {
            _db = new();
        }
        public List<LoaiSanPham> GetLoaiSanPhams()
        {
            return _db.LoaiSanPhams.ToList();
        }

        public List<NhanVien> GetNhanViens()
        {
            return _db.NhanViens.ToList();
        }

        public List<SanPhamVM> GetSanPhams(string searchText, string cbxLoaiSP, int cbxTrangThai)
        {
            if (!string.IsNullOrEmpty(searchText)) // để tìm kiếm tên sản phẩm
            {
                return _db.SanPhams
                    .Select(c => new SanPhamVM()
                    {
                        SanPham = c,
                        TenLoaiSP = c.IdloaiSanPham == null ? "N/A" : _db.LoaiSanPhams.FirstOrDefault(lsp => lsp.IdloaiSanPham == c.IdloaiSanPham)!.TenLoaiSanPham,
                    }).Where(x => x.SanPham.TenSanPham.Contains(searchText)).ToList();
            }
            if (cbxTrangThai == 0 && string.Equals(cbxLoaiSP, "All")) // TH: 2 cbx để All
            {
                return _db.SanPhams
                .Select(s => new SanPhamVM()
                {
                    SanPham = s,
                    TenLoaiSP = s.IdloaiSanPham == null ? "N/A" : _db.LoaiSanPhams.FirstOrDefault(lsp => lsp.IdloaiSanPham == s.IdloaiSanPham)!.TenLoaiSanPham,
                }).ToList();
            }
            else if (cbxTrangThai == 1 && string.Equals(cbxLoaiSP, "All")) // TH: cbx trạng thái là đang bán , cbx loại SP là All 
            {
                return _db.SanPhams.Where(x => x.TrangThai == 1)
                    .Select(c => new SanPhamVM()
                    {
                        SanPham = c,
                        TenLoaiSP = c.IdloaiSanPham == null ? "N/A" : _db.LoaiSanPhams.FirstOrDefault(lsp => lsp.IdloaiSanPham == c.IdloaiSanPham)!.TenLoaiSanPham,
                    }).ToList();
            }
            else if (cbxTrangThai == 2 && string.Equals(cbxLoaiSP, "All")) // TH: cbx trạng thái là ngừng bán, cbx loại SP là All 
            {
                return _db.SanPhams
                    .Where(x => x.TrangThai == 0)
                    .Select(c => new SanPhamVM()
                    {
                        SanPham = c,
                        TenLoaiSP = c.IdloaiSanPham == null ? "N/A" : _db.LoaiSanPhams.FirstOrDefault(lsp => lsp.IdloaiSanPham == c.IdloaiSanPham)!.TenLoaiSanPham,
                    }).ToList();
            }

            else if (!string.IsNullOrEmpty(cbxLoaiSP) && cbxTrangThai == 1) // TH: cbx loại SP là Tên Loại Sản Phẩm, cbx trạng thái là đang bán
            {
                return _db.SanPhams
                    .Select(c => new SanPhamVM()
                    {
                        SanPham = c,
                        TenLoaiSP = c.IdloaiSanPham == null ? "N/A" : _db.LoaiSanPhams.FirstOrDefault(lsp => lsp.IdloaiSanPham == c.IdloaiSanPham)!.TenLoaiSanPham,
                    }).Where(x => x.TenLoaiSP == cbxLoaiSP && x.SanPham.TrangThai == 1).ToList();
            }
            else if (!string.IsNullOrEmpty(cbxLoaiSP) && cbxTrangThai == 2) // TH: cbx loại SP là Tên Loại Sản Phẩm, cbx trạng thái là Ngừng Bán
            {
                return _db.SanPhams
                    .Select(c => new SanPhamVM()
                    {
                        SanPham = c,
                        TenLoaiSP = c.IdloaiSanPham == null ? "N/A" : _db.LoaiSanPhams.FirstOrDefault(lsp => lsp.IdloaiSanPham == c.IdloaiSanPham)!.TenLoaiSanPham,
                    }).Where(x => x.TenLoaiSP == cbxLoaiSP && x.SanPham.TrangThai == 0).ToList();
            }
            else if (!string.IsNullOrEmpty(cbxLoaiSP) && cbxTrangThai == 0) // TH: cbx loại SP là Tên Loại Sản Phẩm, cbx trạng thái là All
            {
                return _db.SanPhams
                    .Select(c => new SanPhamVM()
                    {
                        SanPham = c,
                        TenLoaiSP = c.IdloaiSanPham == null ? "N/A" : _db.LoaiSanPhams.FirstOrDefault(lsp => lsp.IdloaiSanPham == c.IdloaiSanPham)!.TenLoaiSanPham,
                    }).Where(x => x.TenLoaiSP == cbxLoaiSP).ToList();
            }
            return _db.SanPhams
                .Select(s => new SanPhamVM()
                {
                    SanPham = s,
                    TenLoaiSP = s.IdloaiSanPham == null ? "N/A" : _db.LoaiSanPhams.FirstOrDefault(lsp => lsp.IdloaiSanPham == s.IdloaiSanPham)!.TenLoaiSanPham,
                }).ToList();
        }

        public bool GetImgage(string id, string fileImage)
        {
            try
            {
                var result = _db.SanPhams.FirstOrDefault(x => x.IdsanPham == id);
                if (result == null)
                {
                    return false;
                }
                result.HinhAnh = fileImage;
                _db.Update(result);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool AddLoaiSP(LoaiSanPham loaiSanPham)
        {
            try
            {
                _db.Add(loaiSanPham);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateLoaiSP(string id, LoaiSanPham loaiSanPham)
        {
            try
            {
                var result = _db.LoaiSanPhams.FirstOrDefault(x => x.IdloaiSanPham == id);
                if (result == null)
                {
                    return false;
                }
                result.IdloaiSanPham = loaiSanPham.IdloaiSanPham;
                result.TenLoaiSanPham = loaiSanPham.TenLoaiSanPham;
                result.TrangThai = loaiSanPham.TrangThai;
                result.IdnhanVien = loaiSanPham.IdnhanVien;

                _db.Update(result);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool AddSP(SanPham sanPham)
        {
            try
            {
                _db.Add(sanPham);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateSP(string id, SanPham sanPham)
        {
            try
            {
                var result = _db.SanPhams.FirstOrDefault(x => x.IdsanPham == id);
                if (result == null)
                {
                    return false;
                }
                result.IdsanPham = sanPham.IdsanPham;
                result.TenSanPham = sanPham.TenSanPham;
                result.Gia = sanPham.Gia;
                result.TrangThai = sanPham.TrangThai;
                result.Thue = sanPham.Thue;
                result.IdloaiSanPham = sanPham.IdloaiSanPham;
                result.HinhAnh = sanPham.HinhAnh;

                _db.Update(result);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteSP(string id)
        {
            try
            {
                var result = _db.SanPhams.FirstOrDefault(x => x.IdsanPham == id);
                if (result == null)
                {
                    return false;
                }

                _db.Remove(result);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteLoaiSP(string id)
        {
            try
            {
                var result = _db.LoaiSanPhams.FirstOrDefault(x => x.IdloaiSanPham == id);
                if (result == null)
                {
                    return false;
                }

                _db.Remove(result);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool RegexTenSP(string tenSP)
        {

            var result = _db.SanPhams.FirstOrDefault(x => x.TenSanPham.Contains(tenSP));
            if (result != null)
            {
                return true;
            }
            return false;
        }
    }
}
