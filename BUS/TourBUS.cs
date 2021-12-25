using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
namespace BUS
{
    public class TourBUS
    {
        private static TourBUS instance;
        TourDAO tourd = new TourDAO();
        public static TourBUS Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new TourBUS();
                }
                return instance;
            }
        }
        private TourBUS()
        {

        }

        public void Xem(DataGridView data)
        {
            data.DataSource = tourd.Xem();
        }
    }
}
