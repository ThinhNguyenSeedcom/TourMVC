using MyTour.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTour
{
    public partial class ChiPhi
    {
        public string TenLoaiChiPhi
        {
            get
            {
                return this.LoaiChiPhi.TenLoaiChiPhi;
            }
        }

        public static ChiPhi getItemById(String id)
        {
            return ChiPhiDAL.getItemById(id);
        }
        public static int delectChiPhi(string id)
        {
            return ChiPhiDAL.delectChiPhi(id);
        }


    }
}
