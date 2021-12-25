using MyTour.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTour
{
    public partial class PhanBoNV_Doan
    {
        public int add()
        {
            return PhanBoDoanDAL.add(this);
        }
        public static int remove(string maNv,string maDoan)
        {
            return PhanBoDoanDAL.remove(maNv, maDoan);
        }
    }
}
