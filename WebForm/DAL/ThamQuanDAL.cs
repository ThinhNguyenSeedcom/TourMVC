using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebForm.DAL
{
    public partial class ThamQuanDAL
    {
        public static List<ThamQuan> getAll()
        {
            QuanLyTourEntities db = new QuanLyTourEntities();
            var result = from c in db.ThamQuans select c;
            return result.ToList();
        }
        public static int AddThamQuan(ThamQuan tq)
        {
            QuanLyTourEntities db = new QuanLyTourEntities();

            db.ThamQuans.Add(tq);
            return db.SaveChanges();
        }

        public static ThamQuan findElementById(string idTour,string idMaDiaDiem)
        {
            QuanLyTourEntities db = new QuanLyTourEntities();
            return db.ThamQuans.Find(idTour, idMaDiaDiem);
        }

        public static int editThamQuan(ThamQuan thamQuan)
        {
            QuanLyTourEntities db = new QuanLyTourEntities();
            db.Entry(thamQuan).State = EntityState.Modified;
            return db.SaveChanges();
        }

        public static int deleteThamQuan(string idTour, string idMaDiaDiem)
        {
            QuanLyTourEntities db = new QuanLyTourEntities();
            ThamQuan thamQuan = db.ThamQuans.Find(idTour, idMaDiaDiem);
            db.ThamQuans.Remove(thamQuan);
            return db.SaveChanges();
        }
    }
}
