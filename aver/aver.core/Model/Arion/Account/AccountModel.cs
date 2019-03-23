using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aver.core.Model.Arion.Account
{
    public class AccountModel
    {
        public List<Account> account { get; set; }
        public int totalCount { get; set; }
    }
    public class Account
    {
        public string accountID { get; set; }
        public string accountOwnerID { get; set; }
        public double availableAmount { get; set; }
        public double balance { get; set; }
        public string customAccountName { get; set; }
        public double overdraft { get; set; }
        public string status { get; set; }
        public double totalAmountWaiting { get; set; }
    }


}