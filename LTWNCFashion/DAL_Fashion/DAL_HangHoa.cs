using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Fashion;
using System.Drawing;
using System.IO;
namespace DAL_Fashion
{
    public class DAL_HangHoa : Context
    {
        public List<HangHoa> getHangHoa()
        {
            return db.HangHoas.Select(t => t).ToList<HangHoa>();
            //var HH = (from hh in db.HangHoas
            //          select new
            //          {
            //              MaHang = hh.MaHang,
            //              MaThuongHieu = hh.MaThuongHieu,
            //              MaLoai = hh.MaLoai,
            //              TenHang = hh.TenHang,
            //              DonGiaNhap = hh.DonGiaNhap,
            //              DonGiaBan = hh.DonGiaBan,
            //              SoluongTon = hh.SoluongTon,
            //              DVT = hh.DVT,
            //              MoTa = hh.MoTa,
            //              HinhAnh = hh.HinhAnh
            //          });
            ////var hh = db.HangHoas.Select(t => t);
            //var resultTable = new DataTable();
            //bool firstPass = true;
            //foreach (var item in HH)
            //{
            //    if (firstPass)
            //    {
            //        Array.ForEach(item.GetType().GetProperties(), p => resultTable.Columns.Add(new DataColumn(p.Name)));
            //        firstPass = false;
            //    }
            //    var newRow = resultTable.NewRow();
            //    Array.ForEach(item.GetType().GetProperties(), p => newRow[p.Name] = p.GetValue(item, null));
            //    resultTable.Rows.Add(newRow);
            //}
            //return resultTable;
        }
        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }
        //insert hang hoa
        public bool InsertHangHoa(DTO_HangHoa a)
        {
            try
            {
                HangHoa insert = new HangHoa();
                Binary file_binary = new Binary(a.img);
                insert.MaThuongHieu = a.MaThuongHieu;
                insert.MaLoai = a.MaLoai;
                insert.TenHang = a.TenHang;
                insert.DonGiaNhap = a.DonGiaNhap;
                insert.DonGiaBan = a.DonGiaBan;
                insert.SoluongTon = a.SoluongTon;
                insert.DVT = a.DVT;
                insert.MoTa = a.MoTa;
                insert.HinhAnh = file_binary;
                insert.Size = a.Size;
                insert.MauSac = a.MauSac;
                insert.FileNam = a.Filename;
                db.HangHoas.InsertOnSubmit(insert);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Update Hang Hoa
        public bool UpdateHangHoa(DTO_HangHoa a)
        {
            try
            {
                Binary file_binary = new Binary(a.img);
                HangHoa update = db.HangHoas.Where(p => p.MaHang == a.MaHang).SingleOrDefault();
                update.MaThuongHieu = a.MaThuongHieu;
                update.MaLoai = a.MaLoai;
                update.TenHang = a.TenHang;
                update.DonGiaNhap = a.DonGiaNhap;
                update.DonGiaBan = a.DonGiaBan;
                update.SoluongTon = a.SoluongTon;
                update.DVT = a.DVT;
                update.MoTa = a.MoTa;
                update.HinhAnh = file_binary;
                update.Size = a.Size;
                update.MauSac = a.MauSac;
                update.FileNam = a.Filename;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Delete Hang Hoa
        public bool DeleteHangHoa(DTO_HangHoa a)
        {
            try
            {
                HangHoa delete = db.HangHoas.Where(p => p.MaHang == a.MaHang).SingleOrDefault();
                db.HangHoas.DeleteOnSubmit(delete);
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
