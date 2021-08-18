using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using ZXing.OneD;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using PrinterUtility;
using System.Collections;

namespace KDMEDISP
{
    class KDMEDISPPrinter
    {
        util imsg = new util();
        string DefaultPrinter = "";
        public List<string> InstalledPrinters()
        {
            List<string> GetInstalledPrinters = new  List<string>();
            // Add list of installed printers found to the combo box.
            // The pkInstalledPrinters string will be used to provide the display string.
            String pkInstalledPrinters;
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                pkInstalledPrinters = PrinterSettings.InstalledPrinters[i];
                GetInstalledPrinters.Add(pkInstalledPrinters);
            }
            return GetInstalledPrinters;
        }

       
        public PrintQueue FindPrinter(string printerName)
        {
            var printers = new PrintServer().GetPrintQueues();
            foreach (var printer in printers)
            {
                if (printer.FullName == printerName)
                {
                    return printer;
                }
            }
            return LocalPrintServer.GetDefaultPrintQueue();
        }

      
        public void PrintReceipt(Form frm, PosOrder O, List<CartItems> CI,String DefPrinter, bool UseDefPrn)
        {

            string filePath = imsg.retConfigPath("storedata");
            DefaultConfig c = new DefaultConfig();
            serialize st = new serialize(filePath);
            c = (DefaultConfig)st.DeSerializeNow(c);

            PrinterUtility.EscPosEpsonCommands.EscPosEpson obj = new PrinterUtility.EscPosEpsonCommands.EscPosEpson();
            var BytesValue = Encoding.ASCII.GetBytes(string.Empty);
            BytesValue = PrintExtensions.AddBytes(BytesValue, obj.FontSelect.FontA());
            BytesValue = PrintExtensions.AddBytes(BytesValue, obj.Alignment.Center());
            BytesValue = PrintExtensions.AddBytes(BytesValue, obj.CharSize.DoubleHeight3());
            BytesValue = PrintExtensions.AddBytes(BytesValue, "============================= \n");

          //  BytesValue = PrintExtensions.AddBytes(GetLogo("bodyshopcol.png"), Encoding.ASCII.GetBytes("\n"));
            BytesValue = PrintExtensions.AddBytes(BytesValue, Encoding.ASCII.GetBytes(c.StoreName + "\n"));
            BytesValue = PrintExtensions.AddBytes(BytesValue, obj.CharSize.Nomarl());
            BytesValue = PrintExtensions.AddBytes(BytesValue, Encoding.ASCII.GetBytes(c.StoreTag + "\n"));

            BytesValue = PrintExtensions.AddBytes(BytesValue, obj.Alignment.Left());

            BytesValue = PrintExtensions.AddBytes(BytesValue, Encoding.ASCII.GetBytes(c.StoreAddress + "\n"));
            BytesValue = PrintExtensions.AddBytes(BytesValue, Encoding.ASCII.GetBytes(c.StorePhone + "\n"));
            BytesValue = PrintExtensions.AddBytes(BytesValue, Encoding.ASCII.GetBytes("________________________" + "\n"));
            BytesValue = PrintExtensions.AddBytes(BytesValue, Encoding.ASCII.GetBytes("Cust Name: " + O.CustomerName + "\n"));
            BytesValue = PrintExtensions.AddBytes(BytesValue, Encoding.ASCII.GetBytes("Tel: " + O.CustomerPhone + "\n"));
            BytesValue = PrintExtensions.AddBytes(BytesValue, obj.Separator());
            BytesValue = PrintExtensions.AddBytes(BytesValue, Encoding.ASCII.GetBytes("InvoiceNo: " + O.InvoiceNo + "\n"));
            BytesValue = PrintExtensions.AddBytes(BytesValue, Encoding.ASCII.GetBytes("Itm          Qty   Amount  Total\n"));

            BytesValue = PrintExtensions.AddBytes(BytesValue, obj.Separator());
            double Grandtotal=0;
            for (int i = 0; i < CI.Count; i++)
            {
                BytesValue = PrintExtensions.AddBytes(BytesValue, obj.Alignment.Left());

                BytesValue = PrintExtensions.AddBytes(BytesValue, Encoding.ASCII.GetBytes(i+1 + " " + CI[i].ItemDesc + " "));
                BytesValue = PrintExtensions.AddBytes(BytesValue, Encoding.ASCII.GetBytes( CI[i].Qty + " "));
                BytesValue = PrintExtensions.AddBytes(BytesValue, Encoding.ASCII.GetBytes(CI[i].Amount + " "));
                BytesValue = PrintExtensions.AddBytes(BytesValue, Encoding.ASCII.GetBytes( CI[i].Total + " \n"));
                Grandtotal += CI[i].Total;


            }
            BytesValue = PrintExtensions.AddBytes(BytesValue, obj.Alignment.Right());
            BytesValue = PrintExtensions.AddBytes(BytesValue, obj.Separator());
            BytesValue = PrintExtensions.AddBytes(BytesValue, Encoding.ASCII.GetBytes("Total\n"));
            BytesValue = PrintExtensions.AddBytes(BytesValue, Encoding.ASCII.GetBytes(Grandtotal+"\n"));
            BytesValue = PrintExtensions.AddBytes(BytesValue, obj.Separator());
            BytesValue = PrintExtensions.AddBytes(BytesValue, obj.Lf());
            BytesValue = PrintExtensions.AddBytes(BytesValue, obj.Alignment.Center());
            BytesValue = PrintExtensions.AddBytes(BytesValue, obj.CharSize.DoubleHeight6());
            BytesValue = PrintExtensions.AddBytes(BytesValue, "-----Thank you for coming------- \n");
            BytesValue = PrintExtensions.AddBytes(BytesValue, obj.Alignment.Left());
            BytesValue = PrintExtensions.AddBytes(BytesValue, CutPage());

            if (File.Exists(".\\tmpPrint.print"))
                File.Delete(".\\tmpPrint.print");
            File.WriteAllBytes(".\\tmpPrint.print", BytesValue);


            // Allow the user to select a printer.
           
            PrintDialog pd = new PrintDialog();
            pd.PrinterSettings = new PrinterSettings();

            if (UseDefPrn)
            {
                DefaultPrinter = DefPrinter;
            }
            else
            {
                if (DialogResult.OK == pd.ShowDialog(frm))
                {
                    // Send a printer-specific to the printer.
                    //Console.WriteLine(pd.PrinterSettings.PrinterName);
                    DefaultPrinter = pd.PrinterSettings.PrinterName;

                }
            }
            try
            {
                RawPrinterHelper.SendFileToPrinter(DefaultPrinter, ".\\tmpPrint.print");

                File.Delete(".\\tmpPrint.print");
            }
            catch
            {

            }
            //     PrinterUtility.PrintExtensions.Print(BytesValue, POSPrintExample.Properties.Settings.Default.PrinterPath);

        }

