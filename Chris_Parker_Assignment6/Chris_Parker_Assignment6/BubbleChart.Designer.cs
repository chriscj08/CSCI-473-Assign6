namespace Chris_Parker_Assignment6
{
    partial class BubbleChart
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
            this.backPortal = new System.Windows.Forms.Button();
            this.pieChartLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backPortal
            // 
            this.backPortal.Location = new System.Drawing.Point(355, 372);
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
            this.pieChartLabel.Location = new System.Drawing.Point(350, 55);
            this.pieChartLabel.Name = "pieChartLabel";
            this.pieChartLabel.Size = new System.Drawing.Size(137, 25);
            this.pieChartLabel.TabIndex = 4;
            this.pieChartLabel.Text = "Bubble Chart";
            // 
            // BubbleChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backPortal);
            this.Controls.Add(this.pieChartLabel);
            this.Name = "BubbleChart";
            this.Text = "Form3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BubbleChart_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backPortal;
        private System.Windows.Forms.Label pieChartLabel;
    }
}