//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeknikServisOtomasyon
{
    using System;
    using System.Collections.Generic;
    
    public partial class UrunKabul
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UrunKabul()
        {
            this.ArizaDetay = new HashSet<ArizaDetay>();
        }
    
        public int IslemId { get; set; }
        public Nullable<int> Cari { get; set; }
        public Nullable<short> Personel { get; set; }
        public Nullable<System.DateTime> GelisTarih { get; set; }
        public Nullable<System.DateTime> CikisTarih { get; set; }
        public string UrunSeriNo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArizaDetay> ArizaDetay { get; set; }
        public virtual Cariler Cariler { get; set; }
        public virtual Personeller Personeller { get; set; }
    }
}