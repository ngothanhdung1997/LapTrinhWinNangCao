using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Fashion;
using DTO_Fashion;
using System.Data;
namespace BUS_Fashion
{
    public class BUS_NhaCC
    {
        DAL_NhaCC dalNCC = new DAL_NhaCC();
        public DataTable getListNhaCC()
        {
            return dalNCC.getNhaCC();
        }
        public bool InsertNhaCC(DTO_NhaCC a)
        {
            return dalNCC.InsertNhaCC(a);
        }
        public bool UpdateNhaCC(DTO_NhaCC a)
        {
            return dalNCC.UpdateNhaCC(a);
        }
        public bool DeleteNhaCC(DTO_NhaCC a)
        {
            return dalNCC.DeleteNhaCC(a);
        }
    }
}
