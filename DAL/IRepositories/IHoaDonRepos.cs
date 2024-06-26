﻿using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface IHoaDonRepos
    {
        HoaDon AddHoaDon(HoaDon hoaDon);

        HoaDon UpdateHoaDon(HoaDon hoaDon);

        Voucher SearchVoucher(string code);

        Voucher UpdateSoLuongVC(string code);
        HoaDon DeleteHoaDon(HoaDon hoaDon);

        HoaDon GetHoaDonById(string IdHoadon);

        List<HoaDon> GetAllHoaDonList();
    }
}
