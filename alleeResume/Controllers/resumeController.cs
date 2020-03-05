using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace alleeResume.Controllers
{
    public class resumeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Education()
        {
            ViewBag.Message = "education page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult workHistory()
        {
            ViewBag.Message = "work history page.";

            return View();
        }

        public ActionResult skills()
        {
            ViewBag.Message = "skills page.";

            return View();
        }

        public ActionResult references()
        {
            ViewBag.Message = "references page.";

            return View();
        }

        public ActionResult projects()
        {
            ViewBag.Message = "projects page.";

            return View();
        }
    }
}