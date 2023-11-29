using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface ITaiKhoanRepos
    {
        //Nhân viên
        List<NhanVien> GetNhanViens(string id, string loc);
        public bool AddNhanVien(NhanVien nhanVien);
        public bool UpdateNhanVien(string? id, NhanVien nhanVien);
    }
}
