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
        ARMContext price;
        // GET: Price
        public ActionResult Index(Servis model)
        {
            price = new ARMContext();

            
            return View(price.Servises);
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult _Price()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult _Price(Servis model)
        {
           

            ProjectRepository pr = new ProjectRepository();

            var pri = new Servis
            {
                Name = model.Name,
                Price = model.Price

            };
            pr.SaveServ(pri);
            return RedirectToAction("Index", "Price", new { pri });
        }


    }
}