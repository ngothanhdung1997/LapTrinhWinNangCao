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
using System.IO;
using DAL_Fashion;
namespace LTWNCFashion
{
    public partial class FromNhanVien : DevExpress.XtraEditors.XtraForm
    {
        BUS_NhanVien bsnv = new BUS_NhanVien();
        public FromNhanVien()
        {
            InitializeComponent();
        }

        private void FromNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            txtMaNV.Enabled = false;
            gdvNhanVien.DataSource = bsnv.getNhanVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] b = ImageToByteArray(pct_NV.Image);
                DTO_NhanVien nv = new DTO_NhanVien(txtTNV.Text, cboGT.Text, DateTime.Parse(dateNgaySinh.EditValue.ToString()),
                    txtDiaChi.Text, txtSDT.Text, txtEmail.Text, DateTime.Parse(dateNVLam.EditValue.ToString()), b);
                bsnv.InsertNhanVien(nv);
                XtraMessageBox.Show("Thêm thành công.");
                LoadData();
            }
            catch
            {
                XtraMessageBox.Show("Thêm thất bại.");
            }
        }
        //Chuyen Image sang byte[] 
        private byte[] ImageToByteArray(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int manv = int.Parse(txtMaNV.Text);
                DTO_NhanVien nv = new DTO_NhanVien(manv);
                bsnv.DeleteNhanVien(nv);
                XtraMessageBox.Show("Xóa thành công.");
                LoadData();
            }
            catch
            {
                XtraMessageBox.Show("Xóa thất bại.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] b = ImageToByteArray(pct_NV.Image);
                DTO_NhanVien nv = new DTO_NhanVien(int.Parse(txtMaNV.Text), txtTNV.Text, cboGT.Text, DateTime.Parse(dateNgaySinh.EditValue.ToString()),
                    txtDiaChi.Text, txtSDT.Text, txtEmail.Text, DateTime.Parse(dateNVLam.EditValue.ToString()), b);
                bsnv.UpdateNhanVien(nv);
                XtraMessageBox.Show("Sửa thành công.");
                LoadData();
            }
            catch
            {
                XtraMessageBox.Show("Sửa thất bại.");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn đóng?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void gdvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaNV.Text = gdvNhanVien.CurrentRow.Cells["MaNV"].Value.ToString();
                txtTNV.Text = gdvNhanVien.CurrentRow.Cells["TenNV"].Value.ToString();
                cboGT.Text = gdvNhanVien.CurrentRow.Cells["Gioitinh"].Value.ToString();
                dateNgaySinh.Text = gdvNhanVien.CurrentRow.Cells["Ngaysinh"].Value.ToString();
                txtDiaChi.Text = gdvNhanVien.CurrentRow.Cells["Diachi"].Value.ToString();
                txtSDT.Text = gdvNhanVien.CurrentRow.Cells["Sdt"].Value.ToString();
                txtEmail.Text = gdvNhanVien.CurrentRow.Cells["Email"].Value.ToString();
                dateNVLam.Text = gdvNhanVien.CurrentRow.Cells["Ngayvaolam"].Value.ToString();
                int manv = int.Parse(gdvNhanVien.CurrentRow.Cells["MaNV"].Value.ToString());
                CellClick_MaNV(manv);
            }
            catch
            { return; }
        }
        QL_SHOPDataContext db = new QL_SHOPDataContext();
        private void CellClick_MaNV(int manv)
        {
            var s = (from st in db.NhanViens where st.MaNV == manv select st.ImageNV.ToArray()).First();
            pct_NV.Image = ByteArrayToImage(s);
        }
        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }

        private void pct_NV_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox p = sender as PictureBox;
            if (p != null)
            {
                open.Filter = "(*.jpg;*.jpeg;*.bmp) | *.jpg;*.jpeg;*.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    p.Image = Image.FromFile(open.FileName);
                }
            }
        }
    }
}