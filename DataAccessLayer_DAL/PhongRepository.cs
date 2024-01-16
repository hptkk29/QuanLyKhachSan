using DataTransferObject_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_DAL
{
    public interface PhongRepository
    {
        List<Phong> layDanhSachTatCaPhong();

        List<Phong> layDanhSachPhongTrong();

        int demSoPhongConTrong();

        int demSoPhongDuocThue();

        List<Phong> timPhongTheoMaPhong(string maPhong);

        bool capNhatThongTinPhong(Phong objPhong);

        bool capNhatTinhTrangPhong(Phong objPhong);

        List<Phong> timPhongTrongTheoMaPhong(string maPhong);
    }
}
