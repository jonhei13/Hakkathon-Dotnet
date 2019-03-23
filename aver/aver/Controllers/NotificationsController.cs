using aver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aver.Controllers
{
    public class NotificationsController : Controller
    {
        // GET: Notifications
        public ActionResult Index()
        {
            NotificationViewModel model = new NotificationViewModel();

            model.Items = GetItems();
            return View(model);
        }

        public List<NotificationItem> GetItems()
        {
            List<NotificationItem> items = new List<NotificationItem>();

            items.Add(new NotificationItem { Date =  DateTime.Now, Title = "Uppfærði skýrslu", Desctiption = "Bætti við lýsingu og viðhengi á skýrslu"});
            items.Add(new NotificationItem { Date = DateTime.Now, Title = "Uppfærði skýrslu", Desctiption = "Bætti við lýsingu og viðhengi á skýrslu" });
            items.Add(new NotificationItem { Date = DateTime.Now, Title = "Uppfærði skýrslu", Desctiption = "Bætti við lýsingu og viðhengi á skýrslu" });
            items.Add(new NotificationItem { Date = DateTime.Now, Title = "Uppfærði skýrslu", Desctiption = "Bætti við lýsingu og viðhengi á skýrslu" });
            items.Add(new NotificationItem { Date = DateTime.Now, Title = "Uppfærði skýrslu", Desctiption = "Bætti við lýsingu og viðhengi á skýrslu" });
            items.Add(new NotificationItem { Date = DateTime.Now, Title = "Uppfærði skýrslu", Desctiption = "Bætti við lýsingu og viðhengi á skýrslu" });
            items.Add(new NotificationItem { Date = DateTime.Now, Title = "Uppfærði skýrslu", Desctiption = "Bætti við lýsingu og viðhengi á skýrslu" });
            items.Add(new NotificationItem { Date = DateTime.Now, Title = "Uppfærði skýrslu", Desctiption = "Bætti við lýsingu og viðhengi á skýrslu" });
            return items;
        }

        
    }
}