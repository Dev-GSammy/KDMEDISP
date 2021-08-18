using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDMEDISP
{
    public partial class ActivateLic : Form
    {
        public ActivateLic()
        {
            InitializeComponent();
        }

        private void ActivateLic_Load(object sender, EventArgs e)
        {
            // Todo
            // get Hardware ID,  and license Key send it to server
            // check license database if license exist
            // at server fetch license ID where license = sent license
            // if existing
                    // insert license id in license table , change status to Used and return 1
                    // else
                    //



        }
    }
}
