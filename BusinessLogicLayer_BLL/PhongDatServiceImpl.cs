using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject_DTO;
using DataAccessLayer_DAL;

namespace BusinessLogicLayer_BLL
{
    public class PhongDatServiceImpl : PhongDatService
    {
        private PhongDatRepository phongDatRepository = new PhongDatRepositoryImpl();
        public bool datPhong(PhongDat objPhongDat)
        {
            return phongDatRepository.datPhong(objPhongDat);
        }

        public List<PhongDat> layDanhSachPhongDat()
        {
            return phongDatRepository.layDanhSachPhongDat();
        }

        public List<PhongDat> timKiemPhongDatTheoMaHD(string maHopDong)
        {
            return phongDatRepository.timKiemPhongDatTheoMaHD(maHopDong);
        }

        public List<PhongDat> timKiemPhongDatTheoMaPhong(string maPhong)
        {
            return phongDatRepository.timKiemPhongDatTheoMaPhong(maPhong);
        }

        public bool xoaPhongDat(string maHopDong)
        {
            return phongDatRepository.xoaPhongDat(maHopDong);
        }
    }
}
