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
    public partial class frmTheme : Form
    {
        util imsg = new util();
        Settings ss;
        public frmTheme( Settings st)
        {
            InitializeComponent();
            ss = st;
        }

        private void frmTheme_Load(object sender, EventArgs e)
        {
            //    try
            //    {
            //        string topPath = imsg.retConfigPath("themetop");
            //        string leftPath = imsg.retConfigPath("themeleft");
            //        string buttonPath = imsg.retConfigPath("themebutton");
            //        DefaultConfig th = new DefaultConfig();
            //        serialize st = new serialize(topPath);
            //        th = (DefaultConfig)st.DeSerializeNow(th);
            //        pnTop.BackColor = th.top;
            //        serialize sl = new serialize(leftPath);
            //        th = (DefaultConfig)sl.DeSerializeNow(th);
            //        pnLeft.BackColor = th.left;
            //    }
            //    catch (Exception)
            //    {

            //    }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            //ColorDialog clg = new ColorDialog();
            //if (clg.ShowDialog() == DialogResult.OK)
            //{
            //    pnTop.BackColor = clg.Color;
            //}

            //string filePath = imsg.retConfigPath("themetop");
            //DefaultConfig th = new DefaultConfig();
            //th.top = pnTop.BackColor;

            //serialize st = new serialize(filePath);
            //st.SerializeNow(th, th.top);
         
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            //ColorDialog clg = new ColorDialog();
            //if (clg.ShowDialog() == DialogResult.OK)
            //{
            //    pnLeft.BackColor = clg.Color;
            //}
            //string filePath = imsg.retConfigPath("themeleft");
            //DefaultConfig th = new DefaultConfig();
            //th.left = pnLeft.BackColor;

            //serialize st = new serialize(filePath);
            //st.SerializeNow(th, th.left);
        }

        private void btnButtons_Click(object sender, EventArgs e)
        {
            ColorDialog clg = new ColorDialog();
            if (clg.ShowDialog() == DialogResult.OK)
            {
                btnButtons.BackColor = clg.Color;
            }
            string filePath = imsg.retConfigPath("themebutton");
            DefaultConfig th = new DefaultConfig();
            th.button = btnButtons.BackColor;

            serialize st = new serialize(filePath);
            st.SerializeNow(th, th.button);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ss.Enabled = true;
            ss.Show();
            Dispose();
        }
    }
}
