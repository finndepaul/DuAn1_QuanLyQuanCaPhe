using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class HoaDon
{
    public string IdhoaDon { get; set; } = null!;

    public DateTime NgayBan { get; set; }

    public double? TongTien { get; set; }

    public int TrangThai { get; set; }

    public string IdnhanVien { get; set; } = null!;

    public string IdkhachHang { get; set; } = null!;

    public string? Idvoucher { get; set; }

    public virtual ICollection<DichVuPhatSinh> DichVuPhatSinhs { get; set; } = new List<DichVuPhatSinh>();

    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();

    public virtual KhachHang IdkhachHangNavigation { get; set; } = null!;

    public virtual NhanVien IdnhanVienNavigation { get; set; } = null!;

    public virtual Voucher? IdvoucherNavigation { get; set; }
}
