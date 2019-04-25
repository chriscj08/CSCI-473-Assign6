namespace Chris_Parker_Assignment6
{
    partial class BarGraph
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.backPortal = new System.Windows.Forms.Button();
            this.barGraphLabel = new System.Windows.Forms.Label();
            this.BarGraphChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.loadBarGraph = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BarGraphChart)).BeginInit();
            this.SuspendLayout();
            // 
            // backPortal
            // 
            this.backPortal.Location = new System.Drawing.Point(192, 395);
            this.backPortal.Name = "backPortal";
            this.backPortal.Size = new System.Drawing.Size(75, 23);
            this.backPortal.TabIndex = 0;
            this.backPortal.Text = "Back";
            this.backPortal.UseVisualStyleBackColor = true;
            this.backPortal.Click += new System.EventHandler(this.backPortal_Click);
            // 
            // barGraphLabel
            // 
            this.barGraphLabel.AutoSize = true;
            this.barGraphLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barGraphLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.barGraphLabel.Location = new System.Drawing.Point(178, 27);
            this.barGraphLabel.Name = "barGraphLabel";
            this.barGraphLabel.Size = new System.Drawing.Size(340, 25);
            this.barGraphLabel.TabIndex = 1;
            this.barGraphLabel.Text = "Favorite Movie Genres: Bar Graph";
            // 
            // BarGraphChart
            // 
            chartArea1.Name = "ChartArea1";
            this.BarGraphChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.BarGraphChart.Legends.Add(legend1);
            this.BarGraphChart.Location = new System.Drawing.Point(39, 72);
            this.BarGraphChart.Name = "BarGraphChart";
            this.BarGraphChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Genre";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.BarGraphChart.Series.Add(series1);
            this.BarGraphChart.Size = new System.Drawing.Size(657, 300);
            this.BarGraphChart.TabIndex = 2;
            this.BarGraphChart.Text = "BarGraphChart";
            // 
            // loadBarGraph
            // 
            this.loadBarGraph.Location = new System.Drawing.Point(393, 395);
            this.loadBarGraph.Name = "loadBarGraph";
            this.loadBarGraph.Size = new System.Drawing.Size(102, 23);
            this.loadBarGraph.TabIndex = 3;
            this.loadBarGraph.Text = "Load Bar Graph";
            this.loadBarGraph.UseVisualStyleBackColor = true;
            this.loadBarGraph.Click += new System.EventHandler(this.loadBarGraph_Click);
            // 
            // BarGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(736, 450);
            this.Controls.Add(this.loadBarGraph);
            this.Controls.Add(this.BarGraphChart);
            this.Controls.Add(this.barGraphLabel);
            this.Controls.Add(this.backPortal);
            this.Name = "BarGraph";
            this.Text = "Form4";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BarGraph_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.BarGraphChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backPortal;
        private System.Windows.Forms.Label barGraphLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart BarGraphChart;
        private System.Windows.Forms.Button loadBarGraph;
    }
}