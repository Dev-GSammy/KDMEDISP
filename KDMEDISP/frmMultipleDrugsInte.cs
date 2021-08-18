using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KDMEDISP2;
namespace KDMEDISP
{
    public partial class frmMultipleDrugsInte : Form
    {
        util imsg = new util();
        public static string RetString = string.Empty;
        public static bool fromPos = false;
        public frmMultipleDrugsInte()
        {
            InitializeComponent();
            //if (fromPos)
            //{
                btnExit.Visible = true;
            //}
            //else
            //{
            //    btnExit.Visible = false;

            //}
        }

        private void btnAddtoList_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtxtDtS.Text)|| rtxtDtS.Text=="...")
            {
                rtxtDtS.Clear();
                rtxtDtS.Text +=txtRxcui.Text;

            }
            else
            {
                rtxtDtS.Text += "," + txtRxcui.Text;

            }
            txtRxcui.Clear();
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            rtxtDtS.Text = "...";
        }

        private void btnGetInteraction_Click(object sender, EventArgs e)
        {
            try
            {

                string RxCUIS = string.Empty;
                List<string> IDs = new List<string>();
                //List<string> retRxCUIS = new List<string>();
                if (rtxtDtS.Text == "...")
                {
                    return;

                }
                string[] words = rtxtDtS.Text.Split(',');
                foreach (string word in words)
                {
                    IDs.Add(word);
                }
                foreach (var id in IDs)
                {
                    cDrugsInfo drugInfo = new cDrugsInfo(id);
                    if (string.IsNullOrEmpty(RxCUIS))
                    {
                        RxCUIS += cDrugsInfo.DrugRxcuID;

                    }
                    else
                    {
                        RxCUIS += "+" + cDrugsInfo.DrugRxcuID;
                    }

                }
                Console.WriteLine(RxCUIS);
                cDrugsInteractionInfo DI = new cDrugsInteractionInfo();

                loadInteractionInfo(DI.getDrugsInteractionInfo(RxCUIS, false));


            }
            catch (Exception)
            {

            }

        }

        private void loadInteractionInfo(object MultiDinfo)
        {
            cNlmDDIMulti Dinfo = (cNlmDDIMulti)MultiDinfo;
            List<string> res = new List<string>();
            rtxtDisc.Text = "Disclaimer: " + Dinfo.nlmDisclaimer;
            foreach (var item in Dinfo.fullInteractionTypeGroup)
            {

                //lblSource.Text = item.sourceName;
                foreach (var intType in item.fullInteractionType)
                {


                    Console.WriteLine(intType.comment);
                    res.Add(intType.comment);
                    foreach (var pair in intType.interactionPair)
                    {
                        Console.WriteLine(" Pair   " + pair.description);
                        res.Add(pair.description);
                        foreach (var IC in pair.interactionConcept)
                        {
                            Console.WriteLine("min Concept Item ==>" + IC.minConceptItem.name);
                            Console.WriteLine("min Concept Item ==>" + IC.minConceptItem.rxcui);
                        }
                        Console.WriteLine("Interaction Concept" + pair.interactionConcept);
                        //QRes.Add(pair.severity + Environment.NewLine);
                        //QRes.Add(intType.comment + Environment.NewLine);


                    }
                    string finResponse = string.Empty;
                    foreach (var con in res)
                    {
                        finResponse += con + Environment.NewLine;
                    }
                    RetString = finResponse;
                    rtxtRes.Text = finResponse;
                }
            }
        }

        private void frmMultipleDrugsInte_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    }

