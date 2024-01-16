using DataTransferObject_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_DAL
{
    public interface NhanVienRepository
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
