using DAL.Models;

namespace BUS.IServices
{
    public interface ITaiKhoanService
    {
        public List<NhanVien> GetNhanViens(string id, string loc);

        public bool AddNhanVien(NhanVien nhanVien);

        public bool UpdateNhanVien(string? id, NhanVien nhanVien);
    }
}