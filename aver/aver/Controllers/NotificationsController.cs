using aver.Models;
using aver.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aver.Controllers
{
    public class NotificationsController : Controller
    {

        public BusinessHelper helper = new BusinessHelper();


        // GET: Notifications
        public ActionResult Index()
        {
            NotificationViewModel model = new NotificationViewModel();

            model.Items = GetItems();
            return View(model);
        }

        public List<NotificationItem> GetItems()
        {
            var items =  helper.GetMedicationHistoryList("0206929999");

            return items;
        }

        
    }
}