using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Image = System.Drawing.Image;

namespace KDMEDISP
{
    public partial class Settings : Form
    {
        string dbname = "KDMEDISP";

        util imsg = new util();
        Db db = new Db();
        string vatpath;


        string folder = "KDMEDISP";
        string targetFolder = "Config";
        string appData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
        public Settings()
        {
            InitializeComponent();
            System.IO.Directory.CreateDirectory(Path.Combine(appData, folder, targetFolder));
vatpath= imsg.retConfigPath("vat");
            txtVat.Text = getVat();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVAT_Click(object sender, EventArgs e)
        {
            string colval = txtVat.Text;
            colval=colval.Replace('%', ' ');

            DefaultConfig settings = new DefaultConfig();
            serialize st = new serialize(vatpath);
            settings.vat = colval;
            st.SerializeNow(settings, settings.vat);
           
            //db.UpdateSingleData(dbname,"tblVAT","VAT", colval.Trim());
        }
         public string getVat()
        {
            DefaultConfig settings = new DefaultConfig();
            serialize st = new serialize(vatpath);
            settings = (DefaultConfig)st.DeSerializeNow(settings);
            //imsg.info(settings.vat);
            return settings.vat;
        }
        public string getDefaultPrinter()
        {
            DefaultConfig settings = new DefaultConfig();
            serialize st = new serialize(imsg.retConfigPath("printer"));
            settings = (DefaultConfig)st.DeSerializeNow(settings);
            //imsg.info(settings.vat);
            return settings.printer;
        }
        private int getErrorMode()
        {

            return  int.Parse( db.GetSingleData(dbname, "tblErrorMode", "ErrorMode"));
           
        }
        private void Reset(object sender, PaintEventArgs e)
        {
           
            
            db.UpdateSingleData(dbname, "tblVAT", "VAT", "0.00");
            db.UpdateSingleData(dbname, "tblerrormode", "errormode", "1");

            txtVat.Text = getVat();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveErrorList_Click(object sender, EventArgs e)
        {
            int mode;
            if (cboErrorReportMode.SelectedIndex==0)
            {
                mode = 0;
            }
            else
            {
                mode = 1;
            }
            db.UpdateSingleData(dbname, "tblerrormode", "errormode", mode);
            loadVATandErrorMode();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void loadVATandErrorMode()
        {
            if (getErrorMode() == 0)
            {
                cboErrorReportMode.SelectedIndex = 0;

            }
            else
            {
                cboErrorReportMode.SelectedIndex = 1;

            }
            string vatval = getVat();
            if (!vatval.Contains("%"))
            {
               vatval +="%";

            }
            txtVat.Text = vatval;
        }
        private void Settings_Load(object sender, EventArgs e)
        {
            try
            {
                findPrinter();
                loadVATandErrorMode();
                try
                {
                    pbxLogo.Image = imsg.LoadBitmap(imsg.retConfigPath("logo"));
                }
                catch (Exception)
                {

                   // load default KDMEDISP logo here
                } 
            
            }
            catch (Exception)
            {

            }
            try
            {
                cboPrinters.Text = getDefaultPrinter();

            }
            catch (Exception)
            {

            }
        }

        private void txtVat_KeyPress(object sender, KeyPressEventArgs e)
        {
            imsg.numOnly(sender, e, true);
        }
        private void findPrinter()
        {
            try
            {
                KDMEDISPPrinter printer = new KDMEDISPPrinter();
                List<string> printers = new List<string>();
                printers = printer.InstalledPrinters();
                foreach (var foundprinter in printers)
                {
                    cboPrinters.Items.Add(foundprinter);
                }
                if (true)
                {
                    cboPrinters.SelectedIndex = 0;

                }
            }
            catch (Exception)
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboPrinters_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrinterSettings.PrinterName = cboPrinters.Text;
        }

        private void btnPrintTest_Click(object sender, EventArgs e)
        {
          
        }

        private void btnSetDefaultPrinter_Click(object sender, EventArgs e)
        {
            DefaultConfig settings = new DefaultConfig();
            serialize st = new serialize(imsg.retConfigPath("printer"));
            settings.printer = cboPrinters.Text;
            st.SerializeNow(settings, settings.printer);
        
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

       

        private void btnEmailSettings_Click(object sender, EventArgs e)
        {
            frmEmailSettings frmEmail = new frmEmailSettings(this);
            this.Enabled = false;

            frmEmail.ShowDialog();
        }

        private void btnEmail(object sender, EventArgs e)
        {

            frmSendMail sendMail = new frmSendMail(this);
            this.Enabled = false;
            sendMail.Show();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Home H = new Home();
            H.Show();
        }

        private void btnStoreInfo_Click(object sender, EventArgs e)
        {
            frmStoreData SInfo = new frmStoreData(this);
            this.Enabled = false;
           SInfo.Show();

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUploadLogo_Click(object sender, EventArgs e)
        {
            string folder = "KDMEDISP";
            string targetFolder = "Config";
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string logoPath=Path.Combine(Path.Combine(appData, folder, targetFolder));
            string logoName = "logo";
            string imgName = Path.Combine(logoPath, logoName);
            Directory.CreateDirectory(imgName);

            var TempPath = Path.GetTempPath();
            string SaveDirectory = "logo";
            string TempImageName = Path.Combine(TempPath, SaveDirectory);
            Directory.CreateDirectory(Path.Combine(TempPath, SaveDirectory));
            // Console.WriteLine(TempImageName);
            using OpenFileDialog opfd = new OpenFileDialog();
            {

                if (opfd.ShowDialog() == DialogResult.OK)
                {

                    //try
                    //{

                        using Image oldimage = Bitmap.FromFile(opfd.FileName);
                        {
                            using Image newimage = imsg.ResizeImage(oldimage, new Size(240, 130));
                            {
                                using MemoryStream ms = new MemoryStream();
                                {
                                    newimage.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                                    newimage.Save(TempImageName+".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                                    pbxLogo.Image = Image.FromStream(ms);
                                if (File.Exists(imgName))
                                {
                                    File.Copy(TempImageName, imgName, true);

                                }
                                else
                                {
                                    newimage.Save(Path.Combine(imgName,logoName+".bmp"), System.Drawing.Imaging.ImageFormat.Bmp);

                                    }
                                }
                            }
                        }


                    //}
                    //catch (Exception)
                    //{

                    //    imsg.info("An error Occurred !");
                    //}

                }
            }
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            //frmTheme theme = new frmTheme(this);
            //this.Enabled = false;
            //theme.Show();

         
            
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
