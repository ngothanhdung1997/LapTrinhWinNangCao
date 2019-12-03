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
using DTO_Fashion;
using DAL_Fashion;
using DevExpress.XtraEditors;

namespace LTWNCFashion
{
    public partial class FrmHangHoa : Form
    {
        BUS_HangHoa bs_hh = new BUS_HangHoa();
        DAL_HH hh = new DAL_HH();
        public FrmHangHoa()
        {
            InitializeComponent();
        }
        private void FrmHangHoa_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            gdv_HH.DataSource = bs_hh.getListHangHoa();
            //dataGridView1.DataSource = hh.getHH();
            cboLoai.DataSource = hh.getTheLoai();
            cboLoai.DisplayMember = "TenLoai";
            cboLoai.ValueMember = "MaLoai";
            cboTH.DataSource = hh.getThuongHieu();
            cboTH.DisplayMember = "TenTH";
            cboTH.ValueMember = "MaThuongHieu";
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DTO_HangHoa hh = new DTO_HangHoa(txtMaHang.Text, int.Parse(cboTH.SelectedValue.ToString()), int.Parse(cboLoai.SelectedValue.ToString()),
                txtTenHang.Text, int.Parse(txtGia.Text), int.Parse(txtSLT.Text), cboDVT.Text, txtMoTa.Text, txtHinhAnh.Text);
            bs_hh.InsertHangHoa(hh);
            XtraMessageBox.Show("Thêm thành công.");
            LoadData();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DTO_HangHoa hh = new DTO_HangHoa(txtMaHang.Text);
            bs_hh.DeleteHangHoa(hh);
            XtraMessageBox.Show("Xóa thành công.");
            LoadData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DTO_HangHoa hh = new DTO_HangHoa(txtMaHang.Text, int.Parse(cboTH.Text), int.Parse(cboLoai.Text),
                txtTenHang.Text, int.Parse(txtGia.Text), int.Parse(txtSLT.Text), cboDVT.Text, txtMoTa.Text, txtHinhAnh.Text);
            bs_hh.UpdateHangHoa(hh);
            XtraMessageBox.Show("Sửa thành công.");
            LoadData();
        }

        private void gdv_HH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtMaHang.Text = gdv_HH.Rows[numrow].Cells["MaH"].Value.ToString();
            txtTenHang.Text = gdv_HH.Rows[numrow].Cells["TenH"].Value.ToString();
            cboTH.Text = gdv_HH.Rows[numrow].Cells["MaTH"].Value.ToString();
            cboLoai.Text = gdv_HH.Rows[numrow].Cells["MaL"].Value.ToString();
            txtGia.Text = gdv_HH.Rows[numrow].Cells["DG"].Value.ToString();
            txtSLT.Text = gdv_HH.Rows[numrow].Cells["SL"].Value.ToString();
            cboDVT.Text = gdv_HH.Rows[numrow].Cells["DVT"].Value.ToString();
            txtMoTa.Text = gdv_HH.Rows[numrow].Cells["mota"].Value.ToString();
            txtHinhAnh.Text = gdv_HH.Rows[numrow].Cells["Image"].Value.ToString();
        }
    }
}
