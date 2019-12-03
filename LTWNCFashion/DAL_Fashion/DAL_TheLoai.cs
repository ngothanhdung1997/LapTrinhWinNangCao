using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Fashion;
using System.Data;
namespace DAL_Fashion
{
    public class DAL_TheLoai:Context
    {
        public DataTable getTheLoai()
        {
            var kh = db.TheLoais.Select(t => t);
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
        public bool InsertNTheLoai(DTO_TheLoai a)
        {
            try
            {
                TheLoai insert = new TheLoai();
                insert.Tenloai = a.TenLoai;
                db.TheLoais.InsertOnSubmit(insert);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateTheLoai(DTO_TheLoai a)
        {
            try
            {

                TheLoai update = db.TheLoais.Where(p => p.MaLoai.ToString().Equals(a.MaLoai)).SingleOrDefault();
                update.Tenloai = a.TenLoai;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteTheLoai(DTO_TheLoai a)
        {
            try
            {
                TheLoai delete = db.TheLoais.Where(p => p.MaLoai.ToString().Equals(a.MaLoai)).SingleOrDefault();
                db.TheLoais.DeleteOnSubmit(delete);
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
