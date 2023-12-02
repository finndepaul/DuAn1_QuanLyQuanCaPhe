using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class KhachHang
{
    public string Sdt { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Email { get; set; }

    public string? DiaChi { get; set; }

    public int? Point { get; set; }

    public string? Idrank { get; set; }

    public string IdnhanVien { get; set; } = null!;

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();

    public virtual NhanVien IdnhanVienNavigation { get; set; } = null!;

    public virtual MemberShipRank? IdrankNavigation { get; set; }
}
