using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface ICoffeeService
    {
        public List<NhanVien> GetNhanViens();

    }
}
