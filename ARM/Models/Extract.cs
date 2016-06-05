using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ARM.Models
{
    public class Extract
    {
        public int Id { get; set; }
        public string Servise { get; set; }
        public int price { get; set; }
        public int With_privilege { get; set; }
        public int summ { get; set; }

        public virtual Renter Renter { get; set; }
    }
}