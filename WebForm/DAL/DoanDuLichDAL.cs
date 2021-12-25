using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebForm.DAL
{
    public class DoanDuLichDAL
    {
        public List<DoanDuLich> GetAll()
        {
            QuanLyTourEntities db = new QuanLyTourEntities();
            var result = from c in db.DoanDuLiches select c;
            return result.ToList();
        }
        public static DoanDuLich FindElementById(string id)
        {
            QuanLyTourEntities db = new QuanLyTourEntities();
            return db.DoanDuLiches.Find(id);
        }
        public static int addKhachHang(KhachHang kh)
        {
            QuanLyTourEntities db = new QuanLyTourEntities();

            db.KhachHangs.Add(kh);
            return db.SaveChanges();
        }

        public static int addDoanDuLichIntoDB(DoanDuLich doan)
        {
            QuanLyTourEntities db = new QuanLyTourEntities();
            db.DoanDuLiches.Add(doan);
            return db.SaveChanges();
        }
        public static int addNoiDungDoan(NoiDungTour noiDungTour)
        {
            QuanLyTourEntities db = new QuanLyTourEntities();
            db.NoiDungTours.Add(noiDungTour);
            return db.SaveChanges();

        }
        public static int addChiPhi(ChiPhi chiphi)
        {
            QuanLyTourEntities db = new QuanLyTourEntities();
            db.ChiPhis.Add(chiphi);
            return db.SaveChanges();

        }

        public static int Edit(DoanDuLich doanDuLich)
        {
            QuanLyTourEntities db = new QuanLyTourEntities();
            db.Entry(doanDuLich).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges();
        }
        public static int delete(string id)
        {
            QuanLyTourEntities db = new QuanLyTourEntities();
            var doan = db.DoanDuLiches.Find(id);
            db.DoanDuLiches.Remove(doan);
            return db.SaveChanges();
        }
    }
}
