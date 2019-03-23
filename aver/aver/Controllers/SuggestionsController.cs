using aver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aver.Controllers
{
    public class SuggestionsController : Controller
    {
        // GET: Suggestions
        public ActionResult Index()
        {
            SuggestionViewModel model = new SuggestionViewModel();
            model.Items = GetItems();
            return View(model);
        }

        public List<SuggestionItem> GetItems()
        {
            List<SuggestionItem> items = new List<SuggestionItem>();

            items.Add(new SuggestionItem { DateSinceLast = DateTime.Now, Message ="Ristilskoðun"});
            items.Add(new SuggestionItem { DateSinceLast = DateTime.Now, Message = "Ristilspeglun" });
            items.Add(new SuggestionItem { DateSinceLast = DateTime.Now, Message = "Legsokoðun" });
           
            return items;
        }
    }
}