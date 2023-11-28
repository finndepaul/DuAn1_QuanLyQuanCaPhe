using BUS.IServices;
using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class TaiKhoanService : ITaiKhoanService
    {
        TaiKhoanRepos _res = new TaiKhoanRepos();
        public List<NhanVien> GetNhanViens(string id, string loc)
        {
            return _res.GetNhanViens(id, loc);
        }

        public bool AddNhanVien(NhanVien nhanVien)
        {
            return _res.AddNhanVien(nhanVien);
        }

        public bool UpdateNhanVien(string? id, NhanVien nhanVien)
        {
            return _res.UpdateNhanVien(id, nhanVien);
        }

    }
}
