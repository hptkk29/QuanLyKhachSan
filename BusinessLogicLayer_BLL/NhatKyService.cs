using DataTransferObject_DTO;
using DataAccessLayer_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer_BLL
{
    public interface NhatKyService
    {
        List<NhatKy> layTatCaNhatKy();

        bool themNhatKy(NhatKy objNhatKy);

        bool xoaNhatKy(string maHopDong);

        List<NhatKy> timNhatKyTheoMaHopDong(string maHopDong);

        float tinhTienThuePhong(NhatKy objNhatKy);
    }
}
