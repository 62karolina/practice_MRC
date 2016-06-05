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



        public IQueryable<Renter> rent
        {
            get { return context.Renters; }
        }



        public void DeleteExtr(Extract extract)
        {
            context.Extracts.Remove(extract);
            context.SaveChanges();
        }



        public void DeleteRenters(Renter renter)
        {
            context.Renters.Remove(renter);
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