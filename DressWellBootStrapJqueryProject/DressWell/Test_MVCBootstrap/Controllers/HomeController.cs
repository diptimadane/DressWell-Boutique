using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test_MVCBootstrap.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "DressWell Boutique";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Us";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Login";

            return View();
        }

        public ActionResult CustomerCentral()
        {
            ViewBag.Message = "Your JQuery page.";

            return View();
        }

        public ActionResult ShippingPolicies()
        {
            ViewBag.Message = "Please Note: Shipping policies are flexible for bulk requests.";

            return View();
        }
    }
}