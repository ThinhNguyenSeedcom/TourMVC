using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using MyTour.DAL;

namespace MyTour
{
    public partial class TourDuLich
    {
        TourDAL tourdal = new TourDAL();
        public string tenloai = "";
        public string TenLoai
        {
            get
            {
                return this.LoaiHinhDuLich.TenLoaiHinh;
            }
        }


        public static List<TourDuLich> GetAll()
        {
            TourDAL tourdal = new TourDAL();
            return tourdal.GetAll();
        }
        public int upDateTour()
        {
            return TourDAL.upDateTourToDB(this);
        }

        public int addTour()
        {
            return TourDAL.AddTourToDB(this);
        }

        public static int addTour(TourDuLich tourDuLich)
        {
            return TourDAL.AddTourToDB(tourDuLich);
        }


        public static TourDuLich findById(string id)
        {
            return TourDAL.findById(id);
        }

        public static int edit(TourDuLich tour)
        {
            return TourDAL.Edit(tour);
        }
        public static int delete(string id)
        {
            return TourDAL.delete(id);
        }

    }
}
