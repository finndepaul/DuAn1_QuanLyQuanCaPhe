using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class GiamGium
{
    public string IdgiamGia { get; set; } = null!;

    public string? TenChuongTrinh { get; set; }

    public double? PhanTram { get; set; }

    public DateTime? NgayBatDau { get; set; }

    public DateTime? NgayKetThuc { get; set; }

    public int? TrangThai { get; set; }

    public virtual ICollection<GiamGiaChiTiet> GiamGiaChiTiets { get; set; } = new List<GiamGiaChiTiet>();
}
