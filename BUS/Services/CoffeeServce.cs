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
    public class CoffeeServce : ICoffeeService
    {
        CoffeeRepos _res;
        public CoffeeServce()
        {
            _res = new CoffeeRepos();
        }

        public bool AddLoaiSP(LoaiSanPham loaiSanPham)
        {
            return _res.AddLoaiSP(loaiSanPham);
        }
        public bool UpdateLoaiSP(string id, LoaiSanPham loaiSanPham)
        {
            return _res.UpdateLoaiSP(id, loaiSanPham);
        }

        public bool GetImgage(string id, string fileImage)
        {
            return _res.GetImgage(id, fileImage);
        }

        public List<LoaiSanPham> GetLoaiSanPhams()
        {
            return _res.GetLoaiSanPhams();
        }

        public List<SanPhamVM> GetSanPhams(string searchText, string cbxLoaiSP, int cbxLocTrangTha)
        {
            return _res.GetSanPhams(searchText,cbxLoaiSP, cbxLocTrangTha);
        }

        public bool AddSP(SanPham sanPham)
        {
            return _res.AddSP(sanPham);
        }

        public bool UpdateSP(string id, SanPham sanPham)
        {
            return _res.UpdateSP(id, sanPham);
        }

        public bool DeleteSP(string id)
        {
            return _res.DeleteSP(id);
        }

        public bool DeleteLoaiSP(string id)
        {
            return (_res.DeleteLoaiSP(id));
        }

        public List<MemberShipRank> GetMemberShipRanks()
        {
            return _res.MemberShipRanks();
        }

        public List<KhachHangVM> GetKhachHangVMs(string id)
        {
            return _res.GetKhachHangVMs(id);
        }

        public bool AddKhachHang(KhachHang khachHang)
        {
            return _res.AddKhachHang(khachHang);
        }

        public bool UpdateKhachHang(string id,KhachHang khachHang)
        {
            return _res.UpdateKhachHang(id, khachHang);
        }

        public bool DeleteKhachHang(string id)
        {
            return _res.DeleteKhachHang(id);
        }

        public List<NhanVien> GetNhanViens(string id, string loc)
        {
            return _res.GetNhanViens(id,loc);
        }

        public bool AddNhanVien(NhanVien nhanVien)
        {
            return _res.AddNhanVien(nhanVien);
        }

        public bool UpdateNhanVien(string ?id, NhanVien nhanVien)
        {
            return _res.UpdateNhanVien(id, nhanVien);
        }

        public bool DeleteNhanVien(string ?id)
        {
            return _res.DeleteNhanVien(id);
        }

    }
}
