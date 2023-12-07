namespace DAL.Models;

public partial class DatHangChiTiet
{
    public string IddatHangChiTiet { get; set; } = null!;

    public int? SoLuong { get; set; }

    public double? GiaBan { get; set; }

    public string? GhiChu { get; set; }

    public string IdsanPham { get; set; } = null!;

    public string? IddatHang { get; set; }

    public virtual SanPham IddatHangChiTiet1 { get; set; } = null!;

    public virtual DatHang IddatHangChiTietNavigation { get; set; } = null!;
}