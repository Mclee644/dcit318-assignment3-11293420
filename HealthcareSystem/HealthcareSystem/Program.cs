using HealthcareSystem;
using System;
class Program
{
    static void Main(string[] args)
    {
        string title = """

            |           HEALTHCARE SYSTEM           |

            """;

        Console.WriteLine(title);

        HealthSystemApp iclare = new HealthSystemApp();
        iclare.SeedData();
        iclare.BuildPrescriptionMap();
        iclare.PrintAllPatients();
        iclare.PrintPrescriptionsForPatient(11293420);


    }
}

