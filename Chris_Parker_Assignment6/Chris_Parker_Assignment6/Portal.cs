﻿using System;
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

        private void Load_Graph(object sender, EventArgs e)
        {
            PieChart f2 = new PieChart();

            this.Hide();
            f2.ShowDialog();
        }

        private void showBarGraph(object sender, EventArgs e)
        {
            this.Hide();
            BarGraph bg = new BarGraph();
            bg.Show();            
            
        }
    }
}
