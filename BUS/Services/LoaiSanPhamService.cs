
using BUS.IServices;
using DAL.Repositories;
using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class LoaiSanPhamService : ILoaiSanPhamService
    {
        LoaiSanPhamRepos _res;
        public LoaiSanPhamService()
        {
            _res = new LoaiSanPhamRepos();
        }
        public List<SanPhamVM> GetSanPhams(string TenLoaiSP)
        {
            return _res.GetSanPhams(TenLoaiSP);
        }
    }
}
