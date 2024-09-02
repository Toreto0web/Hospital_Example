using Hospital_Example;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Poor design: Direct access to sensitive medical records without a proxy.
            Nurse nurse = new Nurse("Jane", 30, "Night Shift");
            Receptionist receptionist = new Receptionist("Amy", 25, "Front Desk");

            Hospital hospital = new Hospital("City Hospital", "Dr. Smith", 45, "Cardiology", nurse, receptionist);
            Patient patient = new Patient("John Doe", 30, "Flu");
            MedicalRecord record = new MedicalRecord(patient.Name, "Treatment details and history.");

            hospital.Operate();
            hospital.AccessMedicalRecord(record); // No control over who can access the record
        }
    }

}
