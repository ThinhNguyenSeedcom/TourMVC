using WebForm.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebForm
{
    public partial class KhachHang
    {
        public static List<KhachHang> GetAll()
        {
            
            return KhachHangDAL.GetAll();
        }
        public static int addKhachHang(KhachHang khachHang)
        {
            return KhachHangDAL.addKhachHang(khachHang);
        }
      /*  public int addKhachHangIntoDb(KhachHang kh, DoanDuLich doan)
        {
            KhachHang newKhach = KhachHangDAL.getKhachHangById(kh.MaKH);
            return KhachHangDAL.addKhachHangintoDoan(newKhach, doan);
        }*/

    /*    public static int deleteKH(string idKH,string idDoan)
        {
            return KhachHangDAL.deleteKH(idKH, idDoan);
        }*/

        public static KhachHang getKhachHangById(string id)
        {
            return KhachHangDAL.getKhachHangById(id);
        }

        public static int edit(KhachHang khachHang)
        {
            return KhachHangDAL.editKhachHang(khachHang);
        }
    }
}
