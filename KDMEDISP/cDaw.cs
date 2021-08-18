using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDMEDISP
{
    class cDaw
    {
        public NameValueCollection Daw = new NameValueCollection();

        public cDaw()
        {
            Daw.Add("0", "No Product Selection Indicated");
            Daw.Add("1", "Substitution Not Allowed by Prescriber");
            Daw.Add("2", "Substitution Allowed - Patient Requested That Brand Product Be Dispensed");
            Daw.Add("3", "Substitution Allowed - Pharmacist Selected Product Dispensed");
            Daw.Add("4", "Substitution Allowed - Generic Drug Not in Stock");
            Daw.Add("5", "Substitution Allowed - Brand Drug Dispensed as Generic");
            Daw.Add("6", "Override");
            Daw.Add("7", "Substitution Not Allowed - Brand Drug Mandated by Law");
            Daw.Add("8", "Substitution Allowed - Generic Drug Not Available in Marketplace");
            Daw.Add("9", "Other");

        }
        public string DecodeDaw(string key)
        {
            return Daw[key];
        }
    }
}
