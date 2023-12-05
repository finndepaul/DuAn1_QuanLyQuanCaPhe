using BUS.IServices;
using DAL.IRepositories;
using DAL.Repositories;
using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
	public class DoanhThuService : IDoanhThuService
	{
		private readonly DoanhThuRepos _res;

		public DoanhThuService()
		{
			_res = new DoanhThuRepos();
		}

		public List<DoanhThuVM> GetAllHoaDon(DateTime? start, DateTime? end)
		{
			return _res.GetAllHoaDon(start, end);
		}

		public List<string> GetLoai()
		{
			return _res.GetLoai();
		}

		public List<DoanhThuRankSP> GetSanPhamRank(int? loc, string? txtloc, DateTime start, DateTime end)
		{
			return _res.GetSanPhamRank(loc, txtloc, start, end);
		}
	}
}
