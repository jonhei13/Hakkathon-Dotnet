using aver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aver.Controllers
{
    public class UserController : Controller
    {
        // GET: Hisroty
        public ActionResult Index()
        {
            UserViewModel model = new UserViewModel();
            model.Items = GetItems();
            return View(model);
        }

        public List<UserItem> GetItems()
        {
            List<UserItem> items = new List<UserItem>();

            items.Add(new UserItem { Date = DateTime.Now, Title ="Flottur titill"});
            items.Add(new UserItem { Date = DateTime.Now, Title = "Flottur titill" });
            items.Add(new UserItem { Date = DateTime.Now, Title = "Flottur titill" });
            items.Add(new UserItem { Date = DateTime.Now, Title = "Flottur titill" });

            items.Add(new UserItem { Date = DateTime.Now, Title = "Flottur titill" });
            return items;
        }
    }
}