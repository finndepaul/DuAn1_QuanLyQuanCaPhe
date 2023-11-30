using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class LoaiSanPham
{
    public string IdloaiSanPham { get; set; } = null!;

    public string TenLoaiSanPham { get; set; } = null!;

    public int? TrangThai { get; set; }

    public string IdnhanVien { get; set; } = null!;

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
