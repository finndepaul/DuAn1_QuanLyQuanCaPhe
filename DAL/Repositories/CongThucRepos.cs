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

		public NguyenLieu CreateNL(NguyenLieu nguyenLieu)
		{
			_db.NguyenLieus.Add(nguyenLieu);
			_db.SaveChanges();
			return nguyenLieu;
		}

		public PhaChe CreatePC(PhaChe phaChe)
		{
			_db.PhaChes.Add(phaChe);
			_db.SaveChanges();
			return phaChe;

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

		public List<NguyenLieu> GetAllNL(string name, int? loc)
		{
			var get = _db.NguyenLieus;
			if (!String.IsNullOrEmpty(name))
			{
				return get.Where(x => x.TenNguyenLieu.Trim().ToLower() == name.ToString().Trim().ToLower()).ToList();
			}
			if (loc.HasValue)
			{
				if (loc.Value == 1)
				{
					return get.Where(x => x.NgayHetHan > DateTime.Now.Date).ToList();
				}
				if (loc.Value == 2)
				{
					return get.Where(x => x.NgayHetHan < DateTime.Now.Date).ToList();
				}
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

		public NguyenLieu GetByIdNL(string id)
		{
			var get = _db.NguyenLieus.Find(id);
			return get;
		}

		public PhaChe GetByIdPC(string id)
		{
			var get = _db.PhaChes.Find(id);
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
