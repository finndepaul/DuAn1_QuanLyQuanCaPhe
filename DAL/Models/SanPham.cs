using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SanPham
{
    public string IdsanPham { get; set; } = null!;

    public string TenSanPham { get; set; } = null!;

    public double? Gia { get; set; }

    public int? TrangThai { get; set; }

    public double? Thue { get; set; }

    public string? IdloaiSanPham { get; set; }

    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();

    public virtual LoaiSanPham? IdloaiSanPhamNavigation { get; set; }

    public virtual ICollection<PhaChe> PhaChes { get; set; } = new List<PhaChe>();

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
