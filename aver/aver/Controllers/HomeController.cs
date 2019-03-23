
using aver.Helpers;
using aver.Models;
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

         public BusinessHelper helper = new BusinessHelper();

        public ActionResult Index()
        {
            PersonalizedCardProvider provider = new PersonalizedCardProvider();
            provider.GetMealPlan("low");
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