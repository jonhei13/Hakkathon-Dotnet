using aver.core.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace aver.Helpers
{
    public class Icd10Helper
    {
        public Icd10Model GetIcd10Classification(string id)
        {
            WebClient client = new WebClient();


            string jsonData = client.DownloadString($"http://www.icd10api.com/?code={id}&desc=long&r=json");
            return JsonConvert.DeserializeObject<Icd10Model>(jsonData);
        }
    }
}