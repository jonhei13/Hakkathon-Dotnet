using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aver.Models
{
    public class NotificationViewModel
    {
        public List<NotificationItem> Items { get; set; }
    }

    public class NotificationItem
    {
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Quantity { get; set; }
        public string Strength { get; set; }
        public string Uses { get; set; }
        public string Instructions { get; set; }
    } 
}