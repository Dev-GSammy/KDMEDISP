using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDMEDISP
{
   
        public class IdGroup
        {
            public string name { get; set; }
            public IList<string> rxnormId { get; set; }
        }

    public class cRxcui
    
        {
            public IdGroup idGroup { get; set; }
        }

    }
