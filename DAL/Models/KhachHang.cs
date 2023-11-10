using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class KhachHang
{
    public string IdkhachHang { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Sdt { get; set; }

    public string? Email { get; set; }

    public string? DiaChi { get; set; }

    public int? Point { get; set; }

    public string? Idrank { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();

    public virtual MemberShipRank? IdrankNavigation { get; set; }
}
