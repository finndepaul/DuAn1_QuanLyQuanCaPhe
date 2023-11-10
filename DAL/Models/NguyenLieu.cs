using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class NguyenLieu
{
    public string IdnguyenLieu { get; set; } = null!;

    public string TenNguyenLieu { get; set; } = null!;

    public double? Gia { get; set; }

    public DateTime? NgayNhap { get; set; }

    public DateTime? NgayHetHan { get; set; }

    public int? SoLuong { get; set; }

    public virtual ICollection<PhaChe> PhaChes { get; set; } = new List<PhaChe>();
}
