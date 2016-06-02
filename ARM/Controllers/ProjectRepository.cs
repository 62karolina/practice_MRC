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
        public IQueryable<Renter> rent
        {
            get { return context.Renters; }
        }

        public void DeleteRenters(Renter renter)
        {
            context.Renters.Remove(renter);
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
    }
}