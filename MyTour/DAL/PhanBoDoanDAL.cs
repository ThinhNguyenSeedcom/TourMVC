using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTour.DAL
{
    public class PhanBoDoanDAL
    {
        public static int add(PhanBoNV_Doan phanBoNV_Doan)
        {
            QuanLyTourEntities db = new QuanLyTourEntities();

            db.PhanBoNV_Doan.Add(phanBoNV_Doan);

            return db.SaveChanges();
        }

        public static int remove(string id1,string id2)
        {
            QuanLyTourEntities db = new QuanLyTourEntities();
            PhanBoNV_Doan phanBoNV_Doan1 =  db.PhanBoNV_Doan.Find(id1, id2);
            db.PhanBoNV_Doan.Remove(phanBoNV_Doan1);
            return db.SaveChanges();

        }
    }
}
