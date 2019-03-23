using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aver.Models
{
    public class SuggestionItem
    {
        public string Affliction { get; set; }
        public int AgeUpper { get; set; }
        public int AgeLower { get; set; }
        public int FrequencyInYears { get; set; }
        public int FrequencyInMonths { get; set; }

    }
}