using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Fashion;
using DTO_Fashion;
namespace BUS_Fashion
{
    public class BUS_NhanVien
    {
        DAL_NhanVien dalnv = new DAL_NhanVien();
        public List<NhanVien> getNhanVien()
        {
            return dalnv.getNV();
        }
        //Load theo ma nv
        public List<NhanVien> getNhanVientheoma(string pManv)
        {
            return dalnv.getNVthoema(pManv);
        }
        public bool InsertNhanVien(DTO_NhanVien a)
        {
            return dalnv.InsertNhanVien(a);
        }
        //Xoa nhan vien
        public bool DeleteNhanVien(DTO_NhanVien a)
        {
            return dalnv.DeleteNhanVien(a);
        }
        //Update Nhan Vien
        public bool UpdateNhanVien(DTO_NhanVien a)
        {
            return dalnv.UpdateNhanVien(a);
        }
    }
}
