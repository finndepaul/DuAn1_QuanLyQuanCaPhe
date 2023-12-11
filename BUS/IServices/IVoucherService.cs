using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IVoucherService
    {
        List<Voucher> GetVouchers(string searchText, int cbx);
        bool AddVoucher(Voucher voucher);
        int UpdateVocuher(string id,Voucher voucher);
        public bool checkVoucher(int cbx);
        public void checkTrangThai();

    }
}
