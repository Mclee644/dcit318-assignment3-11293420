﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareSystem
{
    internal class Patient
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public Patient(int id,string name,int age,string gender) 
        {
        
            Id = id;
            Name = name;
            Age = age;
            Gender = gender;
        }
    }
}
