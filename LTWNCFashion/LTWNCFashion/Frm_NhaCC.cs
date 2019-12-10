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
    public partial class Frm_NhaCC : Form
    {

        BUS_NhaCC bUS_NhaCC = new BUS_NhaCC();
        public Frm_NhaCC()
        {
            InitializeComponent();
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtDiachi.Enabled = true;
            txtTenNCC.Enabled = true;
            txtsdt.Enabled = true;
            txtMaNCC.Clear();
            txtTenNCC.Focus();
        }
        public void LoadData()
        {
            dataGridView1.DataSource = bUS_NhaCC.getListNhaCC();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    DTO_NhaCC ncc = new DTO_NhaCC(int.Parse(txtMaNCC.Text));
                    bUS_NhaCC.DeleteNhaCC(ncc);
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
                DTO_NhaCC ncc = new DTO_NhaCC(int.Parse(txtMaNCC.Text), txtTenNCC.Text, txtDiachi.Text, txtsdt.Text);
                bUS_NhaCC.UpdateNhaCC(ncc);
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
                DTO_NhaCC ncc = new DTO_NhaCC(txtTenNCC.Text, txtDiachi.Text, txtsdt.Text);
                bUS_NhaCC.InsertNhaCC(ncc);
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
            txtMaNCC.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTenNCC.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDiachi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtsdt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
