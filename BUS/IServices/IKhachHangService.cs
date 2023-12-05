using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IKhachHangService
    {
        public List<KhachHang> GetKhachHangs(string Sdt);
        public bool AddKhachHang(KhachHang khachHang);
        public bool UpdateKhachHang(string? Sdt, KhachHang khachHang);

        public List<MemberShipRank> GetMemberShipRanks(string idRank, string nameRank);
        public bool AddMemberShipRank(string SDT, MemberShipRank memberShip);
        public bool UpdateMemberShip(string idRank, string SDT);
    }
}
