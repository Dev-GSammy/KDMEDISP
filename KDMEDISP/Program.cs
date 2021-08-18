using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDMEDISP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
           Application.EnableVisualStyles();
           Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmMultipleDrugsInte());

            Application.Run(new Login());
            Application.Run(new Welcome());
            //Application.Run(new frmDrug(new frmDrugList(new dashboard())));


        }
    }
} 