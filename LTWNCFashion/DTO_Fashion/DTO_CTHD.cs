using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Fashion
{
    public class DTO_CTHD
    {
        private int _MaHD;
        private int _MaH;
        private int _SLBan;
        private int _GiaBan;
        private int _ThanhTien;

        public int MaHD { get => _MaHD; set => _MaHD = value; }
        public int MaH { get => _MaH; set => _MaH = value; }
        public int SLBan { get => _SLBan; set => _SLBan = value; }
        public int GiaBan { get => _GiaBan; set => _GiaBan = value; }
        public int ThanhTien { get => _ThanhTien; set => _ThanhTien = value; }
        //insert and update cthd
        public DTO_CTHD(int mahd, int mah, int slban, int giaban, int thanhtien)
        {
            this.MaHD = mahd;
            this.MaH = mah;
            this.SLBan = slban;
            this.GiaBan = giaban;
            this.ThanhTien = thanhtien;
        }
        //Delete 
        public DTO_CTHD(int mahd, int mah)
        {
            this.MaHD = mahd;
            this.MaH = mah;
        }
    }
}
