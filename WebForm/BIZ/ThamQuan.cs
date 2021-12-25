using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebForm.DAL;
using System.Threading.Tasks;

namespace WebForm
{
    public partial class ThamQuan
    {
        public string TenTour
        {
            get
            {
                return this.TourDuLich.TenGoi;
            }
        }

        public string TenDiaDiem
        {
            get
            {
                return this.DiaDiem.TenDiaDiem;
            }
        }

        public static List<ThamQuan> getAll()
        {
            return ThamQuanDAL.getAll();
        }

        public static int addThamQuan(ThamQuan thamQuan)
        {
            return ThamQuanDAL.AddThamQuan(thamQuan);
        }

        public static ThamQuan findElementById(string idTour, string idMaDiaDiem)
        {
            return ThamQuanDAL.findElementById(idTour, idMaDiaDiem);
        }
        public static int editThamQuan(ThamQuan thamQuan)
        {
            return ThamQuanDAL.editThamQuan(thamQuan);
        }

        public static int deleteThamQuan(string idTour, string idMaDiaDiem)
        {
            return ThamQuanDAL.deleteThamQuan(idTour, idMaDiaDiem);
        }
    }
}
