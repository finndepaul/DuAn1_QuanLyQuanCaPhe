using DAL.IRepositories;
using DAL.Models;
using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class VoucherRepos : IVoucherRepos
    {
        Da1CoffeeContext _db;
        public VoucherRepos()
        {
            _db = new Da1CoffeeContext();
        }

        public bool AddVoucher(Voucher voucher)
        {
            try
            {
                if (_db.Vouchers.Any())
                {
                    var maxId = _db.Vouchers.Max(v => v.Idvoucher);

                    int nextId = int.Parse(maxId.Substring(2)) + 1;

                    voucher.Idvoucher = "VC" + nextId.ToString("D3");
                    voucher.TrangThai = 2;
                }
                else
                {
                    voucher.Idvoucher = "VC001";
                    voucher.TrangThai = 2;
                }
                _db.Add(voucher);
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public void checkTrangThai()
        {
            foreach (var item in _db.Vouchers.ToList())
            {
                if (item.TrangThai == 1 && item.DateEnd.Value.Date < DateTime.Now.Date)
                {

                    item.TrangThai = 0;
                    _db.Update(item);
                    _db.SaveChanges();                   
                }
                //else
                //{
                //    return;
                //}
            }
        }

        public bool checkVoucher(int cbx)
        {          
            var tt = _db.Vouchers.Any(x => x.TrangThai == 1);
            
            if (cbx == 1 && tt == true)
            {
                return true;
            }
            if (cbx == 1 && tt == false)
            {
                return false;
            }
            return false;
        }

        public List<Voucher> GetVouchers(string searchText, int cbx)
        {
            if (!string.IsNullOrEmpty(searchText))
            {
                return _db.Vouchers.Where(x => x.Code.Contains(searchText)).ToList();
            }
            if (cbx == 0)
            {
                return _db.Vouchers.ToList();
            }
            else if (cbx == 1)
            {
                return _db.Vouchers.Where(x => x.TrangThai == 0).ToList();
            }
            else if (cbx == 2)
            {
                return _db.Vouchers.Where(x => x.TrangThai == 1).ToList();
            }
            else if (cbx == 3)
            {
                return _db.Vouchers.Where(x => x.TrangThai == 2).ToList();
            }
            return _db.Vouchers.ToList();
        }

        public int UpdateVocuher(string id, Voucher voucher)
        {
            try
            {
                var tt = _db.Vouchers.Any(x => x.TrangThai == 1);
                var tt2 = _db.Vouchers.Any(x => x.TrangThai == 1 && x.Idvoucher == id);

                if (voucher.TrangThai == 1 && tt == true && tt2 == false)
                {
                    return 2;
                }
                //if (voucher.TrangThai == 1 && tt == true && tt2 == true)
                //{
                //    return 0;
                //}               
                var result = _db.Vouchers.FirstOrDefault(x => x.Idvoucher == id);
                if (result == null)
                {
                    return 1;
                }
                result.Idvoucher = voucher.Idvoucher;
                result.Code = voucher.Code;
                result.SoLuong = voucher.SoLuong;
                result.PhanTram = voucher.PhanTram;
                result.DateStart = voucher.DateStart;
                result.DateEnd = voucher.DateEnd;
                result.DieuKienApDung = voucher.DieuKienApDung;
                result.TrangThai = voucher.TrangThai;

                _db.Update(result);
                _db.SaveChanges();
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return 1;
            }
        }
    }
}