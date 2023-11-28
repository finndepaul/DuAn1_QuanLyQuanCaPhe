using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class NhanVien
{
    public string IdnhanVien { get; set; } = null!;

    public string LoginName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public bool Role { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();

    public virtual ICollection<LoaiSanPham> LoaiSanPhams { get; set; } = new List<LoaiSanPham>();

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
