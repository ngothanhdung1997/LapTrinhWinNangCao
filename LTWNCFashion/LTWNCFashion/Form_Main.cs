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

namespace LTWNCFashion
{
    public partial class Form_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        NguoiDung nd = new NguoiDung();
        public static string idlogin;
        public Form_Main()
        {
            InitializeComponent();
            DisEndMenuLogin(true, idlogin);
        }
        public void DisEndMenuLogin(bool e, string _idLogin)
        {
            btn_DN.Enabled = e;
            btn_DX.Enabled = !e;
            Page_TT.Visible = !e;
            Page_DM.Visible = !e;
            Page_NV.Visible = !e;
        }
        private void btn_DSKH_ItemClick(object sender, ItemClickEventArgs e)
        {

            Form frm = ktraform(typeof(FrmKhachHang));
            if (frm == null)
            {
                FrmKhachHang f = new FrmKhachHang();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }
        private Form ktraform(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }
        private void btn_DN_ItemClick(object sender, ItemClickEventArgs e)
        {
            Login login = null;
        Check_Login:
            if (login == null || login.IsDisposed)
            { 
                login = new Login();
            }
            if (login.ShowDialog() == DialogResult.OK)
            {
                if (login.txt_User.Text == "")
                {
                    XtraMessageBox.Show("Hãy Nhập username!");
                    login.txt_User.Focus();
                    goto Check_Login;
                }
                if (login.txt_Password.Text == "")
                {
                    XtraMessageBox.Show("Hãy Nhập password!");
                    login.txt_Password.Focus();
                    goto Check_Login;
                }
                if (nd.Check_Config() == 0)
                {
                    int n = nd.Check_User(login.txt_User.Text, login.txt_Password.Text);
                    if (n == 0)
                        XtraMessageBox.Show("Tên đăng nhập không tồn tại !");
                    if (n == 1)
                    {
                        XtraMessageBox.Show("Đăng nhâp thành công !");
                        List<string> a = nd.getDatatable(login.txt_User.Text.Trim());
                        login.Close();
                        DisEndMenuLogin(false, idlogin);
                        // c = { dmin, KH,NH};
                        //pnlQuanly.Hide();
                        nd.PhanQuyen(ribbon, a);
                    }
                    if (n == 2)
                        XtraMessageBox.Show("Tài khoản không hoạt động !");
                }
                else if (nd.Check_Config() == 1 || nd.Check_Config() == 2)
                {
                    CauHinh ch = new CauHinh();
                    XtraMessageBox.Show("Cấu hình không tồn tại!");
                    ch.Show();
                }
            }
            }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = ktraform(typeof(FrmHangHoa));
            if (frm == null)
            {
                FrmHangHoa f = new FrmHangHoa();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btn_DX_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn đăng xuất?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DisEndMenuLogin(true, idlogin);
            }
        }

        private void btn_Close_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn đóng ứng dụng?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = ktraform(typeof(QL_HoaDon));
            if (frm == null)
            {
                QL_HoaDon f = new QL_HoaDon();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }
    }
}