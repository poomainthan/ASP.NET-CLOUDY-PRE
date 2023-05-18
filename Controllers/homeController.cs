using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CLOUDY_PRE_IMPLEMENT.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult about()
        {

            return View("about");
        }
        public ActionResult service()
        {

            return View("service");
        }
        public ActionResult plan()
        {

            return View("plan");
        }
        public ActionResult domain()
        {

            return View("domain");
        }
        public ActionResult faq()
        {

            return View("faq");
        }
        public ActionResult blog()
        {

            return View("blog");
        }
        public ActionResult support()
        {

            return View("support");
        }
        public ActionResult contact()
        {

            return View("contact");
        }
        public ActionResult login()
        {

            return View("login");
        }
        public ActionResult register()
        {

            return View("register");
        }
        public ActionResult domainmanage()
        {

            return View("domainmanage");
        }
        public ActionResult process()
        {

            return View("process");
        }
        public ActionResult processorder()
        {

            return View("processorder");
        }
    }
}