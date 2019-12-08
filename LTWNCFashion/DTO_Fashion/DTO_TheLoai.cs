using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Fashion
{
    public class DTO_TheLoai
    {
        private int _MaLoai;
        private string _TenLoai;

        public int MaLoai
        {
            get { return _MaLoai; }
            set { _MaLoai = value; }
        }
        public string TenLoai
        {
            get { return _TenLoai; }
            set { _TenLoai = value; }
        }
        public DTO_TheLoai(int MaLoai, string TenLoai)
        {
            this.MaLoai = MaLoai;
            this.TenLoai = TenLoai;
        }
        public DTO_TheLoai(int MaLoai)
        {
            this.MaLoai = MaLoai;
        }
        public DTO_TheLoai(string TenLoai)
        {
            this.TenLoai = TenLoai;
        }
    }
}
