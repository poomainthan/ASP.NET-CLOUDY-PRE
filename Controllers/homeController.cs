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
    }
}