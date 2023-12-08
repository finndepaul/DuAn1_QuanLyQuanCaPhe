using BUS.IServices;
using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class KhachHangService : IKhachHangService
    {
        KhachHangRepos _res;

        public KhachHangService()
        {
            _res = new KhachHangRepos();
        }

        public bool AddKhachHang(KhachHang khachHang)
        {
            return _res.AddKhachHang(khachHang);
        }

        public bool AddMemberShipRank(MemberShipRank memberShip)
        {
            return _res.AddMenberShipRank(memberShip);
        }

        public List<KhachHang> GetKhachHangs(string Sdt)
        {
            return _res.GetKhachHangs(Sdt);
        }

        public List<MemberShipRank> GetMemberShipRanks(string idRank, string nameRank)
        {
            return _res.GetMemberShipRanks(idRank, nameRank);
        }

        public bool UpdateKhachHang(string? Sdt, KhachHang khachHang)
        {
            return _res.UpdateKhachHang(Sdt, khachHang);
        }

        public bool UpdateMemberShip(string idRank, MemberShipRank memberShip)
        {
            return _res.UpdateMembership(idRank, memberShip);
        }
    }
}   