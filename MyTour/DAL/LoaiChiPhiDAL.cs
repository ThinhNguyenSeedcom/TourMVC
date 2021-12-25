using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTour.DAL
{
    class LoaiChiPhiDAL
    {
        public static List<LoaiChiPhi> GetAll()
        {
            QuanLyTourEntities db = new QuanLyTourEntities();
            var result = from c in db.LoaiChiPhis select c;
            return result.ToList();
        }
    }
}
