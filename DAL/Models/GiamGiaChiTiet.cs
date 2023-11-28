using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class GiamGiaChiTiet
{
    public string IdgiamGiaChiTiet { get; set; } = null!;

    public string IdsanPham { get; set; } = null!;

    public string IdgiamGia { get; set; } = null!;

    public virtual GiamGia IdgiamGiaNavigation { get; set; } = null!;

    public virtual SanPham IdsanPhamNavigation { get; set; } = null!;
}
