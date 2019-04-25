namespace Chris_Parker_Assignment6
{
    partial class LineGraph
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.backPortal = new System.Windows.Forms.Button();
            this.pieChartLabel = new System.Windows.Forms.Label();
            this.lineGraphChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.loadGraph = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lineGraphChart)).BeginInit();
            this.SuspendLayout();
            // 
            // backPortal
            // 
            this.backPortal.Location = new System.Drawing.Point(219, 389);
            this.backPortal.Name = "backPortal";
            this.backPortal.Size = new System.Drawing.Size(75, 23);
            this.backPortal.TabIndex = 5;
            this.backPortal.Text = "Back";
            this.backPortal.UseVisualStyleBackColor = true;
            this.backPortal.Click += new System.EventHandler(this.backPortal_Click);
            // 
            // pieChartLabel
            // 
            this.pieChartLabel.AutoSize = true;
            this.pieChartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pieChartLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pieChartLabel.Location = new System.Drawing.Point(258, 29);
            this.pieChartLabel.Name = "pieChartLabel";
            this.pieChartLabel.Size = new System.Drawing.Size(262, 25);
            this.pieChartLabel.TabIndex = 4;
            this.pieChartLabel.Text = "Trigonometry : Line Graph";
            // 
            // lineGraphChart
            // 
            chartArea2.Name = "ChartArea1";
            this.lineGraphChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.lineGraphChart.Legends.Add(legend2);
            this.lineGraphChart.Location = new System.Drawing.Point(65, 71);
            this.lineGraphChart.Name = "lineGraphChart";
            this.lineGraphChart.Size = new System.Drawing.Size(680, 300);
            this.lineGraphChart.TabIndex = 6;
            this.lineGraphChart.Text = "chart1";
            // 
            // loadGraph
            // 
            this.loadGraph.Location = new System.Drawing.Point(422, 389);
            this.loadGraph.Name = "loadGraph";
            this.loadGraph.Size = new System.Drawing.Size(75, 23);
            this.loadGraph.TabIndex = 7;
            this.loadGraph.Text = "Load Graph";
            this.loadGraph.UseVisualStyleBackColor = true;
            this.loadGraph.Click += new System.EventHandler(this.loadLineGraph);
            // 
            // LineGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loadGraph);
            this.Controls.Add(this.lineGraphChart);
            this.Controls.Add(this.backPortal);
            this.Controls.Add(this.pieChartLabel);
            this.Name = "LineGraph";
            this.Text = "Form5";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LineGraph_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.lineGraphChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backPortal;
        private System.Windows.Forms.Label pieChartLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart lineGraphChart;
        private System.Windows.Forms.Button loadGraph;
    }
}