//using Interop.Microsoft.Office.Core;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDMEDISP
{
    public partial class frmDiscount : Form
    {

        util imsg = new util();
        Db db = new Db();
        double discountAMount;
        frmPOS frmp;
        public frmDiscount(frmPOS frmpos)
        {
            InitializeComponent();
            frmp = frmpos;
        }

        private void frmDiscount_Load(object sender, EventArgs e)
        {

        }

        private void btnDiscExit_Click(object sender, EventArgs e)
        {

            this.Dispose();
        }

        private void txtDiscPercent_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Double.Parse(txtDiscPercent.Text)>100)
                {
                  imsg.info("Discount cannot be greater than 100")    ;
                    txtDiscPercent.Text="0.0";
                    return;
                }
                double discount = Double.Parse(txtDiscPrice.Text) * (Double.Parse(txtDiscPercent.Text)/100);
                lbldiscountAmount.Text = discount.ToString();
                discountAMount = discount;
                double finalAmount = discount;
               // txtDiscFinalAmount.Text = finalAmount.ToString("#,##0.00");
            }
            catch (Exception)
            {

            }
        }

        private void txtDiscFinalAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNewDiscount_Click(object sender, EventArgs e)
        {
            try
            {
                frmPOS.wholeDiscount = Double.Parse(lbldiscountAmount.Text);
                this.Dispose();
                frmp.LoadCart();
                frmp.getCartTotal();
                frmp.Show();
            }
            catch (Exception)
            {

                
            }
        }

        private void txtDiscPercent_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            imsg.numOnly(sender, e);

        }
    }
}
