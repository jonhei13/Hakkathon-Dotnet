

using aver.Helpers;


using aver.services.ArionApi;

using aver.Models;
using aver.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using aver.core.Models;

namespace aver.Controllers
{
    public class HomeController : Controller
    { 

         public BusinessHelper helper = new BusinessHelper();

        public ActionResult Index()
        {

            PersonalizedCardProvider provider = new PersonalizedCardProvider();
          
            SuperModel model = new SuperModel();

            model.FoodCards = provider.GetMealPlan("low");
            return View(model);
        }
        public ActionResult Detail(string type)
        {
            PersonalizedCardProvider provider = new PersonalizedCardProvider();
            SuggestionItem model = provider.GetByType(type);

            return View(model);
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