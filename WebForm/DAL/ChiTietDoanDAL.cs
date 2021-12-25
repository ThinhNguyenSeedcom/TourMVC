using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForm.DAL
{
    public class ChiTietDoanDAL
    {
        public static int addChiTietDoan(ChiTietDoan chiTietDoan)
        {
            QuanLyTourEntities db = new QuanLyTourEntities();
            db.ChiTietDoans.Add(chiTietDoan);
            return db.SaveChanges();
        }

        public static ChiTietDoan findElementById(string id, string id2)
        {
            QuanLyTourEntities db = new QuanLyTourEntities();
            return db.ChiTietDoans.Find(id, id2);
        }
    }
}