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
    public class BUS_TheLoai
    {
        DAL_TheLoai dalTL = new DAL_TheLoai();
        public DataTable getListTheLoai()
        {
            return dalTL.getTheLoai();
        }
        public bool InsertTheLoai(DTO_TheLoai a)
        {
            return dalTL.InsertNTheLoai(a);
        }
        public bool UpdateTheLoai(DTO_TheLoai a)
        {
            return dalTL.UpdateTheLoai(a);
        }
        public bool DeleteTheLoai(DTO_TheLoai a)
        {
            return dalTL.DeleteTheLoai(a);
        }
    }
}

