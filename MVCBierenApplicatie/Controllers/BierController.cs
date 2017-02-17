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
        private BierenService bierenService = new BierenService();
        // GET: Bier
        public ActionResult Index()
        {
            var bieren = bierenService.FindAll();
            return View(bieren);
        }

        public ActionResult Verwijderen(int id)
        {
            var bier = bierenService.Read(id);
            return View(bier);
        }

        [HttpPost]
        public ActionResult Delete(int ID)
        {
            var bier = bierenService.Read(ID);
            this.TempData["bier"] = bier;
            bierenService.Delete(ID);
            return RedirectToAction("Verwijderd");
        }

        public ActionResult Verwijderd()
        {
            var bier = (Bier)this.TempData["bier"];
            return View(bier);
        }

    }
}