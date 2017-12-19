using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GOTdb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string myName = "", int numTimes = 1)
        {
            
            for(int i = 0; i < numTimes; i++)
    {
                @ViewBag.Message = "Hi " + myName;
    }


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
    }
}