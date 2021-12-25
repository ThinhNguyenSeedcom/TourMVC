using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTour.DAL
{
    public class GiaTourDAL
    {
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
    }
}
