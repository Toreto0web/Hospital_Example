using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Example
{
    public class MedicalRecord
    {
        public string PatientName { get; set; }
        public string RecordDetails { get; set; }

        public MedicalRecord(string patientName, string recordDetails)
        {
            PatientName = patientName;
            RecordDetails = recordDetails;
        }

        public void DisplayRecord()
        {
            Console.WriteLine($"Medical Record for {PatientName}: {RecordDetails}");
        }
    }

}
