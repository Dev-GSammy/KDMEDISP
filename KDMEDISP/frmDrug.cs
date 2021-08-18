using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Net;
using System.Drawing.Imaging;
using System.Collections.Specialized;

namespace KDMEDISP
{
    public partial class frmDrug : Form
    {
        util imsg = new util();
        Db db = new Db();
        frmDrugList flist;
        string pcode = "";
        cSig sig = new cSig();
        public static bool NewRec = true;
        string how="", when="", often="", howmuch="";
        public static  string targetImg="";
        public frmDrug(frmDrugList frm)
        {
            InitializeComponent();
           

            flist = frm;
            try
            {
                LoadSuppliers();
                loadManufacturers();
                cboSupplier.SelectedIndex = 0;
                cboManufacturers.SelectedIndex = 0;
                cboClassofDrug.SelectedIndex = 0;
                cboPackage.SelectedIndex = 0;
            }
            catch (Exception)
            {

            }
            try
            {
                loadSigtoComboBoxes();
            }
            catch (Exception)
            {

            }
        }
    public void loadSigtoComboBoxes()
        {

            //Console.WriteLine(sig.sigHowKV("ad"));
            foreach (var item in sig.sigHow.AllKeys )
            {
                cbxSigHow.Items.Add(item);
            }
            foreach (var item in sig.sigHowMuch.AllKeys)
            {
                cbxSigHowMuch.Items.Add(item);
            }
            foreach (var item in sig.sigOften.AllKeys)
            {
                cbxSigOften.Items.Add(item);
            }
            foreach (var item in sig.sigWhen.AllKeys)
            {
                cbxSigWhen.Items.Add(item);
            }

        }

