using iTextSharp.text.xml;
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
    public partial class frmQty : Form
    {
        frmPOS frmpos;
        public static int adminID;
        util imsg = new util();
        private string pcode;
        private double price;
        private string transno;
        private int currQty;
        Db db = new Db();
        public frmQty(frmPOS frm)
        {
            InitializeComponent();
            frmpos = frm;
        }
     
        public  void ProductDetails(string pcode, double price, string transno, int stockedQty)
        {
            this.pcode =pcode;
            this.price = price;
            this.transno = transno;
            this.currQty = stockedQty;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmQty_Load(object sender, EventArgs e)
        {
            txtQty.Text = "0";
        }

        private void pbxAddQty_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
          private int getAdminID()
        {
            TaskReport ts = new TaskReport();
            ts = (TaskReport)db.getSingleAdmin("KDMEDISP", "adminlogin", frmpos.lblAdmin.Text);
            Console.WriteLine(ts.numData);
            return ts.numData;
        }
        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar==13)&& (txtQty.Text!=string.Empty) && (int.Parse(txtQty.Text)!=0  )  )
            {
                if (int.Parse(txtQty.Text)>currQty)
                {
                    imsg.info("Desired Quantity above stock level", "Stock Level Alert");
                    return;
                }
                db.InsertCart(transno, pcode, price, int.Parse(txtQty.Text),0, Convert.ToDateTime( DateTime.Now.ToShortDateString()),getAdminID());
                txtQty.Clear();
                Hide ();
            }
            if (e.KeyChar==27)
            {
                this.Dispose();
            }
            imsg.numOnly(sender, e, false);
            frmpos.LoadCart();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseProduct_Click(object sender, EventArgs e)
        {
            this.Dispose();        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void btnAddtoCart_Click_1(object sender, EventArgs e)
        {
            if ((int.Parse(txtQty.Text)>currQty) )
            {
                imsg.info("Desired Quantity above stock level", "Stock Level Alert");
                return;
            }
            if ((txtQty.Text != string.Empty) && (int.Parse(txtQty.Text) != 0))
            {
                    db.InsertCart(transno, pcode, price, int.Parse(txtQty.Text), 0,Convert.ToDateTime( DateTime.Now.ToShortDateString()),getAdminID());
                    txtQty.Clear();
                frmpos.LoadCart();

                this.Hide();
                }
        }
    }
}
