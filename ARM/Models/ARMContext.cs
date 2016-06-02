using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ARM.Models
{
    public class ARMContext: DbContext
    {
        public ARMContext()
            : base("ARMdatabase")
        {
        }


        public DbSet<Extract> Extracts { get; set; }
        public DbSet<Privilege> Privileges { get; set; }
        public DbSet<Renter> Renters { get; set; }
        public DbSet<Servis> Servises { get; set; }
    }
}