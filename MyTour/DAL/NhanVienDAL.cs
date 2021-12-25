using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTour.DAL
{
    public class NhanVienDAL
    {
        public static List<NhanVien> GetAll()
        {
            QuanLyTourEntities db = new QuanLyTourEntities();
            var result = from c in db.NhanViens select c;
            return result.ToList();
        }
    }
}
