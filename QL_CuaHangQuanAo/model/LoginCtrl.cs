using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CuaHangQuanAo.model
{
    class LoginCtrl
    {
        public static string CheckDangNhap(string _user, string _pass)
        {
            try
            {
                model.Loginmod login = new model.Loginmod(_user, _pass);
                return login.CheckDangNhap();
            }
            catch { return ""; }
        }
    }
}
