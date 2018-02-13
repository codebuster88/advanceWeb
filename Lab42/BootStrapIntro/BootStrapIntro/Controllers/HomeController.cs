using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootStrapIntro.Controllers
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

        public ActionResult CalcApp()
        {
            return View();
        }

        

        [HttpPost]
        public ActionResult CalcApp(string val1, string val2, string method)
        {
       
            int num1 = Convert.ToInt32(val1);
            int num2 = Convert.ToInt32(val2);
            int ans;
            
            if (method.Equals("+"))
            {
                ans = num1 + num2;
            }
            else if (method.Equals("-"))
            {
                ans = num1 - num2;
            }
            else if (method.Equals("x"))
            {
                ans = num1 * num2;
            }
            else
                ans = num1 / num2;

            return View("CalcApp", (object)ans.ToString());
        }
        

    }
}