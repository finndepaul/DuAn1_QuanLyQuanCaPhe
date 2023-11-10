using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class MemberShipRank
{
    public string Idrank { get; set; } = null!;

    public int? PointsNeed { get; set; }

    public double? Discount { get; set; }

    public string? RankName { get; set; }

    public virtual ICollection<KhachHang> KhachHangs { get; set; } = new List<KhachHang>();
}
