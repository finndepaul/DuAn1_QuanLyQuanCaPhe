using DAL.IRepositories;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class TaiKhoanRepos : ITaiKhoanRepos
    {
        Da1CoffeeContext _db;
        public TaiKhoanRepos()
        {
            _db = new Da1CoffeeContext();
        }
        public List<NhanVien> GetNhanViens(string id, string loc)
        {
            if (!string.IsNullOrEmpty(id) && !string.IsNullOrEmpty(loc))
            {
                if (bool.TryParse(loc, out bool isActive))
                {
                    return _db.NhanViens
                        .Where(x => x.IdnhanVien.Trim().Contains(id) && x.Active == isActive)
                        .ToList();
                }
            }
            else if (!string.IsNullOrEmpty(id))
            {
                return _db.NhanViens
                    .Where(x => x.IdnhanVien.Trim().Contains(id))
                    .ToList();
            }
            else if (!string.IsNullOrEmpty(loc))
            {
                if (bool.TryParse(loc, out bool isActive))
                {
                    return _db.NhanViens
                        .Where(x => x.Active == isActive)
                        .ToList();
                }
            }
            else
            {
                return _db.NhanViens.ToList();
            }
            return new List<NhanVien>();
        }
        public bool AddNhanVien(NhanVien nhanVien)
        {
            if (nhanVien != null)
            {
                _db.Add(nhanVien);
                _db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
       
        public bool UpdateNhanVien(string? id, NhanVien nhanVien)
        {
            var result = _db.NhanViens.FirstOrDefault(x => x.IdnhanVien == id);
            if (id != null && nhanVien != null)
            {
                result.LoginName = nhanVien.LoginName;
                result.Password = nhanVien.Password;
                result.Role = nhanVien.Role;
                result.Active = nhanVien.Active;
                _db.NhanViens.Update(result);
                _db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
