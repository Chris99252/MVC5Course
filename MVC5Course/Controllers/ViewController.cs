using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class ViewController : Controller
    {
        // GET: View
        public ActionResult Index(string location)
        {
            ViewBag.num = new int[] { 1, 2, 3, 4, 5 };

            ViewBag.location = location;

            return PartialView();
        }
    }
}