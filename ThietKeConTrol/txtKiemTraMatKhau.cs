using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
namespace ThietKeConTrol
{
    public class txtKiemTraMatKhau:TextEdit
    {
        public txtKiemTraMatKhau()
        {
            this.KeyPress += TxtKiemTraMatKhau_KeyPress;
        }

        private void TxtKiemTraMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                
            }
        }
    }
}
