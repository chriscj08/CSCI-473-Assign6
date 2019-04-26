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

        /* fucntion loadLineGraph
         * purpose: Generates a 3 different line graphs
         * Each one represents 1 of the 3 common Trig functions 
         * */
        private void loadLineGraph(object sender, EventArgs e)
        {
            lineGraphChart.ChartAreas[0].AxisX.Minimum = -2; //X Axis Min
            lineGraphChart.ChartAreas[0].AxisX.Maximum = 2; //X Axis Max
            lineGraphChart.ChartAreas[0].AxisY.Minimum = -2; //Y Axis Min
            lineGraphChart.ChartAreas[0].AxisY.Maximum = 2; //Y Axis Max
            lineGraphChart.ChartAreas[0].AxisX.Interval = 1; //X Interval
            lineGraphChart.ChartAreas[0].AxisY.Interval = 1; //Y Interval

            lineGraphChart.ChartAreas[0].AxisX.Title = "X Values"; //X Axis Label
            lineGraphChart.ChartAreas[0].AxisY.Title = "Y Values"; //Y Axis Label

            lineGraphChart.Series.Add("SinX"); //adds sinX series
            lineGraphChart.Series["SinX"].Color = Color.Red; //sets sinX color to Red

            lineGraphChart.Series.Add("CosX"); //adds cosX series
            lineGraphChart.Series["CosX"].Color = Color.Blue; //sets cosX color to Blue

            lineGraphChart.Series.Add("TanX"); //adds tanX series
            lineGraphChart.Series["TanX"].Color = Color.Green; //sets tanX color to Green

            //Generates and plots x and y values
            for (double i = -2; i < 3; i+=.1)
            {
                double yValue = Math.Sin(i);
                lineGraphChart.Series["SinX"].Points.AddXY(i, yValue);
                lineGraphChart.Series["SinX"].ChartType = SeriesChartType.Line;
            }

            //Generates and plots x and y values
            for (double i = -2; i < 3; i += .1)
            {
                double yValue = Math.Cos(i);
                lineGraphChart.Series["CosX"].Points.AddXY(i, yValue);
                lineGraphChart.Series["CosX"].ChartType = SeriesChartType.Line;
            }

            //Generates and plots x and y values
            for (double i = -2; i < 3; i += .1)
            {
                double yValue = Math.Tan(i);
                lineGraphChart.Series["TanX"].Points.AddXY(i, yValue);
                lineGraphChart.Series["TanX"].ChartType = SeriesChartType.Line;
            }

            loadGraph.Enabled = false;//disables the bottom to prevent crashes
        }
    }
}
