using BarcodeLib;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode;

namespace KDMEDISP
{
    public partial class frmBarcode : Form
    {
        util imsg = new util();
        Db db = new Db();
        QrCodeEncodingOptions options = new QrCodeEncodingOptions();
        public frmBarcode()
        {
            InitializeComponent();
            string appDesktopFolder = "KDMEDISP Report";
            string pbcode = "Generated Bar_QR Codes";
            string imgPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory), appDesktopFolder,pbcode);

            System.IO.Directory.CreateDirectory(imgPath);
        }
        private void frmBarcode_Load(object sender, EventArgs e)
        {
            cboBarcodeMode.SelectedIndex = 0;
            loadBarCodes();
        }

        // Generate a Simple BarCode image and save as PNG
        public void GenCode(string TextToBeGenerated, string imgPath)
        {
            try
            {
                Barcode barcode = new Barcode();
                Color foreColor = Color.Black;
                Color backColor = Color.White;
                barcode.Height = Convert.ToInt16(pbxBarcode.Height * 0.8);
                barcode.IncludeLabel = true;
                barcode.BarWidth = 2;
                System.Drawing.Image img = barcode.Encode(TYPE.CODE128, TextToBeGenerated, foreColor, backColor);
                pbxBarcode.BackColor = Color.White;
                pbxBarcode.Image = img;
                barcode.SaveImage(imgPath, BarcodeLib.SaveTypes.PNG);

            }

            catch (Exception)
            {

            }
        }
    

        public void QRcode(string TextToBeGenerated, string imgPath)
        {
            try
            {
                options = new QrCodeEncodingOptions
                {
                    DisableECI = true,
                    CharacterSet = "UTF-8",
                    Width = 85,
                    Height = 85,
                };

                var writer = new BarcodeWriter();
                writer.Format = BarcodeFormat.QR_CODE;
                writer.Options = options;
                var qr = new ZXing.BarcodeWriter();
                qr.Options = options;
                qr.Format = ZXing.BarcodeFormat.QR_CODE;
                var result = new Bitmap(qr.Write(TextToBeGenerated));
                pbxQr.Image = result;
                result.Save(imgPath);
            }
            catch (Exception)
            {

            }
        }


        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerateBarcode_Click(object sender, EventArgs e)
        {
            string CodeText = txtCode.Text.Trim();
            string appDesktopFolder = "KDMEDISP Report";
            string barcode = "Generated Bar_QR Codes";


            if (txtCode.Text == string.Empty || txtProdDesc.Text == string.Empty)

            {

                imsg.info("Check inputs and try again");
                return;

            }
            if (cboBarcodeMode.SelectedIndex == 0)
            {
                string img = CodeText + "bc.bmp";
                string imgPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory), appDesktopFolder, barcode, img);

                GenCode(CodeText, imgPath);



            }
            else
            {
                string img = CodeText + "qr.bmp";
                string imgPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory), appDesktopFolder, barcode, img);

                QRcode(CodeText, imgPath);
                pbxQr.BackgroundImage = imsg.LoadBitmap(imgPath);
                var TempPath = Path.GetTempPath();
                string SaveDirectory = "KDMEDISPImg";
                string TempImageName = Path.Combine(TempPath, SaveDirectory, img);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Home frm = new Home();
            this.Hide();
            frm.Show();


        }

        private void txtProdDesc_Click(object sender, EventArgs e)
        {

        }

        private void cboBarcodeMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBarcodeMode.SelectedIndex == 0)
            {
                pbxBarcode.Visible = true;
                pbxQr.Visible = false;
            }
            else
            {
                pbxBarcode.Visible = false;
                pbxQr.Visible = true;
            }
        }

        private string GenerateRandom()
        {
            Random rand = new Random();
            int brA = rand.Next(9999);
            int brB = rand.Next(9999);
            string finalCOde = brA.ToString() + brB.ToString();
            return finalCOde;
        }
        private void btnGenerateRandom_Click(object sender, EventArgs e)
        {

            // int brC = rand.Next(9999);


            if (GenerateRandom().Length == 8)
            {
                txtCode.Text = GenerateRandom();

            }
            else
            {
                GenerateRandom();
            }
        }

        private void pbxQr_Click(object sender, EventArgs e)
        {

        }
        private void loadBarCodes()
        {
            dgvBarcode.Rows.Clear();
            try
            {
                DataTable retTable = (DataTable)
              db.returnBarcode(txtSearchBar.Text.Trim());
                int i = 0;


                foreach (DataRow dr in retTable.Rows)
                {
                    dgvBarcode.Rows.Add(i, dr["pbcode"].ToString(), dr["pdesc"].ToString());
                    i += 1;
                }
            }
            catch (Exception)
            {

            }
        }
        private void btnCreateBar_Click(object sender, EventArgs e)
        {
            string barcode = txtCode.Text.Trim();
            string desc = txtProdDesc.Text.Trim();


            if (barcode == string.Empty || desc == string.Empty)
            {
                imsg.info("Check your input");

                return;
            }
            if (db.CheckBarCodeExist(barcode))
            {
                imsg.info("Code Already Existing");
                loadBarCodes();

                return;
            }
            string appDesktopFolder = "KDMEDISP Report";
            string pbcode = "Generated Bar_QR Codes";
            string imgPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory), appDesktopFolder, pbcode);

            string img1 = "bc.bmp";
            String img2 = "qr.bmp";

            string fileOption1 = barcode + img1;
            string fileOption2 = barcode + img2;

            OpenFileDialog op = new OpenFileDialog();
            op.InitialDirectory = imgPath;
            string f1= Path.Combine(imgPath, fileOption1);
            string f2= Path.Combine(imgPath, fileOption2);
            Console.WriteLine(f1);
            if (!File.Exists(f1) && !File.Exists(f2))
            {

                imsg.info("Barcode/ Qr not Generated, Generate and try again!");
                return;
            }


            if (db.InsertBarcode(barcode, desc))
            {
                imsg.info("Bar Code Saved");
            }
            loadBarCodes();
        }

        private void dgvBarcode_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string appDesktopFolder = "KDMEDISP POS & Inventory";
            string barcode = "Generated Bar & QR Codes";
            string imgPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory), appDesktopFolder, barcode);
            string img1 = "bc.bmp";
            String img2 = "qr.bmp";
            string colName = dgvBarcode.Columns[e.ColumnIndex].Name;
            string id = dgvBarcode[0, e.RowIndex].Value.ToString();
            string pbcode = dgvBarcode[1, e.RowIndex].Value.ToString();
            if (colName == "open")
            {
                string fileOption1 = pbcode + img1;
                string fileOption2 = pbcode + img2;

                OpenFileDialog op = new OpenFileDialog();
                op.InitialDirectory = imgPath;


                if (File.Exists(Path.Combine(imgPath, fileOption1)))
                {
                    op.FileName = fileOption1;


                }
                else if (File.Exists(Path.Combine(imgPath, fileOption2)))
                {

                    op.FileName = fileOption2;


                }


                op.ShowDialog();

            }
            else if (colName == "Delete")
            {
                if (imsg.prompt("Delete   from records ", "Delete"))
                {
                    Console.WriteLine(pbcode);
                    db.DelBarcode(pbcode);
                    loadBarCodes();
                }
            }
        }

        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
            loadBarCodes();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


