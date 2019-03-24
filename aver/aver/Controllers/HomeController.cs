

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
using aver.core.Model.Arion.FinancialData;

namespace aver.Controllers
{
    public class HomeController : Controller
    { 

        public BusinessHelper helper = new BusinessHelper();
        public ArionApi arionHelper = new ArionApi();

        public ActionResult Index()
        {
            PersonalizedCardProvider provider = new PersonalizedCardProvider();
            FinancialModel finmod = arionHelper.GetFinancialStatus();
            SuperModel model = new SuperModel();
            model.Finance = finmod;
            model.FoodCards = provider.GetMealPlan("low");


            helper.GetDiagnosisIds("0206929999");



            return View(model);
        }
        public ActionResult Detail(string type)
        {
            PersonalizedCardProvider provider = new PersonalizedCardProvider();
            SuggestionItem model = provider.GetByType(type);
            model.Foods.ForEach((food) =>
            {
                food.Description = "Bacon ipsum dolor amet venison ground round jerky prosciutto short ribs. Chuck short ribs ground round porchetta, landjaeger turkey pastrami sirloin jerky. Brisket boudin short ribs swine leberkas beef ribs alcatra ham capicola pork loin turducken rump. ";
            });
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