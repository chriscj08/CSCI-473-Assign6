/* Programmers: Chris Jurrens and Parker Cox
 * Assingment 6: Uncharted
 * */
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
    public partial class Portal : Form
    {
        public Portal()
        {
            InitializeComponent();
        }                

        //switches to barGraph form
        private void showBarGraph(object sender, EventArgs e)
        {
            this.Hide();
            BarGraph bg = new BarGraph();
            bg.Show();            
            
        }
        //switches to pieChart form
        private void PieChart_Click(object sender, EventArgs e)
        {
            this.Hide();
            PieChart pc = new PieChart();
            pc.Show();
        }

        //switches to bubbleChart Form
        private void BubbleChart_Click(object sender, EventArgs e)
        {
            this.Hide();
            BubbleChart bc = new BubbleChart();
            bc.Show();
        }

        //Switches to lineGraph chart
        private void LineGraph_Click(object sender, EventArgs e)
        {
            this.Hide();
            LineGraph  lg = new LineGraph();            
            lg.Show();
        }

        //handles closing the form
        private void Portal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //handles closiung the form
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