        public void loadManufacturers()
        {
            cboManufacturers.Items.Clear();
            try
            {
                DataTable retTable = (DataTable)
              db.returnManufacturers("KDMEDISP", "tblmanufacturers");
                int i = 0;


                foreach (DataRow dr in retTable.Rows)
                {
                    i += 1;

                    cboManufacturers.Items.Add(dr["manufacturer"].ToString());
                }
            }
            catch (Exception)
            {

            }
        }
        private void frmProducts_Load(object sender, EventArgs e)
        {
           
            try

            {
                string img = txtPcode.Text + ".bmp";
                string imgName = System.IO.Path.Combine(imsg.retImagePath(), img);
                pbxNewProdImg.Image = imsg.LoadBitmap(imgName);
                
            }
            catch (Exception)
            {
                pbxNewProdImg.Image = Properties.Resources.noImage;

            }

            try
            {
               
               
            }
            catch (Exception)
            {

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string primary, generic, expirydate,units, strength, dclass,selbr;
                int cid, qty,reorderQty;
                double price;string manufacturer;
                //pcode  
                string  barcode, storage, pcode, additionalInfo,supplier,package;
                primary = txtprimary.Text.Trim();
                generic = txtGeneric.Text.Trim();
                strength = txtstrength.Text;
                barcode = txtBarCode.Text;
                units = txtUnit.Text;
                dclass = cboClassofDrug.Text;
                storage = txtStorageLocation.Text;
                reorderQty =Convert.ToInt32( txtReorderLevel.Text);
                additionalInfo = txtDrugAddInfo.Text;
                supplier = cboSupplier.Text;
                package = cboPackage.Text;
                pcode = txtPcode.Text;
                manufacturer = cboManufacturers.Text;
                expirydate = dtpExpiry.Value.ToString();
                //medicationFactor = Convert.ToDouble(txtMedicationFactor.Text);
               
                qty = Convert.ToInt16(txtIniQty.Text.Trim());
            double.TryParse(txtPrice.Text.Trim(), out price);
             
                if (string.IsNullOrWhiteSpace(pcode) || string.IsNullOrWhiteSpace(Convert.ToString(price)))
                //|| string.IsNullOrWhiteSpace(Convert.ToString(qty))
                {
                    imsg.info("Check Entry and try again !", "Add Drug Error");

                }
                else
                {
                    if (imsg.prompt("Save Entry?", "Save Drug"))
                    {


                        if (db.InsertDrugs(primary,generic,strength,units,dclass,manufacturer,pcode,barcode
                            ,storage,qty,reorderQty,expirydate,supplier,package,price,additionalInfo))
                        {

                            string imgName = pcode + ".bmp";
                            imsg.info("Success!", "Insert Drug");


                        }
                        else
                        {
                            imsg.info("An error Occured!", "Insert Drug");

                        }



                    }
                }
            }
            catch (Exception)
            {
                imsg.info("Check Entry and try again !", "Add Product Error");

            }

        }
        public static void SaveStreamAsFile(string filePath, Stream inputStream, string fileName)
        {
            DirectoryInfo info = new DirectoryInfo(filePath);
            if (!info.Exists)
            {
                info.Create();
            }

            string path = Path.Combine(filePath, fileName);
            using (FileStream outputFileStream = new FileStream(path, FileMode.Create))
            {
                inputStream.CopyTo(outputFileStream);
            }
        }
        public void clear()
        {
            txtPcode.Clear();
            txtprimary.Clear();
            txtPrice.Clear();
            txtIniQty.Clear();
            txtPcode.Focus();
        }
        private void btnUpdateProd_Click(object sender, EventArgs e)
        {

            try
            {
             
                string pcode, pbcode, pdesc, selcat, selbr;
                int cid, bid, qty,reorderQty;
                double price;
                pcode = txtPcode.Text.Trim();
                pbcode = txtBarCode.Text.Trim();
                pdesc = txtprimary.Text.Trim();
                selcat = cboClassofDrug.SelectedItem.ToString();
                selbr = cboSupplier.SelectedItem.ToString();
                cid = Convert.ToInt16(db.getCid(selcat));
                bid = Convert.ToInt16(db.getBid(selbr));
                reorderQty = Convert.ToInt16(txtReorderLevel.Text.Trim());
                Int32.TryParse(txtIniQty.Text.Trim(), out qty);
                price = Convert.ToDouble(txtPrice.Text.Trim());

                var TempPath = Path.GetTempPath();
                string SaveDirectory = "KDMEDISPImg";
                string TempImageName = Path.Combine(TempPath, SaveDirectory, pcode+".bmp");
                File.Delete(TempImageName);
                if (string.IsNullOrWhiteSpace(pcode) || string.IsNullOrWhiteSpace(Convert.ToString(price)))
                //|| string.IsNullOrWhiteSpace(Convert.ToString(qty))
                {
                    imsg.info("Check Entry and try again !", "Update Product Error");

                }
                else
                {
                    if (imsg.prompt("Update Product?", "Update Product"))
                    {


                        if (db.UpdateProduct(pcode,pbcode,pdesc,bid,cid,price,qty,reorderQty))
                        {
                            string imgName = pcode + ".bmp";
                            imsg.info("Success!", "Update Product");
                        

                            //clear();
                            //flist.loadProducts();
                        }
                        else
                        {
                            imsg.info("An error Occured!", "Update Product");

                        }



                    }
                }
            }
            catch (Exception)
            {
                imsg.info("Check Entry and try again !", "Add Product Error");

            }
        }
         
        private void btnProdExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void LoadSuppliers()
        {
            cboSupplier.Items.Clear();
            try
            {
                DataTable retTable = (DataTable)
              db.returnSuppliers("KDMEDISP", "tblsuppliers");
                int i = 0;


                foreach (DataRow dr in retTable.Rows)
                {

                    cboSupplier.Items.Add(dr["supplier"].ToString());
                }
            }
            catch (Exception)
            {

            }
        }

