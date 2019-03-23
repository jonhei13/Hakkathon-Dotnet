using aver.core.Model.Arion;
using aver.core.Model.Arion.Account;
using aver.core.Model.Arion.Claims;
using aver.core.Model.Arion.Claims.ClaimsModel;
using aver.core.Model.Arion.Claims.Transaction;
using aver.core.Model.Arion.CreditCards;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace aver.services.ArionApi
{
    public class ArionApi
    {
        private static HttpClient client = new HttpClient();
        private static string _token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsIng1dCI6ImEzck1VZ01Gdjl0UGNsTGE2eUYzekFrZnF1RSIsImtpZCI6ImEzck1VZ01Gdjl0UGNsTGE2eUYzekFrZnF1RSJ9.eyJjbGllbnRfaWQiOiJhd2VraW4iLCJzY29wZSI6ImZpbmFuY2lhbCIsInN1YiI6IjA2MDIzMjIwMjkiLCJhbXIiOiJwYXNzd29yZCIsImF1dGhfdGltZSI6MTU1MzM1MDc2MiwiaWRwIjoiaWRzcnYiLCJpc3MiOiJodHRwczovL2FyaW9uYXBpLWlkZW50aXR5c2VydmVyMy1zYW5kYm94LmF6dXJld2Vic2l0ZXMubmV0IiwiYXVkIjoiaHR0cHM6Ly9hcmlvbmFwaS1pZGVudGl0eXNlcnZlcjMtc2FuZGJveC5henVyZXdlYnNpdGVzLm5ldC9yZXNvdXJjZXMiLCJleHAiOjE1NTM3MTA3NzgsIm5iZiI6MTU1MzM1MDc3OH0.LwigPjEW9zFYFXeMfPvWybpm-b5Y_vQXWfcIkEByE-rcY1097pikfWSgC8OXZnhxEoh1iE8CUllmQ70gssgriroj4A3xrj9Dha53nQYzgzD8hNnl9qJVCVbJuuFEksl2exKsEll-LFdyfvTzhJ3-ju5piGl6F0BPMdocaT_rpkyAQP2QYe7u4Yy1BMfBaKxkcQpkLdhxmhMWe30F_1xWcSZDGG_4BjjpP9tGNjfqdZIp6sgAOH2V8mtbDtZZrR5BsxwNYKRA1XfpLSj0LI0as2-OiRHg4GrqYwseD8azBJhsAEhw2VKIgnHidvia4qEMJ38-ODooNCm1j5Q50z05QQ";

        public ArionApi()
        {
            var url = "https://arionapi-sandbox.azure-api.net";
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "f979fb57057f4e048c95c0592ebee746");
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _token);
            client.BaseAddress = new Uri(url);
        }

        public ClaimsModel GetClaims(int page, int perPage)
        {
            HttpResponseMessage response = client.GetAsync(string.Format("https://arionapi-sandbox.azure-api.net/claims/v1/claims?page={0}&perPage={1}", page, perPage)).Result;
            var claims = new ClaimsModel();
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                claims  = JsonConvert.DeserializeObject<ClaimsModel>(responseContent);
            }
            return claims;
        }

        public int GetHospitalCosts(DateTime? From, DateTime? To)
        {
            var x = string.Format("https://arionapi-sandbox.azure-api.net/claims/v1/claims?page={0}&perPage={1}&claimantKennitala={2}&dateFrom={3}&dateTo{4}", "1", "1500", "1504442099", , From.HasValue ? To.Value.ToString() : "");
            HttpResponseMessage response = client.GetAsync(string.Format("https://arionapi-sandbox.azure-api.net/claims/v1/claims?page={0}&perPage={1}&claimantKennitala={2}&dateFrom={3}&dateTo{4}", "1", "1500", "1504442099", To.HasValue ? To.Value.ToString() : "", From.HasValue ? From.Value.ToString() : "")).Result;
            var claims = new ClaimsModel();
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                claims = JsonConvert.DeserializeObject<ClaimsModel>(responseContent);
                if(claims == null)
                {
                    return 0;
                }
                int sum = 0;
                foreach(var claim in claims.claim)
                {
                    sum += Convert.ToInt32(claim.amount);
                }
                return sum;
            }
            return 0;
        }

        public AccountModel GetAccountStatus()
        {
            HttpResponseMessage response = client.GetAsync(string.Format("https://arionapi-sandbox.azure-api.net/accounts/v1/accounts")).Result;
            var account = new AccountModel();
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                account = JsonConvert.DeserializeObject<AccountModel>(responseContent);
            }
            return account;
        }

        public AccountTransactions GetAccountTransaction(string accountNumber, string page, string perPage, DateTime? dateFrom, DateTime? dateTo)
        {

            var queryString = HttpUtility.ParseQueryString(string.Empty);
            queryString["page"] = page == null ? "" : page;
            queryString["perPage"] = perPage == null ? "" : perPage;
            queryString["dateFrom"] = dateFrom == null ? "" : dateFrom.Value.ToString();
            queryString["dateTo"] = dateTo == null ? "" : dateTo.Value.ToString();

            HttpResponseMessage response = client.GetAsync(string.Format("https://arionapi-sandbox.azure-api.net/accounts/v1/accounts/{0}/accountTransactions?{1}", accountNumber, queryString)).Result;
            var account = new AccountTransactions();
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                account = JsonConvert.DeserializeObject<AccountTransactions>(responseContent);
            }
            return account;
        }

        public List<BankInfoModel> GetBankInfo()
        {
            HttpResponseMessage response = client.GetAsync(string.Format("https://arionapi-sandbox.azure-api.net/bankinfo/v1/bankinfo")).Result;
            var bankInfo = new List<BankInfoModel>();
            if (response.IsSuccessStatusCode)
            { 
                var responseContent = response.Content.ReadAsStringAsync().Result;
                bankInfo = JsonConvert.DeserializeObject <List<BankInfoModel>>(responseContent);
            }
            return bankInfo;
        }

        public CreditCardModel GetCreditCardInfo()
        {
            HttpResponseMessage response = client.GetAsync(string.Format("https://arionapi-sandbox.azure-api.net/creditcards/v1/creditCards")).Result;
            var cardInfo = new CreditCardModel();
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                cardInfo = JsonConvert.DeserializeObject<CreditCardModel>(responseContent);
            }
            return cardInfo;
        }
        public CreditCardTransactions GetCreditCardTransactions(string cardId, string page , string perPage, DateTime? datefrom, DateTime? dateTo)
        {
            var queryString = HttpUtility.ParseQueryString(string.Empty);
            queryString["page"] = page == null ? "" : page;
            queryString["perPage"] = perPage == null ? "" : perPage;
            queryString["dateFrom"] = datefrom == null ? "" : datefrom.Value.ToString();
            queryString["dateTo"] = dateTo == null ? "" : dateTo.Value.ToString();
            HttpResponseMessage response = null;
            if (string.IsNullOrEmpty(cardId))
            {
                response = client.GetAsync(string.Format("https://arionapi-sandbox.azure-api.net/creditcards/v1/creditCards")).Result;
            }
            else
            {
                response = client.GetAsync(string.Format("https://arionapi-sandbox.azure-api.net/creditcards/v1/creditCards/{0}/creditCardTransactions?{1}",cardId,queryString)).Result;
            }
            
            var transaction = new CreditCardTransactions();
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                transaction = JsonConvert.DeserializeObject<CreditCardTransactions>(responseContent);
            }
            return transaction;
        }

        public ClaimTransactions GetClaimTransaction(string claimId)
        {
            if(claimId == null)
            {
                return null;
            }

            HttpResponseMessage response = client.GetAsync(string.Format("https://arionapi-sandbox.azure-api.net/claims/v1/claims/{0}/claimTransactions", claimId)).Result;
            var cardInfo = new ClaimTransactions();
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                cardInfo = JsonConvert.DeserializeObject<ClaimTransactions>(responseContent);
            }
            return cardInfo;

        }


    }
}