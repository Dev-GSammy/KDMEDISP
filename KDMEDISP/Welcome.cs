using System;
using System.IO;
using System.Windows.Forms;

namespace KDMEDISP
{
    public partial class Welcome : Form
    {
        Login login = new Login();
        int duration = 10;
        int count = 0;
        util imsg = new util();
        Db db = new Db();
        public Welcome()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            if (db.getCount() > 0)
            {
                db.UpdateCount();

            }
            

            timer1.Enabled = true;
            try
            {
                System.IO.Directory.CreateDirectory(imsg.retImagePath());
                string appDesktopFolder = "KDMEDISP Report";
                string pbcode = "Generated Bar_QR Codes";
                string imgPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory), appDesktopFolder, pbcode);
                System.IO.Directory.CreateDirectory(imsg.retImagePath());
                System.IO.Directory.CreateDirectory(imgPath);
                string targetFolder = "KDMEDISP Receipt";
                string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string reportsFolder = System.IO.Path.Combine(folderPath, targetFolder);
                if (!System.IO.Directory.Exists(reportsFolder))
                {
                    System.IO.Directory.CreateDirectory(reportsFolder);
                }
            }
            catch (Exception)
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count += 1;
            if (count == duration)
            {
                login.Show();
                this.Hide();
                timer1.Enabled = false;
            }
            Console.WriteLine(count.ToString());
            lblLoading.Text += ".";
        }
    }
}
