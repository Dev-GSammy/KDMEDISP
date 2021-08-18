using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronBarCode;
using System.IO;
namespace Dispensing
{
    class BarcodeMgt
    {
       // Generate a Simple BarCode image and save as PNG
       public void GenCode()
        {
            GeneratedBarcode MyBarCode = IronBarCode.BarcodeWriter.CreateBarcode("http://ironsoftware.com/csharp/barcode", BarcodeWriterEncoding.Code128);
            MyBarCode.AddBarcodeValueTextBelowBarcode();
            MyBarCode.SaveAsPng("MyBarCode.png");

            // This line opens the image in your default image viewer
            System.Diagnostics.Process.Start("MyBarCode.png");
        }

        public void QRcode()
        {
            // Styling a QR code and adding annotation text

            //var MyBarCode = IronBarCode.BarcodeWriter.CreateBarcode("http://ironsoftware.com/csharp/barcode", BarcodeWriterEncoding.QRCode);
            //MyBarCode.AddAnnotationTextAboveBarcode("Product URL:");
            //MyBarCode.AddBarcodeValueTextBelowBarcode();
            //MyBarCode.SetMargins(100);
            //MyBarCode.ChangeBarCodeColor(System.Drawing.Color.Purple);
            //MyBarCode.SaveAsPng("MyBarCode2.png");


            //// This line opens the barcode HTML in your default browser
            //System.Diagnostics.Process.Start("MyBarCode2.png");

            // Adding a Logo
           
            // check if image doesnt exist
            var path = Path.GetTempPath();
            string fileResourceName = "logo";
            string finImageName= path+"\\"+fileResourceName+ ".bmp";
            Properties.Resources.logo.Save(finImageName);  //Save the image to path temporarily
            Console.WriteLine(finImageName);
            string saveNameQr = "qr.png";
            var MyQRWithLogo = QRCodeWriter.CreateQrCodeWithLogo("college of Health Tech Akure", finImageName, 200);
            Console.WriteLine(path);
            MyQRWithLogo.ChangeBarCodeColor(System.Drawing.Color.DarkGreen);
            MyQRWithLogo.SaveAsPng(saveNameQr);
            System.Diagnostics.Process.Start(saveNameQr);

        }
        public string ReadBar_QrCode ( string filepath= "qr.png")
        {
            string readData ="";

            //...
            BarcodeResult Result = BarcodeReader.QuicklyReadOneBarcode(filepath, BarcodeEncoding.QRCode);
            if (Result != null)
            {
                readData = Result.Value;
                Console.WriteLine(readData);
                    
            }
            return readData.ToString();

        }

    }
}
//using IronBarCode;
//using System;
//using System.Drawing;

//namespace Barocde_Image_Generator_Tutorial
//{
//    internal class Program
//    {
//        private static void Main(string[] args)
//        {
//            // See tutorial online at https://ironsoftware.com/csharp/barcode/tutorials/csharp-barcode-image-generator/

//            Console.WriteLine("Creating Barcode Images Tutorial for .Net");
//            Console.WriteLine();

//            Console.WriteLine("Example 1 - Render a Simple Barcode");
//            Examples.Example1();

//            Console.WriteLine();

//            Console.WriteLine("Example 2 - Advanced Barcode Image Creation");
//            Examples.Example2();

//            Console.WriteLine();

//            Console.WriteLine("Example 3 - Fluent API");
//            Examples.Example3();

//            Console.WriteLine();
//            Console.WriteLine("Test Complete - Any Key to Exit..");
//            Console.ReadKey();
//        }
//    }

//    internal static class Examples
//    {
//        public static void Example1()
//        {
//            // Generate a Simple BarCode image and save as PNG
//            GeneratedBarcode MyBarCode = IronBarCode.BarcodeWriter.CreateBarcode("http://ironsoftware.com/csharp/barcode", BarcodeWriterEncoding.Code128);
//            MyBarCode.AddBarcodeValueTextBelowBarcode();
//            MyBarCode.SaveAsPng("MyBarCode.png");

//            // This line opens the image in your default image viewer
//            System.Diagnostics.Process.Start("MyBarCode.png");
//        }

//        public static void Example2()
//        {
//            // Styling a QR code and adding annotation text

//            var MyBarCode = IronBarCode.BarcodeWriter.CreateBarcode("http://ironsoftware.com/csharp/barcode", BarcodeWriterEncoding.QRCode);
//            MyBarCode.AddAnnotationTextAboveBarcode("Product URL:");
//            MyBarCode.AddBarcodeValueTextBelowBarcode();
//            MyBarCode.SetMargins(100);
//            MyBarCode.ChangeBarCodeColor(System.Drawing.Color.Purple);
//            MyBarCode.SaveAsHtmlFile("MyBarCode.html");

//            // This line opens the barcode HTML in your default browser
//            System.Diagnostics.Process.Start("MyBarCode.html");
//        }

//        public static void Example3()
//        {
//            // Fluent API for Barcode Image generation.
//            string MyValue = "http://ironsoftware.com/csharp/barcode";
//            System.Drawing.Bitmap BarcodeBmp = IronBarCode.BarcodeWriter.CreateBarcode(MyValue, BarcodeEncoding.PDF417).ResizeTo(300, 200).SetMargins(100).ToBitmap();

//            // These lines open the styled barcode in your default image viewer
//            BarcodeBmp.Save("BarcodeBmp.bmp");
//            System.Diagnostics.Process.Start("BarcodeBmp.bmp");
//        }
//    }
//}