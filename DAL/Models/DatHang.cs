namespace DAL.Models;

public partial class DatHang
{
    public string IddatHang { get; set; } = null!;

    public DateTime NgayBan { get; set; }

    public double? TongTien { get; set; }

    public int TrangThai { get; set; }

    public virtual DatHangChiTiet? DatHangChiTiet { get; set; }
}