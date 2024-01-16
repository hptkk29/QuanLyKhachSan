using DataTransferObject_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_DAL
{
    public interface PhongDatRepository
    {
        bool datPhong(PhongDat objPhongDat);

        List<PhongDat> layDanhSachPhongDat();

        bool xoaPhongDat(string maHopDong);

        List<PhongDat> timKiemPhongDatTheoMaHD(string maHopDong);

        List<PhongDat> timKiemPhongDatTheoMaPhong(string maPhong);
    }
}
