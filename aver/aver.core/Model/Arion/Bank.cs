using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aver.core.Model.Arion
{
    public class Bank
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Area { get; set; }
        public bool IsWheelChairFriendly { get; set; }
        public bool SelfService { get; set; }
        public string OpeningHours { get; set; }
    }
}