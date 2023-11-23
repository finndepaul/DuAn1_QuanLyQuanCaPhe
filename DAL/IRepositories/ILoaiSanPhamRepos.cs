using DAL.Models;
using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface ILoaiSanPhamRepos
    {
        List<SanPhamVM> GetSanPhams(string TenLoaiSP);
    }
}
