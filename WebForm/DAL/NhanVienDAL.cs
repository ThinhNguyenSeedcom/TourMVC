using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebForm.DAL
{
    public class NhanVienDAL
    {
        public static List<NhanVien> GetAll()
        {
            QuanLyTourEntities db = new QuanLyTourEntities();
            var result = from c in db.NhanViens select c;
            return result.ToList();
        }

        public static NhanVien findElementById(string id)
        {
            QuanLyTourEntities db = new QuanLyTourEntities();
            NhanVien nhanvien = db.NhanViens.Find(id);
            return nhanvien;
        }

        public static int add(NhanVien nhanVien)
        {
            QuanLyTourEntities db = new QuanLyTourEntities();
            db.NhanViens.Add(nhanVien);
            return db.SaveChanges();
        }

        public static int edit(NhanVien nhanVien)
        {
            QuanLyTourEntities db = new QuanLyTourEntities();
            db.Entry(nhanVien).State = EntityState.Modified;
            return db.SaveChanges();
        }
    }
}
