using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Fashion
{
    public class DTO_NhanVien
    {
        private int _MaNV;
        private string _TenNV;
        private string _GioiTinh;
        private DateTime _NgaySinh;
        private string _DiaChi;
        private string _SDT;
        private string _Email;
        private DateTime _NgayVaoLam;
        private Byte[] _Image;

        public int MaNV { get => _MaNV; set => _MaNV = value; }
        public string TenNV { get => _TenNV; set => _TenNV = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public DateTime NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string Email { get => _Email; set => _Email = value; }
        public DateTime NgayVaoLam { get => _NgayVaoLam; set => _NgayVaoLam = value; }
        public byte[] Image { get => _Image; set => _Image = value; }

        // Insert 
        public DTO_NhanVien(string tennv, string gioitinh, DateTime ngaysinh, string diachi, string sdt, string email, DateTime ngayvaolam, byte[] img)
        {
            this.TenNV = tennv;
            this.GioiTinh = gioitinh;
            this.NgaySinh = ngaysinh;
            this.DiaChi = diachi;
            this.SDT = sdt;
            this.Email = email;
            this.NgayVaoLam = ngayvaolam;
            this.Image = img;
        }
        //Update
        public DTO_NhanVien(int manv, string tennv, string gioitinh, DateTime ngaysinh, string diachi, string sdt, string email, DateTime ngayvaolam, byte[] img)
        {
            this.MaNV = manv;
            this.TenNV = tennv;
            this.GioiTinh = gioitinh;
            this.NgaySinh = ngaysinh;
            this.DiaChi = diachi;
            this.SDT = sdt;
            this.Email = email;
            this.NgayVaoLam = ngayvaolam;
            this.Image = img;
        }
        // Delete nhan vien
        public DTO_NhanVien(int manv)
        {
            this.MaNV = manv;
        }
    }
}
