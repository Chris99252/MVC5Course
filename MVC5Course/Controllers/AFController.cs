using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class AFController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MadeMeWrong()
        {
            throw new Exception("OK");
            return View();
        }
    }
}