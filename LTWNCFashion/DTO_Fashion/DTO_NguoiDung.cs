using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Fashion
{
    public class DTO_NguoiDung
    {
        private string _TenDangNhap;
        private string _MatKhau;
        private int _TinhTrang;
        //private string _Ho;
        //private string _Ten;
        //private int _NamSinh;
        //private string _GioiTinh;
        //private decimal _Luong;

        public string TenDangNhap
        {
            get { return _TenDangNhap; }
            set { _TenDangNhap = value; }
        }
        public string MatKhau
        {
            get { return _MatKhau; }
            set { _MatKhau = value; }
        }
        public int TinhTrang
        {
            get { return _TinhTrang; }
            set { _TinhTrang = value; }
        }
        public DTO_NguoiDung(string tendangnhap, string matkhau, int tinhtrang)
        {
            this.TenDangNhap = tendangnhap;
            this.MatKhau = matkhau;
            this.TinhTrang = tinhtrang;
        }
    }
}
