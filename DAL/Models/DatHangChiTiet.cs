using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class DatHangChiTiet
{
    public string IddatHangChiTiet { get; set; } = null!;

    public string IdsanPham { get; set; } = null!;

    public int? SoLuong { get; set; }

    public double? GiaBan { get; set; }

    public string? GhiChu { get; set; }

    public string IddatHang { get; set; } = null!;

    public virtual DatHang IddatHangNavigation { get; set; } = null!;

    public virtual SanPham IdsanPhamNavigation { get; set; } = null!;
}
