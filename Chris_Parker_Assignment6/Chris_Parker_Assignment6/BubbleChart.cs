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

        private void backPortal_Click(object sender, EventArgs e)
        {
            this.Hide();
            Portal p = new Portal();
            p.Show();
        }

        private void BubbleChart_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Portal p = new Portal();
            p.Show();
        }

        private void loadBubbleChart(object sender, EventArgs e)
        {
            using (StreamReader inFile = new StreamReader("bubbleChartData"))
            {
                string line = inFile.ReadLine();

                while (line != null)
                {
                    string[] split = line.Split(',');

                    chart1.Series["FORCE (NEWTONS)"].Points.AddXY(Convert.ToInt32(split[0]), Convert.ToInt32(split[1]), Convert.ToInt32(split[2]));

                    line = inFile.ReadLine();
                }
            }
 
            button1.Enabled = false;
        }
    }
}
