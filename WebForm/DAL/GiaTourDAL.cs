using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebForm.DAL
{
    public class GiaTourDAL
    {
        public static List<GiaTour> GetAll()
        {
            QuanLyTourEntities db = new QuanLyTourEntities();
            var result = from c in db.GiaTours select c;
            return result.ToList();
        }
        public static int AddGiaTour(GiaTour giaTour)
        {
            QuanLyTourEntities db = new QuanLyTourEntities();

            db.GiaTours.Add(giaTour);
            return db.SaveChanges();
        }

        public static int remove(string idGiaTour)
        {
            QuanLyTourEntities db = new QuanLyTourEntities();
            GiaTour giaTour = db.GiaTours.Find(idGiaTour);
            db.GiaTours.Remove(giaTour);
            return db.SaveChanges();
        }
        public static GiaTour findElementById(string id)
        {
            QuanLyTourEntities db = new QuanLyTourEntities();
            return db.GiaTours.Find(id);
        }

        public static int editTourGiaTour(GiaTour giaTour)
        {
            QuanLyTourEntities db = new QuanLyTourEntities();
            db.Entry(giaTour).State = EntityState.Modified;
            return db.SaveChanges();

        }
    }
}