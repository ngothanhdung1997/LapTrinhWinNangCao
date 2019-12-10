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
        //Update lai so luong ton
        public void Updatesoluonggiam(int pMaH, int soluong)
        {
            HangHoa hh = new HangHoa();
            hh = db.HangHoas.Where(t => t.MaHang == pMaH).FirstOrDefault();
            hh.SoluongTon = hh.SoluongTon - soluong;
            db.SubmitChanges();
        }
        public void Updatesoluongtang(int pMaH, int soluong)
        {
            HangHoa hh = new HangHoa();
            hh = db.HangHoas.Where(t => t.MaHang == pMaH).FirstOrDefault();
            hh.SoluongTon = hh.SoluongTon + soluong;
            db.SubmitChanges();
        }

        // lay gia ban theo ma sp
        public string laygiaban(string pmasp)
        {
            string a = "";
            var HH = from sp in db.HangHoas
                     where sp.MaHang.ToString() == pmasp
                     select new
                     {
                         sp.DonGiaBan
                     };
            if (HH.Count() > 0)
            {
                foreach (var c in HH)
                {
                    a = c.DonGiaBan.ToString();
                }
            }
            return a;
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
