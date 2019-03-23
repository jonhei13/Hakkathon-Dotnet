using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aver.core.Model.Arion.CreditCards
{
    public class CreditCardTransactions
    {
        public Paging paging { get; set; }
        public List<Transaction> transaction { get; set; }

    }

    public class Transaction
    {
        public double amount { get; set; }
        public string authorizationNumber { get; set; }
        public int cardId { get; set; }
        public string currencyCode { get; set; }
        public string dueDate { get; set; }
        public int icelandairLoyaltyClubTransaction { get; set; }
        public string issuerBranch { get; set; }
        public string merchantCategory { get; set; }
        public string merchantCity { get; set; }
        public string merchantCountryCode { get; set; }
        public string merchantName { get; set; }
        public string panId { get; set; }
        public string processingDate { get; set; }
        public string transactionDate { get; set; }
        public string transactionId { get; set; }
        public string transactionKey { get; set; }
    }
    public class Paging
    {
        public int totalPages { get; set; }
        public int totalRecords { get; set; }
    }

}