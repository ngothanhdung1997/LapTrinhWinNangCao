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
using DTO_Fashion;
using BUS_Fashion;
namespace LTWNCFashion
{
    public partial class FrmTheLoai : DevExpress.XtraEditors.XtraForm
    {
        BUS_TheLoai bUS_TheLoai = new BUS_TheLoai();
        public FrmTheLoai()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            dataGridView1.DataSource = bUS_TheLoai.getListTheLoai();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            txtTentl.Enabled = true;
            txtMatl.Clear();
            txtTentl.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_TheLoai tl = new DTO_TheLoai(txtTentl.Text);
                bUS_TheLoai.InsertTheLoai(tl);
                MessageBox.Show("Thêm thành công");
                LoadData();
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    DTO_TheLoai tl = new DTO_TheLoai(int.Parse(txtMatl.Text));
                    bUS_TheLoai.DeleteTheLoai(tl);
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
                DTO_TheLoai tl = new DTO_TheLoai(int.Parse(txtMatl.Text), txtTentl.Text);
                bUS_TheLoai.UpdateTheLoai(tl);
                MessageBox.Show("Sửa thành công");
                LoadData();
            }
            catch (Exception)
            {
                MessageBox.Show("sửa thất bại");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            txtMatl.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTentl.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            txtMatl.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTentl.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}