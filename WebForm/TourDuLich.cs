//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebForm
{
    using System;
    using System.Collections.Generic;
    
    public partial class TourDuLich
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TourDuLich()
        {
            this.DoanDuLiches = new HashSet<DoanDuLich>();
            this.GiaTours = new HashSet<GiaTour>();
            this.ThamQuans = new HashSet<ThamQuan>();
        }
    
        public string MaTour { get; set; }
        public string TenGoi { get; set; }
        public string DacDiem { get; set; }
        public string MaLoaiHinh { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoanDuLich> DoanDuLiches { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiaTour> GiaTours { get; set; }
        public virtual LoaiHinhDuLich LoaiHinhDuLich { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThamQuan> ThamQuans { get; set; }
    }
}