using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTWNCFashion
{
    public partial class Main : Form
    {
        NguoiDung CauHinh = new NguoiDung();
        public Main()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmkh = new FrmKhachHang();
            frmkh.MdiParent = this;
            frmkh.Show();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTenDangNhap.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống " + lblTenDangNhap.Text.ToLower());
                this.txtTenDangNhap.Focus();
                return;
            }

            if (string.IsNullOrEmpty(this.txtMatKhau.Text))
            {
                MessageBox.Show("Không được bỏ trống " + lblMatkhau.Text.ToLower());
                this.txtMatKhau.Focus();
                return;
            }
            if (CauHinh.Check_Config() == 0)
            {
                int n = CauHinh.Check_User(txtTenDangNhap.Text, txtMatKhau.Text);
                if (n == 0)
                    MessageBox.Show("Tên đăng nhập không tồn tại !");
                if (n == 1)
                {
                    MessageBox.Show("Đăng nhâp thành công !");
                    List<string> a = CauHinh.getDatatable(txtTenDangNhap.Text.Trim());
                    // c = { dmin, KH,NH};
                    pnlQuanly.Hide();
                    CauHinh.PhanQuyen(ribbonControl1, a);
                }
                if (n == 2)
                    MessageBox.Show("Tài khoản không hoạt động !");
            }
            //if (CauHinh.Check_Config() == 1)
            //{
            //    CauHinhServer a = new CauHinhServer();
            //    a.Show();
            //}
            //if (CauHinh.Check_Config() == 2)
            //{
            //    CauHinhServer a = new CauHinhServer();
            //    a.Show();
            //}
            //var frmMain = new Main();
            //frmMain.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
        