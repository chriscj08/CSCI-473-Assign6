namespace Chris_Parker_Assignment6
{
    partial class Portal
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
            this.Bar_Graph = new System.Windows.Forms.Button();
            this.PieChart = new System.Windows.Forms.Button();
            this.BubbleChart = new System.Windows.Forms.Button();
            this.LineGraph = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bar_Graph
            // 
            this.Bar_Graph.Location = new System.Drawing.Point(123, 110);
            this.Bar_Graph.Name = "Bar_Graph";
            this.Bar_Graph.Size = new System.Drawing.Size(92, 23);
            this.Bar_Graph.TabIndex = 0;
            this.Bar_Graph.Text = "Bar Graph";
            this.Bar_Graph.UseVisualStyleBackColor = true;
            this.Bar_Graph.Click += new System.EventHandler(this.showBarGraph);
            // 
            // PieChart
            // 
            this.PieChart.Location = new System.Drawing.Point(123, 139);
            this.PieChart.Name = "PieChart";
            this.PieChart.Size = new System.Drawing.Size(92, 23);
            this.PieChart.TabIndex = 1;
            this.PieChart.Text = "Pie Chart";
            this.PieChart.UseVisualStyleBackColor = true;
            this.PieChart.Click += new System.EventHandler(this.PieChart_Click);
            // 
            // BubbleChart
            // 
            this.BubbleChart.Location = new System.Drawing.Point(123, 168);
            this.BubbleChart.Name = "BubbleChart";
            this.BubbleChart.Size = new System.Drawing.Size(92, 23);
            this.BubbleChart.TabIndex = 2;
            this.BubbleChart.Text = "Bubble Chart";
            this.BubbleChart.UseVisualStyleBackColor = true;
            this.BubbleChart.Click += new System.EventHandler(this.BubbleChart_Click);
            // 
            // LineGraph
            // 
            this.LineGraph.Location = new System.Drawing.Point(123, 197);
            this.LineGraph.Name = "LineGraph";
            this.LineGraph.Size = new System.Drawing.Size(92, 23);
            this.LineGraph.TabIndex = 3;
            this.LineGraph.Text = "Line Graph";
            this.LineGraph.UseVisualStyleBackColor = true;
            this.LineGraph.Click += new System.EventHandler(this.LineGraph_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(124, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Portal";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(123, 226);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(92, 23);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LineGraph);
            this.Controls.Add(this.BubbleChart);
            this.Controls.Add(this.PieChart);
            this.Controls.Add(this.Bar_Graph);
            this.Name = "Portal";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Portal_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bar_Graph;
        private System.Windows.Forms.Button PieChart;
        private System.Windows.Forms.Button BubbleChart;
        private System.Windows.Forms.Button LineGraph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit;
    }
}

