using WebForm.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebForm
{
    public partial class GiaTour
    {

        public static List<GiaTour> getAll()
        {
            return GiaTourDAL.GetAll();
        }
        public static int addGiaTour(GiaTour giaTour)
        {
            return GiaTourDAL.AddGiaTour(giaTour);
        }
        public static int remove(string idGiaTour)
        {
            return GiaTourDAL.remove(idGiaTour);
        }

        public static GiaTour findElementById(string id)
        {
            return GiaTourDAL.findElementById(id);
        }

        public static int editGiaTour(GiaTour giaTour)
        {
            return GiaTourDAL.editTourGiaTour(giaTour);
        }
    }
}
