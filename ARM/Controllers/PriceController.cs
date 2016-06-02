using ARM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ARM.Controllers
{
    public class PriceController : Controller
    {
        ARMdatabaseEntities price;
        // GET: Price
        public ActionResult Index(Servis model)
        {
            price = new ARMdatabaseEntities();

            ProjectRepository pr = new ProjectRepository();

            var pri = new Servis
            {
                Name = model.Name,
                Price = model.Price

            };
            pr.SaveRenters(pri);
            return View();
        }

        
    }
}