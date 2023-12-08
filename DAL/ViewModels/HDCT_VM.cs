using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
    public class HDCT_VM
    {
        //public HoaDonChiTiet HoaDonChiTiet { get; set; }
        public string TenSanPham { get; set; }

        public int? SoLuong { get; set; }
        public double? GiaBan { get; set; }
        public string? GhiChu { get; set; }
        public string? IdHD { get; set; }
        public string? IdHDCT { get; set; }

    }
}
