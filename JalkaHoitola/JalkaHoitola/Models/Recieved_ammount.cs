//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JalkaHoitola.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Recieved_ammount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Recieved_ammount()
        {
            this.Stock = new HashSet<Stock>();
        }
    
        public int SaapumiseränId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.DateTime> ExpireDate { get; set; }
        public string Price { get; set; }
        public string VendorName { get; set; }
        public string LocationCode { get; set; }
    
        public virtual Products Products { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stock> Stock { get; set; }
    }
}
