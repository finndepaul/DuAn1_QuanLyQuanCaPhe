using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Voucher
{
    public string Idvoucher { get; set; } = null!;

    public double? GiamTien { get; set; }

    public DateTime? DateStart { get; set; }

    public DateTime? DateEnd { get; set; }

    public int? SoLuong { get; set; }

    public string? Code { get; set; }

    public string? DieuKienApDung { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
