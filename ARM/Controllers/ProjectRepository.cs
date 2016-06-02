using ARM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ARM.Controllers
{
    public class ProjectRepository : Interface
    {
        private ARMdatabaseEntities context = new ARMdatabaseEntities();

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

        public IQueryable<Servis> serv
        {
            get
            {
                return context.Servises;
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

        public void DeleteServ(Servis serv)
        {
            context.Servises.Remove(serv);
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

        public void SaveServ(Servis serv)
        {
            if (serv.Id == 0)
            {
                context.Servises.Add(serv);
            }
            else
            {
                context.Entry(serv).State = System.Data.Entity.EntityState.Modified;
            }
            context.SaveChanges();
        }
    }
}