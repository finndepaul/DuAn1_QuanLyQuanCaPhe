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
    public class LoaiSanPhamRepos : ILoaiSanPhamRepos
    {
        Da1CoffeeContext _db;
        public LoaiSanPhamRepos()
        {
            _db = new Da1CoffeeContext();
        }
        public List<SanPhamVM> GetSanPhams(string TenLoaiSP)
        {
            return _db.SanPhams
                .Select(s => new SanPhamVM()
                {
                    SanPham = s,
                    TenLoaiSP = s.IdloaiSanPham == null ? "N/A" : _db.LoaiSanPhams.FirstOrDefault(lsp => lsp.IdloaiSanPham == s.IdloaiSanPham)!.TenLoaiSanPham,
                }).Where(x => x.TenLoaiSP.Contains(TenLoaiSP)).ToList();
        }
    }
}
