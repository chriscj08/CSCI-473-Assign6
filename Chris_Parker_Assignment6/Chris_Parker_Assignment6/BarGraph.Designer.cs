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
            this.backPortal = new System.Windows.Forms.Button();
            this.barGraphLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backPortal
            // 
            this.backPortal.Location = new System.Drawing.Point(358, 393);
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
            this.barGraphLabel.Location = new System.Drawing.Point(325, 34);
            this.barGraphLabel.Name = "barGraphLabel";
            this.barGraphLabel.Size = new System.Drawing.Size(110, 25);
            this.barGraphLabel.TabIndex = 1;
            this.barGraphLabel.Text = "Bar Graph";
            // 
            // BarGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.barGraphLabel);
            this.Controls.Add(this.backPortal);
            this.Name = "BarGraph";
            this.Text = "Form4";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BarGraph_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backPortal;
        private System.Windows.Forms.Label barGraphLabel;
    }
}