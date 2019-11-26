using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Fashion;
using DAL_Fashion;
using System.Data;
using System.Data.SqlClient;



namespace BUS_Fashion
{
    public class BUS_NguoiDung
    {

        DAL_NguoiDung dalNguoiDung = new DAL_NguoiDung();
        public DataTable getListNguoiDung()
        {
            return dalNguoiDung.getNguoiDung();
        }
        public bool UpdateNguoiDung(DTO_NguoiDung a)
        {
            return dalNguoiDung.UpdateNguoiDung(a);
        }
        public bool InsertNguoiDung(DTO_NguoiDung a)
        {
            return dalNguoiDung.InsertNguoiDung(a);
        }


    }
}
