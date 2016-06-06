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
        IQueryable<Extract> extr { get; }
        void SaveRenters(Renter renter);
        Renter DeleteRenters(int id);
        void SaveExtr(Extract extract);
        void DeleteExtr(Extract extract);
       

    }
}
