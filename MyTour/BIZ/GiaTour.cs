using MyTour.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTour
{
    public partial class GiaTour
    {
        public int addGiaTour()
        {
            return GiaTourDAL.AddGiaTour(this);
        }
        public static int remove(string idGiaTour)
        {
            return GiaTourDAL.remove(idGiaTour);
        }
    }
}
