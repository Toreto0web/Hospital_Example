using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Example
{
    public class Patient : Person
    {
        public string Illness { get; set; }

        public Patient(string name, int age, string illness) : base(name, age)
        {
            Illness = illness;
        }

        public void ReceiveTreatment()
        {
            Console.WriteLine($"{Name} is receiving treatment for {Illness}.");
        }
    }

}
