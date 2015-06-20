using MVCGridMainEx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCGridMainEx.Controllers
{
    public class HomeController : Controller
    {
        LabRepository labRepo = new LabRepository();

        public ActionResult Index()
        {
            var items = labRepo.getAll();
            return View(items);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}