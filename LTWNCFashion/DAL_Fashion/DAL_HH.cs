using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Fashion
{
    public class DAL_HH : Context
    {
        public List<HangHoa> getHH()
        {
            return db.HangHoas.Select(t => t).ToList<HangHoa>();
        }
        public List<HangHoa> getGiaBan(string pMaH)
        {
            return db.HangHoas.Where(t => t.MaHang == int.Parse(pMaH)).ToList<HangHoa>();
        }
        public List<TheLoai> getTheLoai()
        {
            return db.TheLoais.Select(t => t).ToList<TheLoai>();
        }
        public List<ThuongHieu> getThuongHieu()
        {
            return db.ThuongHieus.Select(t => t).ToList<ThuongHieu>();
        }
    }
}
