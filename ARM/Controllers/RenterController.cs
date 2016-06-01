using ARM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace ARM.Controllers
{
    public class RenterController : Controller
    {
        ARMdatabaseEntities db;


        // GET: Renter
        public ActionResult Index()
        {
            db = new ARMdatabaseEntities();
            
            return View(db.Renters);

        }
    }
}