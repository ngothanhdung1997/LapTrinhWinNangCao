using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS_Fashion;
using DTO_Fashion;
using DAL_Fashion;

namespace LTWNCFashion
{
    public partial class QL_HoaDon : DevExpress.XtraEditors.XtraForm
    {
        BUS_HoaDon bshd = new BUS_HoaDon();
        DAL_HH hh = new DAL_HH();
        public QL_HoaDon()
        {
            InitializeComponent();
        }

        private void QL_HoaDon_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            gdv_HD.DataSource = bshd.getListHoaDon();
            cbo_TKH.DataSource = bshd.getListKhachHang();
            cbo_TKH.DisplayMember = "TenKH";
            cbo_TKH.ValueMember = "MaKH";
            cboTNV.DataSource = bshd.getListNhanVien();
            cboTNV.DisplayMember = "TenNV";
            cboTNV.ValueMember = "MaNV";
            cboTSP.DataSource = hh.getHH();
            cboTSP.DisplayMember = "TenHang";
            cboTSP.ValueMember = "MaHang";
        }

        private void gdv_HD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtMaHD.Text = gdv_HD.Rows[numrow].Cells[0].Value.ToString();
            cboTNV.Text = gdv_HD.Rows[numrow].Cells[1].Value.ToString();
            string makh = gdv_HD.Rows[numrow].Cells[2].Value.ToString();
            cbo_TKH.DataSource = bshd.getKHtheoma(makh);
            txtTT.Text = gdv_HD.Rows[numrow].Cells[3].Value.ToString();
            dateEdit1.EditValue = gdv_HD.Rows[numrow].Cells[4].Value.ToString();
            txtSDT.Text = gdv_HD.Rows[numrow].Cells[5].Value.ToString();
            txtGhiChu.Text = gdv_HD.Rows[numrow].Cells[6].Value.ToString();
            gdvCTHD.DataSource = bshd.getCTHD(txtMaHD.Text);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_HoaDon hd = new DTO_HoaDon(txtMaHD.Text, cbo_TKH.SelectedValue.ToString(),cboTNV.SelectedValue.ToString(),
                    txtTT.Text,DateTime.Parse(dateEdit1.DateTime.ToString()),txtSDT.Text,txtGhiChu.Text);
                bshd.InsertHoaDon(hd);
                XtraMessageBox.Show("Thêm thành công.");
                LoadData();
            }
            catch
            {
                XtraMessageBox.Show("Thêm thất bại.");
            }
            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_HoaDon hd = new DTO_HoaDon(txtMaHD.Text);
                bshd.DeleteHoaDon(hd);
                XtraMessageBox.Show("Xóa thành công.");
                LoadData();
            }
            catch
            {
                XtraMessageBox.Show("Xóa thất bại.");
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_HoaDon hd = new DTO_HoaDon(txtMaHD.Text, cbo_TKH.SelectedValue.ToString(), cboTNV.SelectedValue.ToString(),
                    txtTT.Text, DateTime.Parse(dateEdit1.DateTime.ToString()), txtSDT.Text, txtGhiChu.Text);
                bshd.UpdateHoaDon(hd);
                XtraMessageBox.Show("Sửa thành công.");
                LoadData();
            }
            catch
            {
                XtraMessageBox.Show("Sửa thất bại.");
            }
        }
    }
}