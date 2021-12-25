using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyTour.DAL;
using System.Threading.Tasks;

namespace MyTour
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

        public int addThamQuan()
        {
            return ThamQuanDAL.AddThamQuan(this);
        }
    }
}
