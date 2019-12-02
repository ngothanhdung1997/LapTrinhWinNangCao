using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Fashion;
namespace DAL_Fashion
{
    public class DAL_HoaDon : Context
    {
        CultureInfo provider = CultureInfo.InvariantCulture;
        public List<KhachHang> getKH()
        {
            return db.KhachHangs.Select(t => t).ToList<KhachHang>();
        }

        public List<NhanVien> getNV()
        {
            return db.NhanViens.Select(t => t).ToList<NhanVien>();

        }
        public List<KhachHang> getKHtheoma(string pMaKH)
        {
            return db.KhachHangs.Where(t => t.MaKH == int.Parse(pMaKH)).ToList<KhachHang>();
        }
        public List<HoaDon> getHD()
        {
            return db.HoaDons.Select(t => t).ToList<HoaDon>();
            //var HD = (from hd in db.HoaDons
            //          select new
            //          {
            //              hd.MaHD,
            //              hd.MaNV,
            //              hd.MaKH,
            //              hd.NgayLapHD,
            //              hd.TongTien,
            //          });
            //var kq = HD.ToList().ConvertAll(t => new HoaDon
            //{
            //    MaHD = t.MaHD,
            //    MaNV = t.MaNV,
            //    MaKH = t.MaKH,
            //    TongTien = t.TongTien,
            //    NgayLapHD = t.NgayLapHD,
            //});
            //return kq;
        }
        public List<CT_HD> getCTHDtheoma(string pMaHD)
        {
            return db.CT_HDs.Where(t => t.MaHD == int.Parse(pMaHD)).ToList<CT_HD>();
            //var CTHD = (from cthd in db.CT_HDs
            //            from hh in db.HangHoas
            //            where cthd.MaHang == hh.MaHang && cthd.MaHD == int.Parse(pMaHD)
            //            select new
            //            {
            //                cthd.MaHD,
            //                cthd.MaHang,
            //                hh.TenHang,
            //                cthd.SLBan,
            //                cthd.GiaBan,
            //                cthd.ThanhTien
            //            });
            //return CTHD;
        }

        //insert hoa don
        public bool InsertHoaDon(DTO_HoaDon a)
        {
            
            try
            {
                HoaDon insert = new HoaDon();
                insert.MaNV = int.Parse(a.MaNV);
                insert.MaKH = int.Parse(a.MaKH);
                insert.TongTien = int.Parse(a.TongTien);
                //DateTime dt = Convert.ToDateTime(a.NgayLapHD).ToString("MM-dd-yyyy");
                //insert.NgayLapHD = dt;
                insert.NgayLapHD = a.NgayLapHD;
                insert.SDT = a.SDT;
                insert.GhiChu = a.GhiChu;
                db.HoaDons.InsertOnSubmit(insert);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Update Hoa Don
        public bool UpdateHoaDon(DTO_HoaDon a)
        {
            try
            {
                HoaDon update = db.HoaDons.Where(p => p.MaHD.ToString().Equals(a.MaHD)).SingleOrDefault();
                update.MaNV = int.Parse(a.MaNV);
                update.MaKH = int.Parse(a.MaKH);
                update.TongTien = int.Parse(a.TongTien);
                update.NgayLapHD = a.NgayLapHD;
                update.SDT = a.SDT;
                update.GhiChu = a.GhiChu;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Delete Hoa Don
        public bool DeleteHoaDon(DTO_HoaDon a)
        {
            try
            {
                HoaDon delete = db.HoaDons.Where(p => p.MaHD.ToString().Equals(a.MaHD)).SingleOrDefault();
                db.HoaDons.DeleteOnSubmit(delete);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
