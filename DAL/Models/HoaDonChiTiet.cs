using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class HoaDonChiTiet
{
    public string IdhoaDonChiTiet { get; set; } = null!;

    public DateTime? NgayXuatDon { get; set; }

    public int? SoLuong { get; set; }

    public double? GiaBan { get; set; }

    public string Idcustomer { get; set; } = null!;

    public string IdsanPham { get; set; } = null!;

    public string Idvoucher { get; set; } = null!;

    public string? IdhoaDon { get; set; }

    public virtual HoaDon? IdhoaDonNavigation { get; set; }

    public virtual SanPham IdsanPhamNavigation { get; set; } = null!;
}
