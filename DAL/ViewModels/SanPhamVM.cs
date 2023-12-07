using DAL.Models;

namespace DAL.ViewModels
{
    public class SanPhamVM
    {
        public SanPham SanPham { get; set; }
        public bool isCheck { get; set; }
        public string TenLoaiSP { get; set; }
    }
}