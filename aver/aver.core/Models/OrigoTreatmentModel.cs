using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aver.core.Models
{
    public class OrigoAppointmentData
    {
        public int Id { get; set; }
        public int? ArrivalId { get; set; }
        public DateTime AppointmentTime { get; set; }
        public string Location { get; set; }
        public string Resource { get; set; }
    }

    public class OrigoArrivalData
    {
        public int Id { get; set; }
        public int AppointmentId { get; set; }
        public DateTime ArrivalDate { get; set; }
        public string HealthcareProvider { get; set; }
        public string TypeOfHealthcare { get; set; }
        public string Location { get; set; }
    }

    public class OrigoEncounterData
    {
        public int Id { get; set; }
        public int ArrivalId { get; set; }
        public string Description { get; set; }
        public string ReferralId { get; set; }
    }

    public class OrigoAllergyData
    {
        public string Atc { get; set; }
        public string Classification { get; set; }
        public object Comment { get; set; }
        public string Component { get; set; }
        public DateTime CreateDate { get; set; }
        public string Type { get; set; }
    }

    public class OrigoMeasurementItem
    {
        public string Description { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public string Unit { get; set; }
    }

    public class OrigoMeasurementsData
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public List<OrigoMeasurementItem> MeasurementItems { get; set; }
    }

    public class OrigoDiagnosticImagingData
    {
        public object ReferralIds { get; set; }
        public DateTime TestDate { get; set; }
        public DateTime ResultDate { get; set; }
        public string LabName { get; set; }
        public string Type { get; set; }
        public string Result { get; set; }
    }

    public class OrigoDiagnosisData
    {
        public int Id { get; set; }
        public List<int> TreatmentPlanIds { get; set; }
        public DateTime Date { get; set; }
        public string IcD10Code { get; set; }
        public string Term { get; set; }
    }

    public class OrigoTreatment
    {
        public string Description { get; set; }
        public string Form { get; set; }
        public int? Strength { get; set; }
        public string StrengthUnit { get; set; }
        public int? MorningDose { get; set; }
        public int? AfternoonDose { get; set; }
        public int? EveningDose { get; set; }
        public string Instructions { get; set; }
    }

    public class OrigoTreatmentItem
    {
        public string TreatmentType { get; set; }
        public List<int> AppointmentIds { get; set; }
        public string TreatmentDescription { get; set; }
        public List<object> ReferralIds { get; set; }
        public List<OrigoTreatment> Treatment { get; set; }
    }

    public class OrigoTreatmentPlan
    {
        public int Ad { get; set; }
        public List<int> DiagnosisIds { get; set; }
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ResponsibleHCProvider { get; set; }
        public string PlanDescription { get; set; }
        public List<OrigoTreatmentItem> TreatmentItems { get; set; }
    }

    public class OrigoReferralData
    {
        public int ReferralId { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public string IssuedBy { get; set; }
        public string Specialty { get; set; }
        public int Status { get; set; }
        public string PatientHistory { get; set; }
        public string Request { get; set; }
    }

    public class OrigoCode
    {
        public string Disease { get; set; }
    }

    public class OrigoVaccinationData
    {
        public string Code { get; set; }
        public string CodeName { get; set; }
        public List<OrigoCode> Codes { get; set; }
        public string CodingSystem { get; set; }
        public DateTime Date { get; set; }
        public string SenderDescription { get; set; }
    }

    public class OrigoMedicationData
    {
        public string AtcCode { get; set; }
        public DateTime ConfirmDate { get; set; }
        public object DaysLeft { get; set; }
        public string Instructions { get; set; }
        public string Form { get; set; }
        public DateTime LastPrescribed { get; set; }
        public string Name { get; set; }
        public int NumberOfPackings { get; set; }
        public int NumberOfTimes { get; set; }
        public bool OneTimeOnly { get; set; }
        public object PrescriptionEnds { get; set; }
        public int Quantity { get; set; }
        public int Strength { get; set; }
        public string StrengthUnit { get; set; }
        public int TotalQuantity { get; set; }
    }

    public class OrigoReturnData
    {
        public List<OrigoAppointmentData> AppointmentData { get; set; }
        public List<OrigoArrivalData> ArrivalData { get; set; }
        public List<OrigoEncounterData> EncounterData { get; set; }
        public List<OrigoAllergyData> AllergyData { get; set; }
        public List<OrigoMeasurementsData> MeasurementsData { get; set; }
        public List<object> BloodworksData { get; set; }
        public List<OrigoDiagnosticImagingData> DiagnosticImagingData { get; set; }
        public List<OrigoDiagnosisData> DiagnosisData { get; set; }
        public List<OrigoTreatmentPlan> TreatmentPlans { get; set; }
        public List<OrigoReferralData> ReferralData { get; set; }
        public List<OrigoVaccinationData> VaccinationData { get; set; }
        public List<OrigoMedicationData> MedicationData { get; set; }
    }

    public class OrigoRootObject
    {
        public OrigoReturnData ReturnData { get; set; }
        public object ErrorMessage { get; set; }
        public bool HasError { get; set; }
    }
}
 