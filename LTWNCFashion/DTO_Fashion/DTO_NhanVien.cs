using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Fashion
{
    public class DTO_NhanVien
    {
        private string _MaNV;
        private string _TenNV;
        private string _GioiTinh;
        private string _NgaySinh;
        private string _DiaChi;
        private string _SDT;
        private string _Email;
        private string _NgayVaoLam;

        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string TenNV { get => _TenNV; set => _TenNV = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string NgayVaoLam { get => _NgayVaoLam; set => _NgayVaoLam = value; }
        // Insert and Update
        public DTO_NhanVien(string manv, string tennv, string gioitinh, string ngaysinh, string diachi, string sdt, string email, string ngayvaolam)
        {
            this.MaNV = manv;
            this.TenNV = tennv;
            this.GioiTinh = gioitinh;
            this.NgaySinh = ngaysinh;
            this.DiaChi = diachi;
            this.SDT = sdt;
            this.Email = email;
            this.NgayVaoLam = ngayvaolam;
        }

        // Delete nhan vien
        public DTO_NhanVien(string manv)
        {
            this.MaNV = manv;
        }
    }
}
