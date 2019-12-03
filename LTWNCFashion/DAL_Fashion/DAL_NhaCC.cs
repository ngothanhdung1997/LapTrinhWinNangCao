using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using DTO_Fashion;
namespace DAL_Fashion
{
    public class DAL_NhaCC:Context
    {
        public DataTable getNhaCC()
        {
            var kh = db.NhaCCs.Select(t => t);
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
        public bool InsertNhaCC(DTO_NhaCC a)
        {
            try
            {
                NhaCC insert = new NhaCC();
                insert.TenNCC = a.TenNCC;
                insert.diachi = a.Diachi;
                insert.sdt = a.SDT;
                insert.sdt = a.SDT;
                db.NhaCCs.InsertOnSubmit(insert);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateNhaCC(DTO_NhaCC a)
        {
            try
            {

                NhaCC update = db.NhaCCs.Where(p => p.MaNCC.ToString().Equals(a.MaNCC)).SingleOrDefault();
                update.TenNCC = a.TenNCC;
                update.diachi = a.Diachi;
                update.sdt = a.SDT;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteNhaCC(DTO_NhaCC a)
        {
            try
            {
                NhaCC delete = db.NhaCCs.Where(p => p.MaNCC.ToString().Equals(a.MaNCC)).SingleOrDefault();
                db.NhaCCs.DeleteOnSubmit(delete);
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
