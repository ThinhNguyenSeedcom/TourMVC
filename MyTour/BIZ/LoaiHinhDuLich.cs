using MyTour.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTour
{

    public partial class LoaiHinhDuLich
    {
       
        public static List<LoaiHinhDuLich> GetAll()
        {
            LoaiHinhDuLichDAL lhdlDAL = new LoaiHinhDuLichDAL();
            return lhdlDAL.GetAll();
        }

        public int addLHDL()
        {
            return LoaiHinhDuLichDAL.AddTourToDB(this);
        }
    }
}
