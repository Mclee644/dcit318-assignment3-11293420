using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareSystem
{
    internal class HealthSystemApp
    {
        Repository<Patient> _patientRepo = new Repository<Patient>();
        Repository<Prescription> _prescriptionRepo = new Repository<Prescription>();
        Dictionary<int, List<Prescription>> _prescriptionMap = new Dictionary<int, List<Prescription>>();

       public void SeedData() 
        {
            //patients
            Patient patient1 = new Patient(11293420,"Bright Mensah Obeng",24,"male");
            _patientRepo.Add(patient1);
            

            Patient patient2 = new Patient(22305586, "Beatrice Dzeketey", 21, "female");
            _patientRepo.Add(patient2);

            //prescription
            Prescription prescription1 = new Prescription(1001, 11293420, "Vigra",new DateTime(2025, 08, 15));
            _prescriptionRepo.Add(prescription1);

            Prescription prescription2 = new Prescription(1002, 11293420, "Joy Daddy Bitters", new DateTime(2025, 08, 15));
            _prescriptionRepo.Add(prescription2);

            Prescription prescription3 = new Prescription(1003, 22305586, "Vivadona", new DateTime(2025, 08, 15));
            _prescriptionRepo.Add(prescription3);

            Prescription prescription4 = new Prescription(1004, 22305586, "Clovina", new DateTime(2025, 08, 15));
            _prescriptionRepo.Add(prescription4);

        }

        public void BuildPrescriptionMap() 
        { }

        public void PrintAllPatients() 
        {
            
            foreach (Patient patient in _patientRepo.items)
            {
                Console.WriteLine($"""
                    ID  NAME    AGE GENDER

                    {patient.Id}    {patient.Name}  {patient.Age}   {patient.Gender}

                    """);
            }

        }
        
        //public void PrintAllPatients(int id) { }

        public void PrintPrescriptionsForPatient(int id) { 
            
        }
    }
}
