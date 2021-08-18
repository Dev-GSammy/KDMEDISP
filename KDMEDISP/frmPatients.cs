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
    public partial class frmPatients : Form
    {
        Db db = new Db();
        util imsg = new util();
        frmPatientList pl;
        string firstname, lastname, email, address, staffid, imgurl, dob, othername, sex, title, phone, organisation, nextofkin, nextofkinPhone, allergies, medicalnotes;

        public frmPatients(frmPatientList frm)
        {
            InitializeComponent();
            pl = frm;
        }
        private void dgvCategoryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmPatients_Load(object sender, EventArgs e)
        {
            cbxSex.SelectedIndex = 0;
            cbxTitle.SelectedIndex = 0;
        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox6_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            string PatientImgID ="PT"+lblid.Text;
            if (string.IsNullOrWhiteSpace(PatientImgID))
            {
                imsg.info("Check entry");
                return;
            }

            string img = PatientImgID + ".bmp";
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            email = txtEmail   .Text;
            firstname = txtfirstname.Text;
            lastname = txtLastName.Text;
            address = txtpatientAdd.Text;
            dob = dtpDob.Value.ToShortDateString();
            othername = txtOtherName.Text;
            sex = cbxSex.Text;
            title = cbxTitle.Text;
            phone = txtPhone.Text;
            nextofkin = txtNextofKin.Text;
            nextofkinPhone = txtNextofkinPhone.Text;
            organisation = txtOrganisation.Text;
            allergies = txtAllergies.Text;
            medicalnotes = txtMedicalNotes.Text;
            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(phone))
            {
                imsg.info("Empty or Incorrect Record! Check and try again!");
                return;
            }
            string PatientID = "PT/" + dob + "/" + title.Replace('.', ' ').Trim() + "/" + firstname.Trim().ToUpper()+ "/"+lastname.Trim().ToUpper() + "/" + phone.Substring(phone.Length-5);
            Console.WriteLine(PatientID);
            lblUniPatientID.Text = PatientID;
            if (db.getPatientID(PatientID))
            {
                imsg.info("Record already existing");

                return;
            }
            string regdate = DateTime.Now.ToShortDateString();
            if (db.InsertPatient(PatientID,title, sex, dob, firstname, lastname, othername, email, phone,address,nextofkin,nextofkinPhone,organisation,allergies,medicalnotes,regdate))

            {
                imsg.info("Record added successfully");
            }
            else
            {
                imsg.info("Error adding records");

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            email = txtEmail.Text;
            firstname = txtfirstname.Text;
            lastname = txtLastName.Text;
            address = txtpatientAdd.Text;
            dob = dtpDob.Value.ToShortDateString();
            othername = txtOtherName.Text;
            sex = cbxSex.Text;
            title = cbxTitle.Text;
            phone = txtPhone.Text;
            nextofkin = txtNextofKin.Text;
            nextofkinPhone = txtNextofkinPhone.Text;
            organisation = txtOrganisation.Text;
            allergies = txtAllergies.Text;
            medicalnotes = txtMedicalNotes.Text;
            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(phone))
            {
                imsg.info("Empty or Incorrect Record! Check and try again!");
                return;
            }
            string PatientID = "PT/" + dob + "/" + title.Replace('.', ' ').Trim() + "/" + firstname.Trim().ToUpper() + "/" + lastname.Trim().ToUpper() + "/" + phone.Substring(phone.Length - 5);
            Console.WriteLine(PatientID);
            lblUniPatientID.Text = PatientID;
          
            if (db.UpdatePatient(Convert.ToInt32(lblid.Text),PatientID, title, sex, dob, firstname, lastname, othername, email, phone, address, nextofkin, nextofkinPhone, organisation, allergies, medicalnotes))

            {
                imsg.info("Record added successfully");
            }
            else
            {
                imsg.info("Error adding records");

            }
        }
    }
}
