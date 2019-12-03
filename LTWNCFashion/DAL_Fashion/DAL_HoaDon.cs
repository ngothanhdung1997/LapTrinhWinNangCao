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
        public List<NhanVien> getNVtheoma(string pMaNV)
        {
            return db.NhanViens.Where(t => t.MaNV == int.Parse(pMaNV)).ToList<NhanVien>();

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
        public DataTable getCTHDtheoma(string pMaHD)
        {
            //return db.CT_HDs.Where(t => t.MaHD == int.Parse(pMaHD)).ToList<CT_HD>();
            var CTHD = (from cthd in db.CT_HDs
                        join hh in db.HangHoas on cthd.MaHang equals hh.MaHang
                        where cthd.MaHD == int.Parse(pMaHD)
                        select new
                        {
                            MaHang = cthd.MaHang,
                            TenHang = hh.TenHang,
                            SLBan = cthd.SLBan,
                            GiaBan = cthd.GiaBan,
                            ThanhTien = cthd.ThanhTien
                        });
            var resultTable = new DataTable();
            bool firstPass = true;
            foreach (var item in CTHD)
            {
                if (firstPass)
                {
                    Array.ForEach(item.GetType().GetProperties(), p => resultTable.Columns.Add(new DataColumn(p.Name)));
                    firstPass = false;
                }
                var newRow = resultTable.NewRow();
                Array.ForEach(item.GetType().GetProperties(), p => newRow[p.Name] = p.GetValue(item, null));
                resultTable.Rows.Add(newRow);
            }
            return resultTable;
        }
        //insert chi tiet hoa don
        public bool InsertCTHD(DTO_CTHD a)
        {
            try
            {
                CT_HD insert = new CT_HD();
                insert.MaHD = int.Parse(a.MaHD);
                insert.MaHang = int.Parse(a.MaH);
                insert.SLBan = int.Parse(a.SLBan);
                insert.GiaBan = int.Parse(a.GiaBan);
                insert.ThanhTien = int.Parse(a.ThanhTien); 
                db.CT_HDs.InsertOnSubmit(insert);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Update Chi Tiet Hoa Don
        public bool UpdateCTHD(DTO_CTHD a)
        {
            try
            {
                CT_HD update = db.CT_HDs.Where(p => p.MaHD.ToString().Equals(a.MaHD) && p.MaHang.ToString().Equals(a.MaH)).SingleOrDefault(); 
                update.SLBan = int.Parse(a.SLBan);
                update.GiaBan = int.Parse(a.GiaBan);
                update.ThanhTien = int.Parse(a.ThanhTien);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Delete Chi Tiet Hoa Don
        public bool DeleteCTHD(DTO_CTHD a)
        {
            try
            {
                CT_HD delete = db.CT_HDs.Where(p => p.MaHD.ToString().Equals(a.MaHD) && p.MaHang.ToString().Equals(a.MaH)).SingleOrDefault();
                db.CT_HDs.DeleteOnSubmit(delete);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
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
        //Search Hóa đơn theo ngày
        public List<HoaDon> searchHD(string pNgayBD, string pNgayKT)
        {
            return db.HoaDons.Where(t => t.NgayLapHD >= DateTime.Parse(pNgayBD) && t.NgayLapHD <= DateTime.Parse(pNgayKT)).ToList<HoaDon>();
        }
    }
}
