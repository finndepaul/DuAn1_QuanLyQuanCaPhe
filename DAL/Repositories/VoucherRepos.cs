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
            _db = new();
        }
        public List<Voucher> GetVouchers(string id, int? trangThai)
        {
            var get = _db.Vouchers;
            if (!string.IsNullOrEmpty(id))
            {
                return get.Where(x => x.Idvoucher.Contains(id)).ToList();
            }
            if (trangThai.HasValue)
            {
                if (trangThai == 1) //het han
                {
                    return get.Where(c => c.DateEnd < DateTime.Now).ToList();
                }
                if (trangThai == 0) //all
                {
                    return get.ToList();
                }
                if (trangThai == 2) // dang ap dung
                {
                    return get.Where(x => x.TrangThai == 1).ToList();
                }
                if (trangThai == 3) //chua ap dung
                {
                    return get.Where(x => x.TrangThai == 2).ToList();
                }


            }
            return get.ToList();
        }

        public bool AddVoucher(Voucher voucher)
        {
            try
            {
                // Kiểm tra xem có sản phẩm nào trong cơ sở dữ liệu hay không
                if (_db.Vouchers.Any())
                {
                    // Truy vấn IdsanPham lớn nhất
                    var maxId = _db.Vouchers.Max(vc => vc.Idvoucher);

                    // Tăng giá trị lên 1
                    int nextId = int.Parse(maxId.Substring(2)) + 1;

                    // Tạo IdsanPham mới
                    voucher.Idvoucher = "VC" + nextId.ToString("D3");
                }
                else
                {
                    // Nếu không có sản phẩm, mặc định IdsanPham là "SP001"
                    voucher.Idvoucher = "VC001";

                }
                // Thêm sản phẩm và lưu thay đổi
                _db.Add(voucher);
                _db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateVocuher(Voucher voucher)
        {


            _db.Update(voucher);
            _db.SaveChanges();
            return true;

        }

        public bool DeleteVocuher(string id)
        {
            try
            {
                var result = _db.Vouchers.FirstOrDefault(x => x.Idvoucher == id);
                if (result == null)
                {
                    return false;
                }

                _db.Remove(result);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Voucher GetByIdVC(string id)
        {
            var search = _db.Vouchers.Find(id);
            return search;

        }

        public Voucher GetByCode(string code)
        {
            var search = _db.Vouchers.FirstOrDefault(x => x.Code.Trim().ToLower() == code.Trim().ToLower());
            return search;

        }
    }
}