using DataTransferObject_DTO;
using DataAccessLayer_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer_BLL
{
    public interface PhongDatService
    {
        bool datPhong(PhongDat objPhongDat);

        List<PhongDat> layDanhSachPhongDat();

        bool xoaPhongDat(string maHopDong);

        List<PhongDat> timKiemPhongDatTheoMaHD(string maHopDong);

        List<PhongDat> timKiemPhongDatTheoMaPhong(string maPhong);
    }
}
