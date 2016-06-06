using ARM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ARM.Controllers
{
    public class PrivilegesController : Controller
    {
        ARMContext armcontext;

        // GET: Privileges
        public ActionResult Index(Renter renter, Extract priv)
        {
            armcontext = new ARMContext();
            TrueFalse tfs = new TrueFalse();
          //  Privilege priv = new Privilege();
          //  Renter renter = new Renter();
            ProjectRepository pr = new ProjectRepository();
            //Renter privil = new Renter();
            // var privil = armcontext.Renters.Where(m => m.Privileges == renter.Privileges).FirstOrDefault();
            var privil = armcontext.Renters.FirstOrDefault(m => m.Privileges == true);
            //var trueFalse = armcontext.TrueFalses.Where(m => m.FTrue == tfs.FTrue).FirstOrDefault();
            var trueFalse = armcontext.TrueFalses.FirstOrDefault(m => m.FTrue == true);
            
            if (privil.Privileges == trueFalse.FTrue)
            {
                Renter user = armcontext.Renters.FirstOrDefault(m => m.Id == renter.Id);

                var info = new Extract
                {
                    RenterId = priv.RenterId
                };

                pr.SaveExtr(info);
                   
                     
           
            }
            return View(armcontext.Extracts);
        }

        

    }
}