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
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Desctiption { get; set; }
    }
}