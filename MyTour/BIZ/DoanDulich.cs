using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTour.DAL;

namespace MyTour
{
    public partial class DoanDuLich
    {
        public string tenTour
        {
            get
            {
                return this.TourDuLich.TenGoi;
            }
        }

        public string HanhTrinh
        {
            get
            {
                return this.NoiDungTour.HanhTrinh;
            }
        }

        public string KhachSan
        {
            get
            {
                return this.NoiDungTour.KhachSan;
            }
        }

        public string DiaDiemThamQuan
        {
            get
            {
                return this.NoiDungTour.DiaDiemThamQuan;
            }
        }


        public static List<DoanDuLich> GetAll()
        {
            DoanDuLichDAL doanDuLichDAL = new DoanDuLichDAL();
            return doanDuLichDAL.GetAll();
        }
        
        public static int addDoanDuLich(DoanDuLich doan)
        {
            return DoanDuLichDAL.addDoanDuLichIntoDB(doan);

        }
        public static int addNoiDungDoan(NoiDungTour noiDungTour)
        {
            return DoanDuLichDAL.addNoiDungDoan(noiDungTour);
        }
        public static int addChiPhi(ChiPhi chi)
        {
            return DoanDuLichDAL.addChiPhi(chi);
        }

    }
}
