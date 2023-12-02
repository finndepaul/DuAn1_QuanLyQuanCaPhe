using DAL.Models;
using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
	public interface ICongThucRepos
	{
		//Pha chế
		List<PhacheVM> GetAllPC();
		PhaChe CreatePC(PhaChe phaChe);
		PhaChe UpdatePC(PhaChe phaChe);
		PhaChe DeletePC(PhaChe phaChe);
		PhaChe GetByIdPC(string id);
		PhaChe GetByIdSP_IdNL(string sp, string nl);
		List<PhaChe> GetByIdSP_PC(string sp);

		List<PhaChe> DeleteAllPhaChe(List<PhaChe> pc);


		//Nguyen Lieu
		List<NguyenLieu> GetAllNL(string name);

		NguyenLieu CreateNL(NguyenLieu nguyenLieu);

		NguyenLieu UpdateNL(NguyenLieu nguyenLieu);

		NguyenLieu DeleteNL(NguyenLieu nguyenLieu);

		NguyenLieu GetByIdNL(string id);
		NguyenLieu GetByNameNL(string name);

		NguyenLieu CheckNameUpadte(string name, string id);

		//SanPham
		List<SanPham> GetAllSanPham();
		SanPham GetByName(string name);
	}
}