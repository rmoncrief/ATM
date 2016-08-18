﻿using System.Web.Mvc;

namespace ATM.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            //ViewBag.Message = "Your contact page.";
            ViewBag.TheMessage = "Having Trouble, send us a message";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string message)
        {
            //TODO: sned message to hq
            ViewBag.TheMessage = "Thanks, Got your message";

            return View();
        }

        public ActionResult Serial(string letterCase)
        {
            string serial = "ASPNETMVCATM1";
            if (letterCase == "lower")
            {
                return Content(serial.ToLower());
            }
            return Content(serial);
        }
    }
}