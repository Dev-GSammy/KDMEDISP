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
    public partial class frmCheckOut : Form
    {
        frmPOS frm;
        PosOrder O;
        List<CartItems> Cart= new List<CartItems>();
        util imsg = new util();
        Random rd = new Random();
        string DefPrinter = "";
        bool UseDefPr = true;
        bool UseDefFolder = false;
        bool AutoOpen = false;
        Db db = new Db();

        public frmCheckOut(frmPOS frmpos, PosOrder Order,List<CartItems> cartitems)
        {
            InitializeComponent();
            try
            {
                frm = frmpos;
                O = Order;
                txtCustName.Text = O.CustomerName;
                TxtCustPhone.Text = O.CustomerPhone;
                txtEmail.Text = O.CustomerEmail;
                Cart = cartitems;
                int num = rd.Next(1, 4);
                switch (num)
                {
                    case 1:
                        txtCustName.Icon = Properties.Resources._1;

                        break;
                    case 2:
                        txtCustName.Icon = Properties.Resources._2;

                        break;
                    case 3:
                        txtCustName.Icon = Properties.Resources._3;

                        break;
                    case 4:
                        txtCustName.Icon = Properties.Resources._4;

                        break;
                    default:
                        txtCustName.Icon = Properties.Resources._2;

                        break;
                }
                DefPrinter = getDefaultPrinter(); 
               
                    lblDefPrinter.Text = DefPrinter;
               
            }
            catch (Exception)
            {

            }
        }
        public string getDefaultPrinter()
        {
            DefaultConfig settings = new DefaultConfig();
            serialize st = new serialize(imsg.retConfigPath("printer"));
            settings = (DefaultConfig)st.DeSerializeNow(settings);
            //imsg.info(settings.vat);
            return settings.printer;
        }
        private async void btnGenReceipt_Click(object sender, EventArgs e)
        {


            string filePath = imsg.retConfigPath("storedata");
            DefaultConfig c = new DefaultConfig();
            serialize st = new serialize(filePath);
            c = (DefaultConfig)st.DeSerializeNow(c);

            if (txtCustName.Text==string.Empty)
            {
                imsg.info("Oops Customer's Name cannot be empty");
                return;
            }
            //O.CustomerName = txtCustName.Text.Trim();
            //O.CustomerPhone = TxtCustPhone.Text.Trim();
            //O.CustomerEmail = txtEmail.Text.Trim();
            KDMEDISPPrinter OrderReceipt = new KDMEDISPPrinter();
            OrderReceipt.PrintReceipt(frm, O, Cart, DefPrinter, UseDefPr);
            GeneratePDF pdf = new GeneratePDF();
            TaskReport Tsr = new TaskReport();        
                Tsr=(TaskReport) pdf.MakePDF(frm.dgvCart,  UseDefFolder, AutoOpen,true,O);
            //bgwReceipt.RunWorkerAsync();
           
            frm.dgvCart.Rows.Clear();
            frm.clearTransaction();
            frm.dgvCart.Enabled = false;
            //if (imsg.prompt("Send Receipt to Client's Email?") )
            //{
            //    EmailSender Email = new EmailSender();
            //    string toAdd, msg, bcc, subject, custName;
            //    toAdd = O.CustomerEmail;
            //    msg = "Thank you for your patronage";
            //    subject = "E-RECEIPT FROM LUSH BEAUTY HOUSE";
            //    custName = O.CustomerName;
            //    bcc = c.ReceiptEmail;

            //    string attachment = Tsr.genFilePath;
            //       await Email.Send(toAdd, custName, subject, msg, attachment, bcc);

            //}

            frm.Show();




        }

        private void btnProdExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frm.clearTransaction();
            frm.dgvCart.Rows.Clear();
            frm.lblTransno.Text = "...";

        }

        private void pnGenRec_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void TxtCustPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar ("+"))
            {
                if (TxtCustPhone.Text.Contains("+") )
                {
                    e.Handled = true;

                }
                else
                {
                    e.Handled = false;

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

        private void pbxDefault_Click(object sender, EventArgs e)
        {
        }

        private void pbxUseDefPrinter_Click(object sender, EventArgs e)
        {
            //UseDefPr = !UseDefPr;
            //if (UseDefPr)
            //{
            //    pbxUseDefPrinter.Image = Properties.Resources.Toggle_On_20px;
            //}
            //else
            //{
            //    pbxUseDefPrinter.Image = Properties.Resources.Toggle_Off_20px;

            //}
            //Console.WriteLine(UseDefPr);
        }

        private void bgwReceipt_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            frm.dgvCart.Rows.Clear();
            frm.clearTransaction();
            frm.dgvCart.Enabled = false;
        }

        private void bgwReceipt_DoWork(object sender, DoWorkEventArgs e)
        {
            KDMEDISPPrinter OrderReceipt = new KDMEDISPPrinter();
            OrderReceipt.PrintReceipt(frm, O, Cart, DefPrinter, UseDefPr);
        }

        private void pbxDefaultFolder_Click(object sender, EventArgs e)
        {
            UseDefFolder = !UseDefFolder;
            if (UseDefFolder)
            {
                pbxDefaultFolder.Image = Properties.Resources.Toggle_On_20px;
            }
            else
            {
                pbxDefaultFolder.Image = Properties.Resources.Toggle_Off_20px;

            }
            //Console.WriteLine(UseDefPr);
        }

        private void pbxAutoOpen_Click(object sender, EventArgs e)
        {
            AutoOpen = !AutoOpen;
            if (AutoOpen)
            {
                pbxAutoOpen.Image = Properties.Resources.Toggle_On_20px;
            }
            else
            {
                pbxAutoOpen.Image = Properties.Resources.Toggle_Off_20px;

            }
        }

        private async void btnSendRecMail_Click(object sender, EventArgs e)
        {

            string filePath = imsg.retConfigPath("storedata");
            DefaultConfig c = new DefaultConfig();
            serialize st = new serialize(filePath);
            c = (DefaultConfig)st.DeSerializeNow(c);

            if (txtCustName.Text == string.Empty || txtEmail.Text == string.Empty)
            {
                imsg.info("Oops Customer's Name or email  cannot be empty");
                return;
            }
          

            GeneratePDF pdf = new GeneratePDF();
            TaskReport Tsr = new TaskReport();
            Tsr = (TaskReport)pdf.MakePDF(frm.dgvCart, UseDefFolder, AutoOpen, true, O);

         
            //if (imsg.prompt("Send Receipt to Client's Email?"))
            //{
            //    EmailSender Email = new EmailSender();
            //    string toAdd, msg, bcc, subject, custName;
            //    toAdd = O.CustomerEmail;
            //    msg = "Thank you for your patronage";
            //    subject = "E-RECEIPT FROM LUSH BEAUTY HOUSE";
            //    custName = O.CustomerName;
            //    //bcc = c.ReceiptEmail;
            //    bcc = "";
            //    string attachment = Tsr.genFilePath;
            //    await Email.Send(toAdd, custName, subject, msg, attachment, bcc);

            //}
        }

        private void frmCheckOut_Load(object sender, EventArgs e)
        {
            imsg.info("Payment Successful", "Check Out");
           

        }
    }
    }
