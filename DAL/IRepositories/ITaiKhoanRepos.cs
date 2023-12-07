using DAL.Models;

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