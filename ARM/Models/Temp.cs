using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ARM.Models
{
    public class Temp
    {
        public int Id { get; set; }
        public List<Renter> IdRenters { get; set; }
        public List<Privilege> IdPriviliges { get; set; }
    }
}