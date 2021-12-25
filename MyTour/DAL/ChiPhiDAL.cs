using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTour.DAL
{
    public class ChiPhiDAL
    {
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
    }
}
