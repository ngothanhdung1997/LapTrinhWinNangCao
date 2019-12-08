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
using System.IO;
using System.Data.Linq;
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
            txtMaHang.Enabled = false;
            gdv_HH.DataSource = bs_hh.getListHangHoa();
            cboLoai.DataSource = hh.getTheLoai();
            cboLoai.DisplayMember = "TenLoai";
            cboLoai.ValueMember = "MaLoai";
            cboTH.DataSource = hh.getThuongHieu();
            cboTH.DisplayMember = "TenTH";
            cboTH.ValueMember = "MaThuongHieu";
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] b = ImageToByteArray(pct_HinhAnh.Image);
                DTO_HangHoa hh = new DTO_HangHoa(int.Parse(cboTH.SelectedValue.ToString()), int.Parse(cboLoai.SelectedValue.ToString()),txtTenHang.Text,
                    int.Parse(txtGiaNhap.Text), int.Parse(txtDonGiaBan.Text), int.Parse(txtSLT.Text), cboDVT.Text, txtMoTa.Text, b);
                bs_hh.InsertHangHoa(hh);
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
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_HangHoa hh = new DTO_HangHoa(int.Parse(txtMaHang.Text));
                bool bien = bs_hh.DeleteHangHoa(hh);
                if (bien)
                {
                    XtraMessageBox.Show("Xóa thành công.");
                    LoadData();
                }
                else
                {
                    XtraMessageBox.Show("Sản phẩm tồn tại trong CTHD.");
                }
            }
            catch
            {
                XtraMessageBox.Show("Xóa thất bại.");
            }   
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            byte[] b = ImageToByteArray(pct_HinhAnh.Image);
            DTO_HangHoa hh = new DTO_HangHoa(int.Parse(txtMaHang.Text), int.Parse(cboTH.Text), int.Parse(cboLoai.Text),
                txtTenHang.Text, int.Parse(txtGiaNhap.Text), int.Parse(txtDonGiaBan.Text), int.Parse(txtSLT.Text), cboDVT.Text, txtMoTa.Text, b);
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
            txtGiaNhap.Text = gdv_HH.Rows[numrow].Cells["DGN"].Value.ToString();
            txtDonGiaBan.Text = gdv_HH.Rows[numrow].Cells["DGB"].Value.ToString();
            txtSLT.Text = gdv_HH.Rows[numrow].Cells["SL"].Value.ToString();
            cboDVT.Text = gdv_HH.Rows[numrow].Cells["DVT"].Value.ToString();
            txtMoTa.Text = gdv_HH.Rows[numrow].Cells["mota"].Value.ToString();
            string ma = gdv_HH.Rows[numrow].Cells["MaH"].Value.ToString();
            int s = int.Parse(ma);
            CellClick_MaSP(s);
        }
        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }
        private void btnThemthhieu_Click(object sender, EventArgs e)
        {
            var frmth = new FrmThuongHieu();
            frmth.ShowDialog();
        }

        private void btnThemloai_Click(object sender, EventArgs e)
        {
            var frmtl = new FrmTheLoai();
            frmtl.ShowDialog();
        }

        private void pct_HinhAnh_DoubleClick(object sender, EventArgs e)
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

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        QL_SHOPDataContext db = new QL_SHOPDataContext();
        private void CellClick_MaSP(int maSP)
        {
            var s = (from st in db.HangHoas where st.MaHang == maSP select st.HinhAnh.ToArray()).First();
            pct_HinhAnh.Image = ByteArrayToImage(s);
        }

        private void cboTH_Click(object sender, EventArgs e)
        {
            cboTH.DataSource = hh.getThuongHieu();
            cboTH.DisplayMember = "TenTH";
            cboTH.ValueMember = "MaThuongHieu";
        }

        private void cboLoai_Click(object sender, EventArgs e)
        {
            cboLoai.DataSource = hh.getTheLoai();
            cboLoai.DisplayMember = "TenLoai";
            cboLoai.ValueMember = "MaLoai";
        }
    }
}
