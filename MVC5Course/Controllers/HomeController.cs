using MVC5Course.ActionFilters;
using MVC5Course.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    [Logger]
    public class HomeController : BaseController
    {

        [ShareData]
        public ActionResult Index()
        {
            return View();
        }

        [ShareData]
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Profile()
        {
            return View();
        }

        public ActionResult Cart()
        {
            //var vr = new ViewResult();
            //vr.ViewName = "Cart";
            //return vr;

            return View();
        }

    }
}