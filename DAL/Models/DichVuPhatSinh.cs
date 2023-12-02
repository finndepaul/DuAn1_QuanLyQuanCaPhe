using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class DichVuPhatSinh
{
    public string IddichVuPhatSinh { get; set; } = null!;

    public string? ChiTiet { get; set; }

    public double? SoTien { get; set; }

    public string IdhoaDon { get; set; } = null!;

    public virtual HoaDon IdhoaDonNavigation { get; set; } = null!;
}
