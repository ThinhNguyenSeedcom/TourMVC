using MyTour.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTour
{
    public partial class LoaiChiPhi
    {
        public static List<LoaiChiPhi> getAll()
        {
            return LoaiChiPhiDAL.GetAll();
        }
    }
}
