using DAL.IRepositories;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class DichVuPhatSinhRepos : IDichVuPhatSinh
    {
        private Da1CoffeeContext _db;

        public DichVuPhatSinhRepos()
        {
            _db = new Da1CoffeeContext();
        }

        public Models.DichVuPhatSinh AddDVPS(Models.DichVuPhatSinh dichVuPhatSinh)
        {
            var maxId = _db.DichVuPhatSinhs.Max(sp => sp.IddichVuPhatSinh);

            // Tăng giá trị lên 1
            string nextId;
            if (string.IsNullOrEmpty(maxId))
            {
                nextId = "DVPS001";
            }
            else
            {
                int numberPart = int.Parse(Regex.Match(maxId, @"\d+").Value);
                nextId = "DVPS" + (numberPart + 1).ToString("D3");
            }
            dichVuPhatSinh.IddichVuPhatSinh = nextId;

            _db.DichVuPhatSinhs.Add(dichVuPhatSinh);
            _db.SaveChanges();
            return dichVuPhatSinh;
        }

        public Models.DichVuPhatSinh DeleteDVPS(Models.DichVuPhatSinh dichVuPhatSinh)
        {
            throw new NotImplementedException();
        }

        public List<Models.DichVuPhatSinh> GetAllDVPSList()
        {
            var lstDVPS = _db.DichVuPhatSinhs.ToList();
            return lstDVPS;
        }

        public Models.DichVuPhatSinh GetDVPSById(string IdDVPS)
        {
            var search = _db.DichVuPhatSinhs.FirstOrDefault(x => x.IddichVuPhatSinh == IdDVPS);
            return search;
        }

        public Models.DichVuPhatSinh UpdateDVPS(Models.DichVuPhatSinh dichVuPhatSinh)
        {
            _db.DichVuPhatSinhs.Update(dichVuPhatSinh);
            _db.SaveChanges();
            return dichVuPhatSinh;
        }
    }
}