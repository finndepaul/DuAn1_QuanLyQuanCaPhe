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
    public class VoucherService : IVoucherService
    {
        VoucherRepos _res;
        public VoucherService()
        {
            _res = new VoucherRepos();
        }

       
        public bool AddVoucher(Voucher voucher)
        {
           return _res.AddVoucher(voucher);
        }

        public bool DeleteVocuher(string id)
        {
            return _res.DeleteVocuher(id);
        }

        public Voucher GetByCode(string code)
        {
            return _res.GetByCode(code);
        }

        public Voucher GetByIdVC(string id)
        {
            return (_res.GetByIdVC(id));
        }

        public List<Voucher> GetVouchers(string id, int? trangThai)
        {
            return _res.GetVouchers(id, trangThai);
        }

        public bool UpdateVocuher(Voucher voucher)
        {
            return _res.UpdateVocuher( voucher);
        }
    }
}
