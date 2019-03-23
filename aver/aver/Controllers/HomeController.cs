using aver.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aver.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            OrigoAPI x = new OrigoAPI();
            core.Models.OrigoRootObject d = x.GetPationtData("0206929999");
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