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
        DAL_HoaDon hd = new DAL_HoaDon();
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
            txtMaHD.Enabled = false;
            txtTT.Text = "0";
            txtTT.Enabled = false;
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
            txtMaHD.Text = gdv_HD.Rows[numrow].Cells["MaHD"].Value.ToString();
            string manv = gdv_HD.Rows[numrow].Cells["MaNV"].Value.ToString();
            cboTNV.DataSource = bshd.getNVtheoma(manv);
            string makh = gdv_HD.Rows[numrow].Cells["MaKH"].Value.ToString();
            cbo_TKH.DataSource = bshd.getKHtheoma(makh);
            dateEdit1.EditValue = gdv_HD.Rows[numrow].Cells["NgayLapHD"].Value.ToString();
            txtSDT.Text = gdv_HD.Rows[numrow].Cells["SDT"].Value.ToString();
            txtGhiChu.Text = gdv_HD.Rows[numrow].Cells["GhiChu"].Value.ToString();
            int mscthd = int.Parse(txtMaHD.Text);
            gdvCTHD.DataSource = bshd.getCTHD(mscthd);
            txtTT.Text = tongtien().ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                txtMaHD.Clear();
                DTO_HoaDon hd = new DTO_HoaDon(txtMaHD.Text, cboTNV.SelectedValue.ToString(), cbo_TKH.SelectedValue.ToString(),
                    txtTT.Text, DateTime.Parse(dateEdit1.DateTime.ToString()), txtSDT.Text, txtGhiChu.Text);
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
                bool kq = bshd.DeleteHoaDon(hd);
                if (kq == false)
                {
                    XtraMessageBox.Show("Chưa xóa sản phẩm trong chi tiết hóa đơn.\nXoá thất bại.");
                }
                else
                { 
                    XtraMessageBox.Show("Xóa thành công.");
                }
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
        private void cboTSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtGiaBan.Text = hh.laygiaban(cboTSP.SelectedValue.ToString());
            }
            catch
            { return; }

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            try
            {
                bool bien = true;
                for (int i = 0; i < gdvCTHD.Rows.Count-1; i++)
                {
                    string masp = gdvCTHD.Rows[i].Cells["MaSP"].Value.ToString();
                    if (masp.Equals(cboTSP.SelectedValue.ToString()))
                    {
                        bien = false;
                        break;
                    }
                    else
                    {
                        bien = true;
                    }
                }
                if (bien)
                {
                    int tt = (int.Parse(num_SL.Value.ToString()) * int.Parse(txtGiaBan.Text));
                    DTO_CTHD cthd = new DTO_CTHD(int.Parse(txtMaHD.Text), int.Parse(cboTSP.SelectedValue.ToString()), int.Parse(num_SL.Value.ToString()), int.Parse(txtGiaBan.Text), tt);
                    bshd.InsertCT_HD(cthd);
                    XtraMessageBox.Show("Thêm thành công.");
                    gdvCTHD.DataSource = bshd.getCTHD(int.Parse(txtMaHD.Text));
                    int sl = int.Parse(num_SL.Value.ToString());
                    string mah = cboTSP.SelectedValue.ToString();
                    hh.Updatesoluonggiam(int.Parse(mah), sl);
                }
                else
                {
                    XtraMessageBox.Show("Đã có sản phẩm trong giỏ hàng.\n Bạn có thể sửa số lượng sản phẩm trong giỏ.");
                }
            }
            catch
            {
                XtraMessageBox.Show("Thêm thất bại.");
            }
            //int dong = gdvCTHD.Rows.Count;
            //int tong = 0;
            //for (int i = 0; i < dong-1; i++)
            //{
            //    string kq = gdvCTHD.Rows[i].Cells["TT"].Value.ToString();
            //    tong += int.Parse(kq);
            //}
            //txtTT.Text = tong.ToString();

        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            try
            {
                int tt = (int.Parse(txtThanhTien.Text));
                DTO_CTHD cthd = new DTO_CTHD(int.Parse(txtMaHD.Text), int.Parse(cboTSP.SelectedValue.ToString()), int.Parse(num_SL.Value.ToString()), int.Parse(txtGiaBan.Text), tt);
                bshd.UpdateCTHD(cthd);
                XtraMessageBox.Show("Sửa thành công.");
                gdvCTHD.DataSource = bshd.getCTHD(int.Parse(txtMaHD.Text));
            }
            catch
            {
                XtraMessageBox.Show("Sửa thất bại.");
            }
        }
        private void num_SL_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                string tt = (num_SL.Value * int.Parse(txtGiaBan.Text)).ToString();
                txtThanhTien.Text = tt;
            }
            catch
            {
                return;
            }

        }

        private void cboGB_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string tt = (num_SL.Value * int.Parse(txtGiaBan.Text)).ToString();
                txtThanhTien.Text = tt;
            }
            catch
            { return; }

        }

        private void gdvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numrow;
                numrow = e.RowIndex;
                num_SL.Value = int.Parse(gdvCTHD.Rows[numrow].Cells["SL"].Value.ToString());
                txtGiaBan.Text = gdvCTHD.Rows[numrow].Cells["GB"].Value.ToString();
                txtThanhTien.Text = gdvCTHD.Rows[numrow].Cells["TT"].Value.ToString();
            }
            catch
            { return; }

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            try
            {
                string masp = gdvCTHD.CurrentRow.Cells[0].Value.ToString();
                string sl = gdvCTHD.CurrentRow.Cells["SL"].Value.ToString();
                DTO_CTHD cthd = new DTO_CTHD(int.Parse(txtMaHD.Text), int.Parse(masp));
                bool kq = bshd.DeleteCTHD(cthd);
                if (kq == true)
                {
                    XtraMessageBox.Show("Xóa thành công.");
                }
                else
                {
                    XtraMessageBox.Show("Xóa thất bại.");
                }
                gdvCTHD.DataSource = bshd.getCTHD(int.Parse(txtMaHD.Text));
                hh.Updatesoluongtang(int.Parse(masp),int.Parse(sl));
            }
            catch
            {
                XtraMessageBox.Show("Lỗi!");
            }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            string ngaybd = dateNgayBD.DateTime.ToString();
            string ngaykt = dateNgayKT.DateTime.ToString();
            gdv_HD.DataSource = bshd.SearchTheoNgay(ngaybd, ngaykt);
        }
        private Form ktraform(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }
        private void simpleButton9_Click(object sender, EventArgs e)
        {
            Form frm = ktraform(typeof(FrmKhachHang));
            if (frm == null)
            {
                FrmKhachHang f = new FrmKhachHang();
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }
        //private void XuatExcel(string file)
        //{
        //    try
        //    {
        //        // creating Excel Application  
        //        Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
        //        // creating new WorkBook within Excel application  
        //        Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
        //        // creating new Excelsheet in workbook  
        //        Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
        //        // get the reference of first sheet. By default its name is Sheet1.  
        //        // store its reference to worksheet  
        //        worksheet = workbook.Sheets["Sheet1"];
        //        worksheet = workbook.ActiveSheet;
        //        // changing the name of active sheet  
        //        worksheet.Name = "Bán hàng";
        //        Microsoft.Office.Interop.Excel.Range head = worksheet.Range["A1", "F1"];
        //        head.MergeCells = true;
        //        head.Value2 = "DANH SÁCH HÓA ĐƠN BÁN HÀNG";
        //        head.Font.Bold = true;
        //        head.Font.Size = 20;
        //        head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        //        //--------------TOTAL----------------------
        //        int dong = gdv_HD.Rows.Count;
        //        int tong = 0;
        //        for (int i = 0; i < dong; i++)
        //        {
        //            string kq = gdv_HD.Rows[i].Cells["TongTien"].Value.ToString();
        //            tong += int.Parse(kq);
        //        }
        //        Microsoft.Office.Interop.Excel.Range total = worksheet.Range["F17", "G17"];
        //        total.MergeCells = true;
        //        total.Value2 = "Total: " + tong.ToString();
        //        total.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        //        //from
        //        Microsoft.Office.Interop.Excel.Range fromDate = worksheet.Range["A3", "C3"];
        //        fromDate.MergeCells = true;
        //        fromDate.Value2 = "Từ ngày: " + dateNgayBD.Text;
        //        fromDate.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        //        //to
        //        Microsoft.Office.Interop.Excel.Range toDate = worksheet.Range["F3", "H3"];
        //        toDate.MergeCells = true;
        //        toDate.Value2 = "Đến ngày: " + dateNgayKT.Text;
        //        toDate.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        //        // storing header part in Excel  
        //        for (int i = 1; i < gdv_HD.Columns.Count - 1; i++)
        //        {
        //            worksheet.Cells[5, i] = gdv_HD.Columns[i - 1].HeaderText;
        //        }
        //        worksheet.Range["A5", "G5"].Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

        //        // storing Each row and column value to excel sheet  
        //        for (int i = 0; i < gdv_HD.Rows.Count; i++)
        //        {
        //            for (int j = 0; j < gdv_HD.Columns.Count - 2; j++)
        //            {
        //                worksheet.Cells[i + 6, j + 1] = gdv_HD.Rows[i].Cells[j].Value.ToString();
        //            }
        //        }
        //        // save the application  
        //        workbook.SaveAs(file);

        //        // see the excel sheet behind the program  
        //        if (MessageBox.Show("Xuất tệp excel thành công!") == DialogResult.OK)
        //            app.Visible = true;
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Xuất tệp excel thất bại!");
        //    }
        //}

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel files (*.xlsx)|*.xlsx";
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                XuatCTHD(sfd.FileName);
            }
        }

        private int tongtien()
        {
            int tt = 0;
              for (int i = 0; i < gdvCTHD.Rows.Count; i++)
                {
                try
                {
                    string thanhtien = gdvCTHD.Rows[i].Cells["TT"].Value.ToString();
                    tt = tt + int.Parse(thanhtien);
                }
                catch
                { break; }
                }
            return tt;
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            Form frm = ktraform(typeof(FrmHangHoa));
            if (frm == null)
            {
                FrmHangHoa f = new FrmHangHoa();
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void XuatCTHD(string file)
        {
            try
            {
                // creating Excel Application 
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // get the reference of first sheet. By default its name is Sheet1.  
                // store its reference to worksheet  
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet  
                worksheet.Name = "Bán hàng";
                Microsoft.Office.Interop.Excel.Range head = worksheet.Range["A1", "E1"];
                head.MergeCells = true;
                head.Value2 = "HÓA ĐƠN BÁN HÀNG";
                head.Font.Bold = true;
                head.Font.Size = 20;
                head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                //--------------TOTAL----------------------
                int r = gdvCTHD.Rows.Count + 8;
                Microsoft.Office.Interop.Excel.Range total = worksheet.Range["D"+r.ToString(), "D"+r.ToString()];
                total.MergeCells = true;
                total.Value2 = "Tổng tiền:";
                total.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                //-----------------------------------------------------------------------------------------------------
                Microsoft.Office.Interop.Excel.Range total1 = worksheet.Range["E" + r.ToString(), "E" + r.ToString()];
                total1.MergeCells = true;
                total1.Value2 = txtTT.Text;
                total1.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                //tên khách hàng
                Microsoft.Office.Interop.Excel.Range tenkh = worksheet.Range["A3", "A3"];
                tenkh.MergeCells = true;
                tenkh.Value2 = "Tên KH:";
                tenkh.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                //-----------------------------------------------------
                Microsoft.Office.Interop.Excel.Range tenkh1 = worksheet.Range["B3", "B3"];
                tenkh1.MergeCells = true;
                tenkh1.Value2 = cbo_TKH.Text;
                tenkh1.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                //tên nhân vien bán
                Microsoft.Office.Interop.Excel.Range tennv = worksheet.Range["D3", "D3"];
                tennv.MergeCells = true;
                tennv.Value2 = "Tên NV:";
                tennv.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                //-----------------------------------------------------
                Microsoft.Office.Interop.Excel.Range tennv1 = worksheet.Range["E3", "E3"];
                tennv1.MergeCells = true;
                tennv1.Value2 = cboTNV.Text;
                tennv1.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                //Mã hóa đơn
                Microsoft.Office.Interop.Excel.Range mahd = worksheet.Range["A5", "A5"];
                mahd.MergeCells = true;
                mahd.Value2 = "Mã Hóa Đơn:";
                mahd.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                //-----------------------------------------------------
                Microsoft.Office.Interop.Excel.Range mahd1 = worksheet.Range["B5", "B5"];
                mahd1.MergeCells = true;
                mahd1.Value2 = txtMaHD.Text;
                mahd1.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                //Ngày lập
                Microsoft.Office.Interop.Excel.Range ngaylap = worksheet.Range["D5", "D5"];
                ngaylap.Value2 = "Ngày Lập:";
                ngaylap.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                //-----------------------------------------------------
                Microsoft.Office.Interop.Excel.Range ngaylap1 = worksheet.Range["E5", "E5"];
                dateEdit1.EditValue = DateTime.Now;
                ngaylap1.Value2 = dateEdit1.EditValue.ToString();
                ngaylap1.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                // storing header part in Excel
                for (int i = 1; i <= gdvCTHD.Columns.Count; i++)
                {
                    worksheet.Cells[7, i] = gdvCTHD.Columns[i - 1].HeaderText;
                }
                worksheet.Range["A7", "E7"].Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                // storing Each row and column value to excel sheet  
                for (int i = 0; i < gdvCTHD.Rows.Count-1; i++)
                {
                    for (int j = 0; j < gdvCTHD.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 8, j + 1] = gdvCTHD.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // save the application  
                workbook.SaveAs(file);

                // see the excel sheet behind the program  
                if (MessageBox.Show("Xuất tệp excel thành công!") == DialogResult.OK)
                    app.Visible = true;
            }
            catch
            {
                MessageBox.Show("Xuất tệp excel thất bại!");
            }
        }

        private void cboTSP_Click(object sender, EventArgs e)
        {
            cboTSP.DataSource = hh.getHH();
            cboTSP.DisplayMember = "TenHang";
            cboTSP.ValueMember = "MaHang";
        }

        private void cbo_TKH_Click(object sender, EventArgs e)
        {
            cbo_TKH.DataSource = bshd.getListKhachHang();
            cbo_TKH.DisplayMember = "TenKH";
            cbo_TKH.ValueMember = "MaKH";
        }

        private void gdvCTHD_DataSourceChanged(object sender, EventArgs e)
        {
            txtTT.Text = tongtien().ToString();
        }

        private void cbo_TKH_TextChanged(object sender, EventArgs e)
        {
           txtSDT.Text = hd.laysdt(cbo_TKH.SelectedValue.ToString());
        }
    }
}