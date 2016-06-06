using ARM.Models;
using System;
using System.Collections.Generic;
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
        public ActionResult Index()
        {
            db = new ARMContext();

            
            
            return View(db.Renters);

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

        [HttpPost]
        public ActionResult Delete(int id)
        {
            ProjectRepository pr = new ProjectRepository();
            Renter deletedGame = pr.DeleteRenters(id);
            if (deletedGame != null)
            {
                TempData["message"] = string.Format("Удалено");
            }
            return RedirectToAction("Index");
        }

        

        [HttpGet]
        public ViewResult Edit(int id)
        {
            db = new ARMContext();
            Renter game = db.Renters.FirstOrDefault(g => g.Id == id);
            return View(game);
        }

        [HttpPost]
        public ActionResult Edit(Renter game)
        {
            db = new ARMContext();
            ProjectRepository pr = new ProjectRepository();
            if (ModelState.IsValid)
            {
                pr.SaveRenters(game);
                db.SaveChanges();
                TempData["message"] = string.Format("Сохранено", game.Name);
                return RedirectToAction("Index");
            }
            else
            {
                // Что-то не так со значениями данных
                return View(game);
            }
        }



    }
}