using DAL.IRepositories;
using DAL.Models;
using DAL.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class KhachHangRepos : IKhachHangRepos
    {
        Da1CoffeeContext _db;
        public KhachHangRepos()
        {
            _db = new Da1CoffeeContext();
        }
        // Khách hàng

        
        public List<KhachHang> GetKhachHangs(string Sdt)
        {
            if (!string.IsNullOrEmpty(Sdt))
            {
                return _db.KhachHangs.Where(x => x.Sdt.Contains(Sdt.Trim())).ToList();
            }
            else
            {
                return _db.KhachHangs.ToList();
            }
        }
        public bool AddKhachHang(KhachHang khachHang)
        {
            if (khachHang == null)
            {
                return false;
            }
            else
            {
                khachHang.Point = 0;
                _db.KhachHangs.Add(khachHang);
                _db.SaveChanges();
                return true;
            }
        }

        public bool UpdateKhachHang(string? SDT, KhachHang khachHang)
        {
            if (SDT == null || khachHang == null)
            {
                return false;
            }
            else
            {
                var result = _db.KhachHangs.FirstOrDefault(x => x.Sdt == SDT);
                result.Name = khachHang.Name;
                result.Email = khachHang.Email;
                result.DiaChi = khachHang.DiaChi;
                result.Point = Convert.ToInt32(_db.HoaDons.Where(x => x.Sdt == SDT).Sum(x => x.TongTien));
                result.IdnhanVien = khachHang.IdnhanVien;
                string RankId = _db.MemberShipRanks.Where(x => x.PointsNeed <= result.Point)
                                    .OrderByDescending(x => x.PointsNeed)
                                    .Select(x => x.Idrank)
                                    .FirstOrDefault();
                result.Idrank = RankId;
                _db.KhachHangs.Update(result);
                _db.SaveChanges();
                return true;
            }
        }


        public List<MemberShipRank> GetMemberShipRanks(string idRank, string nameRank)
        {
            if (idRank != null && nameRank != null)
            {
                return _db.MemberShipRanks.Where(x => x.Idrank.Contains(idRank) && x.RankName == nameRank).ToList();
            }
            else if (idRank != null)
            {
                return _db.MemberShipRanks.Where(x => x.Idrank.Contains(idRank)).ToList();
            }
            else if (nameRank != null)
            {
                return _db.MemberShipRanks.Where(x => x.RankName == nameRank).ToList();
            }
            else
            {
                return _db.MemberShipRanks.ToList();
            }
        }

        public bool AddMenberShipRank(MemberShipRank memberShip)
        {
            if (memberShip == null)
            {
                return false;
            }
            
            else
            {
                if (_db.MemberShipRanks.Count() != 0)
                {
                    var max = _db.MemberShipRanks.Max(x=>x.Idrank);
                    int id = Convert.ToInt32( max.Substring(2)) + 1;
                    memberShip.Idrank = "MR" + id.ToString("D3");
                }
                else
                {
                    memberShip.Idrank = "MR001";
                }
                _db.MemberShipRanks.Add(memberShip);
                _db.SaveChanges();
                return true;
            }
        }
        public bool UpdateMembership(string idRank, MemberShipRank memberShip)
        {
            if (idRank == null || memberShip == null)
            {
                return false;
            }
            else
            {
                var result = _db.MemberShipRanks.FirstOrDefault(x=>x.Idrank == idRank);
                result.RankName = memberShip.RankName;
                result.PointsNeed = memberShip.PointsNeed;
                result.Discount = memberShip.Discount;
                _db.MemberShipRanks.Update(result);
                _db.SaveChanges();
                return true;
            }
        }


    }
}