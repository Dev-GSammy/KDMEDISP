using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDMEDISP
{
    class cDrugsInfo
    {
        public static string DrugRxcuID { get; set; }
        util imsg = new util();
        public cDrugsInfo(string drugName)
        {
            try
            {

                string url = @"https://rxnav.nlm.nih.gov/REST/rxcui.json?name=" + drugName.Trim() + "&search=1";
                url = Uri.EscapeUriString(url);
                RestApi rClient = new RestApi();
                rClient.endpoint = url;
                Console.WriteLine(url);
                string strResponse = string.Empty;
                strResponse = rClient.makeRequest();

                cRxcui RxCui = JsonConvert.DeserializeObject<cRxcui>(strResponse);
                if (RxCui.idGroup.rxnormId==null)
                {
                    imsg.info("Drug Not Found, check input and try again!");
                    return;
                }
                IList<string> rxIDS = RxCui.idGroup.rxnormId;
                string id = string.Empty;
                foreach (var drugid in rxIDS)
                {
                    id = drugid;
                    Console.WriteLine(id);
                }
                DrugRxcuID = id;
                Console.WriteLine(DrugRxcuID);
            }
            catch (Exception)
            {

                imsg.info("An Error Occured Check input and Try again!");
            }

        }

    }
}
