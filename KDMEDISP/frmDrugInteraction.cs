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
    public partial class frmDrugInteraction : Form
    {
        util imsg = new util();
        public static string RetString = string.Empty;
        public static bool fromPos = false;
        public frmDrugInteraction()
        {
            InitializeComponent();
            //if (fromPos)
            //{
                btnExit.Visible = true;
            //}
            //else
            //{
            //    btnExit.Visible = false;

            
        }

        private void btnGetInteraction_Click(object sender, EventArgs e)
        {


            try
            {

                if (!cCheckConn.IsConnectedToInternet())
                {
                    imsg.info("Internet Not Available, Check Connectivity and Try again");
                    return;
                }
                cDrugsInfo drugInfo = new cDrugsInfo(txtRxcui.Text);

                cDrugsInteractionInfo DI = new cDrugsInteractionInfo();
                loadInteractionInfo(DI.getDrugsInteractionInfo(cDrugsInfo.DrugRxcuID));
            }
            catch (Exception)
            {

            }

        }

        private void loadInteractionInfo(object SDinfo)
        {
            cNlmDDI Dinfo = (cNlmDDI)SDinfo;

            List<string> res = new List<string>() ;
            rtxtDisc.Text = "Disclaimer: "+Dinfo.nlmDisclaimer;
            foreach (var item in Dinfo.interactionTypeGroup)
            {

                //lblSource.Text = item.sourceName;
                foreach (var intType in item.interactionType)
                {
                    

                    Console.WriteLine(intType.comment);
                    res.Add(intType.comment);
                    foreach (var pair in intType.interactionPair)
                    {
                        Console.WriteLine(" Pair   " + pair.description);
                       res.Add( pair.description);
                        res.Add(pair.severity);
                        Console.WriteLine("Pair severity" + pair.severity);
                        foreach (var IC in pair.interactionConcept)
                        {
                            Console.WriteLine("min Concept Item ==>"+IC.minConceptItem.name);
                            Console.WriteLine("min Concept Item ==>"+IC.minConceptItem.rxcui);
                        }
                        Console.WriteLine("Interaction Concept" + pair.interactionConcept);
                        //QRes.Add(pair.severity + Environment.NewLine);
                        //QRes.Add(intType.comment + Environment.NewLine);


                    }
                    string finResponse = string.Empty;
                    foreach (var con in res)
                    {
                        finResponse += con+Environment.NewLine;
                    }
                    RetString = finResponse;
                    rtxtRes.Text = finResponse;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            clearTextSelection();
            string[] words = txtSearchHigh.Text. Split(',');
            foreach (string word in words)
            {
                int startindex = 0;
                while (startindex < RetString.Length)
                {
                    int wordstartIndex = rtxtRes.Find(word, startindex, RichTextBoxFinds.None);
                    if (wordstartIndex != -1)
                    {
                        rtxtRes.SelectionStart = wordstartIndex;
                        rtxtRes.SelectionLength = word.Length;
                        rtxtRes.SelectionBackColor= Color.CadetBlue;
                    }
                    else
                        break;
                    startindex = wordstartIndex + word.Length;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTextSelection();
        }
        private void clearTextSelection ()
        {
            rtxtRes.SelectionStart = 0;
            rtxtRes.SelectAll();
            rtxtRes.SelectionBackColor = Color.FromArgb(64, 0, 64);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide() ;
        }

        private void frmDrugInteraction_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
