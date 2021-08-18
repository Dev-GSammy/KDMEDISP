using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDMEDISP
{
    [Serializable]
    class DefaultConfig
    {
        public string EmailServer { get; set; }
        public string EmailUsername { get; set; }
        public string ReceiptEmail { get; set; }
        public string EmailPassword { get; set; }
        public string defaultPrinter { get; set; }
        public string StoreName { get; set; }
        public string StoreTag { get; set; }
        public string StoreAddress { get; set; }
        public string StorePhone { get; set; }
        public int TrialCount { get; set; }

        public string ErrorMode { get; set; }

        public Color top { get; set; }
        public Color left { get; set; }
        public Color button { get; set; }
        public string vat { get; set; }
        public string printer { get; set; }


    }
}
