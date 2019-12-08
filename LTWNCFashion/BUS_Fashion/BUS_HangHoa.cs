using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Fashion;
using DTO_Fashion;
namespace BUS_Fashion
{
    public class BUS_HangHoa
    {
        DAL_HangHoa dalhh = new DAL_HangHoa();
        public List<HangHoa> getListHangHoa()
        {
            return dalhh.getHangHoa();
        }
        public bool InsertHangHoa(DTO_HangHoa a)
        {
            return dalhh.InsertHangHoa(a);
        }
        public bool UpdateHangHoa(DTO_HangHoa a)
        {
            return dalhh.UpdateHangHoa(a);
        }
        public bool DeleteHangHoa(DTO_HangHoa a)
        {
            return dalhh.DeleteHangHoa(a);
        }
    }
}
