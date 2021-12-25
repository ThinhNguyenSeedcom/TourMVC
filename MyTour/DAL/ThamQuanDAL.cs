using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTour
{
    public partial class ThamQuanDAL
    {
        public static int AddThamQuan(ThamQuan tq)
        {
            QuanLyTourEntities db = new QuanLyTourEntities();

            db.ThamQuans.Add(tq);
            return db.SaveChanges();
        }


    }
}
