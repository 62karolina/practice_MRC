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
        IQueryable<Servises> serv { get; }
        IQueryable<Extract> extr { get; }
        IQueryable<Privilege> priv { get; }
        void SaveRenters(Renter renter);
        void DeleteRenters(Renter renter);
        void SaveServ(Servises servis);
        void DeleteServ(Servises servis);
        void SaveExtr(Extract extract);
        void DeleteExtr(Extract extract);
        void SavePriv(Privilege privilege);
        void DeletePriv(Privilege privilege);

    }
}
