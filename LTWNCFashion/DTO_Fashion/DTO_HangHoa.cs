using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace DTO_Fashion
{
    public class DTO_HangHoa
    {
        private int _MaH;
        private int _MaTH;
        private int _MaL;
        private string _TenH;
        private int _DonGiaNhap;
        private int _DonGiaBan;
        private int _SoL;
        private string _DVT;
        private string _MoTa;
        private Byte[] _img;

        public int MaHang
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
        public byte[] img
        {
            get { return _img; }
            set { _img = value; }
        }

        public int DonGiaNhap { get => _DonGiaNhap; set => _DonGiaNhap = value; }
        public int DonGiaBan { get => _DonGiaBan; set => _DonGiaBan = value; }
        //insert
        public DTO_HangHoa(int math, int mal, string tenh, int dongianhap, int dongiaban, int soluong, string dvt, string mota, byte[] img)
        {
            this.MaThuongHieu = math;
            this.MaLoai = mal;
            this.TenHang = tenh;
            this.DonGiaNhap = dongianhap;
            this.DonGiaBan = dongiaban;
            this.SoluongTon = soluong;
            this.DVT = dvt;
            this.MoTa = mota;
            this.img = img;
        }
        //update
        public DTO_HangHoa(int mah, int math, int mal, string tenh, int dongianhap, int dongiaban, int soluong, string dvt, string mota, byte[] img)
        {
            this.MaHang = mah;
            this.MaThuongHieu = math;
            this.MaLoai = mal;
            this.TenHang = tenh;
            this.DonGiaNhap = dongianhap;
            this.DonGiaBan = dongiaban;
            this.SoluongTon = soluong;
            this.DVT = dvt;
            this.MoTa = mota;
            this.img = img;
        }
        //delete
        public DTO_HangHoa(int mah)
        {
            this.MaHang = mah;
        }
    }
}
