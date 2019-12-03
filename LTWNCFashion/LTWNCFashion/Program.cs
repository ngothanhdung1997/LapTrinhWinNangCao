using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTWNCFashion
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Main());
            //Application.Run(new FrmKhachHang());
            //Application.Run(new FrmTheLoai());
            //Application.Run(new QL_HoaDon());
            //Application.Run(new FrmNhaCC());
            //Application.Run(new FrmThuongHieu());
            //Application.Run(new FrmHangHoa());
        }
        //public static Main main = null;
    }
}
