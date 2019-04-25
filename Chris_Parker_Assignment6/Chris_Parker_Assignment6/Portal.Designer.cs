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
            this.SuspendLayout();
            // 
            // Bar_Graph
            // 
            this.Bar_Graph.Location = new System.Drawing.Point(45, 396);
            this.Bar_Graph.Name = "Bar_Graph";
            this.Bar_Graph.Size = new System.Drawing.Size(75, 23);
            this.Bar_Graph.TabIndex = 0;
            this.Bar_Graph.Text = "Bar Graph";
            this.Bar_Graph.UseVisualStyleBackColor = true;
            this.Bar_Graph.Click += new System.EventHandler(this.showBarGraph);
            // 
            // Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Bar_Graph);
            this.Name = "Portal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bar_Graph;
    }
}

