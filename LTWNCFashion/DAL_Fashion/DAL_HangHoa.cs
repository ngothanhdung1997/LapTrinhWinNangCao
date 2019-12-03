using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Fashion;
namespace DAL_Fashion
{
    public class DAL_HangHoa:Context
    {
        public DataTable getHangHoa()
        {
            var hh = db.HangHoas.Select(t => t);
            var resultTable = new DataTable();
            bool firstPass = true;
            foreach (var item in hh)
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
        //insert hang hoa
        public bool InsertHangHoa(DTO_HangHoa a)
        {
            try
            {
                HangHoa insert = new HangHoa();
                insert.MaThuongHieu = a.MaThuongHieu;
                insert.MaLoai = a.MaLoai;
                insert.TenHang = a.TenHang;
                insert.DonGiaNhap = a.DongiaNhap;
                insert.DonGiaBan = a.DongiaBan;
                insert.SoluongTon = a.SoluongTon;
                insert.DVT = a.DVT;
                insert.MoTa = a.MoTa;
                insert.img = a.img;
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

                HangHoa update = db.HangHoas.Where(p => p.MaHang.ToString().Equals(a.MaHang)).SingleOrDefault();
                update.MaThuongHieu = a.MaThuongHieu;
                update.MaLoai = a.MaLoai;
                update.TenHang = a.TenHang;
                update.DonGiaNhap = a.DongiaNhap;
                update.DonGiaBan = a.DongiaBan;
                update.SoluongTon = a.SoluongTon;
                update.DVT = a.DVT;
                update.MoTa = a.MoTa;
                update.img = a.img;
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
                HangHoa delete = db.HangHoas.Where(p => p.MaHang.ToString().Equals(a.MaHang)).SingleOrDefault();
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
