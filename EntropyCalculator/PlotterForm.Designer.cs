namespace EntropyCalculator
{
    partial class PlotterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlotterForm));
            this.HistogramDrawer = new OxyPlot.WindowsForms.PlotView();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.EntropyLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.EntropyValueLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.probabilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // HistogramDrawer
            // 
            this.HistogramDrawer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HistogramDrawer.Location = new System.Drawing.Point(0, 0);
            this.HistogramDrawer.Name = "HistogramDrawer";
            this.HistogramDrawer.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.HistogramDrawer.Size = new System.Drawing.Size(800, 450);
            this.HistogramDrawer.TabIndex = 0;
            this.HistogramDrawer.Text = "Histogram";
            this.HistogramDrawer.Visible = false;
            this.HistogramDrawer.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.HistogramDrawer.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.HistogramDrawer.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EntropyLabel,
            this.EntropyValueLabel,
            this.toolStripSplitButton1,
            this.toolStripSplitButton2});
            this.StatusStrip.Location = new System.Drawing.Point(0, 428);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(800, 22);
            this.StatusStrip.TabIndex = 1;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // EntropyLabel
            // 
            this.EntropyLabel.Name = "EntropyLabel";
            this.EntropyLabel.Size = new System.Drawing.Size(81, 17);
            this.EntropyLabel.Text = "Entropy (bits):";
            // 
            // EntropyValueLabel
            // 
            this.EntropyValueLabel.Name = "EntropyValueLabel";
            this.EntropyValueLabel.Size = new System.Drawing.Size(29, 17);
            this.EntropyValueLabel.Text = "N/A";
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.AutoSize = true;
            this.LoadingLabel.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadingLabel.Location = new System.Drawing.Point(324, 198);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(110, 22);
            this.LoadingLabel.TabIndex = 2;
            this.LoadingLabel.Text = "Loading...";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numbersToolStripMenuItem,
            this.probabilityToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // probabilityToolStripMenuItem
            // 
            this.probabilityToolStripMenuItem.Name = "probabilityToolStripMenuItem";
            this.probabilityToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.probabilityToolStripMenuItem.Text = "Probabilitys";
            this.probabilityToolStripMenuItem.Click += new System.EventHandler(this.ProbabilityToolStripMenuItem_Click);
            // 
            // numbersToolStripMenuItem
            // 
            this.numbersToolStripMenuItem.Name = "numbersToolStripMenuItem";
            this.numbersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.numbersToolStripMenuItem.Text = "Numbers";
            this.numbersToolStripMenuItem.Click += new System.EventHandler(this.NumbersToolStripMenuItem_Click);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linearToolStripMenuItem,
            this.logToolStripMenuItem});
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton2.Text = "toolStripSplitButton2";
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logToolStripMenuItem.Text = "Log";
            this.logToolStripMenuItem.Click += new System.EventHandler(this.LogToolStripMenuItem_Click);
            // 
            // linearToolStripMenuItem
            // 
            this.linearToolStripMenuItem.Name = "linearToolStripMenuItem";
            this.linearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.linearToolStripMenuItem.Text = "Linear";
            this.linearToolStripMenuItem.Click += new System.EventHandler(this.LinearToolStripMenuItem_Click);
            // 
            // Plotter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.HistogramDrawer);
            this.Controls.Add(this.LoadingLabel);
            this.Name = "Plotter";
            this.Text = "Plotter";
            this.Load += new System.EventHandler(this.Plotter_Load);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OxyPlot.WindowsForms.PlotView HistogramDrawer;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel EntropyLabel;
        private System.Windows.Forms.ToolStripStatusLabel EntropyValueLabel;
        private System.Windows.Forms.Label LoadingLabel;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem numbersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem probabilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem linearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
    }
}