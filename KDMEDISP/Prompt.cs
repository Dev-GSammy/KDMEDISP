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
    public partial class Prompt : Form
    {
        public bool status = false;
        public static string Message = " ";
        public static string Title = " ";
        public Prompt(string message, string title="KDMEDISP")
        {
            InitializeComponent();
            lblMessage.Text = message;
            lblTitle.Text = title;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            status = true;
            this.Dispose();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            status = false;
            this.Dispose();

        }

        private void Prompt_Load(object sender, EventArgs e)
        {

        }
    }
}
