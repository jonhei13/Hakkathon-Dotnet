using aver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aver.Controllers
{
    public class HistoryController : Controller
    {
        // GET: Hisroty
        public ActionResult Index()
        {
            HistoryViewModel model = new HistoryViewModel();
            model.Items = GetItems();
            return View(model);
        }

        public List<HistoryItem> GetItems()
        {
            List<HistoryItem> items = new List<HistoryItem>();

            items.Add(new HistoryItem { Date = DateTime.Now, Title ="Flottur titill"});
            items.Add(new HistoryItem { Date = DateTime.Now, Title = "Flottur titill" });
            items.Add(new HistoryItem { Date = DateTime.Now, Title = "Flottur titill" });
            items.Add(new HistoryItem { Date = DateTime.Now, Title = "Flottur titill" });

            items.Add(new HistoryItem { Date = DateTime.Now, Title = "Flottur titill" });
            return items;
        }
    }
}