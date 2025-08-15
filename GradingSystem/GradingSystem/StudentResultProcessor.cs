using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem
{
    internal class StudentResultProcessor
    {
        public List<Student> validStudents = new List<Student>();
        public void ReadStudentsFromFile(string inputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                string line;
                string[] fields = {};
                if (File.Exists(inputFilePath))
                {
                    
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                        fields = line.Split(",");
                        //validStudents.Add(line.Split(","));
                    }


                    Console.WriteLine(fields[0]);
                }
                else
                {
                    throw new MissingFieldException();
                }


            }
    
        
        }
        public void WriteReportToFile(List<Student> students, string outputFilePath)
        {
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
               
            }
        
        }

    }
}
