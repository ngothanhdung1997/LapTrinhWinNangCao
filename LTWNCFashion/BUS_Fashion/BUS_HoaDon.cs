using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Fashion;
using DTO_Fashion;
namespace BUS_Fashion
{
    public class BUS_HoaDon
    {
        DAL_HoaDon dalhd = new DAL_HoaDon();
        public List<HoaDon> getListHoaDon()
        {
            return dalhd.getHD();
        }
        public List<CT_HD> getCTHD(string pMahd)
        {
            return dalhd.getCTHDtheoma(pMahd);
        }
        public List<KhachHang> getKHtheoma(string pMaKH)
        {
            return dalhd.getKHtheoma(pMaKH);
        }
        public List<KhachHang> getListKhachHang()
        {
            return dalhd.getKH();
        }
        public List<NhanVien> getListNhanVien()
        {
            return dalhd.getNV();
        }
        public bool InsertHoaDon(DTO_HoaDon a)
        {
            return dalhd.InsertHoaDon(a);
        }
        public bool UpdateHoaDon(DTO_HoaDon a)
        {
            return dalhd.UpdateHoaDon(a);
        }
        public bool DeleteHoaDon(DTO_HoaDon a)
        {
            return dalhd.DeleteHoaDon(a);
        }
    }
}
