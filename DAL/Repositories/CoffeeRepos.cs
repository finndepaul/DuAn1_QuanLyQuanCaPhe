using DAL.IRepositories;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CoffeeRepos : ICoffeeRepos
    {
        Da1CoffeeContext _context;
        public CoffeeRepos()
        {
            _context = new Da1CoffeeContext();
        }
        public List<NhanVien> GetNhanViens()
        {
            return _context.NhanViens.ToList();
        }
    }
}
