using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
namespace QL_CuaHangQuanAo.model
{
   public class Loginmod
    {
        protected string user { get; set; }
        protected string pass { get; set; }
        //bien kiem tra trang thai
        protected bool status { get; set; }

        public Loginmod(string _user, string _pass)
        {
            this.user = _user;
            this.pass = _pass;
        }
        //check dangnhap
        public string CheckDangNhap()
        {
            string str = "";
            //truyen vao 2 bien TaiKhoan va MatKhau trung vs csdl
            string[] para = new string[2] { "@TaiKhoan", "@MatKhau" };
            object[] value = new object[2] { user, pass };
            str = Connection.ExcuteScalar("CheckDangNhap", CommandType.StoredProcedure, para,value); 
            return str;
        }
    }
}
