using MyTour.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTour
{
    public partial class DiaDiem
    {
        public static List<DiaDiem> GetAll()
        {
            DiaDiemDAL dd = new DiaDiemDAL();
            return dd.GetAll();
        }
        public int addDD()
        {
            return DiaDiemDAL.AddDiaDiem(this);
        }

        public static int remove(string idMaTour,string idMaDiaDiem)
        {
            return DiaDiemDAL.remove(idMaTour, idMaDiaDiem);
        }
    }
}
