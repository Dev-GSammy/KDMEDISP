using iTextSharp.awt.geom;
using iTextSharp.text.pdf.parser;
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDMEDISP
{
    class util
    {
      
        public string retConfigPath(string target)
        {
            string filename = " ";

            string folder = "KDMEDISP";
            string targetFolder = "Config";
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            switch (target.ToLower())
            {
                case "email":
                     filename = "Default.dat";

                    break;
                case "storedata":
                     filename = "storedata.dat";

                    break;
                case "themetop":
                    filename = "themetop.dat";

                    break;
                case "themeleft":
                    filename = "themeleft.dat";

                    break;
                case "themebutton":
                    filename = "themeleft.dat";

                    break;
                case "vat":
                    filename = "vat.dat";

                    break;
                case "printer":
                    filename = "printer.dat";

                    break;
                case "count":
                    filename = "count.dat";

                    break;
                case "logo":
                    string logofolder = "logo";
                    filename = System.IO.Path.Combine(logofolder, "logo.bmp");
                    break;

                default:

                    break;
            }

           
            return System.IO.Path.Combine(System.IO.Path.Combine(appData, folder, targetFolder, filename));

        }

        public void getLogo(PictureBox  pb)
        {
            try
            {
                pb.Image = LoadBitmap(retConfigPath("logo"));
            }
            catch (Exception)
            {

                pb.Image = Properties.Resources.noImage;

            }
        }
        //public Color topColor()
        //{
        //   // string topPath = retConfigPath("themetop");
         
        //   // DefaultConfig th = new DefaultConfig();
        //   // serialize st = new serialize(topPath);
        //   // th = (DefaultConfig)st.DeSerializeNow(th);
        //   //return th.top;
            
        //}
        public Color leftColor()
        {
            string LeftPath = retConfigPath("themeleft");

            DefaultConfig th = new DefaultConfig();
            serialize st = new serialize(LeftPath);
            th = (DefaultConfig)st.DeSerializeNow(th);
            return th.left;

        }
        //public Color buttonColor()
        //{
        //    string ButtonPath = retConfigPath("themebutton");

        //    DefaultConfig th = new DefaultConfig();
        //    serialize st = new serialize(ButtonPath);
        //    th = (DefaultConfig)st.DeSerializeNow(th);
        //    return th.button;

        //}
        public string retImagePath()
        {
            string folder = "KDMEDISP";
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string res = "resources";
            string img = "img";
            return System.IO.Path.Combine( appData, folder, res, img);
        }
        public Bitmap LoadBitmap(string path)
        {
            if (File.Exists(path))
            {
                // open file in read only mode
                using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                // get a binary reader for the file stream
                using (BinaryReader reader = new BinaryReader(stream))
                {
                    // copy the content of the file into a memory stream
                    var memoryStream = new MemoryStream(reader.ReadBytes((int)stream.Length));
                    // make a new Bitmap object the owner of the MemoryStream
                    return new Bitmap(memoryStream);
                }
            }
            else
            {

                return new Bitmap(Properties.Resources.noImage);
            }
        }
        public  Image ResizeImage( Image image, Size newSize)
        {
            Image newImage = new Bitmap(newSize.Width, newSize.Height);
                using (Graphics GFX=  Graphics.FromImage((Bitmap)newImage))
            {
                GFX.DrawImage(image, new Rectangle(System.Drawing.Point.Empty, newSize));
            }

            return newImage;
        }
        public void  numOnly(object sender, KeyPressEventArgs e, bool AllowPoint=true)
        {
            TextBox txtB = (TextBox)sender;
            if (e.KeyChar == 46)
            {
                if (AllowPoint)
                {
                    if (txtB.Text.Contains("."))
                    {
                        e.Handled = true;

                    }
                }
                else
                {
                    e.Handled = true;

                }

            }
            else if (e.KeyChar==8)    /// backspace
            {
                e.Handled = false;

            }
            else if ((e.KeyChar < 48) || (e.KeyChar > 57))
            {
                e.Handled = true;
            }
            } 
        public void info(string message, string title = "KDMEDISP")
        {

            AppMessage.Message = message;
            AppMessage.Title = title;
            AppMessage msg = new AppMessage();
            msg.ShowDialog();

        }
        public bool prompt(string prompt, string title = "KDMEDISP")
        {
            Prompt.Message = prompt;
            Prompt.Title = title;
            Prompt pm = new Prompt(prompt,title);
            pm.ShowDialog();
            return  pm.status;


        }
      

    public string ConfigFileRead( string fileName)
        {

            /*    
            *     This will essentially take a filename and  read the string in it and return a string , 
            *     create the text file and write string to it
            *    
            *    */
            string s = "";

            try
            {

                using (StreamReader sr = File.OpenText(fileName))
                {
                    while ((s = sr.ReadLine()) != null)
                    {
                        s += s + " > ";
                    }

                }
            }
            catch (Exception)
            {

            }
            return s;

        }

        public void ConfigFileWrite(string fileName, string StringtoWrite)
        {

            /*    
             *     This will essentially take a filename and string, 
             *     create the text file and write string to it
             *    
             *    */
            try
            {
                using (StreamWriter sw = File.CreateText(fileName))
                {
                    sw.WriteLine("New  write at : {0}", DateTime.Now.ToString());
                    sw.WriteLine(StringtoWrite);

                }
            }
            catch (Exception)
            {

            }
        }
    }
}
