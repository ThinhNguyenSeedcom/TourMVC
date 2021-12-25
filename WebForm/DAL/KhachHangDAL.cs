using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebForm.DAL
{

    public class KhachHangDAL
    {
        public static List<KhachHang> GetAll()
        {
            QuanLyTourEntities db = new QuanLyTourEntities();
            var result = from c in db.KhachHangs select c;
            return result.ToList();
        }
        public static int addKhachHang(KhachHang kh)
        {
            QuanLyTourEntities db = new QuanLyTourEntities();

            db.KhachHangs.Add(kh);
            return db.SaveChanges();
        }

        public static KhachHang getKhachHangById(string id)
        {
            QuanLyTourEntities db = new QuanLyTourEntities();
            var result = db.KhachHangs.Find(id);
            return result;
        }

/*        public static int addKhachHangintoDoan(KhachHang kh, DoanDuLich doan)
        {
            using (var db = new QuanLyTourEntities())
            {
                db.KhachHangs.Attach(kh);
                DoanDuLich doanInCurrentContext = db.DoanDuLiches.Find(doan.MaDoan);
                kh.DoanDuLiches.Add(doanInCurrentContext);
                db.Entry(kh).State = System.Data.Entity.EntityState.Modified;
                return db.SaveChanges();
            }
            return 0;
        }*/
/*
        public static int deleteKH(string idKh, string idDoan)
        {
            using (var db = new QuanLyTourEntities())
            {
                DoanDuLich doanDuLich = db.DoanDuLiches.Find(idDoan);
                KhachHang khachHang = db.KhachHangs.Find(idKh);
                doanDuLich.KhachHangs.Remove(khachHang);
                db.Entry(khachHang).State = System.Data.Entity.EntityState.Modified;
                return db.SaveChanges();
            }
            *//*QuanLyTourEntities db = new QuanLyTourEntities();
        var kh = db.KhachHangs.Find(id);
        db.KhachHangs.Remove(kh);
        return db.SaveChanges();*//*
        }*/

        public static int editKhachHang(KhachHang khachHang)
        {
            QuanLyTourEntities db = new QuanLyTourEntities();
            db.Entry(khachHang).State = EntityState.Modified;
            return db.SaveChanges();
        }
    }


}
