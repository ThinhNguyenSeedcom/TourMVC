using MyTour.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTour
{
    public partial class NhanVien
    {
        public static List<NhanVien> GetAll() {
            return NhanVienDAL.GetAll();
        }
    }
}
