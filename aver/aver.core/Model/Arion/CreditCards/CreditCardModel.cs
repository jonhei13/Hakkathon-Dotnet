using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aver.core.Model.Arion.CreditCards
{
    public class CreditCardModel
    {
        public List<CreditCard> creditCard { get; set; }
    }
    public class CreditCard
    {
        public bool active { get; set; }
        public double amountDue { get; set; }
        public double availableBalance { get; set; }
        public double balance { get; set; }
        public string bankNumber { get; set; }
        public string cardBrand { get; set; }
        public string cardHolderKennitala { get; set; }
        public string cardHolderName { get; set; }
        public int cardId { get; set; }
        public string cardNumber { get; set; }
        public string cardOwnerKennitala { get; set; }
        public string cardOwnerName { get; set; }
        public string cardRole { get; set; }
        public string cardType { get; set; }
        public double currentYearTurnover { get; set; }
        public string expiryDate { get; set; }
        public string issueDate { get; set; }
        public double lastYearTurnover { get; set; }
        public double limit { get; set; }
        public string panId { get; set; }
    }



}