using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Fashion
{
    public class DTO_KhachHang
    {
        private string _MaKH;
        private string _TenKH;
        private string _GioiTinh;
        private string _DiaChi;
        private string _SDT;
        private string _Email;

        public string MaKH
        {
            get { return _MaKH; }
            set { _MaKH = value; }
        }
        public string TenKH
        {
            get { return _TenKH; }
            set { _TenKH = value; }
        }
        public string GioiTinh
        {
            get { return _GioiTinh; }
            set { _GioiTinh = value; }
        }
        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        // insert
        public DTO_KhachHang ( string tenkh,string gioitinh, string diachi, string sdt,string email)
        {
            this.TenKH = tenkh;
            this.GioiTinh = gioitinh;
            this.DiaChi = diachi;
            this.SDT = sdt;
            this.Email = email;
        }
        // update
        public DTO_KhachHang (string makh,string tenkh,string gioitinh, string diachi, string sdt,string email)
        {
            this.MaKH = makh;
            this.TenKH = tenkh;
            this.GioiTinh = gioitinh;
            this.DiaChi = diachi;
            this.SDT = sdt;
            this.Email = email;
        }
        public DTO_KhachHang(string makh)
        {
            this.MaKH = makh;
        }


    }
}
