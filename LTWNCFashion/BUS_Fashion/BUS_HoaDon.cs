using System;
using System.Collections.Generic;
using System.Data;
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
        public DataTable getCTHD(int pMahd)
        {
            return dalhd.getCTHDtheoma(pMahd);
        }
        public List<KhachHang> getKHtheoma(string pMaKH)
        {
            return dalhd.getKHtheoma(pMaKH);
        }
        public List<NhanVien> getNVtheoma(string pMaNV)
        {
            return dalhd.getNVtheoma(pMaNV);
        }
        public List<KhachHang> getListKhachHang()
        {
            return dalhd.getKH();
        }
        public List<NhanVien> getListNhanVien()
        {
            return dalhd.getNV();
        }
        //insert  update delete HOADON
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
        //insert  update delete CTHD
        public bool InsertCT_HD(DTO_CTHD a)
        {
            return dalhd.InsertCTHD(a);
        }
        public bool UpdateCTHD(DTO_CTHD a)
        {
            return dalhd.UpdateCTHD(a);
        }
        public bool DeleteCTHD(DTO_CTHD a)
        {
            return dalhd.DeleteCTHD(a);
        }

        public List<HoaDon> SearchTheoNgay(string pNgayBD, string pNgayKT)
        {
            return dalhd.searchHD(pNgayBD,pNgayKT);
        }
    }
}
