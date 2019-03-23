using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aver.core.Model.Arion.Claims.ClaimsModel
{
    public class ClaimsModel
    {
        public List<Claim> claim { get; set; }
        public Paging paging { get; set; }
    }
    public class BillPresentmentSystem
    {
        public string parameters { get; set; }
        public string type { get; set; }
    }

    public class ClaimKey
    {
        public string account { get; set; }
        public string claimantKennitala { get; set; }
        public string dueDate { get; set; }
    }

    public class CurrencyInformation
    {
        public string currency { get; set; }
        public string currencyInformationPaymentRate { get; set; }
        public string currencyInformationReferenceRate { get; set; }
    }

    public class FirstDefaultCharge
    {
        public double days { get; set; }
        public double value { get; set; }
    }

    public class SecondDefaultCharge
    {
        public double days { get; set; }
        public double value { get; set; }
    }

    public class DefaultCharge
    {
        public FirstDefaultCharge firstDefaultCharge { get; set; }
        public string referenceDate { get; set; }
        public SecondDefaultCharge secondDefaultCharge { get; set; }
    }

    public class DefaultInterest
    {
        public string defaultInterestRule { get; set; }
        public double percentage { get; set; }
        public string specialCode { get; set; }
    }

    public class FirstDiscount
    {
        public double amount { get; set; }
        public double days { get; set; }
    }

    public class SecondDiscount
    {
        public double amount { get; set; }
        public double days { get; set; }
    }

    public class Discount
    {
        public FirstDiscount firstDiscount { get; set; }
        public bool isPostRefDate { get; set; }
        public string referenceDate { get; set; }
        public SecondDiscount secondDiscount { get; set; }
    }

    public class NoticeAndPaymentFee
    {
        public double paperless { get; set; }
        public double printing { get; set; }
    }

    public class ClaimantAddress
    {
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string name { get; set; }
        public string postalCode { get; set; }
        public string region { get; set; }
    }

    public class ItemRow
    {
        public double amount { get; set; }
        public string text { get; set; }
    }

    public class ItemRows
    {
        public List<ItemRow> itemRow { get; set; }
    }

    public class PayorAddress
    {
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string name { get; set; }
        public string postalCode { get; set; }
        public string region { get; set; }
    }

    public class Printing
    {
        public ClaimantAddress claimantAddress { get; set; }
        public List<string> comments { get; set; }
        public ItemRows itemRows { get; set; }
        public PayorAddress payorAddress { get; set; }
    }

    public class Claim
    {
        public string amount { get; set; }
        public string billNumber { get; set; }
        public BillPresentmentSystem billPresentmentSystem { get; set; }
        public string cancellationDate { get; set; }
        public string claimID { get; set; }
        public ClaimKey claimKey { get; set; }
        public CurrencyInformation currencyInformation { get; set; }
        public string customerNumber { get; set; }
        public DefaultCharge defaultCharge { get; set; }
        public DefaultInterest defaultInterest { get; set; }
        public Discount discount { get; set; }
        public string finalDueDate { get; set; }
        public string identifier { get; set; }
        public bool isPartialPaymentAllowed { get; set; }
        public NoticeAndPaymentFee noticeAndPaymentFee { get; set; }
        public double otherCosts { get; set; }
        public double otherDefaultCosts { get; set; }
        public string payorKennitala { get; set; }
        public bool permitOutOfSequencePayment { get; set; }
        public Printing printing { get; set; }
        public string reference { get; set; }
        public string state { get; set; }
        public string status { get; set; }
    }

    public class Paging
    {
        public int totalPages { get; set; }
        public int totalRecords { get; set; }
    }




}