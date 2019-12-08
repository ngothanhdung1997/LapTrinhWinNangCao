using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_Fashion;
using DevExpress.XtraEditors;
using DTO_Fashion;

namespace LTWNCFashion
{
    public partial class FrmKhachHang : Form
    {
        BUS_KhachHang bUS_KhachHang = new BUS_KhachHang();
        public FrmKhachHang()
        {
            InitializeComponent();
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
            txtMakh.Enabled = false;
            txtDiachi.Enabled = false;
            txtTenkh.Enabled = false;
            txtsdt.Enabled = false;
            txtEmail.Enabled = false;
        }
        public void LoadData()
        {
            dataGridView1.DataSource = bUS_KhachHang.getListKhachHang();
            btn_luu.Enabled = false;
            
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            btn_luu.Enabled = true;
            txtDiachi.Enabled = true;
            txtTenkh.Enabled = true;
            txtsdt.Enabled = true;
            txtEmail.Enabled = true;
            foreach (Control item in this.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    item.Text = "";
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_KhachHang kh = new DTO_KhachHang(txtMakh.Text);
                bUS_KhachHang.DeleteKhachHang(kh);
                LoadData();
                XtraMessageBox.Show("Xóa thành công.");
            }
            catch
            {
                XtraMessageBox.Show("Xóa thất bại.");
            }
            

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_KhachHang kh = new DTO_KhachHang(txtMakh.Text,txtTenkh.Text,cboGT.Text,txtDiachi.Text,txtsdt.Text,txtEmail.Text);
                bUS_KhachHang.UpdateKhachHang(kh);
                LoadData();
                XtraMessageBox.Show("Sửa thành công.");
            }
            catch
            {
                XtraMessageBox.Show("Sửa thất bại.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;

            txtMakh.Text = dataGridView1.Rows[numrow].Cells[0].Value.ToString();
            txtTenkh.Text = dataGridView1.Rows[numrow].Cells[1].Value.ToString();
            txtDiachi.Text = dataGridView1.Rows[numrow].Cells[3].Value.ToString();
            txtsdt.Text = dataGridView1.Rows[numrow].Cells[4].Value.ToString();
            cboGT.Text = dataGridView1.Rows[numrow].Cells[2].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[numrow].Cells[5].Value.ToString();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_KhachHang kh = new DTO_KhachHang(txtMakh.Text, txtTenkh.Text, cboGT.Text, txtDiachi.Text, txtsdt.Text, txtEmail.Text);
                bUS_KhachHang.InsertKhachHang(kh);
                LoadData();
                XtraMessageBox.Show("Thêm thành công.");
            }
            catch
            {
                XtraMessageBox.Show("Thêm thất bại.");
            }
            
            //if (XtraMessageBox.Show("Bạn có muốn đóng?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    this.Close();
            //    QL_HoaDon f = new QL_HoaDon();
            //    f.Refresh();
            //}
        }
    }
}
