﻿using BUS.IServices;
using DAL.Models;
using DAL.Repositories;
using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class GiamGiaService : IGiamGIaService
    {
        GiamGiaRepos _res;
        public GiamGiaService()
        {
            _res = new GiamGiaRepos();
        }
        public List<GiamGia> GetGiamGias()
        {
            return _res.GetGiamGias();
        }

        public List<SanPhamVM> GetSanPham(string idGiamGia)
        {
            return _res.GetSanPham(idGiamGia);
        }
        public bool CheckIdGiamGiaChiTiet(string idSanPham, string idGiamGia)
        {
            // Thực hiện truy vấn để kiểm tra xem idSanPham đã tồn tại trong bảng GiamGiaChiTiets hay không
            // Trả về true nếu tồn tại, ngược lại trả về false
            return _res.CheckIdGiamGiaChiTiet(idSanPham, idGiamGia);
        }

    }
}