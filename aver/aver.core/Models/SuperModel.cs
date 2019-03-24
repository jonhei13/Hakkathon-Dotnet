using aver.core.Model.Arion.FinancialData;
using aver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aver.core.Models
{
    public class SuperModel
    {
        public List<SuggestionItem> FoodCards { get; set; }
        public FinancialModel Finance { get; set; }
    }
}