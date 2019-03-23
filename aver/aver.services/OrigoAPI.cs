using aver.core.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;


namespace aver.services
{
    public class OrigoAPI
    {
        private const string OrigoUrl = "http://healthapi.hc.t.is";

        public static OrigoRootObject GetPationtData(string patientSSN)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(OrigoUrl)
            };

            string url = $"/api/PatientData/GetPatient/{patientSSN}";
            HttpResponseMessage response = client.GetAsync(url).Result;

            OrigoRootObject results = null;

            if (response.IsSuccessStatusCode)
            {
                var responseString = response.Content.ReadAsStringAsync().Result;
                results =  JsonConvert.DeserializeObject<OrigoRootObject>(responseString);
            }

            return results;
        }
    }
}