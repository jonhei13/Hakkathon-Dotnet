using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aver.core.Models
{
    public class OrigoTreatmentModel
    {
        public string Description { get; set; }
        public string Form { get; set; }
        public double Strenght { get; set; }
        public string TrengthUnit { get; set; }
        public double MorningDose { get; set; }
        public double AfternoonDose { get; set; }
        public double EveningDose { get; set; }
        public string Instructions { get; set; }
    }
}
 