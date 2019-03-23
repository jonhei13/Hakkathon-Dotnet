using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aver.core.Model.Arion.Account
{
    public class AccountTransactions
    {
        public Paging paging { get; set; }
        public List<Transaction> transaction { get; set; }
    }


    public class Transaction
    {
        public string AccountID { get; set; }
        public double amount { get; set; }
        public double balance { get; set; }
        public string batchNumber { get; set; }
        public string billNumber { get; set; }
        public string category { get; set; }
        public string categoryCode { get; set; }
        public string payorID { get; set; }
        public string redeemingBank { get; set; }
        public string reference { get; set; }
        public string referenceDetail { get; set; }
        public string transactionDate { get; set; }
        public string transactionID { get; set; }
        public string transactionKey { get; set; }
        public string valueDate { get; set; }
    }
    public class Paging
    {
        public int totalPages { get; set; }
        public int totalRecords { get; set; }
    }


}