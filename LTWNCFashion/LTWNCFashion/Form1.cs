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
    public partial class Form1 : Form
    {
        BUS_NguoiDung busNguoiDung = new BUS_NguoiDung();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busNguoiDung.getListNguoiDung();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DTO_NguoiDung s = new DTO_NguoiDung("nm", "3242353", 0);
            if (busNguoiDung.UpdateNguoiDung(s))
            {
                MessageBox.Show("ok");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DTO_NguoiDung s = new DTO_NguoiDung("nm","123",1);
            busNguoiDung.InsertNguoiDung(s);
        }
    }
}
