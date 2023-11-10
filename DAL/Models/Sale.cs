using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Sale
{
    public string Idsale { get; set; } = null!;

    public double? PhanTram { get; set; }

    public int? SoLuong { get; set; }

    public DateTime? NgayBatDau { get; set; }

    public DateTime? NgayKetThuc { get; set; }

    public string IdsanPham { get; set; } = null!;

    public virtual SanPham IdsanPhamNavigation { get; set; } = null!;
}
