﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject_DTO;
using DataAccessLayer_DAL;

namespace BusinessLogicLayer_BLL
{
    public class NhatKyDangNhapServiceImpl : NhatKyDangNhapService
    {
        private NhatKyDangNhapRepository nhatKyDangNhapRepository = new NhatKyDangNhapRepositoryImpl();

        public List<NhatKyDangNhap> layDanhSachDangNhap()
        {
            return nhatKyDangNhapRepository.layDanhSachDangNhap();

        }

        public bool themNhatKy(NhatKyDangNhap obj)
        {
            return nhatKyDangNhapRepository.themNhatKy(obj);
        }

        public List<NhatKyDangNhap> timKiemTheoMaNhanVien(string maNhanVien)
        {
            return nhatKyDangNhapRepository.timKiemTheoMaNhanVien(maNhanVien);
        }
    }
}
