

using aver.Models;
using System.Collections.Generic;

namespace aver.services
{
    public class BusinessHelper
    {
        OrigoAPI origoAPI;
        public BusinessHelper()
        {
            origoAPI = new OrigoAPI();
        }
        public HistoryItem GetPatientHistory(string SSN)
        {
            return null;
        }


        public List<NotificationItem> GetMedicationHistoryList(string ssn)
        {
            var data = origoAPI.GetPationtData(ssn);
            List<NotificationItem> items = new List<NotificationItem>();
            if (data != null)
            {
                data.ReturnData.MedicationData.ForEach((item) => 
                {
                    NotificationItem temp = new NotificationItem();
                    temp.Date = item.ConfirmDate;
                    temp.Title =  $"Úthlutun lyfja - {item.Name} - {item.Strength}{item.StrengthUnit}";
                    temp.Uses = item.NumberOfTimes.ToString();
                    temp.Quantity = item.Quantity.ToString();
                    temp.Instructions = item.Instructions;
                    items.Add(temp);
                });
                data.ReturnData.TreatmentPlans.ForEach((item) => 
                {
                    item.TreatmentItems.ForEach((subitem) => 
                    {

                    });
                });

            }
            return items;
        }
    }
}