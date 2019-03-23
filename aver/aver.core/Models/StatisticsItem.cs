using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aver.Models
{
    public class StatisticsItem
    {
        public enum Type { Spending, Count }
        public string Message { get; set; }
        public Type StatType { get; set; }

        public int Data { get; set; }
    }

  
}