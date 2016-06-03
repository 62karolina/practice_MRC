﻿using ARM.Models;
using System;
using System.Collections;
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
    
        public ActionResult Index()
        {
            price = new ARMContext();


            return View(price.Servis);
        }

  
     
        [AllowAnonymous]
        [HttpGet]
        public ActionResult Price()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Price(Servises model)
        {
            ProjectRepository pr = new ProjectRepository();

            var pri = new Servises
            {
                Name = model.Name,
                Price = model.Price

            };
            pr.SaveServ(pri);
            return RedirectToAction("Index", "Price", new { pri }); 
        }


    }
}