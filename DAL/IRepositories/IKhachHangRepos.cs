using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface IKhachHangRepos
    {
        public List<KhachHang> GetKhachHangs(string Sdt);
        public bool AddKhachHang(KhachHang khachHang);
        public bool UpdateKhachHang(string? Sdt, KhachHang khachHang);

        public List<MemberShipRank> GetMemberShipRanks(string idRank, string nameRank);
        public bool AddMenberShipRank(MemberShipRank memberShip);
        public bool UpdateMembership(string idRank, MemberShipRank memberShip);
    }
}
