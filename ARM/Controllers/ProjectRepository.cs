using ARM.Models;
using ARM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ARM.Controllers
{
    public class ProjectRepository : Interface
    {
        private ARMContext context = new ARMContext();

        public IQueryable<Extract> extr
        {
            get { return context.Extracts; }
        }

        public IQueryable<Privilege> priv
        {
            get
            {
                return context.Privileges;
            }
        }

        public IQueryable<Renter> rent
        {
            get { return context.Renters; }
        }

        public IQueryable<Servises> serv
        {
            get
            {
                return context.Servis;
            }
        }

        public void DeleteExtr(Extract extract)
        {
            context.Extracts.Remove(extract);
            context.SaveChanges();
        }

        public void DeletePriv(Privilege privilege)
        {
            context.Privileges.Remove(privilege);
            context.SaveChanges();
        }

        public void DeleteRenters(Renter renter)
        {
            context.Renters.Remove(renter);
            context.SaveChanges();
        }

        public void DeleteServ(Servises servis)
        {
            context.Servis.Remove(servis);
            context.SaveChanges();
        }

        public void SaveExtr(Extract extract)
        {
            if (extract.Id == 0)
            {
                context.Extracts.Add(extract);
            }
            else
            {
                context.Entry(extract).State = System.Data.Entity.EntityState.Modified;
            }
            context.SaveChanges();
        }

        public void SavePriv(Privilege privilege)
        {
            if (privilege.Id == 0)
            {
                context.Privileges.Add(privilege);
            }
            else
            {
                context.Entry(privilege).State = System.Data.Entity.EntityState.Modified;
            }
            context.SaveChanges();
        }

        public void SaveRenters(Renter renter)
        {
            if (renter.Id == 0)
            {
                context.Renters.Add(renter);
            }
            else
            {
                context.Entry(renter).State = System.Data.Entity.EntityState.Modified;
            }
            context.SaveChanges();
        }

        public void SaveServ(Servises servis)
        {
            if (servis.Id == 0)
            {
                context.Servis.Add(servis);
            }
            else
            {
                context.Entry(serv).State = System.Data.Entity.EntityState.Modified;
            }
            context.SaveChanges();
        }
    }
}