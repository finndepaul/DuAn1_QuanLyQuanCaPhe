using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
	public class DoanhThuVM
	{
		public string IdhoaDon { get; set; }

		public double? TongTien { get; set; }

		public DateTime NgayBan { get; set; }

		

		public string? IdnhanVien { get; set; } 
		public string? IdkhachHang { get; set; } 
		public string? IdsanPham { get; set; } 
	}
}
