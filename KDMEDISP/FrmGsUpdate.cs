using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDMEDISP
{
    public partial class FrmGsUpdate : Form
    {
        string functionSelect;
        int targetID;
        string EndButtonText;
        util imsg = new util();
        Db db = new Db();
        frmPOS frmp;
        double productPrice;
        public FrmGsUpdate(frmPOS  frmpos, string title, string recStartbuttonText, string recEndbuttonText, string functionSelect, double price=0.0,string currentVal="", int  id=1 )
        {
            InitializeComponent();
            lblTitle.Text = title;
            txtEdit.Text = currentVal;
           this. functionSelect = functionSelect;
            targetID = id;
            btnAction.Text = recStartbuttonText;
            this.EndButtonText = recEndbuttonText;
            frmp = frmpos;
            productPrice = price;
           
        }

        private void btnNewDiscount_Click(object sender, EventArgs e)
        {
            if (txtEdit.Text==string.Empty)
            {
                return;
            }
            switch (functionSelect)
            {
                case "updateQty":
                   
                    db.UpdateSingleData("KDMEDISP", "tblcart", "qty", txtEdit.Text.Trim(), targetID) ;
                    break;
                case "updateDisc":
                    // code block
                    if (Double.Parse(txtEdit.Text)>100)
                    {
                        imsg.info("Discount Percentage cannot be greater than 100");
                        return;

                    }
                    db.UpdateSingleData("KDMEDISP", "tblcart", "discount", productPrice *(Double.Parse(txtEdit.Text.Trim())/100), targetID);

                    break;
                default:
                    // code block
                    break;
            }
            frmp.LoadCart();
            frmp.Show();
            this.Dispose();

        }

        private void txtEdit_TextChanged(object sender, EventArgs e)
        {
            btnAction.Text = EndButtonText;
        }

        private void pnEditQty_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmGsUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Dispose();
            }
            if (e.KeyChar == 46)
            {
                if (true)
                {
                    if (txtEdit.Text.Contains("."))
                    {
                        e.Handled = true;

                    }
                }
                else
                {
                    e.Handled = true;

                }

            }
            else if (e.KeyChar == 8)    /// backspace
            {
                e.Handled = false;

            }
            else if ((e.KeyChar < 48) || (e.KeyChar > 57))
            {
                e.Handled = true;
            }
        }
    }
}
