using LiveCharts;
using LiveCharts.Wpf;
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
using Color = System.Windows.Media.Color;

namespace KDMEDISP
{
    public partial class frmCashierAnalytics : Form
    {
        string start, end;
        util imsg = new util();
        Db db = new Db();
        public frmCashierAnalytics()
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
            try
            {
                dtpStart.Value = DateTime.Now.AddMonths(-1);
                start = dtpStart.Value.ToString("MM/dd/yyyy");
                end = dtpEnd.Value.ToString("MM/dd/yyyy");

            }
            catch (Exception)
            {

            }
            loadCashierPerf();

        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            start = dtpStart.Value.ToString("MM/dd/yyyy");
            end = dtpEnd.Value.ToString("MM/dd/yyyy");
            loadCashierPerf();

        }
        private void loadDgv()
        {
            dgvCashierPerf.Rows.Clear();

            DataTable retTable = (DataTable)db.ReturnCashierPerf(Convert.ToDateTime(start), Convert.ToDateTime(end));
            int i = 0;

                if (!(retTable.Rows.Count > 1))
                {
                    Console.WriteLine("No Rec ");
                    return;
                }
                foreach (DataRow dr in retTable.Rows)
                {
                    i += 1;
                    dgvCashierPerf.Rows.Add(i, dr[1].ToString().ToUpper(), dr[0].ToString(), dr[2].ToString()); ;
                }

            }
        private void loadCashierPerf()
        {
            dgvCashierPerf.Rows.Clear();
            //pnchart.Controls.Clear();
            DataTable retTable = (DataTable)db.ReturnCashierPerf(Convert.ToDateTime(start), Convert.ToDateTime(end));
            int i = 0;
            chtCashier.Series = new SeriesCollection();
            ColumnSeries cs = new ColumnSeries();
            cs.DataLabels = true;
            List<string> prodLabel = new List<string>();
            ChartValues<double> val = new ChartValues<double>();
            var dangerBrush = new SolidColorBrush(Color.FromRgb(174, 0, 174));
            Axis Xaxis = new Axis();
            Axis  Yaxis = new Axis();
            Xaxis.Foreground = dangerBrush;
            Xaxis.Title = "Cashier ";
            Yaxis.ShowLabels = true;
            Yaxis.Foreground = dangerBrush;


            try
            { 
            if (!(retTable.Rows.Count > 1))
            {
                Console.WriteLine("No Rec ");
                return;
            }
            foreach (DataRow dr in retTable.Rows)
            {
                i += 1;
                    dgvCashierPerf.Rows.Add(i, dr[1].ToString().ToUpper(), dr[0].ToString(), dr[2].ToString()); ;
                    val.Add(Convert.ToDouble(dr[0].ToString()));
                    prodLabel.Add(dr[1].ToString());
                    cs.Fill = dangerBrush;
                }
            cs.Values = val;
            Xaxis.Labels = prodLabel;
                chtCashier.AxisX.Add(Xaxis);
                chtCashier.AxisY.Add(Yaxis);

                chtCashier.Series.Add(cs);


                var tooltip = new DefaultTooltip
                {
                    SelectionMode = TooltipSelectionMode.SharedXInSeries
                };

                chtCashier.DataTooltip = tooltip;

            }
            catch (Exception)
            {

            }

}
    }
}

