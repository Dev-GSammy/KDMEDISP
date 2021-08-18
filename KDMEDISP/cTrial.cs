using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDMEDISP
{
   public class cTrial
    {
        public static int count=0;
       public static void IncreCurrentCount()
        {
            if (true)
            {

                int currcount = getCount();
                util imsg = new util();

                DefaultConfig settings = new DefaultConfig();
                serialize st = new serialize(imsg.retConfigPath("trial"));
                settings.TrialCount =currcount+1 ;
                st.SerializeNow(settings, settings.TrialCount);
            }
        }


        public static int getCount()
        {
            util imsg = new util();

            DefaultConfig settings = new DefaultConfig();
            serialize st = new serialize(imsg.retConfigPath("trial"));
            settings = (DefaultConfig)st.DeSerializeNow(settings);
            //imsg.info(settings.vat);
            imsg.info(settings.TrialCount.ToString());
            return settings.TrialCount;
        }
    }
}
