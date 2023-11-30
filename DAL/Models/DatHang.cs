using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class DatHang
{
    public string IddatHang { get; set; } = null!;

    public DateTime NgayBan { get; set; }

    public double? TongTien { get; set; }

    public int TrangThai { get; set; }

    public virtual ICollection<DatHangChiTiet> DatHangChiTiets { get; set; } = new List<DatHangChiTiet>();
}
