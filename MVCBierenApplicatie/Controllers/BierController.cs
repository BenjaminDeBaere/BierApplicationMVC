using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBierenApplicatie.Models;

namespace MVCBierenApplicatie.Controllers
{
    public class BierController : Controller
    {
        // GET: Bier
        public ActionResult Index()
        {
            var bieren = new List<Bier>();
            bieren.Add(new Bier { ID = 1, Naam = "Stella Artois", Alcohol = 15F });
            bieren.Add(new Bier { ID = 2, Naam = "Heineken", Alcohol = 0.02F });
            bieren.Add(new Bier { ID = 10, Naam = "Carlsberg", Alcohol = 5F });
            return View("bieren",bieren);
        }
    }
}