using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace KDMEDISP

{
    public enum httpverb
    {
        GET,
        POST,
        PUT,
        DELETE
    }
    public class RestApi
    {

        public string endpoint { get; set; }
        public httpverb httpMethod { get; set; }


        public RestApi()
        {
            endpoint = string.Empty;
            httpMethod = httpverb.GET;
        }

        public string makeRequest()
        {
            string strResponseValue = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endpoint);
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

            request.Method = httpMethod.ToString();
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode!= HttpStatusCode.OK)
                {
                    throw new ApplicationException("error code:"+ response.StatusCode.ToString());

                }

                using (Stream responseStream = response.GetResponseStream())
            {

                    if (responseStream!=null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();
                        } // end of using streamreader
                    }     
            }// end of using resposeStream
            } // end of using web response

            return strResponseValue;

        }
    }
}
