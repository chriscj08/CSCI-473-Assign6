using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chris_Parker_Assignment6
{
    public partial class BubbleChart : Form
    {
        public BubbleChart()
        {
            InitializeComponent();
        }

        //Takes us back to portal
        private void backPortal_Click(object sender, EventArgs e)
        {
            this.Hide();
            Portal p = new Portal();
            p.Show();
        }

        //Handles the event where user closes form
        private void BubbleChart_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Portal p = new Portal();
            p.Show();
        }

        /*
         * Function: LoadBubbleChart
         * 
         * 
         * Use: This function simply takes a text file
         * filled with data and constructs a bubble chart
         * about the physical property Force
         * 
         */
        private void loadBubbleChart(object sender, EventArgs e)
        {
            using (StreamReader inFile = new StreamReader("bubbleChartData"))
            {
                string line = inFile.ReadLine(); //Get the first line

                while (line != null)
                {
                    string[] split = line.Split(','); //Split the line where there's a comma

                    //Add the point to the chart
                    chart1.Series["FORCE (NEWTONS)"].Points.AddXY(Convert.ToInt32(split[0]), Convert.ToInt32(split[1]), Convert.ToInt32(split[2]));

                    line = inFile.ReadLine(); //Get the next line
                }
            }
 
            button1.Enabled = false;
        }
    }
}
