using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ARM.Models
{
    public class Renter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Renter()
        {
            this.Extracts = new HashSet<Extract>();
        }

        public int Id { get; set; }
        public string F_name { get; set; }
        public string Name { get; set; }
        public string L_name { get; set; }
        public string Adres { get; set; }
        public Nullable<bool> Privileges { get; set; }
        public Nullable<bool> Debtor { get; set; }

        public virtual ICollection<Extract> Extracts { get; set; }
    }
}