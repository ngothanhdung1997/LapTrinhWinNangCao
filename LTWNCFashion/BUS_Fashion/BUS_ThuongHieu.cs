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
    public class BUS_ThuongHieu
    {
        DAL_ThuongHieu dAL_ThuongHieu = new DAL_ThuongHieu();
        public DataTable getListThuongHieu()
        {
            return dAL_ThuongHieu.getThuongHieu();
        }
        public bool InsertThuongHieu(DTO_ThuongHieu a)
        {
            return dAL_ThuongHieu.InsertNThuongHieu(a);
        }
        public bool UpdateThuongHieu(DTO_ThuongHieu a)
        {
            return dAL_ThuongHieu.UpdateThuongHieu(a);
        }
        public bool DeleteThuongHieu(DTO_ThuongHieu a)
        {
            return dAL_ThuongHieu.DeleteThuongHieu(a);
        }
    }
}
