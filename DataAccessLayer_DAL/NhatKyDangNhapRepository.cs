using DataTransferObject_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_DAL
{
    public interface NhatKyDangNhapRepository
    {
        bool themNhatKy(NhatKyDangNhap obj);

        List<NhatKyDangNhap> layDanhSachDangNhap();

        List<NhatKyDangNhap> timKiemTheoMaNhanVien(string maNhanVien);
    }
}
