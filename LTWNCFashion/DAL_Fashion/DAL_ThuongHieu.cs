using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Fashion;
using System.Data;
namespace DAL_Fashion
{
    public class DAL_ThuongHieu:Context
    {
        
        public DataTable getThuongHieu()
        {
            var kh = db.ThuongHieus.Select(t => t);
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
        public bool InsertNThuongHieu(DTO_ThuongHieu a)
        {
            try
            {
                ThuongHieu insert = new ThuongHieu();
                insert.TenTH = a.TenTH;
                db.ThuongHieus.InsertOnSubmit(insert);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateThuongHieu(DTO_ThuongHieu a)
        {
            try
            {

                ThuongHieu update = db.ThuongHieus.Where(p => p.MaThuongHieu.ToString().Equals(a.MaThuongHieu)).SingleOrDefault();
                update.TenTH = a.TenTH;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteThuongHieu(DTO_ThuongHieu a)
        {
            try
            {
                ThuongHieu delete = db.ThuongHieus.Where(p => p.MaThuongHieu.ToString().Equals(a.MaThuongHieu)).SingleOrDefault();
                db.ThuongHieus.DeleteOnSubmit(delete);
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

