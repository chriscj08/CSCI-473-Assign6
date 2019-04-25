using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Chris_Parker_Assignment6
{
    public partial class LineGraph : Form
    {
        public LineGraph()
        {
            InitializeComponent();
        }

        private void backPortal_Click(object sender, EventArgs e)
        {
            this.Hide();
            Portal p = new Portal();
            p.Show();
            
        }

        private void LineGraph_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Portal p = new Portal();
            p.Show();
        }

        private void loadLineGraph(object sender, EventArgs e)
        {
            lineGraphChart.ChartAreas[0].AxisX.Minimum = -5;
            lineGraphChart.ChartAreas[0].AxisX.Maximum = 5;
            lineGraphChart.ChartAreas[0].AxisY.Minimum = -2;
            lineGraphChart.ChartAreas[0].AxisY.Maximum = 2;
            lineGraphChart.ChartAreas[0].AxisX.Interval = 1;
            lineGraphChart.ChartAreas[0].AxisY.Interval = 1;

            lineGraphChart.ChartAreas[0].AxisX.Title = "X Values";
            lineGraphChart.ChartAreas[0].AxisY.Title = "Y Values";

            lineGraphChart.Series.Add("SinX");
            lineGraphChart.Series["SinX"].Color = Color.Red;

            lineGraphChart.Series.Add("CosX");
            lineGraphChart.Series["CosX"].Color = Color.Blue;

            lineGraphChart.Series.Add("TanX");
            lineGraphChart.Series["TanX"].Color = Color.Green;

            for (double i = -5; i < 6; i+=.1)
            {
                double yValue = Math.Sin(i);
                lineGraphChart.Series["SinX"].Points.AddXY(i, yValue);
                lineGraphChart.Series["SinX"].ChartType = SeriesChartType.Line;
            }

            for (double i = -5; i < 6; i += .1)
            {
                double yValue = Math.Cos(i);
                lineGraphChart.Series["CosX"].Points.AddXY(i, yValue);
                lineGraphChart.Series["CosX"].ChartType = SeriesChartType.Line;
            }

            for (double i = -5; i < 6; i += .1)
            {
                double yValue = Math.Tan(i);
                lineGraphChart.Series["TanX"].Points.AddXY(i, yValue);
                lineGraphChart.Series["TanX"].ChartType = SeriesChartType.Line;
            }

            loadGraph.Enabled = false;
        }
    }
}
