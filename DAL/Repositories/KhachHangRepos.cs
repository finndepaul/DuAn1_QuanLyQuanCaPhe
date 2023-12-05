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
                return _db.KhachHangs.Where(x=>x.Sdt.Contains(Sdt.Trim())).ToList();
            }
            else
            {
                return _db.KhachHangs.ToList();
            }
        }
        public bool AddKhachHang(KhachHang khachHang)
        {
            if(khachHang == null)
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
       
        public bool UpdateKhachHang(string ?SDT, KhachHang khachHang)
        {
            if (SDT == null || khachHang == null)
            {
                return false;
            }
            else
            {
                var result = _db.KhachHangs.FirstOrDefault(x => x.Sdt == SDT);
                //if (_db.KhachHangs.Any(x=>x.Sdt != khachHang.Sdt) && _db.HoaDons.Any(x=>x.Sdt != khachHang.Sdt))
                //{
                //    _db.Entry(result).State = EntityState.Detached;
                //    result.Sdt = khachHang.Sdt;
                //    _db.Entry(result).State = EntityState.Modified;
                //    result.Name = khachHang.Name;
                //    result.Email = khachHang.Email;
                //    result.DiaChi = khachHang.DiaChi;
                //    result.Point = 0;
                //    result.IdnhanVien = khachHang.IdnhanVien;
                //}
                    result.Name = khachHang.Name;
                    result.Email = khachHang.Email;
                    result.DiaChi = khachHang.DiaChi;
                    result.Point = Convert.ToInt32(_db.HoaDons.Where(x => x.Sdt == SDT).Sum(x => x.TongTien ?? 0));
                    result.IdnhanVien = khachHang.IdnhanVien;         
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
            else if(nameRank != null)
            {
                return _db.MemberShipRanks.Where(x => x.RankName == nameRank).ToList();
            }
            else
            {
                return _db.MemberShipRanks.ToList();
            }
        }

        public bool AddMenberShipRank(string SDT,MemberShipRank memberShip)
        {           
            if (memberShip != null && !string.IsNullOrEmpty(SDT))
            {
                int diem = 0;
                memberShip.PointsNeed = 500000;
                if (diem < 500000)
                {
                    memberShip.Discount = 0;
                    memberShip.RankName = "Chưa sếp hạng rank";
                }
                else if (500000<=diem && diem<1000000)
                {
                    memberShip.Discount= 0.05;
                    memberShip.RankName = "Rank đồng";
                }
                else if (1000000 <= diem && diem < 2000000)
                {
                    memberShip.Discount = 0.1;
                    memberShip.RankName = "Rank bạc";
                }
                else if (2000000 <= diem && diem < 4000000)
                {
                    memberShip.Discount = 0.15;
                    memberShip.RankName = "Ranks vàng";
                }
                else
                {
                    memberShip.Discount = 0.2;
                    memberShip.RankName = "Ranks kim cương";
                }
                _db.MemberShipRanks.Add(memberShip);
                _db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateMembership(string idRank, string SDT)
        {
            
            int diem = Convert.ToInt32((from item in _db.KhachHangs where item.Sdt == SDT select item.Point).FirstOrDefault());
            if (idRank != null && SDT != null)
            {
                var result = _db.MemberShipRanks.FirstOrDefault(x => x.Idrank == idRank);
                //if (_db.KhachHangs.Any(x => x.Sdt != SDT))
                //{                   
                //    result.Discount = 0;
                //    result.RankName = "Chưa sếp hạng rank";
                //}
                
                    if (diem < 500000)
                    {
                        result.Discount = 0;
                        result.RankName = "Chưa sếp hạng rank";
                    }
                    else if (500000 <= diem && diem < 1000000)
                    {
                        result.Discount = 0.05;
                        result.RankName = "Rank đồng";
                    }
                    else if (1000000 <= diem && diem < 2000000)
                    {
                        result.Discount = 0.1;
                        result.RankName = "Rank bạc";
                    }
                    else if (2000000 <= diem && diem < 4000000)
                    {
                        result.Discount = 0.15;
                        result.RankName = "Ranks vàng";
                    }
                    else
                    {
                        result.Discount = 0.2;
                        result.RankName = "Ranks kim cương";
                    }
                               
                _db.MemberShipRanks.Update(result);
                _db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        } 
    }
}
