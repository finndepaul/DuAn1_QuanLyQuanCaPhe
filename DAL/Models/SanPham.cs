using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SanPham
{
    public string IdsanPham { get; set; } = null!;

    public string TenSanPham { get; set; } = null!;

    public double? Gia { get; set; }

    public double? GiaSale { get; set; }

    public int? TrangThai { get; set; }

    public double? Thue { get; set; }

    public string? HinhAnh { get; set; }

    public string IdloaiSanPham { get; set; } = null!;

    public string IdnhanVien { get; set; } = null!;

    public virtual ICollection<GiamGiaChiTiet> GiamGiaChiTiets { get; set; } = new List<GiamGiaChiTiet>();

    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();

    public virtual LoaiSanPham IdloaiSanPhamNavigation { get; set; } = null!;

    public virtual NhanVien IdnhanVienNavigation { get; set; } = null!;

    public virtual ICollection<PhaChe> PhaChes { get; set; } = new List<PhaChe>();
}
