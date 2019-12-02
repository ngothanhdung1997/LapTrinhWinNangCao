using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Fashion
{
    public class DTO_HoaDon
    {
        private string _MaHD;
        private string _MaNV;
        private string _MaKH;
        private string _TongTien;
        private DateTime _NgayLapHD;
        private string _SDT;
        private string _GhiChu;

        public string MaHD { get => _MaHD; set => _MaHD = value; }
        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public string TongTien { get => _TongTien; set => _TongTien = value; }
        public DateTime NgayLapHD { get => _NgayLapHD; set => _NgayLapHD = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string GhiChu { get => _GhiChu; set => _GhiChu = value; }
        //insert and update
        public DTO_HoaDon(string mahd, string manv, string makh, string tongtien, DateTime ngaylaphd, string sdt, string ghichu)
        {
            this.MaHD = mahd;
            this.MaNV = manv;
            this.MaKH = makh;
            this.TongTien = tongtien;
            this.NgayLapHD = ngaylaphd;
            this.SDT = sdt;
            this.GhiChu = ghichu;
        }
        //Delete 
        public DTO_HoaDon(string mahd)
        {
            this.MaHD = mahd;
        }
    }
}
