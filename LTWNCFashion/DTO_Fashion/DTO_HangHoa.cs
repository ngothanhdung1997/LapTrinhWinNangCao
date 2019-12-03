using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Fashion
{
    public class DTO_HangHoa
    {
        private string _MaH;
        private int _MaTH;
        private int _MaL;
        private string _TenH;
        private int _DonG;
        private int _SoL;
        private string _DVT;
        private string _MoTa;
        private string _img;

        public string MaHang
        {
            get { return _MaH; }
            set { _MaH = value; }
        }
        public int MaThuongHieu
        {
            get { return _MaTH; }
            set { _MaTH = value; }
        }
        public int MaLoai
        {
            get { return _MaL; }
            set { _MaL = value; }
        }
        public string TenHang
        {
            get { return _TenH; }
            set { _TenH = value; }
        }
        public int Dongia
        {
            get { return _DonG; }
            set { _DonG = value; }
        }
        public int SoluongTon
        {
            get { return _SoL; }
            set { _SoL = value; }
        }
        public string DVT
        {
            get { return _DVT; }
            set { _DVT = value; }
        }
        public string MoTa
        {
            get { return _MoTa; }
            set { _MoTa = value; }
        }
        public string img
        {
            get { return _img; }
            set { _img = value; }
        }
        //insert and update
        public DTO_HangHoa(string mah, int math, int mal, string tenh, int dongia, int soluong, string dvt, string mota, string img)
        {
            this.MaHang = mah;
            this.MaThuongHieu = math;
            this.MaLoai = mal;
            this.TenHang = tenh;
            this.Dongia = dongia;
            this.SoluongTon = soluong;
            this.DVT = dvt;
            this.MoTa = mota;
            this.img = img;
        }
        //delete
        public DTO_HangHoa(string mah)
        {
            this.MaHang = mah;
        }
    }
}
