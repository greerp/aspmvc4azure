// 
// Date		21-10-2015 10:08
// Author	Paul Greer
// 
// Copyright © RedPixie Ltd 2010-2014. All rights reserved.
// The software and associated documentation supplied hereunder are the 
// proprietary information of RedPixie Ltd, 145-157 St John Street, 
// London, EC1V 4PY, United Kingdom and are supplied subject to licence terms.

using System.Web.Mvc;

namespace aspmvc4azure.web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() {
            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}