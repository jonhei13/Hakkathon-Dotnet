using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aver.Models
{
    public class UserItem
    {
        public List<string> Allergies { get; set; }
        public String Name { get; set; }
        public String BloodPressure { get; set; }
        public int Budget{ get; set; }

        public DateTime Date { get; set; }
        public string Title { get; set; }
    }
}