using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebForm.DAL;

namespace WebForm
{
    public partial class ChiTietDoan
    {
        public static int addChiTietDoan(ChiTietDoan chiTietDoan)
        {
            return ChiTietDoanDAL.addChiTietDoan(chiTietDoan);
        }

        public static ChiTietDoan findElementById(string id, string id2)
        {
            return ChiTietDoanDAL.findElementById(id,id2);
        }
    }
}