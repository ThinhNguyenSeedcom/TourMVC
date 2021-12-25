using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTour.DAL
{
    public class DiaDiemDAL
    {

        public List<DiaDiem> GetAll()
        {
            QuanLyTourEntities db = new QuanLyTourEntities();
            var result = from dd in db.DiaDiems select dd;
            return result.ToList();
        }
        public static int AddDiaDiem(DiaDiem dd)
        {
            QuanLyTourEntities db = new QuanLyTourEntities();

            db.DiaDiems.Add(dd);
            return db.SaveChanges();
        }

        public static int remove(string idMaTour,string idMaDiaDiem)
        {
            QuanLyTourEntities db = new QuanLyTourEntities();
            ThamQuan thamQuan = db.ThamQuans.Find(idMaTour, idMaDiaDiem);
            db.ThamQuans.Remove(thamQuan);
            return db.SaveChanges();
        }


    }
}
