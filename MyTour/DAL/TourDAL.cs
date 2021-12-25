using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTour.DAL
{
    public class TourDAL
    {
        public TourDAL()
        {

        }
        public List<TourDuLich> GetAll()
        {
            QuanLyTourEntities db = new QuanLyTourEntities();
            var result = from c in db.TourDuLiches select c;
            return result.ToList();
        }
        public static TourDuLich findById(string id)
        {
            QuanLyTourEntities db = new QuanLyTourEntities();
            TourDuLich tourDuLich = db.TourDuLiches.Find(id);

            return tourDuLich;
        }

        public static int upDateTourToDB(TourDuLich tour)
        {
            QuanLyTourEntities db = new QuanLyTourEntities();
            System.Console.WriteLine(tour.MaLoaiHinh);

            TourDuLich newTour = db.TourDuLiches.Find(tour.MaTour);// lay tu csdl len

            newTour.TenGoi = tour.TenGoi;
            newTour.DacDiem = tour.DacDiem;
            newTour.MaLoaiHinh = tour.MaLoaiHinh;

            //db.Entry(tour).State = EntityState.Modified;
            return db.SaveChanges();

        }

        public static int AddTourToDB(TourDuLich tour)
        {
            QuanLyTourEntities db = new QuanLyTourEntities();
            db.TourDuLiches.Add(tour);
            return db.SaveChanges();
        }

        public static int Edit(TourDuLich tour)
        {
            QuanLyTourEntities db = new QuanLyTourEntities();
            db.Entry(tour).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges();
        }
        public static int delete(string id)
        {
            QuanLyTourEntities db = new QuanLyTourEntities();
            var tour = db.TourDuLiches.Find(id);
            db.TourDuLiches.Remove(tour);
            return db.SaveChanges();
        }



    }
}
