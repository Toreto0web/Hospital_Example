using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Example
{
    public class Nurse : Person
    {
        public string Shift { get; set; }

        public Nurse(string name, int age, string shift) : base(name, age)
        {
            Shift = shift;
        }

        public void Assist()
        {
            Console.WriteLine($"{Name} is assisting a doctor.");
        }
    }

}
