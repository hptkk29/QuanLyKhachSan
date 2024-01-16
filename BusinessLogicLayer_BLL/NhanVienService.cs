using DataTransferObject_DTO;
using DataAccessLayer_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer_BLL
{
    public interface NhanVienService
    {
        List<NhanVien> layDanhSachNhanVien();

        bool themNhanVien(NhanVien objNhanVien);

        bool capNhatNhanVien(NhanVien objNhanVien);

        bool xoaNhanVien(string maNhanVien);

        List<NhanVien> timKiemNhanVienTheoMa(string maNhanVien);

        bool dangNhap(NhanVien objNhanVien);

        List<NhanVien> layDanhSachQuyenHanNhanVien();
    }
}
