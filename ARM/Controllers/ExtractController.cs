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
        // GET: Extract
        ARMContext db;
        public ActionResult Index(int id)
        {
            db = new ARMContext();

            return View(db.Extracts);
        }
    }
}