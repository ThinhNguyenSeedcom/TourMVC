using WebForm.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebForm
{
    public partial class NhanVien
    {
        public static List<NhanVien> GetAll() {
            return NhanVienDAL.GetAll();
        }
        public static NhanVien findElementById(string id)
        {
            return NhanVienDAL.findElementById(id);
        }
        public static int add(NhanVien nhanVien)
        {
            return NhanVienDAL.add(nhanVien);
        }
        public static int edit(NhanVien nhanVien)
        {
            return NhanVienDAL.edit(nhanVien);
        }
    }

    

}
