using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Fashion
{
    public class DTO_CTHD
    {
        private string _MaHD;
        private string _MaH;
        private string _SLBan;
        private string _GiaBan;
        private string _ThanhTien;

        public string MaHD { get => _MaHD; set => _MaHD = value; }
        public string MaH { get => _MaH; set => _MaH = value; }
        public string SLBan { get => _SLBan; set => _SLBan = value; }
        public string GiaBan { get => _GiaBan; set => _GiaBan = value; }
        public string ThanhTien { get => _ThanhTien; set => _ThanhTien = value; }
        //insert and update cthd
        public DTO_CTHD(string mahd, string mah, string slban, string giaban, string thanhtien)
        {
            this.MaHD = mahd;
            this.MaH = mah;
            this.SLBan = slban;
            this.GiaBan = giaban;
            this.ThanhTien = thanhtien;
        }
        //Delete 
        public DTO_CTHD(string mahd, string mah)
        {
            this.MaHD = mahd;
            this.MaH = mah;
        }
    }
}
