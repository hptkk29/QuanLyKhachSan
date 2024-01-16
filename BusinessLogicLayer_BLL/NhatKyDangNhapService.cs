using DataTransferObject_DTO;
using DataAccessLayer_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer_BLL
{
    public interface NhatKyDangNhapService
    {
        bool themNhatKy(NhatKyDangNhap obj);

        List<NhatKyDangNhap> layDanhSachDangNhap();

        List<NhatKyDangNhap> timKiemTheoMaNhanVien(string maNhanVien);
    }
}
