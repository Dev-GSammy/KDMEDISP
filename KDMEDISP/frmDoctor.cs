using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDMEDISP
{
    public partial class frmDoctor : Form
    {
        Db db = new Db();
        util imsg = new util();
        frmDoctorList dl;
        string firstname, lastname, email, address, staffid, imgurl, dob, othername, sex, title, phone, organisation, nextofkin, nextofkinPhone, allergies, medicalnotes;

        public frmDoctor(frmDoctorList d)
        {
            InitializeComponent();
            dl = d;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            email = TxtEmail.Text;
            firstname = txtFirstName.Text;
            lastname = txtLastName.Text;
            address = txtAdd.Text;
            staffid = txtStaffID.Text;
            dob = dtpDob.Value.ToShortDateString();
            othername = txtOtherName.Text;
            sex = cboSex.Text;
            title = cbxTitle.Text;
            phone = txtPhone.Text;
            if (string.IsNullOrEmpty(firstname)||string.IsNullOrEmpty(lastname)||string.IsNullOrEmpty(title)||string.IsNullOrEmpty(phone))
            {
                imsg.info("Empty or Incorrect Record! Check and try again!");
                return;
            }
            if (db.getPrescriberID(staffid))
            {
                imsg.info("Record already existing");

                return;
            }
            if (db.InsertPrescriber(title, sex, dob, firstname, lastname, othername, email, phone, staffid, address))

            {
                imsg.info("Record added successfully");
            }
            else
            {
                imsg.info("Error adding records");

            }
        }

        private void frmDoctor_Load(object sender, EventArgs e)
        {
            cboSex.SelectedIndex = 0;
            cbxTitle.SelectedIndex = 0;
            string img = txtStaffID.Text + ".bmp";
            string imgName = System.IO.Path.Combine(imsg.retImagePath(), img);
            pbxNewProdImg.Image = imsg.LoadBitmap(imgName);

        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            string staffID = txtStaffID.Text.Trim();
            if (string.IsNullOrWhiteSpace(staffID))
            {
                imsg.info("Enter a Product reference Code");
                return;
            }

            string img = staffID + ".bmp";
            System.IO.Directory.CreateDirectory(imsg.retImagePath());

            string imgName = Path.Combine(imsg.retImagePath(), img);
            var TempPath = Path.GetTempPath();
            string SaveDirectory = "KDMEDISPImg";
            string TempImageName = Path.Combine(TempPath, SaveDirectory, img);
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
                            using Image newimage = imsg.ResizeImage(oldimage, new Size(101, 62));
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

        private void txtStaffID_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void cboSex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtOtherName_Click(object sender, EventArgs e)
        {

        }

        private void cbxTitle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpDob_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtEmail_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_Click(object sender, EventArgs e)
        {

        }

        private void txtLastName_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            email = TxtEmail.Text;
            firstname = txtFirstName.Text;
            lastname = txtLastName.Text;
            address = txtAdd.Text;
            staffid = txtStaffID.Text;
            dob = dtpDob.Value.ToShortDateString();
            othername = txtOtherName.Text;
            sex = cboSex.Text;
            title = cbxTitle.Text;
            phone = txtPhone.Text;

            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(phone))
            {
                imsg.info("Empty or Incorrect Record! Check and try again!");
                return;
            }
           int ID = db.getIDfromStaffID((staffid));

            if (db.UpdatePrescriber(Convert.ToInt32(ID), title, sex, dob, firstname, lastname, othername, email, phone, staffid,address))

            {
                imsg.info("Update successful");
            }
            else
            {
                imsg.info("Error updating records");

            }
        }
    }
}
