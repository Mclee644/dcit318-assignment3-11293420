using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareSystem
{
    internal class Prescription
    {
        public int Id { get; set; }
        public int PatientId { get; set; }

        public string MedicationName { get; set; }

        public DateTime DateIssued { get; set; }

        public Prescription(int id, int patientId, string medicatingName, DateTime dateIssued) 
        {
            Id = id;
            PatientId = patientId;
            MedicationName = medicatingName;
            DateIssued = dateIssued;        
        }

        Dictionary<int, List<Prescription>> patientsPrescription = new Dictionary<int, List<Prescription>>();
        

        List<Prescription> GetPrescriptionByPatientId(int patientId) 
        {
            return patientsPrescription[patientId];
        
        }
    }
}
