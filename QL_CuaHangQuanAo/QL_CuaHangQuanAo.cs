using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using QL_CuaHangQuanAo.model;

namespace QL_CuaHangQuanAo
{
    public partial class QL_CuaHangQuanAo : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        
        public static string user;
        public static string idlogin;
        public QL_CuaHangQuanAo()
        {
            InitializeComponent();
            DisEndMenuLogin(true,idlogin);
        }
        public void skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Office 2007 Blue";
        }

        public void DisEndMenuLogin(bool e, string _idLogin)
        {
            btn_Login.Enabled = e;
            btn_Changepass.Enabled = !e;
            btn_Logout.Enabled = !e;
            btn_PhanQuyen.Enabled = !e;
            btn_PhucHoi.Enabled = !e;
            btn_SaoLuu.Enabled = !e;
        }

        private void QL_CuaHangQuanAo_Load(object sender, EventArgs e)
        {
            skin();
        }


        private void QL_CuaHangQuanAo_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Btn_Login_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormDangNhap login = null;
            Check_Login:
            if (login == null || login.IsDisposed)
                login = new FormDangNhap();
            if (login.ShowDialog() == DialogResult.OK)
            {
                if (login.txt_User.Text == "")
                {
                    XtraMessageBox.Show("Hãy Nhập username!");
                    goto Check_Login;
                }
                if (login.txt_Password.Text == "")
                {
                    XtraMessageBox.Show("Hãy Nhập password!");
                    goto Check_Login;
                }
                string check = "";
                string username = login.txt_User.Text;
                //goi ham SHA256 ma hoa mat khau
                string pass = login.txt_Password.Text;
                check = model.LoginCtrl.CheckDangNhap(username, pass);
                if (check == "")
                {
                    XtraMessageBox.Show("Đăng nhập thất bại. Kiểm tra lại username or password!");
                    goto Check_Login;
                }
                else
                {
                    DisEndMenuLogin(false, idlogin);
                }
            }
        }

        private void Btn_Logout_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn đăng xuất?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DisEndMenuLogin(true, idlogin);
                Btn_Logout_ItemClick(sender, e);
            }
        }
    }
}