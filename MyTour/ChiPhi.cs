//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyTour
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiPhi
    {
        public string MaChiPhi { get; set; }
        public string MaDoan { get; set; }
        public Nullable<double> SoTien { get; set; }
        public string MaLoaiChiPhi { get; set; }
    
        public virtual DoanDuLich DoanDuLich { get; set; }
        public virtual LoaiChiPhi LoaiChiPhi { get; set; }
    }
}
