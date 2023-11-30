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
         List<Voucher> GetVouchers(string id,int? trangThai );
         bool AddVoucher(Voucher voucher);
        bool UpdateVocuher( Voucher voucher);
        bool DeleteVocuher(string id);
        Voucher GetByIdVC(string id);
        Voucher GetByCode(string code);
    }
}
