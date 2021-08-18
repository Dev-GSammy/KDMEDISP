using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using CartesianChart = LiveCharts.WinForms.CartesianChart;
using Color = System.Drawing.Color;

namespace KDMEDISP
{
    public partial class frmTopSelling : Form
    {
        util imsg = new util();
        Db db = new Db();
        string start, end;

        public frmTopSelling()
        {
            InitializeComponent();
            try
            {
                dtpStart.Value = DateTime.Now.AddMonths(-1);
                start = dtpStart.Value.ToString("MM/dd/yyyy");
                end = dtpEnd.Value.ToString("MM/dd/yyyy");

            }
            catch (Exception)
            {

            }
           loadTopSelling();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            start = dtpStart.Value.ToString("MM/dd/yyyy");
            end = dtpEnd.Value.ToString("MM/dd/yyyy");
            //Console.WriteLine(start);
            //Console.WriteLine(end);
            //Console.WriteLine("Hello");
            loadTopSelling();
        }
        public void loadTopSelling()
        {
          
            try
            {
                dgvTopSelling.Rows.Clear();
                List<string> prodLabel = new List<string>();
                DataTable retTable = (DataTable)db.returnTopSelling(Convert.ToDateTime(start),Convert.ToDateTime(end));
                int i = 0;

            if (!(retTable.Rows.Count>1)   )
            {
                Console.WriteLine("No Rec ");
                return;
            }
                foreach (DataRow dr in retTable.Rows)
                {
                    i += 1;

                    dgvTopSelling.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());

                prodLabel.Add("");
                if (i == 1)
                {
                    chrTsp.Series = new SeriesCollection {
                new RowSeries
                {
                    Title = dr[1].ToString(),
                    Values = new ChartValues<double> {Convert.ToDouble(dr[2].ToString())}
                   
                }
            };
                }
                if(i>1 && i<=10)
                {  
                    chrTsp.Series.Add(new RowSeries
                    {
                        Title = dr[1].ToString(),
                        Values = new ChartValues<double> { Convert.ToDouble(dr[2].ToString()) }
                    }


                    );
                   
                    //also adding values updates and animates the chart automatically
                   
                }
            }
            chrTsp.AxisY.Add(new Axis
            {
                Labels = prodLabel
            });

            
            chrTsp.AxisX.Add(new Axis
            {
                LabelFormatter = value => value.ToString("N")
            });

            var tooltip = new DefaultTooltip
            {
                SelectionMode = TooltipSelectionMode.SharedYValues
            };

            chrTsp.DataTooltip = tooltip;

        }
            catch (Exception)
            {

            }
}

        private void frmTopSelling_Load(object sender, EventArgs e)
        {

            start = dtpStart.Value.ToString("MM/dd/yyyy");
            end = dtpEnd.Value.ToString("MM/dd/yyyy");
            //Console.WriteLine(start);
            //Console.WriteLine(end);
            //Console.WriteLine("Hello");
            loadTopSelling();


        }

        private void populateChart()
        {
       
           
        }

        private void chrTsp_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {
                    }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chrTsp_ChildChanged_1(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void dgvTopSelling_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTopSelling_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
