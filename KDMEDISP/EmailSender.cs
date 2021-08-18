using System;
using System.Threading.Tasks;

using System.Net.Mail;
using SmtpClient = System.Net.Mail.SmtpClient;
using System.ComponentModel;

namespace KDMEDISP
{
    class EmailSender
    {
        util imsg = new util();

      
        Settings s = new Settings();


      
        public async Task Send(string toAdd, string custName ,string Esubject, string msg, string attachmentPath, string BCC="")
        {

            
            string filePath = imsg.retConfigPath("email");
            DefaultConfig c = new DefaultConfig();
            serialize st = new serialize(filePath);
            c = (DefaultConfig)st.DeSerializeNow(c);

            MailMessage mail = new MailMessage();
                                                
            Console.WriteLine(c.EmailPassword);
            // if sending from front
            SmtpClient SmtpServer = new SmtpClient(c.EmailServer);

           MailAddress mailFrm = new MailAddress(c.EmailUsername,"LUSH BEAUTY HOUSE");
           MailAddress mailTo =new MailAddress(toAdd, custName);
            mail.Subject = Esubject;
            mail.Body = msg;
            mail.From = mailFrm;
            mail.To.Add(mailTo);
            if (!string.IsNullOrWhiteSpace(BCC))
            {
                MailAddress mailBcc = new MailAddress(BCC);

                mail.Bcc.Add(mailBcc);
            }
           
            if (!string.IsNullOrWhiteSpace(attachmentPath))
            {
                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment(attachmentPath);
                mail.Attachments.Add(attachment);

            }


            try
            {



                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(c.EmailUsername, c.EmailPassword);
                SmtpServer.EnableSsl = true;
                //wire up the event for when the Async send is completed
                object userState = mail;

                SmtpServer.SendAsync(mail, userState);

                SmtpServer.SendCompleted += new SendCompletedEventHandler(SmtpClient_OnCompleted);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }

        }

        
        
    public static void SmtpClient_OnCompleted(object sender, AsyncCompletedEventArgs e)
    {
        //Get the Original MailMessage object
        MailMessage mail = (MailMessage)e.UserState;

        //write out the subject
        string subject = mail.Subject;
            util imsg = new util();
        if (e.Cancelled)
        {

                imsg.info("Send canceled for mail with subject " + subject);
                Console.WriteLine("Send canceled for mail with subject [{0}].", subject);
        }
        if (e.Error != null)
        {
            Console.WriteLine("Error {1} occurred when sending mail [{0}] ", subject, e.Error.ToString());
        }
        else
        {
                imsg.info("Email with subject: " + subject +"  sent Successfully");
                Console.WriteLine("Message [{0}] sent.", subject);
        }
    }
}
    

}

