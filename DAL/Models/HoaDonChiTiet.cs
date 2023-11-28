using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class HoaDonChiTiet
{
    public string IdhoaDonChiTiet { get; set; } = null!;

    public int? SoLuong { get; set; }

    public double? GiaBan { get; set; }

    public string? GhiChu { get; set; }

    public string IdsanPham { get; set; } = null!;

    public string IdhoaDon { get; set; } = null!;

    public virtual HoaDon IdhoaDonNavigation { get; set; } = null!;

    public virtual SanPham IdsanPhamNavigation { get; set; } = null!;
}
