using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Example
{
    public class Receptionist : Person
    {
        public string Desk { get; set; }

        public Receptionist(string name, int age, string desk) : base(name, age)
        {
            Desk = desk;
        }

        public void CheckInPatient()
        {
            Console.WriteLine($"{Name} is checking in a patient.");
        }
    }

}
