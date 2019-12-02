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
            dataGridView1.DataSource = bs_hh.getListHangHoa();
            //dataGridView1.DataSource = hh.getHH();
            cboLoai.DataSource = hh.getTheLoai();
            cboLoai.DisplayMember = "TenLoai";
            cboLoai.ValueMember = "MaLoai";
            cboThuongHieu.DataSource = hh.getThuongHieu();
            cboThuongHieu.DisplayMember = "TenTH";
            cboThuongHieu.ValueMember = "MaThuongHieu";
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DTO_HangHoa hh = new DTO_HangHoa(txtMaHang.Text, int.Parse(cboThuongHieu.SelectedValue.ToString()), int.Parse(cboLoai.SelectedValue.ToString()),
                txtTenHang.Text, int.Parse(txtDonGia.Text), int.Parse(txtSL.Text), cboDVT.Text, txtMoTa.Text, txtimg.Text);
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
            DTO_HangHoa hh = new DTO_HangHoa(txtMaHang.Text, int.Parse(cboThuongHieu.Text), int.Parse(cboLoai.Text),
                txtTenHang.Text, int.Parse(txtDonGia.Text), int.Parse(txtSL.Text), cboDVT.Text, txtMoTa.Text, txtimg.Text);
            bs_hh.UpdateHangHoa(hh);
            XtraMessageBox.Show("Sửa thành công.");
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtMaHang.Text = dataGridView1.Rows[numrow].Cells[0].Value.ToString();
            txtTenHang.Text = dataGridView1.Rows[numrow].Cells[3].Value.ToString();
            cboThuongHieu.Text = dataGridView1.Rows[numrow].Cells[1].Value.ToString();
            cboLoai.Text = dataGridView1.Rows[numrow].Cells[2].Value.ToString();
            txtDonGia.Text = dataGridView1.Rows[numrow].Cells[4].Value.ToString();
            txtSL.Text = dataGridView1.Rows[numrow].Cells[5].Value.ToString();
            cboDVT.Text = dataGridView1.Rows[numrow].Cells[6].Value.ToString();
            txtMoTa.Text = dataGridView1.Rows[numrow].Cells[7].Value.ToString();
            txtimg.Text = dataGridView1.Rows[numrow].Cells[8].Value.ToString();
        }
    }
}
