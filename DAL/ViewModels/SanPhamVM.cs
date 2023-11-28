using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
    public class SanPhamVM
    {
        public SanPham SanPham { get; set; }
        public bool isCheck { get; set; }
        public string TenLoaiSP { get; set; }
    }
}
