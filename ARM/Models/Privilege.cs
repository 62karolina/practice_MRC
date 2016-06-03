using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ARM.Models
{
    public class Privilege
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<double> Procent { get; set; }
        public Nullable<bool> Privileges { get; set; }
        public int RenterId { get; set; }

    }
}