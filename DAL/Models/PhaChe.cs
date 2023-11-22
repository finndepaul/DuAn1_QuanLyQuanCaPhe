using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class PhaChe
{
    public string IdphaChe { get; set; } = null!;

    public string IdsanPham { get; set; } = null!;

    public string IdnguyenLieu { get; set; } = null!;

    public virtual NguyenLieu IdnguyenLieuNavigation { get; set; } = null!;

    public virtual SanPham IdsanPhamNavigation { get; set; } = null!;
}
