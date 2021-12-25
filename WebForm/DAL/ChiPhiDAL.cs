using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebForm.DAL
{
    public class ChiPhiDAL
    {
        public static List<ChiPhi> getAll()
        {
            QuanLyTourEntities db = new QuanLyTourEntities();
            var result = from c in db.ChiPhis select c;
            return result.ToList();
        }
        public static int addChiPhi(ChiPhi chiPhi)
        {
            QuanLyTourEntities db = new QuanLyTourEntities();
            db.ChiPhis.Add(chiPhi);
            return db.SaveChanges();
        }
        public static ChiPhi getItemById(string id)
        {
            ChiPhi chiPhi = null;
            QuanLyTourEntities db = new QuanLyTourEntities();
            chiPhi = db.ChiPhis.Find(id);
            return chiPhi;
        }

        public static int delectChiPhi(string id)
        {
            QuanLyTourEntities db = new QuanLyTourEntities();
            var chiphi = db.ChiPhis.Find(id);
            db.ChiPhis.Remove(chiphi);
            return db.SaveChanges();
        }

        public static int edit(ChiPhi chiPhi)
        {
            QuanLyTourEntities db = new QuanLyTourEntities();
            db.Entry(chiPhi).State = EntityState.Modified;
            return db.SaveChanges();
        }
    }
}
