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
    
    public partial class LoaiHinhDuLich
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiHinhDuLich()
        {
            this.TourDuLiches = new HashSet<TourDuLich>();
        }
    
        public string MaLoaiHinh { get; set; }
        public string TenLoaiHinh { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TourDuLich> TourDuLiches { get; set; }
    }
}
