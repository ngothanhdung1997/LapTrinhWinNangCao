using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Fashion
{
    public class DTO_NhaCC
    {
        private int _MaNCC;
        private string _TenNCC;
        private string _Diachi;
        private string _SDT;

        public int MaNCC
        {
            get { return _MaNCC; }
            set { _MaNCC = value; }
        }
        public string TenNCC
        {
            get { return _TenNCC; }
            set { _TenNCC = value; }
        }
        public string Diachi
        {
            get { return _Diachi; }
            set { _Diachi = value; }
        }
        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }
        public DTO_NhaCC(string TenNCC, string diachi, string sdt)
        {
            this.TenNCC = TenNCC;
            this.Diachi = diachi;
            this.SDT = sdt;
        }
        public DTO_NhaCC(int MaNCC,string TenNCC, string diachi, string sdt)
        {
            this.MaNCC = MaNCC;
            this.TenNCC = TenNCC;
            this.Diachi = diachi;
            this.SDT = sdt;
        }
        public DTO_NhaCC(int MaNCC)
        {
            this.MaNCC = MaNCC;
        }
    }
}
