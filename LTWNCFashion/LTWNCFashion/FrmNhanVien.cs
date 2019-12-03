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
namespace LTWNCFashion
{
    public partial class FrmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        BUS_NhanVien bsnv = new BUS_NhanVien();
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            gdvNhanVien.DataSource = bsnv.getNhanVien();
            cboNV.DataSource = bsnv.getNhanVien();
            cboNV.DisplayMember = "TenNV";
            cboNV.ValueMember = "MaNV";
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_NhanVien nv = new DTO_NhanVien(cboNV.Text, cboNV.Text, cboGT.Text,
                   dateNgaySinh.Text, txtDiaChi.Text, txtSDT.Text, txtEmail.Text,dateNVLam.Text);
                bsnv.InsertNhanVien(nv);
                XtraMessageBox.Show("Thêm thành công.");
                LoadData();
            }
            catch
            {
                XtraMessageBox.Show("Thêm thất bại.");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_NhanVien nv = new DTO_NhanVien(cboNV.SelectedValue.ToString());
                bsnv.DeleteNhanVien(nv);
                XtraMessageBox.Show("Thêm thành công.");
                LoadData();
            }
            catch
            {
                XtraMessageBox.Show("Xóa thất bại.");
            }
           
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_NhanVien nv = new DTO_NhanVien(cboNV.SelectedValue.ToString(), cboNV.Text, cboGT.Text,
                   dateNgaySinh.Text, txtDiaChi.Text, txtSDT.Text, txtEmail.Text, dateNVLam.Text);
                bsnv.UpdateNhanVien(nv);
                XtraMessageBox.Show("Sửa thành công.");
                LoadData();
            }
            catch
            {
                XtraMessageBox.Show("Sửa thất bại.");
            }
        }

        private void gdvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string manv = gdvNhanVien.CurrentRow.Cells["MaNV"].Value.ToString();
                cboNV.DataSource = bsnv.getNhanVientheoma(manv);
                cboNV.DisplayMember = "TenNV";
                cboGT.Text = gdvNhanVien.CurrentRow.Cells["Gioitinh"].Value.ToString();
                dateNgaySinh.Text = gdvNhanVien.CurrentRow.Cells["Ngaysinh"].Value.ToString();
                txtDiaChi.Text = gdvNhanVien.CurrentRow.Cells["Diachi"].Value.ToString();
                txtSDT.Text = gdvNhanVien.CurrentRow.Cells["Sdt"].Value.ToString();
                txtEmail.Text = gdvNhanVien.CurrentRow.Cells["Email"].Value.ToString();
                dateNVLam.Text = gdvNhanVien.CurrentRow.Cells["Ngayvaolam"].Value.ToString();
            }
            catch
            { return; } 
        }
    }
}