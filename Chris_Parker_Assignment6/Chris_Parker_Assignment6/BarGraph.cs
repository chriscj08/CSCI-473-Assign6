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
using System.Windows.Forms.DataVisualization.Charting;

namespace Chris_Parker_Assignment6
{
    public partial class BarGraph : Form
    {
        public BarGraph()
        {
            InitializeComponent();
        }

        //handles switching the forms
        private void backPortal_Click(object sender, EventArgs e)
        {
            this.Hide();
            Portal p = new Portal();
            p.Show();
        }

        //handles switching the forms
        private void BarGraph_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Portal p = new Portal();
            p.Show();
        }

        /* Function: loadBarGraph
         * 
         * Purpose: Generate a bar graph based on values from a file
         *  
         * Implementation: Opens text file and reads in the values.
         * Counters are used to keep track of the values
         * Once the file is done the values are added to the bar
         * graph with the respective x and y values
         * */
        private void loadBarGraph_Click(object sender, EventArgs e)
        {
            int actionCount = 0; //action counter
            int adventureCount = 0; //adventure counter
            int comedyCount = 0; //comedy counter
            int sciFiCount = 0; //scifi counter
            int horrorCount = 0; //horror counter

            //Reads in the values from file
            using (StreamReader inFile = new StreamReader("movieGenres.txt"))
            {
                string source = inFile.ReadLine(); // remember to "prime the read"
                while (source != null)
                {
                    //Checks to see what the line is
                    //and increments appropriate counter
                    if (source == "Action")
                    {
                        actionCount++;
                    }
                    else if (source == "Adventure")
                    {
                        adventureCount++;
                    }
                    else if (source == "Comedy")
                    {
                        comedyCount++;
                    }
                    else if (source == "SciFi")
                    {
                        sciFiCount++;
                    }
                    else horrorCount++;
                    source = inFile.ReadLine(); //Read the next line
                }
                inFile.Close();//closes the file
            }            

            BarGraphChart.ChartAreas[0].AxisY.Minimum = -0; //Y Axis Min
            BarGraphChart.ChartAreas[0].AxisY.Maximum = 13; //Y Axis Max            
            BarGraphChart.ChartAreas[0].AxisY.Interval = 1; //Y Interval            

            BarGraphChart.ChartAreas[0].AxisX.Title = "Movie Genres"; //X Axis Label
            BarGraphChart.ChartAreas[0].AxisY.Title = "# per Genre"; //Y Axis Label
            
            //Adds the actions bar
            BarGraphChart.Series["Genre"].Points.AddXY("Action", actionCount);
            BarGraphChart.Series["Genre"].Points[0].Color = Color.Red;
            
            //Adds the Adventure bar
            BarGraphChart.Series["Genre"].Points.AddXY("Adventure", adventureCount);
            BarGraphChart.Series["Genre"].Points[1].Color = Color.Orange;
            
            //Adds the Comedy Bar
            BarGraphChart.Series["Genre"].Points.AddXY("Comedy", comedyCount);
            BarGraphChart.Series["Genre"].Points[2].Color = Color.Purple;
            
            //Adds the SciFi bar
            BarGraphChart.Series["Genre"].Points.AddXY("SciFi", sciFiCount);
            BarGraphChart.Series["Genre"].Points[3].Color = Color.Blue;
            
            //Adds the horror bar
            BarGraphChart.Series["Genre"].Points.AddXY("Horror", horrorCount);
            BarGraphChart.Series["Genre"].Points[4].Color = Color.Pink;           

            loadBarGraph.Enabled = false;//disables the button to prevent duplication
        }
    }
}
