using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Fashion;
using DTO_Fashion;


namespace BUS_Fashion
{
    public class BUS_KhachHang
    {
         DAL_KhachHang dalkhachhang = new DAL_KhachHang();
        public DataTable getListKhachHang()
        {
            return dalkhachhang.getKhachHang();
        }
        public bool InsertKhachHang(DTO_KhachHang a)
        {
            return dalkhachhang.InsertKhachHang(a);
        }
        public bool UpdateKhachHang(DTO_KhachHang a)
        {
            return dalkhachhang.UpdateKhachHang(a);
        }
        public bool DeleteKhachHang(DTO_KhachHang a)
        {
            return dalkhachhang.DeleteKhachHang(a);
        }
    }
}
