using KDMEDISP2;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDMEDISP
{
    class cDrugsInteractionInfo
    {
     
        const string newline = "/n";
        /// <summary>
        /// user to select source 
        /// </summary>
        /// <param name="Rxcui"></param>
        public object getDrugsInteractionInfo(string Rxcui, bool singleDrug=true)
        {
            object drugInt = new object();

            try
            {

                string url = string.Empty;
                if (!singleDrug)
                {
                    url = @"https://rxnav.nlm.nih.gov/REST/interaction/list.json?rxcuis="+ Rxcui.Trim();
                }
                else
                {
                    url = @"https://rxnav.nlm.nih.gov/REST/interaction/interaction.json?rxcui=" + Rxcui.Trim();/*+"&sources=ONCHigh"*/;

                }
                url = Uri.EscapeUriString(url);
                Console.WriteLine(url);
                RestApi rClient = new RestApi();
                rClient.endpoint = url;
                string strResponse = string.Empty;
                strResponse = rClient.makeRequest();
                if (!singleDrug)
                {
                    drugInt = JsonConvert.DeserializeObject<cNlmDDIMulti>(strResponse);
                }
                else
                {
                    drugInt = JsonConvert.DeserializeObject<cNlmDDI>(strResponse);

                }

            }
            catch (Exception)
            {

            }
            return drugInt;




        }
    }
    }

