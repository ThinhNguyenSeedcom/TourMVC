using WebForm.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebForm
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
        public static List<ChiPhi> getAll()
        {

            return ChiPhiDAL.getAll();
        }

        public static int addChiPhi(ChiPhi chiPhi)
        {
            return ChiPhiDAL.addChiPhi(chiPhi);
        }
        public static ChiPhi getItemById(string id)
        {
            return ChiPhiDAL.getItemById(id);
        }
        public static int delectChiPhi(string id)
        {
            return ChiPhiDAL.delectChiPhi(id);
        }

        public static int edit(ChiPhi chiPhi)
        {
            return ChiPhiDAL.edit(chiPhi);
        }

    }
}
