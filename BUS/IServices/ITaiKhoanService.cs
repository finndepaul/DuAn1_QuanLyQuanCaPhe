using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface ITaiKhoanService
    {
        public List<NhanVien> GetNhanViens(string id, string loc);
        public bool AddNhanVien(NhanVien nhanVien);
        public bool UpdateNhanVien(string? id, NhanVien nhanVien);

    }
}
