using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Example
{
    public class Doctor : Person
    {
        public string Specialty { get; set; }

        public Doctor(string name, int age, string specialty) : base(name, age)
        {
            Specialty = specialty;
        }

        public void Diagnose()
        {
            Console.WriteLine($"{Name} is diagnosing a patient.");
        }
    }

}
