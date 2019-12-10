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
namespace LTWNCFashion
{
    public partial class Frm_ThuongHieu : Form
    {
        BUS_ThuongHieu bUS_ThuongHieu = new BUS_ThuongHieu();
        public Frm_ThuongHieu()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            dataGridView1.DataSource = bUS_ThuongHieu.getListThuongHieu();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtTenth.Enabled = true;
            txtMath.Clear();
            txtTenth.Focus();
            btnLuu.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    DTO_ThuongHieu th = new DTO_ThuongHieu(int.Parse(txtMath.Text));
                    bUS_ThuongHieu.DeleteThuongHieu(th);
                    MessageBox.Show("Xóa thành công.");
                    LoadData();
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_ThuongHieu th = new DTO_ThuongHieu(int.Parse(txtMath.Text), txtTenth.Text);
                bUS_ThuongHieu.UpdateThuongHieu(th);
                MessageBox.Show("Sửa thành công");
                LoadData();
            }
            catch (Exception)
            {
                MessageBox.Show("sửa thất bại");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            try
            {
                DTO_ThuongHieu th = new DTO_ThuongHieu(txtTenth.Text);
                bUS_ThuongHieu.InsertThuongHieu(th);
                MessageBox.Show("Thêm thành công");
                LoadData();
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            txtMath.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTenth.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
