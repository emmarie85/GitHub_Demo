using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitHub_Demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "This is some code.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is a change made from git";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult MakeABranch()
        {
            //This is a branch created on my local machine.

            int i = 3; 

            return View();

            //I am addin some code for source code example
        }
    }
}
