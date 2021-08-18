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
    public partial class frmNewSupplier : Form
    {
        string supplierName, phone, email, address;
        frmSuppliers sup;
        util imsg = new util( ); Db db = new Db();
        public frmNewSupplier(frmSuppliers s)
        {
            InitializeComponent();
            sup = s;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (imsg.prompt("Update Records?", "Supplier Update"))
                {
                    supplierName = txtSupplierName.Text;
                    phone = txtPhone.Text;
                    email = TxtEmail.Text;
                    address = txtAdd.Text;     // assigned brandName to autoProperty
                    if (string.IsNullOrWhiteSpace(supplierName))
                    {
                        imsg.info("Check entry and try again!", "Update Supplier");

                    }
                    else
                    {
                        if (db.UpdateSupplier(supplierName, email, phone, address, lblID.Text))
                        {

                            txtSupplierName.Clear();
                            txtPhone.Clear();
                            TxtEmail.Clear();
                            txtAdd.Clear();
                            imsg.info("Success!", "Update Manufacturer");
                            sup.LoadSuppliers();
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }

      

        private void btnSave_Click(object sender, EventArgs e)
        {
            supplierName = txtSupplierName.Text;
            phone = txtPhone.Text;
            email = TxtEmail.Text;
            address = txtAdd.Text;

            if (string.IsNullOrWhiteSpace(supplierName))
            {
                imsg.info("Check entry and try again!", "Add New Supplier");

            }
            else
            {


                if (db.insertSupplier(supplierName,phone,email,address))
                {


                  
                    imsg.info("Success!", "Add Supplier");
                    txtSupplierName.Clear();
                    txtPhone.Clear();
                    TxtEmail.Clear();
                    txtAdd.Clear();

                }
                else
                {
                    imsg.info("An error occured !", "Add Suppliers");

                }
            }

        }
    }
}