        public byte[] CutPage()
        {
            List<byte> oby = new List<byte>();
            oby.Add(Convert.ToByte(Convert.ToChar(0x1D)));
            oby.Add(Convert.ToByte('V'));
            oby.Add((byte)66);
            oby.Add((byte)3);
            return oby.ToArray();
        }
        public byte[] GetLogo(string LogoPath)
        {
            List<byte> byteList = new List<byte>();
            if (!File.Exists(LogoPath))
                return null;
            BitmapData data = GetBitmapData(LogoPath);
            BitArray dots = data.Dots;
            byte[] width = BitConverter.GetBytes(data.Width);

            int offset = 0;
            MemoryStream stream = new MemoryStream();
            // BinaryWriter bw = new BinaryWriter(stream);
            byteList.Add(Convert.ToByte(Convert.ToChar(0x1B)));
            //bw.Write((char));
            byteList.Add(Convert.ToByte('@'));
            //bw.Write('@');
            byteList.Add(Convert.ToByte(Convert.ToChar(0x1B)));
            // bw.Write((char)0x1B);
            byteList.Add(Convert.ToByte('3'));
            //bw.Write('3');
            //bw.Write((byte)24);
            byteList.Add((byte)24);
            while (offset < data.Height)
            {
                byteList.Add(Convert.ToByte(Convert.ToChar(0x1B)));
                byteList.Add(Convert.ToByte('*'));
                //bw.Write((char)0x1B);
                //bw.Write('*');         // bit-image mode
                byteList.Add((byte)33);
                //bw.Write((byte)33);    // 24-dot double-density
                byteList.Add(width[0]);
                byteList.Add(width[1]);
                //bw.Write(width[0]);  // width low byte
                //bw.Write(width[1]);  // width high byte

                for (int x = 0; x < data.Width; ++x)
                {
                    for (int k = 0; k < 3; ++k)
                    {
                        byte slice = 0;
                        for (int b = 0; b < 8; ++b)
                        {
                            int y = (((offset / 8) + k) * 8) + b;
                            // Calculate the location of the pixel we want in the bit array.
                            // It'll be at (y * width) + x.
                            int i = (y * data.Width) + x;

                            // If the image is shorter than 24 dots, pad with zero.
                            bool v = false;
                            if (i < dots.Length)
                            {
                                v = dots[i];
                            }
                            slice |= (byte)((v ? 1 : 0) << (7 - b));
                        }
                        byteList.Add(slice);
                        //bw.Write(slice);
                    }
                }
                offset += 24;
                byteList.Add(Convert.ToByte(0x0A));
                //bw.Write((char));
            }
            // Restore the line spacing to the default of 30 dots.
            byteList.Add(Convert.ToByte(0x1B));
            byteList.Add(Convert.ToByte('3'));
            //bw.Write('3');
            byteList.Add((byte)30);
            return byteList.ToArray();
            //bw.Flush();
            //byte[] bytes = stream.ToArray();
            //return logo + Encoding.Default.GetString(bytes);
        }

        public BitmapData GetBitmapData(string bmpFileName)
        {
            using (var bitmap = (Bitmap)Bitmap.FromFile(bmpFileName))
            {
                var threshold = 127;
                var index = 0;
                double multiplier = 570; // this depends on your printer model. for Beiyang you should use 1000
                double scale = (double)(multiplier / (double)bitmap.Width);
                int xheight = (int)(bitmap.Height * scale);
                int xwidth = (int)(bitmap.Width * scale);
                var dimensions = xwidth * xheight;
                var dots = new BitArray(dimensions);

                for (var y = 0; y < xheight; y++)
                {
                    for (var x = 0; x < xwidth; x++)
                    {
                        var _x = (int)(x / scale);
                        var _y = (int)(y / scale);
                        var color = bitmap.GetPixel(_x, _y);
                        var luminance = (int)(color.R * 0.3 + color.G * 0.59 + color.B * 0.11);
                        dots[index] = (luminance < threshold);
                        index++;
                    }
                }

                return new BitmapData()
                {
                    Dots = dots,
                    Height = (int)(bitmap.Height * scale),
                    Width = (int)(bitmap.Width * scale)
                };
            }
        }

        public class BitmapData
        {
            public BitArray Dots
            {
                get;
                set;
            }

            public int Height
            {
                get;
                set;
            }

            public int Width
            {
                get;
                set;
            }
        }
    }
}
