using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDMEDISP
{
    public partial class frmPOS : Form
    {
        util imsg = new util();
        public static bool paid = false;
        public static Double wholeDiscount ;
        public static string posTime;
        public static bool wholeCartTick = false;
        public static bool CheckOutStats = false;
        public static string presstaffID = "";
        public static string PatientID = "";


        Db db = new Db();
        string price = "0";
        int SelectedItemID = 0;
        public frmPOS()
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToLongDateString();
            LoadCart();
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
            txtCheckOutCash.Enabled = false;
            lblPresStaffID.Text = presstaffID;
            //imsg.info(presstaffID);
            try
            {
                if (clPresandPatientID.Guest == true)
            {
                    lblPatientName.Text = clPresandPatientID.GuesPatientName;
                    lblPatientPhone.Text = clPresandPatientID.GuesPatientPh;
                    rtxtPatientAdd.Text = clPresandPatientID.GuesPatientAddress;
                }
            else {
                DataTable retTable = (DataTable)
            db.returnPatientfromID(clPresandPatientID.patientID);
                int i = 0;


                foreach (DataRow dr in retTable.Rows)
                {

                    lblPatientName.Text = dr["title"].ToString() + " " + dr["firstname"].ToString() + " " + dr["LastName"].ToString() + " " + dr["othername"].ToString();
                    rtxtPatientAdd.Text = dr["address"].ToString();
                    lblPatientPhone.Text = dr["phone"].ToString();
                    lblPatientAge.Text = dr["dob"].ToString();
                }

                //}
                //catch (Exception)
                //{


                //}

                //try
                //{
                DataTable retTable2 = (DataTable)
            db.returnPrescriberfromStaffID(clPresandPatientID.prescriberID);


                foreach (DataRow dr in retTable2.Rows)
                {

                    lblPrescName.Text = dr["title"].ToString() + " " + dr["firstname"].ToString() + " " + dr["LastName"].ToString() + " " + dr["othername"].ToString();
                    lblPrescPhone.Text = dr["phone"].ToString();
                    rtxtPresAdd.Text = dr["address"].ToString();
                }
            }

        }
                catch (Exception)
            {


            }
        }
            private void getTransNo()
        {
            try
            {
                string sdate = DateTime.Now.ToString("yyyyMMdd");
                string transno;
                DataTable retTable = (DataTable)db.returnTransno(sdate);
                int count;
                if (retTable.Rows.Count > 0)
                {
                    foreach (DataRow dr in retTable.Rows)
                    {


                        transno = dr[0].ToString();
                        count = int.Parse(transno.Substring(8,4));
                        lblTransno.Text = sdate + (count + 1);
                    }
                }
                else
                {
                    transno = sdate + "1001";
                    lblTransno.Text = transno;
                }
            }
            catch (Exception)
            {

            }
        }
      
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (dgvCart.Rows.Count > 0)
            {
                if (imsg.prompt("Clear  items from Cart?"))
                {
                    if (paid)
                    {
                        dgvCart.Rows.Clear();
                    }
                    else
                    {
                        for (int i = 0; i < dgvCart.Rows.Count; i++)
                        {
                            string RowID = dgvCart.Rows[i].Cells["selectedID"].Value.ToString();
                            db.DelItemFromCart(RowID, false);


                        }
                    }
                    LoadCart();
                    clearTransaction();
                    this.Dispose();
                    var dashboard = new dashboard();
                    dashboard.Show();
                }
                else
                {
                    return;
                }
            }
            else
            {
                this.Dispose();
                var dashboard = new dashboard();
                dashboard.Show();
            }
                
          

        }

      

         public void LoadCart()
        {
            dgvCart .Rows.Clear();
            //try
            //{
              DataTable retTable = (DataTable) db.ReturnPendingCart(lblTransno.Text);
                int i = 0;

                double SubtotalSales=0;
                double discount=0;
                double UndiscountedTotal=0;
            if (retTable==null)
            {
                btnEnter.Enabled = false;
                return;
                
            }
            btnEnter.Enabled = true;

            foreach (DataRow dr in retTable.Rows)                                                
                {
                    i += 1;

                    dgvCart.Rows.Add(i, dr["id"].ToString(), dr["nprimary"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["discount"].ToString(),Double.Parse(dr["total"].ToString()).ToString("#,##0.00"), dr["pcode"].ToString());
                    discount += Double.Parse(dr["discount"].ToString());
                    UndiscountedTotal += Double.Parse(dr["price"].ToString())* Double.Parse(dr["qty"].ToString());
                    Console.WriteLine(dr["pcode"].ToString());
                }
                
                lblDiscount.Text = (discount+wholeDiscount).ToString("#,##0.0");
                lblSubTotal.Text = (UndiscountedTotal - Double.Parse(lblDiscount.Text)).ToString("#,##0.0");

                lblUndisCountedTotal.Text = (UndiscountedTotal).ToString("#,##0.0");
                txtScanBarcode.Clear();
                
                txtScanBarcode.Focus();
                getCartTotal();
                if (wholeDiscount>0)
                {
                    pbxWholeCartDiscTick.Visible = true;
                }
                else
                {
                    pbxWholeCartDiscTick.Visible = false;
                                    //}
            //catch (Exception)
            //{

            //}
                }


        }
         public void getCartTotal()
        {
            //try
            //{
                Double sales = Double.Parse(lblSubTotal.Text);
                Double Vat = Double.Parse(getVat()) / 100.00;
                lblVatRate.Text = "(" + getVat() + "%)";
                lblVat.Text = ((Double.Parse(lblSubTotal.Text) * Vat).ToString("#,##0.00"));
                lblCartTotalforCheckOut.Text = ((Double.Parse(lblSubTotal.Text) + ((Double.Parse(lblSubTotal.Text) * Vat))).ToString("#,##0.00"));

            //}
            //catch (Exception)
            //{

            //    imsg.info("An error occured, Check Config");
            //}
         }
        public string getVat()
        {
            DefaultConfig settings = new DefaultConfig();
            serialize st = new serialize(imsg.retConfigPath("vat"));
            settings = (DefaultConfig)st.DeSerializeNow(settings);
            //imsg.info(settings.vat);
            return settings.vat;
        }
        private void dgvSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
      

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (lblTransno.Text=="...")
            {
                imsg.info("Create a New Transaction First");
                return;
            }
            txtCheckOutCash.Clear();
            txtCheckOutChange.Clear();
            txtCheckoutSalesAmount.Clear();

            productLookup frmplkup = new productLookup(this);
            //this.Hide();

            frmplkup.ShowDialog();
        }

        private void btnSalesOverview_Click(object sender, EventArgs e)
        {
          analytics frm = new analytics();
            frm.ShowDialog();
        }

        private void txtScanBarcode_Click(object sender, EventArgs e)
        {
            txtCheckOutCash.Clear();
            txtCheckOutChange.Clear();
            txtCheckoutSalesAmount.Clear();
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void txtScanBarcode_TextChanged(object sender, EventArgs e)
        {

            if (lblTransno.Text=="...")
            {
                imsg.info("Create a New Transaction First!");
                return;
            }
            //try
            //{
                string searchString = txtScanBarcode.Text;
                if (string.IsNullOrEmpty(searchString))
                {
                    return;
                }
                DataTable retTable = new DataTable();
               retTable=(DataTable) db.returnBarcodeProduct(searchString);
                if (retTable.Rows.Count>0)
                {
                    frmQty qty = new frmQty(this);

                    foreach (DataRow dr in retTable.Rows)
                    {
                        string pcode = dr["pcode"].ToString();
                        string stockqty = dr["qty"].ToString();
                        string img = pcode + ".bmp";
                        string imgName = System.IO.Path.Combine(imsg.retImagePath(), img);

                        qty.lblProdFound.Text = dr["nprimary"].ToString();
                        qty.pbxFoundProd.Image = imsg.LoadBitmap(imgName);
                        qty.ProductDetails(pcode, double.Parse(dr["price"].ToString()), lblTransno.Text, int.Parse(stockqty));
                    }
                    qty.ShowDialog();
                }
            //}
            //catch (Exception)
            //{

            //}
        }

      

        

      

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvCart_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        private void dgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCart.Columns[e.ColumnIndex].Name;
            string id = dgvCart.Rows[e.RowIndex].Cells["selectedID"].Value.ToString();
            if (colName == "Delete")
                if (imsg.prompt("Delete item from Cart?"))
                {
                    {
                        wholeDiscount = 0.0; // reset whole discount
                        db.DelItemFromCart(id);
                        LoadCart();
                    }
                }
        }

        private void dgvCart_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCart.Columns[e.ColumnIndex].Name;
            price = dgvCart.Rows[e.RowIndex].Cells["Itemprice"].Value.ToString();
         string discqty = dgvCart.Rows[e.RowIndex].Cells["qty"].Value.ToString();
            double prodprice = Double.Parse(price);
            double DiscQtyNum = Double.Parse(discqty);
            if (colName == "qty")
            {
            string curval = dgvCart.Rows[e.RowIndex].Cells["qty"].Value.ToString();
                var frmQtyedit = new FrmGsUpdate(this,"Edit Qty", "Edit", "Update", "updateQty",prodprice , curval, SelectedItemID);
                wholeDiscount = 0.0;

                frmQtyedit.ShowDialog();

            }
           else if (colName == "discount")                                 
            {
                string curval = dgvCart.Rows[e.RowIndex].Cells["discount"].Value.ToString();
                wholeDiscount = 0.0;

                var frmQtyedit = new FrmGsUpdate(this,"Add Discount (%)", "Edit", "Apply", "updateDisc",prodprice* DiscQtyNum, curval, SelectedItemID);
                frmQtyedit.ShowDialog();
            }
            LoadCart();
        }

        
        private void dgvCart_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvCart.Rows[e.RowIndex].Cells["selectedID"].Value.ToString();
             price = dgvCart.Rows[e.RowIndex].Cells["Itemprice"].Value.ToString();
            SelectedItemID = int.Parse( id);
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            if (imsg.prompt("Clear  items from Cart?"))
            {
                if (paid)
                {
                    dgvCart.Rows.Clear();
                }    
                else

                {
                    for (int i = 0; i < dgvCart.Rows.Count; i++)
                    {
                        string RowID = dgvCart.Rows[i].Cells["selectedID"].Value.ToString();
                        db.DelItemFromCart(RowID,false);
                       

                    }

                    LoadCart();
                    clearTransaction();

                }
            }
            
        }
             public void clearTransaction()
        {
            wholeDiscount = 0.0;
            pbxWholeCartDiscTick.Visible = false;
            lblSubTotal.Text = "0.00";
            lblDiscount.Text = "0.00";
            lblUndisCountedTotal.Text = "0.00";
            lblCartTotalforCheckOut.Text = "0.00";
            lblVat.Text = "0.00";
            dgvCart.Enabled = true;
            txtCheckOutCash.Clear();
            txtCheckoutSalesAmount.Clear();
            txtCheckOutChange.Clear();
            CheckOutStats = false;
        }
        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmPOS_Activated(object sender, EventArgs e)
        {
           // LoadCart();

        }

        private void lblSubdiscount_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }



        private void btnCalc_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblSubTotal_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {


        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (!(dgvCart.Rows.Count>0) )
            {
                imsg.info("Add items to Cart first!");
                return;
            }
            txtCheckoutSalesAmount.Text = lblCartTotalforCheckOut.Text;
            dgvCart.Enabled = false;
            dgvCart.BackgroundColor = Color.Beige;
            txtCheckOutCash.Enabled = true;

            txtCheckOutCash.Focus();
            CheckOutStats = true;
            if (CheckOutStats)
            {
                pbxCartLockStats.Visible = true;


            }




        }

        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            if (dgvCart.Rows.Count > 0)
            {
                if (imsg.prompt("Clear  items from Cart?"))
                {
                    if (paid)
                    {
                        dgvCart.Rows.Clear();
                    }
                    else
                    {
                        for (int i = 0; i < dgvCart.Rows.Count; i++)
                        {
                            string RowID = dgvCart.Rows[i].Cells["selectedID"].Value.ToString();
                            db.DelItemFromCart(RowID, false);


                        }
                        paid = false;
                    }
                    LoadCart();
                    clearTransaction();
                }
                    
                }
                    getTransNo();
            dgvCart.BackgroundColor = Color.White;
            pbxCartLockStats.Visible = false;

            dgvCart.Enabled = true;

        }

        private void txtCheckOutCash_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtCheckOutChange.Text = (Double.Parse(txtCheckOutCash.Text) - Double.Parse(txtCheckoutSalesAmount.Text)).ToString("#,##0.00");
            }
            catch (Exception)
            {

            }
        }

        private void lblCartTotal_TextChanged(object sender, EventArgs e)
        {
            if (true)
            {
                txtCheckoutSalesAmount.Text = lblCartTotalforCheckOut.Text;

            }
        }

        private void dgvCart_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnWholeCartDiscount_Click(object sender, EventArgs e)
        {

            if (dgvCart.Rows.Count > 0)
            {
                if (wholeDiscount > 0)
                {
                    wholeDiscount = 0.0;
                    pbxWholeCartDiscTick.Visible = false;

                }
                LoadCart();
                var frm = new frmDiscount(this);
                frm.txtDiscPrice.Text = lblSubTotal.Text;

                frm.ShowDialog();

            }
            else
            {
                imsg.info("Add items to cart first!");
            }
        }


        private void btnEditCart_Click(object sender, EventArgs e)
        {
            pbxWholeCartDiscTick.Visible = false;
            pbxCartLockStats.Visible = false;
            dgvCart.BackgroundColor = Color.White;
            txtCheckOutCash.Enabled = false;

            dgvCart.Enabled = true;
            txtCheckOutCash.Clear();
            txtCheckoutSalesAmount.Clear();
            txtCheckOutChange.Clear();
            CheckOutStats = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (CheckOutStats)
            {
                txtCheckOutCash.Text += btn7.Text;

            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (CheckOutStats)
            {
                txtCheckOutCash.Text += btn8.Text;

            }

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (CheckOutStats)
            {
                txtCheckOutCash.Text += btn9.Text;

            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (CheckOutStats)
            {
                txtCheckOutCash.Text += btn4.Text;

            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (CheckOutStats)
            {
                txtCheckOutCash.Text += btn5.Text;

            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (CheckOutStats)
            {
                txtCheckOutCash.Text += btn6.Text;

            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (CheckOutStats)
            {
                txtCheckOutCash.Text += btn1.Text;

            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (CheckOutStats)
            {
                txtCheckOutCash.Text += btn2.Text;

            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (CheckOutStats)
            {
                txtCheckOutCash.Text += btn3.Text;

            }
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            if (CheckOutStats)
            {
                txtCheckOutCash.Text += btn00.Text;

            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (CheckOutStats)
            {
                txtCheckOutCash.Text += btn0.Text;

            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtCheckOutCash.Clear();
            txtCheckOutCash.Focus();
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (CheckOutStats)
            {
                if (!txtCheckOutCash.Text.Contains("."))
                {
                    txtCheckOutCash.Text += ".";

                }

            }
        }

        private void txtCheckOutCash_KeyPress(object sender, KeyPressEventArgs e)
        {

           
            if (e.KeyChar == 46)
            {
                if (true)
                {
                    if (txtCheckOutCash.Text.Contains("."))
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

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {

                if ((Double.Parse(txtCheckOutChange.Text) < 0) || string.IsNullOrEmpty(txtCheckOutChange.Text))
                {
                    imsg.info("Insufficient Fund Please Try again!", "Payment Error");

                }
                else
                {
                    for (int i = 0; i < dgvCart.Rows.Count; i++)
                    {
                        string id = dgvCart.Rows[i].Cells["selectedID"].Value.ToString();
                        string pcode = dgvCart.Rows[i].Cells["pcode"].Value.ToString();
                        int qty = int.Parse(dgvCart.Rows[i].Cells["qty"].Value.ToString());
                        db.UpdateProductQtyFromCart(pcode, qty);
                        db.UpdateSingleData("KDMEDISP", "tblCart", "status", "sold", int.Parse(id));
                    }
                    paid = true;

                    // get Cart items
                    Double Amount, Discount, Total=0.0;

                    List<CartItems> Cart = new List<CartItems>();
            for (int i = 0; i < dgvCart.Rows.Count; i++)
            {
                string itemDesc;
                int Qty;
                itemDesc = dgvCart.Rows[i].Cells["description"].Value.ToString();
                Amount = Double.Parse(dgvCart.Rows[i].Cells["itemPrice"].Value.ToString());
                Discount = Double.Parse(dgvCart.Rows[i].Cells["discount"].Value.ToString());
                Total = Double.Parse(dgvCart.Rows[i].Cells["total"].Value.ToString());
                Qty = int.Parse(dgvCart.Rows[i].Cells["qty"].Value.ToString());
                CartItems CI = new CartItems(itemDesc,Amount,Qty,Discount,Total);
                Cart.Add(CI);
            }
                    PosOrder O = new PosOrder()
                    {

                        InvoiceNo = lblTransno.Text,
                        CustomerName = lblPatientName.Text,
                        CustomerPhone = lblPatientPhone.Text,

                        TotalAmount = Total.ToString()

            };

            frmCheckOut checkOut = new frmCheckOut(this, O,Cart);
            checkOut.Show();
                    //

                }
            }
            catch (Exception)
            {

            }
        }

      

        private void btnInteraction_Click(object sender, EventArgs e)
        {
            frmDrugInteractionMain frm = new frmDrugInteractionMain();

            frmDrugInteractionMain.fromPos = true;
            
            frm.ShowDialog();
            //dashboard.selBtn = "profile";

            //this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
