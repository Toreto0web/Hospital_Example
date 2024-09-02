using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Example
{
    public class Hospital : Doctor
    {
        public string HospitalName { get; set; }
        public Nurse Nurse { get; set; }
        public Receptionist Receptionist { get; set; }

        public Hospital(string hospitalName, string doctorName, int doctorAge, string specialty, Nurse nurse, Receptionist receptionist)
            : base(doctorName, doctorAge, specialty)
        {
            HospitalName = hospitalName;
            Nurse = nurse;
            Receptionist = receptionist;
        }

        // Direct access to MedicalRecord without control
        public void AccessMedicalRecord(MedicalRecord record)
        {
            Console.WriteLine($"Accessing medical record in {HospitalName}.");
            record.DisplayRecord();
        }

        public void Operate()
        {
            Console.WriteLine($"{HospitalName} is now operational.");
            Diagnose(); // Inherited from Doctor
            Nurse.Assist();
            Receptionist.CheckInPatient();
        }
    }

}
