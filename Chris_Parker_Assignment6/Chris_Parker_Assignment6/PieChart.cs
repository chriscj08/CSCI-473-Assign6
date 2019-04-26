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
    public partial class PieChart : Form
    {
        public PieChart()
        {
            InitializeComponent();
        }

        //Takes us back to the portal
        private void backPortal_Click(object sender, EventArgs e)
        {
            this.Hide();
            Portal p = new Portal();
            p.Show();
        }

        //Handles the event where we close the form
        private void PieChart_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Portal p = new Portal();
            p.Show();
        }

        /*
         * Function: Load_PieChart
         * 
         * 
         * Use: This function simply takes a text file
         * filled with data and constructs a pie chart
         * about most popular video games
         * 
         */ 
        private void Load_PieChart(object sender, EventArgs e)
        {
            using (StreamReader inFile = new StreamReader("pieChartData"))
            {
                string line = inFile.ReadLine(); //Get the first line

                while (line != null)
                {
                    string[] split = line.Split(','); //Split the line where there's a comma

                    chart1.Series["Series1"].Points.AddXY(split[0], Convert.ToDouble(split[1])); //Add the point to the chart

                    line = inFile.ReadLine(); //Get the next line
                }
            }

            chart1.Series["Series1"].IsValueShownAsLabel = true; //Show the percent value

            button1.Enabled = false;
        }
    }
}
