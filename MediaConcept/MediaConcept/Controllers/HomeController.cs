using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MediaConcept.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {          
            return View();
        }
        public ActionResult MaintenanceCorrective()
        {
            return View();
        }
        public ActionResult MaintenancePreventive()
        {
            return View();
        }
        public ActionResult TableauxDeBord()
        {
            return View();
        }
        public ActionResult BonsDeTravail()
        {
            return View();
        }
        public ActionResult Planification()
        {
            return View();
        }
        public ActionResult GestionProduction()
        {
            return View();
        }
        public ActionResult Produits()
        {
            return View();
        }
        public ActionResult Clients()
        {
            return View();
        }
    }
}