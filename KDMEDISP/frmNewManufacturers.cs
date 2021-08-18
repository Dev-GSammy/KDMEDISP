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
    public partial class frmNewManufacturers : Form
    {
        frmManufacturersList mfl;
        util imsg = new util();
        Db db = new Db();
        public frmNewManufacturers( frmManufacturersList ml)
        {
            InitializeComponent();
            mfl = ml;
        }

        private void frmNewManufacturers_Load(object sender, EventArgs e)
        {

        }
        private void clear()
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            txtmanufName.Clear();
            txtmanufName.Focus();

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string manufName = txtmanufName.Text.ToString();      // assigned brandName to autoProperty
            if (string.IsNullOrWhiteSpace(manufName))
            {
                imsg.info("Check entry and try again!", "Add New Manufacturer");

            }
            else
            {


                if (db.insertManufacturer(manufName))
                {


                    clear();
                    imsg.info("Success!", "Add Brand");
                   
                   
                }
                else
                {
                    imsg.info("An error occured !", "Add Brand");

                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (imsg.prompt("Update Records?", "Manufacturer Update"))
                {
                    string manufacturerName = txtmanufName.Text.ToString();      // assigned brandName to autoProperty
                    if (string.IsNullOrWhiteSpace(manufacturerName))
                    {
                        imsg.info("Check entry and try again!", "Update Manufacturer");

                    }
                    else
                    {
                        db.UpdateManufactuerer(manufacturerName, lblID.Text);
                        clear();
                        imsg.info("Success!", "Update Manufacturer");
                        //frmlist.LoadBrands();
                        this.Dispose();
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtmanufName_Click(object sender, EventArgs e)
        {

        }
    }
}
