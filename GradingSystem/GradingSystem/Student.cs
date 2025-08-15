using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem
{
    internal class Student
    {
        int Id { get; set; }
        string Fullname { get; set; }
        int Score {  get; set; }

        public String GetGrade(int score)
        {
            if (score >= 80 || score <= 100)
            {
                return "A";
            }
            else if (score >= 70 || score <= 79)
            {
                return "B";
            }
            else if (Score >= 60 || Score <= 69)
            {
                return "C";
            }
            else if (score >= 50 || score <= 59)
            {
                return "D";
            }
            else if (score < 50)
            {
                return "F";
            }
            else
            {
                return "N/A";
            }

        }
    }
}
