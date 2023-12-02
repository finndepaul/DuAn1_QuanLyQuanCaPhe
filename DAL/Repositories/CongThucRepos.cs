using DAL.IRepositories;
using DAL.Models;
using DAL.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CongThucRepos : ICongThucRepos
    {
        private readonly Da1CoffeeContext _db;

        public CongThucRepos()
        {
            _db = new();
        }

        public NguyenLieu CheckNameUpadte(string name, string id)
        {
            return _db.NguyenLieus.FirstOrDefault(x => x.TenNguyenLieu == name && x.IdnguyenLieu != id);
        }

        public NguyenLieu CreateNL(NguyenLieu nguyenLieu)
        {
            if (GetAllNL(null).Count != 0)
            {
                var maxid = _db.NguyenLieus.Max(sp => sp.IdnguyenLieu);
                int nextid = Convert.ToInt32(maxid.Substring(2)) + 1;
                nguyenLieu.IdnguyenLieu = "NL" + nextid.ToString("D3");
            }
            else
            {
                nguyenLieu.IdnguyenLieu = "NL001";
            }

            _db.NguyenLieus.Add(nguyenLieu);
            _db.SaveChanges();
            return nguyenLieu;
        }

        public PhaChe CreatePC(PhaChe phaChe)
        {
            if (GetAllPC().Count != 0)
            {
                var maxid = _db.PhaChes.Max(sp => sp.IdphaChe);
                int nextid = Convert.ToInt32(maxid.Substring(2)) + 1;
                phaChe.IdphaChe = "PC" + nextid.ToString("D3");
            }
            else
            {
                phaChe.IdphaChe = "PC001";
            }
            _db.PhaChes.Add(phaChe);
            _db.SaveChanges();
            return phaChe;

        }

        public List<PhaChe> DeleteAllPhaChe(List<PhaChe> pc)
        {
            _db.PhaChes.RemoveRange(pc);
            _db.SaveChanges();
            return pc;
        }

        public NguyenLieu DeleteNL(NguyenLieu nguyenLieu)
        {
            _db.NguyenLieus.Remove(nguyenLieu);
            _db.SaveChanges();
            return nguyenLieu;
        }

        public PhaChe DeletePC(PhaChe phaChe)
        {
            _db.PhaChes.Remove(phaChe);
            _db.SaveChanges();
            return phaChe;
        }

        public List<NguyenLieu> GetAllNL(string name)
        {
            var get = _db.NguyenLieus;
            if (!String.IsNullOrEmpty(name))
            {
                return get.Where(x => x.TenNguyenLieu.Trim().ToLower().Contains(name.Trim().ToLower())).ToList();
            }

            return get.ToList();
        }

        public List<PhacheVM> GetAllPC()
        {
            var query = from s in _db.SanPhams
                        join p1 in _db.PhaChes on s.IdsanPham equals p1.IdsanPham
                        group new { s, p1 } by new { s.TenSanPham, s.IdsanPham } into grouped
                        select new PhacheVM
                        {
                            TenSanPham = grouped.Key.TenSanPham,
                            TenNguyenLieu = string.Join(", ",
                                grouped.SelectMany(x => _db.PhaChes
                                                                   .Where(p => p.IdsanPham == x.s.IdsanPham)
                                                                   .Join(_db.NguyenLieus,
                                                                         p => p.IdnguyenLieu,
                                                                         n => n.IdnguyenLieu,
                                                                         (p, n) => n.TenNguyenLieu)
                                                          ).Distinct()
                            )
                        };

            var distinctProducts = query.ToList();
            return distinctProducts;
        }

        public List<SanPham> GetAllSanPham()
        {
            var get = _db.SanPhams.ToList();
            return get;

        }

        public NguyenLieu GetByIdNL(string id)
        {
            var get = _db.NguyenLieus.FirstOrDefault(x => x.IdnguyenLieu.Equals(id));
            return get;
        }

        public PhaChe GetByIdPC(string id)
        {
            var get = _db.PhaChes.Find(id);
            return get;
        }

        public PhaChe GetByIdSP_IdNL(string sp, string nl)
        {
            var search = _db.PhaChes.FirstOrDefault(x => x.IdsanPham == sp && x.IdnguyenLieu == nl);
            return search;
        }

        public List<PhaChe> GetByIdSP_PC(string sp)
        {
            var get = _db.PhaChes.Where(x => x.IdsanPham == sp).ToList();
            return get;
        }

        public SanPham GetByName(string name)
        {
            var get = _db.SanPhams.FirstOrDefault(x => x.TenSanPham == name);
            return get;
        }

        public NguyenLieu GetByNameNL(string name)
        {
            var get = _db.NguyenLieus.FirstOrDefault(x => x.TenNguyenLieu.Trim() == name.Trim());
            return get;
        }

        public NguyenLieu UpdateNL(NguyenLieu nguyenLieu)
        {
            _db.NguyenLieus.Update(nguyenLieu);
            _db.SaveChanges();
            return nguyenLieu;
        }

        public PhaChe UpdatePC(PhaChe phaChe)
        {
            _db.PhaChes.Update(phaChe);
            _db.SaveChanges();
            return phaChe;
        }
    }
}