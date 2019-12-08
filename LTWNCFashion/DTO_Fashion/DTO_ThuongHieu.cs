using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Fashion
{
    public class DTO_ThuongHieu
    {
        private int _MaThuongHieu;
        private string _TenTH;

        public int MaThuongHieu
        {
            get { return _MaThuongHieu; }
            set { _MaThuongHieu = value; }
        }
        public string TenTH
        {
            get { return _TenTH; }
            set { _TenTH = value; }
        }
        public DTO_ThuongHieu(int MaThuongHieu, string TenTH)
        {
            this.MaThuongHieu = MaThuongHieu;
            this.TenTH = TenTH;
        }
        public DTO_ThuongHieu(int MaThuongHieu)
        {
            this.MaThuongHieu = MaThuongHieu;
        }
        public DTO_ThuongHieu(string TenTH)
        {
            this.TenTH = TenTH;
        }
    }
}
