using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface IDichVuPhatSinh
    {
        DichVuPhatSinh AddDVPS(DichVuPhatSinh dichVuPhatSinh);

        DichVuPhatSinh UpdateDVPS(DichVuPhatSinh dichVuPhatSinh);

        DichVuPhatSinh DeleteDVPS(DichVuPhatSinh dichVuPhatSinh);

        DichVuPhatSinh GetDVPSById(string IdDVPS);

        List<DichVuPhatSinh> GetAllDVPSList();
    }
}
