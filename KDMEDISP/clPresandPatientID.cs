using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDMEDISP
{
   public  static class clPresandPatientID
    {
        public static string prescriberID { get; set; }
        public static string TaskText { get; set; }
        public static string GuesPatientName { get; set; }
        public static string GuesPatientAddress { get; set; }
        public static string GuesPatientPh { get; set; }
        public static string GuesPresc { get; set; }
        public static string patientID { get; set; }
        public static string prescriptionID { get; set; }
        public static string medicationPcode { get; set; }
        public static bool Guest { get; set; }
    }
}
