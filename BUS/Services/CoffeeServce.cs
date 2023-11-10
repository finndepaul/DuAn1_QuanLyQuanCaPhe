using BUS.IServices;
using DAL.IRepositories;
using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class CoffeeServce : ICoffeeService
    {
        CoffeeRepos _res;
        public CoffeeServce()
        {
            _res = new CoffeeRepos();
        }
        public List<NhanVien> GetNhanViens()
        {
            return _res.GetNhanViens();
        }
    }
}
