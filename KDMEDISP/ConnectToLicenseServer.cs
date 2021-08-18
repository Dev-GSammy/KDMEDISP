using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDMEDISP
{
  public static  class ConnectToLicenseServer
    {

        public  static string  Delete( string url, string user)
        {
            // use name of post variable and values
            //string Data = Web.GetPost(url, "user", user, "name ", "value ");
            string Data = Web.GetPost(url, "user", user,"DbAction","delete");
            return (Data);
        }
        public static string Update(string url, string user)
        {
            // use name of post variable and values
            //string Data = Web.GetPost(url, "user", user, "name ", "value ");
            string Data = Web.GetPost(url, "user", user, "DbAction", "update");
            return (Data);
        }
        public static string Insert(string url, string user)
        {
            // use name of post variable and values
            //string Data = Web.GetPost(url, "user", user, "name ", "value ");
            string Data = Web.GetPost(url, "user", user, "DbAction", "insert");
            return (Data);
        }
      


    }
}
