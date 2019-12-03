using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Fashion;
namespace DAL_Fashion
{
    public class DAL_NhanVien : Context
    {
        public List<NhanVien> getNV()
        {
            return db.NhanViens.Select(t => t).ToList<NhanVien>();
        }
        //Load thong tin nhan vien theo manv
        public List<NhanVien> getNVthoema(string pMaNV)
        {
            return db.NhanViens.Where(t => t.MaNV == int.Parse(pMaNV)).ToList<NhanVien>();
        }
        //Insert Nhan vien
        public bool InsertNhanVien(DTO_NhanVien a)
        {
            try
            {
                NhanVien insert = new NhanVien();
                insert.TenNV = a.TenNV;
                insert.Gioitinh = a.GioiTinh;
                insert.Ngaysinh = DateTime.Parse(a.NgaySinh);
                insert.Diachi = a.DiaChi;
                insert.Sdt = a.SDT;
                insert.Email = a.Email;
                insert.Ngayvaolam = DateTime.Parse(a.NgayVaoLam);
                db.NhanViens.InsertOnSubmit(insert);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Update Nhan Vien
        public bool UpdateNhanVien(DTO_NhanVien a)
        {
            try
            {
                NhanVien update = db.NhanViens.Where(p => p.MaNV.ToString().Equals(a.MaNV)).SingleOrDefault();
                update.TenNV = a.TenNV;
                update.Gioitinh = a.GioiTinh;
                update.Ngaysinh = DateTime.Parse(a.NgaySinh);
                update.Diachi = a.DiaChi;
                update.Sdt = a.SDT;
                update.Email = a.Email;
                update.Ngayvaolam = DateTime.Parse(a.NgayVaoLam);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Delete Nhan Vien
        public bool DeleteNhanVien(DTO_NhanVien a)
        {
            try
            {
                NhanVien delete = db.NhanViens.Where(p => p.MaNV.ToString().Equals(a.MaNV)).SingleOrDefault();
                db.NhanViens.DeleteOnSubmit(delete);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
