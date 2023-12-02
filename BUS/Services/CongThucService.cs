using BUS.IServices;
using DAL.IRepositories;
using DAL.Models;
using DAL.Repositories;
using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class CongThucService : ICongThucService
    {
        private readonly CongThucRepos _ser;

        public CongThucService()
        {
            _ser = new CongThucRepos();
        }

        public NguyenLieu CheckNameUpadte(string name, string id)
        {
            return _ser.CheckNameUpadte(name, id);
        }

        public NguyenLieu CreateNL(NguyenLieu nguyenLieu)
        {
            return _ser.CreateNL(nguyenLieu);
        }

        public PhaChe CreatePC(PhaChe phaChe)
        {
            return _ser.CreatePC(phaChe);
        }

        public List<PhaChe> DeleteAllPhaChe(List<PhaChe> pc)
        {
            return _ser.DeleteAllPhaChe(pc);
        }

        public NguyenLieu DeleteNL(NguyenLieu nguyenLieu)
        {
            return _ser.DeleteNL(nguyenLieu);
        }

        public PhaChe DeletePC(PhaChe phaChe)
        {
            return _ser.DeletePC(phaChe);
        }

        public List<NguyenLieu> GetAllNL(string name)
        {
            return _ser.GetAllNL(name);
        }

        public List<PhacheVM> GetAllPC()
        {
            return _ser.GetAllPC();
        }

        public List<SanPham> GetAllSanPham()
        {
            return _ser.GetAllSanPham();
        }

        public NguyenLieu GetByIdNL(string id)
        {
            return _ser.GetByIdNL(id);
        }

        public PhaChe GetByIdPC(string id)
        {
            return _ser.GetByIdPC(id);
        }

        public PhaChe GetByIdSP_IdNL(string sp, string nl)
        {
            return _ser.GetByIdSP_IdNL(sp, nl);
        }

        public List<PhaChe> GetByIdSP_PC(string sp)
        {
            return _ser.GetByIdSP_PC(sp);
        }

        public SanPham GetByName(string name)
        {
            return _ser.GetByName(name);
        }

        public NguyenLieu GetByNameNL(string name)
        {
            return _ser.GetByNameNL(name);
        }

        public NguyenLieu UpdateNL(NguyenLieu nguyenLieu)
        {
            return _ser.UpdateNL(nguyenLieu);
        }

        public PhaChe UpdatePC(PhaChe phaChe)
        {
            return _ser.UpdatePC(phaChe);
        }
    }
}