using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
//using Microsoft.Office.Core;

namespace KDMEDISP
{
    public partial class frmSendMail : Form
    { 
        Settings s = new Settings();
        util imsg = new util();
        string attachment = "";

        public frmSendMail(Settings ss)
        {
            InitializeComponent();
            s = ss;
        }

        private void frmSendMail_Load(object sender, EventArgs e)
        {
            
        }

       private void sendMail()
        {
            EmailSender Email = new EmailSender();
            string toAdd, msg, bcc,subject,custName;
            toAdd = txtEmailAdd.Text.Trim() ;
            msg = txtEmail.Text;
            subject = txtEmailSubject.Text;
            custName = txtCustName.Text.Trim();
            bcc = txtBcc.Text.Trim();
            if (imsg.prompt("Send Email to " + toAdd + "?"))
            {
                Email.Send(toAdd, custName, subject, msg, attachment, bcc);
            }
            else
            {
                return;
            }
        }
        private void btnProdExit_Click(object sender, EventArgs e)
        {
            s.Enabled = true;

            s.Show();
            Dispose();

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using OpenFileDialog opfd = new OpenFileDialog();
            {
                opfd.InitialDirectory = "c:\\";
                opfd.Filter = "Files | *.jpg; *.pdf; *.png; *.xls; *.doc; ";
                    opfd.FilterIndex = 2;
                opfd.RestoreDirectory = true;
                if (opfd.ShowDialog() == DialogResult.OK)
                {

                  
                    try
                    {
                        attachment = opfd.FileName;
                        txtAttachement.Text = attachment;
                    }
                    catch (Exception)
                    {

                    }
                    Console.WriteLine(attachment);

                }
            }
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            string filePath = imsg.retConfigPath("email");
            DefaultConfig c = new DefaultConfig();
            serialize st = new serialize(filePath);
            c = (DefaultConfig)st.DeSerializeNow(c);
            //Console.WriteLine(c.EmailServer);
            //Console.WriteLine(c.EmailPassword);
            //Console.WriteLine(c.EmailUsername);
           sendMail  ();
        }

        private void txtEmailAdd_Click(object sender, EventArgs e)
        {

        }

        private void pnGenRec_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtEmail_Click(object sender, EventArgs e)
        {

        }
    }                                                                                                          
}

