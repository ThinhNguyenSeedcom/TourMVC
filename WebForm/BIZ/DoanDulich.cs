using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebForm.DAL;

namespace WebForm
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
        public static DoanDuLich findElementById(string id)
        {
            return DoanDuLichDAL.FindElementById(id);
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
        public static int edit(DoanDuLich doanDuLich)
        {
            return DoanDuLichDAL.Edit(doanDuLich);
        }
        public static int delete (string id)
        {
            return DoanDuLichDAL.delete(id);
        }
    }
}
