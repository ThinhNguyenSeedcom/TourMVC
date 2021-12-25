using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTour.DAL
{
    public class LoaiHinhDuLichDAL
    {
        public LoaiHinhDuLichDAL()
        {

        }
        public List<LoaiHinhDuLich> GetAll()
        {
            QuanLyTourEntities db = new QuanLyTourEntities();
            var result = from loaihinhdulich in db.LoaiHinhDuLiches select loaihinhdulich;
            return result.ToList();
        }

        public static int AddTourToDB(LoaiHinhDuLich LHDL)
        {
            QuanLyTourEntities db = new QuanLyTourEntities();

            db.LoaiHinhDuLiches.Add(LHDL);
            return db.SaveChanges();

        }
    }
    
}
