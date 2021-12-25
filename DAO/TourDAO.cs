using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TourDAO
    {
        private static TourDAO instance;
        public static TourDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TourDAO();
                }
                return instance;
            }
        }

        public List<TourDuLich> Xem()
        {
            QuanLyTourEntities db = new QuanLyTourEntities();
            var result = from c in db.TourDuLiches select c;
            return result.ToList();
        }
    }
}
