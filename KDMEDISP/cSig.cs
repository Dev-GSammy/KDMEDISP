using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDMEDISP
{
   public  class cSig
    {
      public  NameValueCollection sigHow = new NameValueCollection();
     public   NameValueCollection sigOften = new NameValueCollection();
       public NameValueCollection sigWhen = new NameValueCollection();
       public NameValueCollection sigHowMuch = new NameValueCollection();
        public cSig()
        {
            sigHow.Add("ad", "right ear");
            sigHow.Add("al", "left ear");
            sigHow.Add("c", "with");
            sigHow.Add("o", "with");
            sigHow.Add("od", "right eye");
            sigHow.Add("os", "left eye");
            sigHow.Add("ou", "both eyes");
            sigHow.Add("po", "by mouth");
            sigHow.Add("s", "without");
            sigHow.Add("ø", "without");
            sigHow.Add("sl", "sublingual");
            sigHow.Add("top", "apply topically");

            sigOften.Add("ad-lib", "as it pleases you");
            sigOften.Add("bid", "twice a day");
            sigOften.Add("prn", "as needed");
            sigOften.Add("q", "every");
            sigOften.Add("q3h", "every 3 hours");
            sigOften.Add("q4h", "every 4 hours");
            sigOften.Add("qd", "every day");
            sigOften.Add("qid", "four time a day");
            sigOften.Add("qod", "every other day ");
            sigOften.Add("tid", "three times a day ");

            sigWhen.Add("ac", "Before meals");
            sigWhen.Add("pc", "After meals");
            sigWhen.Add("hs", "at bedtime");
            sigWhen.Add("int", "between meals");

            sigHowMuch.Add("cap", "Capsule");
            sigHowMuch.Add("gtt", "drops");
            sigHowMuch.Add("i", " 1 dose");
            sigHowMuch.Add("ii", " 2 doses");
            sigHowMuch.Add("iii", " 3 doses");
            sigHowMuch.Add("iiii", " 4 doses");
            sigHowMuch.Add("mL", " millliters");
            sigHowMuch.Add("mg", " milligrams");
            sigHowMuch.Add("ss", " one-half");
            sigHowMuch.Add("tab", " tablet");
            sigHowMuch.Add("tbsp", " tablespoon 15mL");
            sigHowMuch.Add("tsp", " teaspoon 5mL");


        }
        public string sigHowKV(string key)
        {
           
            return sigHow[key];

        }
       public  string sigOftenKV(string key)
        {

            
            return sigOften[key];
        }
       public  string sigWhenKV(string key)
        {
            return sigWhen[key];
        }
       public  string sigHowMuchKV(string key)
        { 
            
            return sigHowMuch[key];
        }
    }
}
