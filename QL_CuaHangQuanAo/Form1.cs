using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QL_CuaHangQuanAo
{
    public partial class QL_CHTT : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public QL_CHTT()
        {
            InitializeComponent();
        }

        private void AccordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void QL_CHTT_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
