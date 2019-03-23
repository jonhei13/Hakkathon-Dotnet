using aver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aver.services
{
    public class BusinessHelper
    {
        OrigoAPI origoAPI;
        BusinessHelper()
        {
            origoAPI = new OrigoAPI();
        }
        public HistoryItem GetPatientHistory(string SSN)
        {
            return null;
        }
    }
}