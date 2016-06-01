//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ARM.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Renter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Renter()
        {
            this.Privileges1 = new HashSet<Privilege>();
            this.Extracts = new HashSet<Extract>();
        }
    
        public int Id { get; set; }
        public string F_name { get; set; }
        public string Name { get; set; }
        public string L_name { get; set; }
        public string Adres { get; set; }
        public Nullable<bool> Privileges { get; set; }
        public Nullable<bool> Debtor { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Privilege> Privileges1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Extract> Extracts { get; set; }

        //public static implicit operator Renter(Renter v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}