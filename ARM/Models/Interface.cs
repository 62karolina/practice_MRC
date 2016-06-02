using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM.Models
{
    interface Interface
    {
        IQueryable<Renter> rent { get; }
      //  IQueryable<Servis> serv { get; }
        void SaveRenters(Renter renter);
        void DeleteRenters(Renter renter);
        
    }
}
