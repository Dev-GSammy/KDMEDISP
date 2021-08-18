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
    public partial class AppMessage : Form
    {
         public static string Message=" ";
         public static string Title=" ";
        public AppMessage()
        {
            InitializeComponent();
        }

        private void AppMessage_Load(object sender, EventArgs e)
        {
            lblTitle.Text = Title;
            lblMessage.Text = Message;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
