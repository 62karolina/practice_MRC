using ARM.Models;
using ARM.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace ARM.Controllers
{
    public class RenterController : Controller
    {
        ARMContext db;


        // GET: Renter
        [HttpGet]
        public ActionResult Index()
        {
            db = new ARMContext();
           
            return View(db.Renters);

        }

        public ActionResult Delete(int id)
        {
            Renter b = new Renter { Id = id };
            db.Entry(b).State = EntityState.Deleted;
            db.SaveChanges();

            return RedirectToAction("Index", "Renter");
        }
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Renter b = db.Renters.Find(id);
            if (b == null)
            {
                return HttpNotFound();
            }
            return View(b);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Renter b = db.Renters.Find(id);
            if (b == null)
            {
                return HttpNotFound();
            }
            db.Renters.Remove(b);
            db.SaveChanges();
            return RedirectToAction("Index", "Renter");
        }




        [AllowAnonymous]
        [HttpGet]
        public ActionResult newPerson()
        {
            return View();

        }

       
        [HttpPost]
        [AllowAnonymous]
        public ActionResult newPerson(Renter model)
        {
          
            ProjectRepository pr = new ProjectRepository();
           
            var person = new Renter
            {
                F_name = model.L_name,
                Name = model.Name,
                L_name = model.L_name,
                Adres = model.Adres,
                Debtor = model.Debtor,
                Privileges = model.Privileges
            };
            pr.SaveRenters(person);

            

            return RedirectToAction("Index", "Renter", new { person });
        }

            
            
           

        

    }
}