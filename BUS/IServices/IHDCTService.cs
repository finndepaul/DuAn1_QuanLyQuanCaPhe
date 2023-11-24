using DAL.Models;
using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IHDCTService
    {
        // Nhân viên
        public List<NhanVien> GetNhanViens();

        // Sản Phẩm
        public List<HDCT_VM> GetHDCT();
        public bool GetImgage(string id, string fileImage);
        public bool AddHDCT();
        public bool UpdateHDCT();
        public bool DeleteHDCT();
        //public bool RegexTenSP(string tenSP);
    }
}