        //public void loadCategory()
        //{
        //    DataTable retTable = (DataTable) db.returnCategory("KDMEDISP", "tblcategory");
        //    int i = 0;
        //    foreach (DataRow item in retTable.Rows)
        //    {
        //        //Console.WriteLine(item["category"].ToString());
        //        cboClassofDrug.Items.Add(item["category"].ToString()    );
        //    }
        //    cboClassofDrug.SelectedIndex = 0;
        //}
        //public void loadbrand()
        //{
        //    DataTable retTable = (DataTable)
        //        db.returnPatients("KDMEDISP", "tblbrand");
        //    int i = 0;
        //    foreach (DataRow item in retTable.Rows)
        //    {
        //        //Console.WriteLine(item["category"].ToString());
        //        cboSupplier.Items.Add(item["brand"].ToString());
        //    }
        //    cboSupplier.SelectedIndex = 0;
        //}

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            imsg.numOnly(sender, e);          // accept only num points and backspace.
        }

        private void txtIniQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            imsg.numOnly(sender, e,false);          // accept only num and backspace.

        }

        private void btnUploadImage_Click(object sender, EventArgs e)

        {
            if (string.IsNullOrWhiteSpace(txtPcode.Text.Trim()))
            {
                imsg.info("Enter a Product reference Code");
                return;
            }

            string img = txtPcode.Text.Trim() + ".bmp";
            System.IO.Directory.CreateDirectory(imsg.retImagePath());

            string imgName = Path.Combine(imsg.retImagePath(),img);
            var TempPath = Path.GetTempPath();
            string SaveDirectory = "KDMEDISPImg";
            string TempImageName =Path.Combine(TempPath, SaveDirectory, img) ;
            System.IO.Directory.CreateDirectory(Path.Combine(TempPath, SaveDirectory));
           // Console.WriteLine(TempImageName);
            using OpenFileDialog opfd = new OpenFileDialog();
            { 

            if (opfd.ShowDialog() == DialogResult.OK)
            {

                    try
                    {

                        using Image oldimage = Bitmap.FromFile(opfd.FileName);
                    {
                        using Image newimage = imsg.ResizeImage(oldimage, new Size( 101, 62));
                        {
                            using MemoryStream ms = new MemoryStream();
                            {
                                newimage.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                                newimage.Save(TempImageName, System.Drawing.Imaging.ImageFormat.Bmp);
                                    pbxNewProdImg.Image = Image.FromStream(ms);
                                    if (File.Exists(imgName))
                                    {
                                        File.Copy(TempImageName, imgName, true);

                                    }
                                    else
                                    {
                                        newimage.Save(imgName, System.Drawing.Imaging.ImageFormat.Bmp);

                                    }
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        imsg.info("An error Occurred !");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtReorderLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            imsg.numOnly(sender, e, false);
        }
        private  void getLogo()
        {
            try
            {
                string imgurl ="";

                if (string.IsNullOrWhiteSpace(imgurl))
                {
                    imsg.info("Invalid Url Check and Try again!");
                    return;
                }
                string img = txtPcode.Text.Trim() + ".bmp";
                Directory.CreateDirectory(imsg.retImagePath());
                string imgName = Path.Combine(imsg.retImagePath(), img);
                var TempPath = Path.GetTempPath();
                string SaveDirectory = "KDMEDISPImg";
                string TempImageName = Path.Combine(TempPath, SaveDirectory, img);
                Directory.CreateDirectory(Path.Combine(TempPath, SaveDirectory));
                using (WebClient webClient = new WebClient())
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                                                        | SecurityProtocolType.Tls11
                                                        | SecurityProtocolType.Tls12
                                                        | SecurityProtocolType.Ssl3;
                    byte[] data = webClient.DownloadData(imgurl);

                    using (MemoryStream mem = new MemoryStream(data))
                    {
                        using (var prodImg = Image.FromStream(mem))
                        {
                            using Image newimage = imsg.ResizeImage(prodImg, new Size(101, 62));
                            {
                                using MemoryStream ms = new MemoryStream();
                                {
                                    newimage.Save(ms, ImageFormat.Bmp);
                                    newimage.Save(TempImageName, System.Drawing.Imaging.ImageFormat.Bmp);
                                    pbxNewProdImg.Image = Image.FromStream(ms);
                                    if (File.Exists(imgName))
                                    {
                                        File.Copy(TempImageName, imgName, true);

                                    }
                                    else
                                    {
                                        newimage.Save(imgName, System.Drawing.Imaging.ImageFormat.Bmp);

                                    }
                                }
                            }

                        }
                    }
                }
            }
            catch (Exception)
            {
                imsg.info("Product image not available Online!, Contact Shop Admin");
            }
        }
        private void btnFetchImgfromUrl_Click(object sender, EventArgs e)
        {
            getLogo();
        }

        private void cbxSigOften_SelectedIndexChanged(object sender, EventArgs e)
        {
            often = sig.sigOftenKV(cbxSigOften.Text);
            generateSig();
        }

        private void cbxSigWhen_SelectedIndexChanged(object sender, EventArgs e)
        {
            when = sig.sigWhenKV(cbxSigWhen.Text);
            generateSig();
        }

        private void cbxSigHow_SelectedIndexChanged(object sender, EventArgs e)
        {
            how = sig.sigHowKV(cbxSigHow.Text);
            generateSig();
        }

        private void txtSigQty_TextChanged(object sender, EventArgs e)
        {
            generateSig();

        }

        private void txtPrice_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46)
            {
                if (true)
                {
                    if (txtPrice.Text.Contains("."))
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

        private void btnLoadDrugs_Click(object sender, EventArgs e)
        {
            loadDrugsList ldl = new loadDrugsList(this);
            ldl.ShowDialog();
        }

        private void btnManufacturer_Click(object sender, EventArgs e)
        {
            frmManufacturersList frm = new frmManufacturersList(this);
            frm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadManufacturers();
            LoadSuppliers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string primary, generic, expirydate, units, strength, dclass, selbr;
                int cid, qty, reorderQty;
                double price; string manufacturer;
                //pcode  
                string barcode, storage, pcode, additionalInfo, supplier, package;
                primary = txtprimary.Text.Trim();
                generic = txtGeneric.Text.Trim();
                strength = txtstrength.Text;
                barcode = txtBarCode.Text;
                units = txtUnit.Text;
                dclass = cboClassofDrug.Text;
                storage = txtStorageLocation.Text;
                reorderQty = Convert.ToInt32(txtReorderLevel.Text);
                additionalInfo = txtDrugAddInfo.Text;
                supplier = cboSupplier.Text;
                package = cboPackage.Text;
                pcode = txtPcode.Text;
                manufacturer = cboManufacturers.Text;
                expirydate = dtpExpiry.Value.ToString();
                int id;
                int.TryParse(lblID.Text,out id);
                //medicationFactor = Convert.ToDouble(txtMedicationFactor.Text);
                selbr = cboSupplier.SelectedItem.ToString();
                qty = Convert.ToInt16(txtIniQty.Text.Trim());
                double.TryParse(txtPrice.Text.Trim(), out price);

                if (string.IsNullOrWhiteSpace(pcode) || string.IsNullOrWhiteSpace(Convert.ToString(price)))
                //|| string.IsNullOrWhiteSpace(Convert.ToString(qty))
                {
                    imsg.info("Check Entry and try again !", "Add Drug Error");
                }
                else
                {
                    if (imsg.prompt("update Entry?", "Update Drug"))
                    {
                        if (db.UpdateDrugs(id,primary, generic, strength, units, dclass, manufacturer, pcode, barcode
                            , storage, qty, reorderQty, expirydate, supplier, package, price, additionalInfo))
                        {
                            string imgName = pcode + ".bmp";
                            imsg.info("Success!", "Update Drug");
                        }
                        else
                        {
                            imsg.info("An error Occured!", "Update Drug");
                        }
                    }
                }
            }
            catch (Exception)
            {
                imsg.info("Check Entry and try again !", "Update Drug");
            }
        } 
        private void cbxSigHowMuch_SelectedIndexChanged(object sender, EventArgs e)
        {
            howmuch = sig.sigHowMuchKV(cbxSigHowMuch.Text);
            generateSig(); 
        }

        private void generateSig()
        {
            txtSigTrans.Text = "Take " + txtSigQty.Text + " " +howmuch +" " +often+" "+ when+ " [" + how+" ]";
        }
    }
}
