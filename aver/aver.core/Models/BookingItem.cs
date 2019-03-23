using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aver.Models
{
    public class BookingItem
    {
        public string  Ssn { get; set; }
        public DateTime NextAvailible { get; set; }
        public string Name { get; set; }
    }
}