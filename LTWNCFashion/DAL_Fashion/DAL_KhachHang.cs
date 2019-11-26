using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Fashion;

namespace DAL_Fashion
{
    public class DAL_KhachHang
    {
        QL_SHOPDataContext db = new QL_SHOPDataContext();
        public DataTable getKhachHang()
        {
            var kh = db.KhachHangs.Select(t => t);
            var resultTable = new DataTable();
            bool firstPass = true;
            foreach (var item in kh)
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
        public bool InsertKhachHang(DTO_KhachHang a)
        {
            try
            {
                KhachHang insert = new KhachHang();
                insert.TenKH = a.TenKH;
                insert.Gioitinh = a.GioiTinh;
                insert.Diachi = a.DiaChi;
                insert.sdt = a.SDT;
                insert.email = a.Email;
                db.KhachHangs.InsertOnSubmit(insert);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }


        }
        public bool UpdateKhachHang(DTO_KhachHang a)
        {
            try
            {
                
                KhachHang update = db.KhachHangs.Where(p => p.MaKH.ToString().Equals(a.MaKH)).SingleOrDefault();
                update.TenKH = a.TenKH;
                update.Gioitinh = a.GioiTinh;
                update.Diachi = a.DiaChi;
                update.sdt = a.SDT;
                update.email = a.Email;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteKhachHang(DTO_KhachHang a)
        {
            try
            {
                KhachHang delete = db.KhachHangs.Where(p => p.MaKH.ToString().Equals(a.MaKH)).SingleOrDefault();
                db.KhachHangs.DeleteOnSubmit(delete);
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
