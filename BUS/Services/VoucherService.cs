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

        public void checkTrangThai()
        {
            _res.checkTrangThai();
        }

        public bool checkVoucher(int cbx)
        {
            return _res.checkVoucher(cbx);
        }

        public List<Voucher> GetVouchers(string searchText, int cbx)
        {
            return _res.GetVouchers(searchText,cbx);
        }

        public int UpdateVocuher(string id,Voucher voucher)
        {
            return _res.UpdateVocuher(id, voucher);
        }
    }
}