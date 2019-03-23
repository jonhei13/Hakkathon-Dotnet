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

          
            return items;
        }


        public List<SuggestionItem> SuggestionTable()
        {
            List<SuggestionItem> suggestions = new List<SuggestionItem>();
            suggestions.Add(CreateSuggestionItem("colorectal cancer",50,74,2, 24));
            suggestions.Add(CreateSuggestionItem("High blood pressure", 18, 99, 2, 24));
            suggestions.Add(CreateSuggestionItem("High cholesterol", 45, 99, 5,60));
            suggestions.Add(CreateSuggestionItem("Cardiovascular", 45, 99, 0, 6));
            suggestions.Add(CreateSuggestionItem("Dental health", 50, 74, 2,24));
            suggestions.Add(CreateSuggestionItem("Diabetes: type 2", 40, 99, 3, 36));
            suggestions.Add(CreateSuggestionItem("Glaucoma", 50, 99, 1,12));
            suggestions.Add(CreateSuggestionItem("Hearing impairment", 65, 99, 1,12));
            suggestions.Add(CreateSuggestionItem("Overweight", 18, 99, 2,24));

            return suggestions;
        }

        public SuggestionItem CreateSuggestionItem(string affl, int lower, int upper,int frequencyYears, int frequencyMonths)
        {
            return new SuggestionItem() { Affliction = affl, AgeUpper = upper, AgeLower = lower, FrequencyInYears = frequencyYears, FrequencyInMonths = frequencyMonths };
        }

        
    }
}