using System;
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
    public partial class LineGraph : Form
    {
        public LineGraph()
        {
            InitializeComponent();
        }

        private void backPortal_Click(object sender, EventArgs e)
        {           
            Portal p = new Portal();
            p.Show();

            LineGraph lg = new LineGraph();
            lg.Hide();
        }

        private void LineGraph_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Portal p = new Portal();
            p.Show();
        }
    }
}
