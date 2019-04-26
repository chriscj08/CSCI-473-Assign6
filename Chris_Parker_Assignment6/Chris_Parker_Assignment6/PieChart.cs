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

        private void backPortal_Click(object sender, EventArgs e)
        {
            this.Hide();
            Portal p = new Portal();
            p.Show();
        }

        private void PieChart_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Portal p = new Portal();
            p.Show();
        }

        private void Load_PieChart(object sender, EventArgs e)
        {
            using (StreamReader inFile = new StreamReader("pieChartData"))
            {
                string line = inFile.ReadLine();

                while (line != null)
                {
                    string[] split = line.Split(',');

                    chart1.Series["Series1"].Points.AddXY(split[0], Convert.ToDouble(split[1]));

                    line = inFile.ReadLine();
                }
            }

            chart1.Series["Series1"].IsValueShownAsLabel = true;

            button1.Enabled = false;
        }
    }
}
