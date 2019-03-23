

using aver.Models;
using System;
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
                    temp.Instructions = $"Leiðbeiningar: {item.Instructions}";
                    items.Add(temp);
                });
                data.ReturnData.TreatmentPlans.ForEach((item) => 
                {
                    NotificationItem temp = new NotificationItem();
                    temp.Date = item.EndDate;
                    temp.Title = $"{item.ResponsibleHCProvider} -  Yfirlit";
                    temp.Instructions = "Aðgerðir: ";
                    item.TreatmentItems.ForEach((subitem) =>
                    {
                        temp.Instructions +=$"{subitem.TreatmentType} ";
                           
                       
                    });
                    items.Add(temp);
                });
                
                data.ReturnData.AppointmentData.ForEach((item) =>
                {
                    if (item.AppointmentTime > DateTime.Now )
                    {
                        NotificationItem temp = new NotificationItem();
                        temp.Title = $"Bókaður tími";
                        temp.Instructions = $"Þú átt bókaðan í {item.Location} tíma hjá {item.Resource}  kl {item.AppointmentTime.Hour}:{item.AppointmentTime.Minute} þann {item.AppointmentTime.ToShortDateString()}";
                        temp.Date =  item.AppointmentTime;
                        items.Add(temp);
                    }
                    
                });

            }
            return items;
        }
    }
}