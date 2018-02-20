﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace narnia.Controllers
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
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Basic()
        {

            return View();
        }

        public ActionResult Advance()
        {
            var person = new WebApplication1.Models.Person
            {
                FirstName = "Andy",
                LastName = "Schwab"
            };

            return View(person);
        }
            
    }
}
