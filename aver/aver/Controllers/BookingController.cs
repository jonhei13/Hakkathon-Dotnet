using aver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aver.Controllers
{
    public class BookingController : Controller
    {
        // GET: Booking
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BookingFor(int ssn)
        {
            BookingItem model = new BookingItem();
            model.Ssn = ssn.ToString();
            model.NextAvailible = DateTime.Now;
            model.Name = "Ari Freyr Guðmundsson";
            return View(model);
        }
    }
}