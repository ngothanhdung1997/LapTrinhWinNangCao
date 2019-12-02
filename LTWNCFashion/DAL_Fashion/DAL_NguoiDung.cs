using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO_Fashion;
using System.Data;

namespace DAL_Fashion
{
    public class DAL_NguoiDung
    {
        DBFashionDataContext db = new DBFashionDataContext();
        public DataTable getNguoiDung()
        {
            var nd = db.QL_NguoiDungs.Select(t => t);
            var resultTable = new DataTable();
            bool firstPass = true;
            foreach (var item in nd)
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
        public bool UpdateNguoiDung(DTO_NguoiDung a)
        {
            try
            {
                QL_NguoiDung update = db.QL_NguoiDungs.Where(p => p.TenDangNhap.Trim().Equals(a.TenDangNhap)).SingleOrDefault();
                update.MatKhau = a.MatKhau;
                update.TinhTrang = a.TinhTrang;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool InsertNguoiDung(DTO_NguoiDung a)
        {
            try
            {
                QL_NguoiDung insert = new QL_NguoiDung();
                insert.TenDangNhap = a.TenDangNhap;
                insert.MatKhau = a.MatKhau;
                insert.TinhTrang = a.TinhTrang;
                db.QL_NguoiDungs.InsertOnSubmit(insert);
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
