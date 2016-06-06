using ARM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ARM.Controllers
{
    public class ExtractController : Controller
    {
        ARMContext db;
        // GET: Extract
        public ActionResult Index()
        {
            db = new ARMContext();
            if (db.Extracts == null)
            {
                return View();
            }


            return View(db.Extracts);
        }

        [HttpGet]
        public ActionResult Change()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Change(Extract model)
        {
            ProjectRepository pr = new ProjectRepository();

            var pri = new Extract
            {
                RenterId = model.RenterId,
                With_privilege = model.With_privilege                 

            };
            pr.SaveExtr(pri);

            return RedirectToAction("Index", "Extract", new { pri });
        }

    }
}