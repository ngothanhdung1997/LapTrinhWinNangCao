using DevExpress.XtraEditors;
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
    public partial class CauHinh : Form
    {
        NguoiDung nd = new NguoiDung();
        public CauHinh()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            nd.ChangeConnectionString(cbosv.Text, cboDt.Text, txtuser.Text, txtpss.Text);
            this.Close();
        }

        private void cbosv_DropDown(object sender, EventArgs e)
        {
            cbosv.DataSource = nd.GetServerName();
            cbosv.DisplayMember = "ServerName";
        }

        private void cboDt_DropDown(object sender, EventArgs e)
        {
            cboDt.DataSource = nd.GetDatabaseName(cbosv.Text, txtuser.Text, txtpss.Text);
            cboDt.DisplayMember = "name";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn hủy?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
