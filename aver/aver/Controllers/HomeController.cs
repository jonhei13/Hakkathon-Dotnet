using aver.services.ArionApi;
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
            var x = new ArionApi();
            //var bla = x.GetClaims(1, 50);
            //var account = x.GetAccountStatus();
            //var bla = x.GetBankInfo();
            //var da = x.GetCreditCardInfo();
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