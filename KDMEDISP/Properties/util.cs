using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRODUCTIVITY
{
    class util
    {
        public void info(string message, string title = "Productivity Assessment")
        {

            AppMessage.Message = message;
            AppMessage.Title = title;
            AppMessage msg = new AppMessage();
            msg.Show();

        }
    }
}
