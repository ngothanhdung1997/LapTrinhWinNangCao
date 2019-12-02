﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Data.Sql;
using DevExpress;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Controls;
using DevExpress.XtraBars.Ribbon;

namespace LTWNCFashion
{
    public class NguoiDung
    {
        public List<string> mamh = new List<string>();
        public int Check_Config()
        {
            if (Properties.Settings.Default.FashionConnectionString == string.Empty)
                return 1;// Chuỗi cấu hình không tồn tại
            try
            {
                SqlConnection _Sqlconn = new SqlConnection(Properties.Settings.Default.FashionConnectionString);
                if (_Sqlconn.State == System.Data.ConnectionState.Closed)
                { 
                    _Sqlconn.Open();
                }
                return 0; // Kết nối thành công chuỗi cấu hình hợp lệ
            }
            catch
            {
                return 2; // Chuỗi cấu hình không phù hợp.
            }
        }
        public int Check_User(string pUser, string pPass)
        {
            SqlDataAdapter daUser = new SqlDataAdapter("select * from QL_NguoiDung where TenDangNhap='" + pUser + "' and MatKhau ='" + pPass + "'", Properties.Settings.Default.FashionConnectionString);
            DataTable dt = new DataTable();
            daUser.Fill(dt);
            if (dt.Rows.Count == 0)
                return 0; // User không tồn tại
            else
            if (dt.Rows[0][2] == null || int.Parse(dt.Rows[0][2].ToString()) == 2)
            {
                return 2; // Không hoạt động
            }
            return 1; // Đăng nhập thành công
        }
        public DataTable GetServerName()
        {
            DataTable dt = new DataTable();
            dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            return dt;
        }
        public DataTable GetDatabaseName(string pServerName, string pUser, string pPass)
        {
           
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select name from sys.Databases", "Data Source=" + pServerName +
                            ";Initial Catalog=master;User ID=" + pUser + ";pwd=" + pPass + "");
            da.Fill(dt);
            return dt;
        }
        public void ChangeConnectionString(string pServerName, string pDataBase, string pUser, string pPass)
        {
            MessageBox.Show(pServerName);
            Properties.Settings.Default["FashionConnectionString"] = "Data Source=" + pServerName + ";Initial Catalog=" + pDataBase + ";User ID=" + pUser + ";pwd = " + pPass + "";
            Properties.Settings.Default.Save();
        }
        public List<string> getDatatable(string TenDangNhap)
        {
            string sqlnhom = "select MaNhom from QL_NguoiDung, QL_NguoiDungNhomNguoiDung where QL_NguoiDung.TenDangNhap = '" + TenDangNhap + "' and QL_NguoiDung.TenDangNhap = QL_NguoiDungNhomNguoiDung.TenDangNhap";
            DataTable dtNhom = new DataTable();
            List<string> ListMaNhom = new List<string>();
            SqlDataAdapter daNhom = new SqlDataAdapter(sqlnhom, Properties.Settings.Default.FashionConnectionString);
            daNhom.Fill(dtNhom);
            foreach (System.Data.DataRow row in dtNhom.Rows)
            {
                foreach (System.Data.DataColumn col in dtNhom.Columns)
                {
                    //MessageBox.Show (row[col].ToString ());
                    ListMaNhom.Add(row[col].ToString());
                }
            }
            DataTable dt = new DataTable();
            List<string> _list = new List<string>();
            try
            {
                foreach (string manhom in ListMaNhom)
                {
                    SqlDataAdapter da = new SqlDataAdapter("select MaManHinh from QL_PhanQuyen, QL_NhomNguoiDung where QL_PhanQuyen.MaNhom = '" + manhom + "' and QL_PhanQuyen.MaNhom= QL_NhomNguoiDung.MaNhom", Properties.Settings.Default.FashionConnectionString);
                    da.Fill(dt);
                    foreach (System.Data.DataRow row in dt.Rows)
                    {
                        foreach (System.Data.DataColumn col in dt.Columns)
                        {
                            //MessageBox.Show (row[col].ToString ());
                            _list.Add(row[col].ToString());
                            mamh.Add(row[col].ToString());
                        }
                    }
                }
            }
            catch
            {
                return null;
            }
            return mamh;
        }
        public List<string> getoutMaManHinh()
        {
            return mamh;
        }
        public void resetMaManHinh()
        {
            mamh.Clear();
        }
        //public void DongPhanQuyen(RibbonControl a)
        //{
        //    foreach (RibbonPage item in a.Pages)
        //    {
        //        item.Visible = false;
        //        foreach (RibbonPageGroup item2 in item.Groups)
        //        {
        //            item2.Visible = false;
        //            foreach (BarButtonItemLink x in item2.ItemLinks)
        //            {
        //                x.Item.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        //            }
        //        }
        //    }
        //    resetMaManHinh();
        //}
        List<string> b = new List<string>();
        public void PhanQuyen(RibbonControl a, List<string> b)
        {
            foreach (RibbonPage item in a.Pages)
            {
                foreach (string t in b)
                {
                    string c = t.Trim();
                    if (item.Tag.ToString().CompareTo(c) == 0 && item.Tag != null)
                        item.Visible = true;
                    foreach (RibbonPageGroup item2 in item.Groups)
                    {
                        if (item2.Tag.ToString().CompareTo(c) == 0 && item2.Tag != null)
                            item2.Visible = true;
                        foreach (BarButtonItemLink item3 in item2.ItemLinks)
                        {
                            if (item3.Item.Tag.ToString().CompareTo(c) == 0 && item3.Item.Tag != null)
                                item3.Item.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        }
                    }
                }
            }
        }
    }
}
